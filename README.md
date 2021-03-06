# EnterpriseArchitect_hoTools
Addin with Tools for SPARX Enterprise Architect (EA)

# Abstract
Collection of useful tools (see also [WiKi](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/home)):

- [hoTools](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/hoTools) Assortment of tools
  - Toolbar for Searches, [SQL](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/SQL), [Services](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/Services) and [Scripts](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/Scripts)
    - 5 Searches (EA or from SQL File)
    - 5 Services (Predefined hoTools Services, your beloved Script (VBScript, JavaScript, JScript))
  - Global Keys for Searches, SQL, Services and Scripts 
    - e.g.: F1+Ctrl executes your beloved Search (EA, SQL-File)
    - e.g.: F1+Ctrl+Shft locks the selected Package
    - e.g.: F2+Ctrl+Shft runs your beloved Script (VBScript, JavaScript, JScript)
  - Set diagram Line Style
  - Version Control + SVN
  - [Quick Search](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/Quick Search) 
    - Auto complete Search, Find Search + List all Searches
  - Port support
  - Favorites
  - Export SQL query results to Excel (hoTools, SQL, Script)
  - Clipboard CSV to Excel
  - ..
- [SQL](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/SQL) with tabbed Windows
    - Select, Insert, Delete, Update
	- Export SQL query results to Excel
    - Templates
    - Macros (easy access to EA items / Packages or complete Branches, a lot more than EA delivers)
    - Easy handling of SQL errors
    - Conveyed Items
    - *.sql files in file system (you may use favorite Editor)
    - [Find Search](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/Find Search)
- [Script](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/Script) which runs for [SQL](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/SQL) results 
  - All EA script languages (vbScript, JScript, JavaScript) 
  - Compatible to Geert Bellekens great VBScript Library
  - Script can be called from Search Results, Key, Toolbar
- [Find&Replace](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/FindAndReplace)
  - Find simple string or Regular Expression
  - Name, Description, Stereotype, Tagged Value
  - in Packages, Elements, Diagrams, Attributes, Operations
- [COM Server](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/ComServer) for [SQL searches](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/EaSearches)
- Configure
 - Buttons & Global Keys
 - Searches & Services & Scripts
 - GUI appearance
- Administration of EA
  - Version Control
- Intuitive GUI
- [WiKi](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/home)


# Requirements
- Windows
- .NET 4.5 or greater
- EA 9.0 or greater
- Local administration rights for installation (register COM dll)


# SQL Query
- Tabbed Editor or use your own editor
- Macro replacement (ID, GUID, Branch, DiagramSelectObject, ConveyedItem,..)
- DB specific (#DB=ORACLE#,..)
- Comment your sql
- Easy find SQL error
- Load / Save to file
- History / Last opened
- Easy cooperation with your beloved editor (try e.g. atom,..)
- etc.

# SQL Query + Script (VB, JScript, JavaScript)
- Run SQL and do something by script with the results

# Development
- C#
- ActiveX for Addin GUI
- BookMe for Online Help (powerful!)
- Configuration (*.xml)
- Installation via WIX
- Load MDG during startup
- Handling Keys
- Integrated Geert Bellekens VBScript Library
- Useful Searches
- Installable for different customers (brands)
- Visual Studio 2015
- Visual Studio Debug: Select "Enable native code debugging"

# Power features C/C++ for SPICE / FuSi #
Inside code are many powerful features to Reverse Engineer C/C++ Code for e.g. SPICE or FuSi (Functional Safety). With the existing code and a little knowhow it's easy to develop SPICE or FuSi compatible Architecture and Design.

Some features:
- Generate Activity Diagram from code snippets

# Installation 
- Uninstall hoTools
- hoTools.msi  (Setup\bin\Release\hoTools.msi V2.0.11)
- In EA: Extension, Addin Windows is selected
- In EA: Manage Addins, MDG: hoTools is selected
- hoToolsRemove.ps1 (deinstall with PowerShell)
- Make sure only one instance of hoTools is installed
- See also: [Installation](https://github.com/Helmut-Ortmann/EnterpriseArchitect_hoTools/wiki/Installation)

## Install folders
- c:\Users\&lt;user>\AppData\Local\Apps\hoTools\
  - The application installation folder
  - Sql.zip  Examples SQL files
- c:\Users\&lt;user>\AppData\Roaming\ho\hoTools\
  - Data folder
  - user.config Configuration 


# Releases

## Release 2.0.11
- SQL Query Results can be exported to Excel (no Excel required)
- Clipboard CSV content can be exported to Excel (no Excel required)
- User SQL Search definitions possible
- Reverse direction of edge (connector, dependency, association, information flow, SysML Item Flow)
- Unused references deleted (no functional implication)
- Implementation documentation added
- Search can't find Tagged Values in of Package


## Release 2.0.10
- Favorites (Show Favorites didn't work)
- SysML Locate Part for Sequence Call by name
- Add Load Scripts (if a Script is changed the user has to update the Script in hoTools before using it)
- Script Examples for JavaScript
- EAModel with Clipboard functions (for usage in Scripts)
- Default Line style all none (delete *.xml file required, or File, Settings,..)
  It's possible that Activity Diagrams and Statechart have a default Line style
  You may want to change it by
  File, Settings, Default Line style

## Release 2.0.9

- Consolidate Tag with release (skip 2.0.8)    
- Fix: Conveyed Items for Information Flow and for Connector
- Fix: Opened tabbed were duplicated by opening another repository
- Optimization: Only one Button Conveyed Items (former two, function decides from selected element/connector/flow)
- Optimization: Only one Button Notes (former two, function decides from selected element/diagram what to do)
- Switch off annoying Tooltip in SQL window
- Search description adapted to EA 13

## Release 2.0.7
    
- Global Keys with possible start Script (VBScript, JavaScript, JScript)
- Toolbar with possible start Script (VBScript, JavaScript, JScript)
- Fix: Automatic line style: Line-style of a length of 1 leads to Exception
- Error fixed Script usage of hoTools as COM Object


## Release 2.0.6
  - QuickSearch selection with auto complete for available Searches
  - SQL Searches (multiple folders are possible, file name should be unique)
  - MDG
  - Own Searches
  - Standard Searches
  - Determine Search
    - Auto complete (.NET standard feature)
    - Find part of string after Up, Down, Blank Key
      - Double Click in find starts Search








## Not yet scheduled 
- Search Management (for Quick Search)
  - Enable Category (Settings)
  - Favorites (configuration via JSON)
  - EA Standard Searches (configurable via JSON, my EA Standard Searches) 

# Feedback

I appreciate your feedback!!

