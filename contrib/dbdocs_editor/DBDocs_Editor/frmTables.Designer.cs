namespace DBDocs_Editor
{
    partial class FrmTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTables));
            this.label1 = new System.Windows.Forms.Label();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.txtTableNotes = new System.Windows.Forms.TextBox();
            this.chkDBDocsEntry = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstSubtables = new System.Windows.Forms.ListBox();
            this.btnShowSubtables = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCloseWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnShowFields = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tables";
            // 
            // lstTables
            // 
            this.lstTables.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(2, 53);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(204, 329);
            this.lstTables.TabIndex = 2;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.lstTables_SelectedIndexChanged);
            // 
            // txtTableNotes
            // 
            this.txtTableNotes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTableNotes.Location = new System.Drawing.Point(212, 53);
            this.txtTableNotes.Multiline = true;
            this.txtTableNotes.Name = "txtTableNotes";
            this.txtTableNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTableNotes.Size = new System.Drawing.Size(525, 366);
            this.txtTableNotes.TabIndex = 8;
            this.txtTableNotes.TextChanged += new System.EventHandler(this.txtTableNotes_TextChanged);
            // 
            // chkDBDocsEntry
            // 
            this.chkDBDocsEntry.AutoSize = true;
            this.chkDBDocsEntry.Enabled = false;
            this.chkDBDocsEntry.Location = new System.Drawing.Point(554, 6);
            this.chkDBDocsEntry.Name = "chkDBDocsEntry";
            this.chkDBDocsEntry.Size = new System.Drawing.Size(96, 17);
            this.chkDBDocsEntry.TabIndex = 9;
            this.chkDBDocsEntry.Text = "DB Docs Entry";
            this.chkDBDocsEntry.UseVisualStyleBackColor = true;
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
            // lstSubtables
            // 
            this.lstSubtables.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstSubtables.ColumnWidth = 140;
            this.lstSubtables.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSubtables.FormattingEnabled = true;
            this.lstSubtables.HorizontalScrollbar = true;
            this.lstSubtables.ItemHeight = 14;
            this.lstSubtables.Location = new System.Drawing.Point(2, 387);
            this.lstSubtables.MultiColumn = true;
            this.lstSubtables.Name = "lstSubtables";
            this.lstSubtables.Size = new System.Drawing.Size(204, 32);
            this.lstSubtables.TabIndex = 11;
            this.lstSubtables.SelectedIndexChanged += new System.EventHandler(this.lstSubtables_SelectedIndexChanged);
            // 
            // btnShowSubtables
            // 
            this.btnShowSubtables.Location = new System.Drawing.Point(330, 2);
            this.btnShowSubtables.Name = "btnShowSubtables";
            this.btnShowSubtables.Size = new System.Drawing.Size(96, 23);
            this.btnShowSubtables.TabIndex = 12;
            this.btnShowSubtables.Text = "Show Subtables";
            this.btnShowSubtables.UseVisualStyleBackColor = true;
            this.btnShowSubtables.Click += new System.EventHandler(this.btnShowSubtables_Click);
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
            this.newToolStripMenuItem,
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
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
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
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
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
            this.undoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(42, 25);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.btnMnuCopy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.btnMnuPaste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.label2.Location = new System.Drawing.Point(209, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Notes";
            // 
            // btnShowFields
            // 
            this.btnShowFields.Enabled = false;
            this.btnShowFields.Location = new System.Drawing.Point(432, 2);
            this.btnShowFields.Name = "btnShowFields";
            this.btnShowFields.Size = new System.Drawing.Size(80, 23);
            this.btnShowFields.TabIndex = 11;
            this.btnShowFields.Text = "Show Fields";
            this.btnShowFields.UseVisualStyleBackColor = true;
            this.btnShowFields.Click += new System.EventHandler(this.btnShowFields_Click);
            // 
            // FrmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 444);
            this.Controls.Add(this.chkDBDocsEntry);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowSubtables);
            this.Controls.Add(this.btnShowFields);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstSubtables);
            this.Controls.Add(this.txtTableNotes);
            this.Controls.Add(this.lstTables);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selected Database: ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTables_FormClosing);
            this.Load += new System.EventHandler(this.frmTables_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.TextBox txtTableNotes;
        private System.Windows.Forms.CheckBox chkDBDocsEntry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstSubtables;
        private System.Windows.Forms.Button btnShowFields;
        private System.Windows.Forms.Button btnShowSubtables;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox lstLangs;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chkUseEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnCloseWindow;
        private System.Windows.Forms.ToolStripMenuItem btnQuit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
