﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using EAAddinFramework.Utils;
using hoTools.Utils.Configuration;
using hoTools.Utils.SQL;
using Microsoft.Win32;
using Newtonsoft.Json;
using AddinFramework.Extension;

using DuoVia.FuzzyStrings;

// ReSharper disable once CheckNamespace
namespace AddinFramework.Util
{
    /// <summary>
    /// Load the possible Searches:<para/>
    /// - EA Standard Searches<para/>
    /// - Searches defined in MDG (Program-Technology-Folder, MDG in file locations, MDG in URI locations)<para/> 
    /// - Local Search of PC <para/>
    /// </summary>
    public static class Search
    {
        static List<SearchItem> _staticAllSearches;
        static AutoCompleteStringCollection _staticSearchesSuggestions;

        // configuration as singleton
        static readonly HoToolsGlobalCfg GlobalCfg = HoToolsGlobalCfg.Instance;

        /// <summary>
        /// Loads all findable Searches. These Searches are stored outside the model and cannot be changed by the user.
        /// Dynamic added Searches aren't currently detectable (ok, by brute force). Possible search sources are:
        /// <para /> Build in: No chance.
        /// <para />
        /// All Technologies:
        /// <para />
        /// Technology folder inside installation
        /// <para />
        /// EA_Search.xml
        /// </summary>


        // ReSharper disable once EmptyConstructor
        static Search()
        {

        }
       
        /// <summary>
        /// Get the SearchItem for the index
        /// </summary>
        public static SearchItem GetSearch(int index)
        {
            
            return _staticAllSearches[index];

        }

        /// <summary>
        /// Makes a Forms Auto Completion List of all searches.
        /// </summary>
        /// <param name="rep"></param>
        /// <param name="configFilePath">Configuration file with user configurations</param>
        /// <returns></returns>
        public static AutoCompleteStringCollection GetSearchesSuggestions(EA.Repository rep, string configFilePath)
        {

                LoadAllSearches(rep, configFilePath);
                LoadStaticSearchesSuggestions();
                return _staticSearchesSuggestions;
            
        }
        /// <summary>
        /// Calculate score, sort and visualize rtf field. Upper/Lower cases are not considered.
        /// </summary>
        /// <param name="pattern"></param>
        public static void CalulateAndSort(string pattern)
        {
            pattern = pattern.ToLower();

            foreach (SearchItem item in _staticAllSearches)
            {
                item.Score = pattern.LongestCommonSubsequence(item.Name.ToLower()).Item2;
            }
           // sort list
            _staticAllSearches = _staticAllSearches.OrderByDescending(a => a.Score).ToList();

        }
        /// <summary>
        /// Reset sort in rtf by default order (Name field of SearchItem).
        /// </summary>
        public static void ResetSort()
        {
            // sort list
            _staticAllSearches = _staticAllSearches.OrderBy(a => a.Name).ToList();

        }


        /// <summary>
        /// Load the possible Searches:<para/>
        /// - EA Standard Searches<para/>
        /// - Searches defined in MDG (Program-Technology-Folder, MDG in file locations, MDG in URI locations)<para/> 
        /// - Local Search of PC <para/> 
        /// </summary>
        static void LoadAllSearches(EA.Repository rep, string configFilePath)
        {
            _staticAllSearches = new List<SearchItem>();


            // Load EA Standard Search Names for current release  
            LoadEaStandardSearchesFromJason(rep.getRelease(), configFilePath);

            LoadSqlSearches();

            //local scripts
            LoadLocalSearches(rep);
            //MDG scripts in the program folder
            LoadLocalMdgSearches(rep);
            // MDG scripts in other locations
            LoadOtherMdgSearches(rep);
            // order
            _staticAllSearches = _staticAllSearches.OrderBy(a => a.Name)
                .ToList();
            

        }
        /// <summary>
        /// Get the suggestions for the rtf box
        /// </summary>
        public static string GetRtf()
        {
            // var s = _staticAllSearches.Select(e => $"{e.Score,2} {e.Category,-15} {e.Name}" ).ToList();
            var s = _staticAllSearches.Select(e => $"{e.Category,-10} {e.Name}" ).ToList();
            return string.Join($"{Environment.NewLine}", s);
        }


        /// <summary>
        /// Load the suggestions for the search Combo Box
        /// </summary>
        private static void LoadStaticSearchesSuggestions()
        {
            _staticSearchesSuggestions = new AutoCompleteStringCollection();
            var result = _staticAllSearches.Select(e => e.Name).ToArray();
            _staticSearchesSuggestions.AddRange(result);
            


        } 

        /// <summary>
        /// The local Searches are located in the "ea program files"\scripts (so usually C:\Program Files (x86)\Sparx Systems\EA\Scripts or C:\Program Files\Sparx Systems\EA\Scripts)
        /// The contents of the local scripts is loaded into the Searches.
        /// </summary>
        static void LoadLocalSearches(EA.Repository rep)
        {
            
            string searchFolder = SqlError.GetEaSqlErrorPath() + @"\Search Data"; 
            LoadSearchFromFolder(rep, searchFolder);

        }
        /// <summary>
        /// Load Searches from MDG Technology folder
        /// </summary>
        static void LoadLocalMdgSearches(EA.Repository rep)
        {
            string searchFolder = Path.GetDirectoryName(Model.ApplicationFullPath) + "\\MDGTechnologies";
            LoadSearchFromFolder(rep, searchFolder);
        }

        static void LoadSearchFromFolder(EA.Repository rep, string folder)
        {
            string[] searchFiles = Directory.GetFiles(folder, "*.xml", SearchOption.AllDirectories);
            foreach (string searchFile in searchFiles)
            {
                LoadMdgSearches(rep, File.ReadAllText(searchFile));
            }

        }
        /// <summary>
        /// loads the MDG scripts from the locations added from MDG Technologies|Advanced. 
        /// these locations are stored as a comma separated string in the registry
        /// a location can either be a directory, or an URL
        /// </summary>
        static void LoadOtherMdgSearches(EA.Repository rep)
        {

                //read the registry key to find the locations
                var pathList = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Sparx Systems\EA400\EA\OPTIONS", "MDGTechnology PathList", null) as string;
                if (pathList != null)
                {
                    string[] mdgPaths = pathList.Split(',');
                    foreach (string mdgPath in mdgPaths)
                    {
                        if (mdgPath.Trim() == "") continue;
                        //figure out it we have a folder path or an URL
                        if (mdgPath.StartsWith("http", StringComparison.InvariantCultureIgnoreCase))
                        {
                            //URL
                            LoadMdgSearchFromUrl(rep, mdgPath);
                        }
                        else
                        {
                            //directory
                            LoadSearchFromFolder(rep, mdgPath);
                        }
                    }
                }

        }


        /// <summary>
        /// Loads the Searches described in the MDG file into the includable scripts
        /// </summary>
        /// <param name="rep"></param>
        /// <param name="mdgXmlContent">the string content of the MDG file</param>
        static void LoadMdgSearches(EA.Repository rep, string mdgXmlContent)
        {
            try
            {
                var mdg  = XElement.Parse(mdgXmlContent);


                // get MDG data (ID, Name) 

                string id = "My EA Searches";
                //string name = "";
                //string notes = "";
                XElement documentation = mdg.Element("Documentation");
                // Not part of a MDG
                if (documentation != null)
                {
                    id = documentation.Attribute("id").Value;
                    //name = documentation.Attribute("name").Value;
                    //notes = documentation.Attribute("notes").Value;
                    // check if Technology is enabled
                    if (rep.IsTechnologyEnabled(id) == false && rep.IsTechnologyLoaded(id)) return;

                }

                //----------------------------------------
                // Get all searches
                var searches = from search in mdg.Descendants("Search")
                    select search;
                foreach (XElement search in searches)
                {
                    string searchName = search.Attribute("Name").Value;
                    _staticAllSearches.Add(new EaSearchItem(id, searchName));
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(@"", @"Error in loadMDGScripts: " + e.Message);
            }
        }

        /// <summary>
        /// load the MDG Search from the MDG file located at the given URL
        /// </summary>
        /// <param name="rep"></param>
        /// <param name="url">the URL pointing to the MDG file</param>
        static void LoadMdgSearchFromUrl(EA.Repository rep, string url)
        {
            try
            {
                LoadMdgSearches(rep, new WebClient().DownloadString(url));
            }
            catch (Exception e)
            {
                MessageBox.Show($"URL='{url}' skipped (see: Extensions, MDGTechnology,Advanced).\r\n{e.Message}",
                    @"Error in load *.xml MDGSearches from url! ");
            }
        }

        /// <summary>
        /// Load SQL Searches in structure '_staticAllSearches'. The structure contains:
        /// <para/>File, Description of SQL
        /// </summary>
        /// <returns></returns>
        public static void LoadSqlSearches()
        {
            foreach (string file in GlobalCfg.getListFileCompleteName())
            {
                string description = SqlGetDescription(file);
                string name = Path.GetFileName(file);
                _staticAllSearches.Add( new SqlSearchItem(name, file,description)); 
            }
        }
        /// <summary>
        /// Get Description from SQL file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private static string SqlGetDescription(string file)
        {
            string sqlText = File.ReadAllText(file);
            Regex regex = new Regex(@"(^[ \t]*// \S[^\n]*\n)+", RegexOptions.Multiline);
            Match match = regex.Match(sqlText);
            Char[] c =  { '\r','\n' };

            if (match.Success)
            {
                // delete '// ' from start of line
                string pattern = "^[ \t]*// ";
                string s = match.Value.Trim(c);
                s = Regex.Replace(s, pattern, "", RegexOptions.Multiline);
                return s;
            }
            else return "";
        }

        /// <summary>
        /// Load all EA Standard Searches from JSON for an EA Release. The Standard searches are stored in: 'EaStandardSearches.json'.
        /// Possible EA Releases are: "9, 10, 11, 12, 12.1, 13\"
        /// 
        /// </summary>
        /// <param name="eaRelease">The release of EA</param>
        static void LoadEaStandardSearchesFromJason(string eaRelease, string configFilePath)
        {

            string jasonPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                @"EaStandardSearches.json");
            var eaSearches = LoadSearchesFromJason(jasonPath);

            // add user search definitions
            var jasonUserPatch = configFilePath + @"userSearches.json";
            if (File.Exists(jasonUserPatch)) { 
                var eaSearchesUser = LoadSearchesFromJason(jasonUserPatch);

                try
                {
                    eaSearches.AddRange(eaSearchesUser);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e.Message}",
                        "Import user searches 'userSearches.json' impossible, double definitions!");
                }
            }


            // filter only EA Searches used in current release
            foreach (var eaSearchItem in eaSearches)
            {
                    if (eaSearchItem.EARelease != null)
                    {
                        if (eaSearchItem.EARelease.Contains(eaRelease)) _staticAllSearches.Add(eaSearchItem);
                    }
                    else
                    {
                        MessageBox.Show($"Like: \"EARelease\": \"9, 10, 11, 12, 12.1, 13\"\r\nFile:\r\n'{jasonPath}'",
                            @"Error JSON, no release defined");
                    }

            }
        }

        private static List<EaSearchItem> LoadSearchesFromJason(string jasonPath)
        {
            List<EaSearchItem> eaSearches;
            using (StreamReader sr = new StreamReader(path: jasonPath))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                JsonSerializer serializer = new JsonSerializer();
                eaSearches = serializer.Deserialize<List<EaSearchItem>>(reader);
            }
            return eaSearches;
        }
    }
    
}
