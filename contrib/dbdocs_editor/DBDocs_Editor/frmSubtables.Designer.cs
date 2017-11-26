namespace DBDocs_Editor
{
    partial class FrmSubtables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubtables));
            this.label1 = new System.Windows.Forms.Label();
            this.lstsubtables = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRebuildContent = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSubtableTemplate = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSubtableContent = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowse = new System.Windows.Forms.WebBrowser();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStripTemplate = new System.Windows.Forms.Button();
            this.txtSubTableName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCloseWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undomnu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkUseEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.lstLangs = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sub-Tables";
            // 
            // lstsubtables
            // 
            this.lstsubtables.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstsubtables.ColumnWidth = 140;
            this.lstsubtables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstsubtables.FormattingEnabled = true;
            this.lstsubtables.HorizontalScrollbar = true;
            this.lstsubtables.ItemHeight = 15;
            this.lstsubtables.Location = new System.Drawing.Point(2, 51);
            this.lstsubtables.Name = "lstsubtables";
            this.lstsubtables.Size = new System.Drawing.Size(204, 364);
            this.lstsubtables.Sorted = true;
            this.lstsubtables.TabIndex = 11;
            this.lstsubtables.SelectedIndexChanged += new System.EventHandler(this.lstsubtables_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(656, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Entry";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRebuildContent
            // 
            this.btnRebuildContent.Location = new System.Drawing.Point(432, 2);
            this.btnRebuildContent.Name = "btnRebuildContent";
            this.btnRebuildContent.Size = new System.Drawing.Size(101, 23);
            this.btnRebuildContent.TabIndex = 14;
            this.btnRebuildContent.Text = "Rebuild Content";
            this.btnRebuildContent.UseVisualStyleBackColor = true;
            this.btnRebuildContent.Click += new System.EventHandler(this.btnRebuildContent_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(212, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 367);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSubtableTemplate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Template Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSubtableTemplate
            // 
            this.txtSubtableTemplate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSubtableTemplate.Location = new System.Drawing.Point(0, 0);
            this.txtSubtableTemplate.Multiline = true;
            this.txtSubtableTemplate.Name = "txtSubtableTemplate";
            this.txtSubtableTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSubtableTemplate.Size = new System.Drawing.Size(513, 345);
            this.txtSubtableTemplate.TabIndex = 10;
            this.txtSubtableTemplate.TextChanged += new System.EventHandler(this.txtSubtableTemplate_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSubtableContent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HTML Markup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSubtableContent
            // 
            this.txtSubtableContent.Location = new System.Drawing.Point(-4, 0);
            this.txtSubtableContent.Multiline = true;
            this.txtSubtableContent.Name = "txtSubtableContent";
            this.txtSubtableContent.ReadOnly = true;
            this.txtSubtableContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSubtableContent.Size = new System.Drawing.Size(517, 345);
            this.txtSubtableContent.TabIndex = 9;
            this.txtSubtableContent.TextChanged += new System.EventHandler(this.txtSubTableName_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowse);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(513, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rendered HTML";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowse
            // 
            this.webBrowse.Location = new System.Drawing.Point(0, 0);
            this.webBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowse.MinimumSize = new System.Drawing.Size(23, 22);
            this.webBrowse.Name = "webBrowse";
            this.webBrowse.Size = new System.Drawing.Size(513, 345);
            this.webBrowse.TabIndex = 6;
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.Location = new System.Drawing.Point(354, 2);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(72, 23);
            this.btnNewEntry.TabIndex = 20;
            this.btnNewEntry.Text = "New Entry";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnStripTemplate
            // 
            this.btnStripTemplate.Location = new System.Drawing.Point(539, 2);
            this.btnStripTemplate.Name = "btnStripTemplate";
            this.btnStripTemplate.Size = new System.Drawing.Size(101, 23);
            this.btnStripTemplate.TabIndex = 21;
            this.btnStripTemplate.Text = "Strip Template";
            this.btnStripTemplate.UseVisualStyleBackColor = true;
            this.btnStripTemplate.Click += new System.EventHandler(this.btnStripTemplate_Click);
            // 
            // txtSubTableName
            // 
            this.txtSubTableName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSubTableName.Location = new System.Drawing.Point(292, 30);
            this.txtSubTableName.Name = "txtSubTableName";
            this.txtSubTableName.Size = new System.Drawing.Size(441, 20);
            this.txtSubTableName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Subtable Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.languageToolStripMenuItem,
            this.lstLangs,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 29);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.mnuSave,
            this.toolStripSeparator1,
            this.btnCloseWindow,
            this.btnQuit});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(39, 25);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // mnuNew
            // 
            this.mnuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(159, 22);
            this.mnuNew.Text = "&New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(156, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Enabled = false;
            this.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(159, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(159, 22);
            this.btnCloseWindow.Text = "Close Window";
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(159, 22);
            this.btnQuit.Text = "E&xit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undomnu,
            this.toolStripSeparator2,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(42, 25);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // undomnu
            // 
            this.undomnu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undomnu.Name = "undomnu";
            this.undomnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.undomnu.Size = new System.Drawing.Size(153, 22);
            this.undomnu.Text = "Undo";
            this.undomnu.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.btnMnuCopy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.btnMnuPaste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(150, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.btnMnuSelectAll_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkUseEnglish});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // chkUseEnglish
            // 
            this.chkUseEnglish.Checked = true;
            this.chkUseEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseEnglish.Name = "chkUseEnglish";
            this.chkUseEnglish.Size = new System.Drawing.Size(258, 22);
            this.chkUseEnglish.Text = "Populate with English if missing";
            this.chkUseEnglish.Click += new System.EventHandler(this.chkUseEnglish_Click);
            // 
            // lstLangs
            // 
            this.lstLangs.AutoToolTip = true;
            this.lstLangs.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstLangs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLangs.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.lstLangs.Margin = new System.Windows.Forms.Padding(0);
            this.lstLangs.Name = "lstLangs";
            this.lstLangs.Size = new System.Drawing.Size(130, 25);
            this.lstLangs.SelectedIndexChanged += new System.EventHandler(this.lstLangs_SelectedIndexChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(117, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Field Comment:";
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Enabled = false;
            this.btnDeleteEntry.Location = new System.Drawing.Point(132, 29);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(75, 20);
            this.btnDeleteEntry.TabIndex = 25;
            this.btnDeleteEntry.Text = "Delete Entry";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // FrmSubtables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 444);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.btnStripTemplate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewEntry);
            this.Controls.Add(this.btnRebuildContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtSubTableName);
            this.Controls.Add(this.lstsubtables);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmSubtables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "subtables Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmsubtables_FormClosing);
            this.Load += new System.EventHandler(this.frmsubtables_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstsubtables;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRebuildContent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSubtableContent;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtSubtableTemplate;
        internal System.Windows.Forms.WebBrowser webBrowse;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnStripTemplate;
        private System.Windows.Forms.TextBox txtSubTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox lstLangs;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chkUseEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnCloseWindow;
        private System.Windows.Forms.ToolStripMenuItem btnQuit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undomnu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnDeleteEntry;
    }
}
