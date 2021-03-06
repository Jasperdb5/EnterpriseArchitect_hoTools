﻿namespace hoTools.Find
{
    partial class ShowAndChangeItemGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtfNotes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtSubType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.rtfName = new System.Windows.Forms.RichTextBox();
            this.rtfStereotype = new System.Windows.Forms.RichTextBox();
            this.btnChangeAll = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkIsChanged = new System.Windows.Forms.CheckBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.gridTags = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTaggedValues = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTaggedValueNames = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridTags)).BeginInit();
            this.SuspendLayout();
            // 
            // rtfNotes
            // 
            this.rtfNotes.Location = new System.Drawing.Point(36, 136);
            this.rtfNotes.Name = "rtfNotes";
            this.rtfNotes.Size = new System.Drawing.Size(679, 247);
            this.rtfNotes.TabIndex = 0;
            this.rtfNotes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(116, 38);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 22);
            this.txtType.TabIndex = 3;
            // 
            // txtSubType
            // 
            this.txtSubType.Enabled = false;
            this.txtSubType.Location = new System.Drawing.Point(329, 38);
            this.txtSubType.Name = "txtSubType";
            this.txtSubType.Size = new System.Drawing.Size(171, 22);
            this.txtSubType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subtype";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stereotype";
            // 
            // txtFrom
            // 
            this.txtFrom.Enabled = false;
            this.txtFrom.Location = new System.Drawing.Point(116, 407);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(146, 22);
            this.txtFrom.TabIndex = 9;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(305, 407);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(171, 22);
            this.txtTo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "to";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(39, 443);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Replace";
            this.toolTip1.SetToolTip(this.btnChange, "Replace find string by replace string in current item. Store is needed to make it" +
        " permanent.");
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(401, 443);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.toolTip1.SetToolTip(this.btnNext, "Show next found item. Not stored changes are lost.");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(320, 443);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Previous";
            this.toolTip1.SetToolTip(this.btnPrevious, "Show previous found item. Not stored changes are lost.");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(482, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(231, 443);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 17;
            this.btnStore.Text = "Store";
            this.toolTip1.SetToolTip(this.btnStore, "Store the visualized item (make changes permanent).");
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // rtfName
            // 
            this.rtfName.Location = new System.Drawing.Point(116, 66);
            this.rtfName.Multiline = false;
            this.rtfName.Name = "rtfName";
            this.rtfName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfName.Size = new System.Drawing.Size(384, 22);
            this.rtfName.TabIndex = 18;
            this.rtfName.Text = "";
            // 
            // rtfStereotype
            // 
            this.rtfStereotype.Location = new System.Drawing.Point(116, 94);
            this.rtfStereotype.Multiline = false;
            this.rtfStereotype.Name = "rtfStereotype";
            this.rtfStereotype.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfStereotype.Size = new System.Drawing.Size(384, 22);
            this.rtfStereotype.TabIndex = 19;
            this.rtfStereotype.Text = "";
            // 
            // btnChangeAll
            // 
            this.btnChangeAll.Location = new System.Drawing.Point(120, 443);
            this.btnChangeAll.Name = "btnChangeAll";
            this.btnChangeAll.Size = new System.Drawing.Size(105, 23);
            this.btnChangeAll.TabIndex = 20;
            this.btnChangeAll.Text = "ReplaceAll";
            this.toolTip1.SetToolTip(this.btnChangeAll, "Replace all findings in all choosen\r\n- Field Types\r\n- Field Items\r\nof the found i" +
        "tems permanently. \r\n\r\nNo undue/cancel possible!");
            this.btnChangeAll.UseVisualStyleBackColor = true;
            this.btnChangeAll.Click += new System.EventHandler(this.btnChangeAll_Click);
            // 
            // chkIsChanged
            // 
            this.chkIsChanged.AutoSize = true;
            this.chkIsChanged.Enabled = false;
            this.chkIsChanged.Location = new System.Drawing.Point(508, 420);
            this.chkIsChanged.Name = "chkIsChanged";
            this.chkIsChanged.Size = new System.Drawing.Size(87, 21);
            this.chkIsChanged.TabIndex = 22;
            this.chkIsChanged.Text = "Changed";
            this.toolTip1.SetToolTip(this.chkIsChanged, "Indicates that the item is changed by:\r\n- Store\r\n- ChangeAll\r\n- Change in overvie" +
        "w");
            this.chkIsChanged.UseVisualStyleBackColor = true;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(39, 473);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(518, 22);
            this.txtState.TabIndex = 21;
            // 
            // gridTags
            // 
            this.gridTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnValue});
            this.gridTags.Location = new System.Drawing.Point(721, 136);
            this.gridTags.Name = "gridTags";
            this.gridTags.RowTemplate.Height = 24;
            this.gridTags.Size = new System.Drawing.Size(297, 247);
            this.gridTags.TabIndex = 23;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnValue
            // 
            this.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnValue.DataPropertyName = "Value";
            this.ColumnValue.HeaderText = "Value";
            this.ColumnValue.Name = "ColumnValue";
            // 
            // lblTaggedValues
            // 
            this.lblTaggedValues.AutoSize = true;
            this.lblTaggedValues.Location = new System.Drawing.Point(718, 94);
            this.lblTaggedValues.Name = "lblTaggedValues";
            this.lblTaggedValues.Size = new System.Drawing.Size(104, 17);
            this.lblTaggedValues.TabIndex = 24;
            this.lblTaggedValues.Text = "Tagged Values";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(31, 116);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Description";
            // 
            // txtTaggedValueNames
            // 
            this.txtTaggedValueNames.Enabled = false;
            this.txtTaggedValueNames.Location = new System.Drawing.Point(721, 113);
            this.txtTaggedValueNames.Name = "txtTaggedValueNames";
            this.txtTaggedValueNames.ReadOnly = true;
            this.txtTaggedValueNames.Size = new System.Drawing.Size(297, 22);
            this.txtTaggedValueNames.TabIndex = 26;
            // 
            // ShowAndChangeItemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 521);
            this.Controls.Add(this.txtTaggedValueNames);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTaggedValues);
            this.Controls.Add(this.gridTags);
            this.Controls.Add(this.chkIsChanged);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnChangeAll);
            this.Controls.Add(this.rtfStereotype);
            this.Controls.Add(this.rtfName);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtfNotes);
            this.Name = "ShowAndChangeItemGUI";
            this.Text = "Show and change item";
            ((System.ComponentModel.ISupportInitialize)(this.gridTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSubType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.RichTextBox rtfName;
        private System.Windows.Forms.RichTextBox rtfStereotype;
        private System.Windows.Forms.Button btnChangeAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.CheckBox chkIsChanged;
        private System.Windows.Forms.DataGridView gridTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.Label lblTaggedValues;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTaggedValueNames;
    }
}