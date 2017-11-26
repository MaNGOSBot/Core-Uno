namespace DBDocs_Editor
{
    partial class FrmSubtablesLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubtablesLookup));
            this.label1 = new System.Windows.Forms.Label();
            this.lstsubtables = new System.Windows.Forms.ListBox();
            this.txtSubtableName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSubtableTemplate = new System.Windows.Forms.TextBox();
            this.webBrowse = new System.Windows.Forms.WebBrowser();
            this.txtSubtableContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "subtables";
            // 
            // lstsubtables
            // 
            this.lstsubtables.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstsubtables.FormattingEnabled = true;
            this.lstsubtables.Location = new System.Drawing.Point(12, 27);
            this.lstsubtables.Name = "lstsubtables";
            this.lstsubtables.Size = new System.Drawing.Size(162, 394);
            this.lstsubtables.Sorted = true;
            this.lstsubtables.TabIndex = 2;
            this.lstsubtables.SelectedIndexChanged += new System.EventHandler(this.lstsubtables_SelectedIndexChanged);
            // 
            // txtSubtableName
            // 
            this.txtSubtableName.AutoSize = true;
            this.txtSubtableName.Location = new System.Drawing.Point(281, 9);
            this.txtSubtableName.Name = "txtSubtableName";
            this.txtSubtableName.Size = new System.Drawing.Size(182, 13);
            this.txtSubtableName.TabIndex = 5;
            this.txtSubtableName.Text = "Select a Table from the list on the left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "subTable Name:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(659, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Select Entry";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSubtableTemplate
            // 
            this.txtSubtableTemplate.Location = new System.Drawing.Point(22, 266);
            this.txtSubtableTemplate.Multiline = true;
            this.txtSubtableTemplate.Name = "txtSubtableTemplate";
            this.txtSubtableTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSubtableTemplate.Size = new System.Drawing.Size(441, 309);
            this.txtSubtableTemplate.TabIndex = 18;
            this.txtSubtableTemplate.Visible = false;
            // 
            // webBrowse
            // 
            this.webBrowse.Location = new System.Drawing.Point(180, 27);
            this.webBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowse.MinimumSize = new System.Drawing.Size(23, 22);
            this.webBrowse.Name = "webBrowse";
            this.webBrowse.Size = new System.Drawing.Size(545, 394);
            this.webBrowse.TabIndex = 19;
            // 
            // txtSubtableContent
            // 
            this.txtSubtableContent.Location = new System.Drawing.Point(469, 266);
            this.txtSubtableContent.Multiline = true;
            this.txtSubtableContent.Name = "txtSubtableContent";
            this.txtSubtableContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSubtableContent.Size = new System.Drawing.Size(441, 309);
            this.txtSubtableContent.TabIndex = 20;
            this.txtSubtableContent.Visible = false;
            // 
            // FrmSubtablesLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 430);
            this.Controls.Add(this.txtSubtableContent);
            this.Controls.Add(this.txtSubtableTemplate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubtableName);
            this.Controls.Add(this.lstsubtables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowse);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSubtablesLookup";
            this.Text = "===";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSubtablesLookup_FormClosing);
            this.Load += new System.EventHandler(this.frmsubtables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstsubtables;
        private System.Windows.Forms.Label txtSubtableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSubtableTemplate;
        internal System.Windows.Forms.WebBrowser webBrowse;
        private System.Windows.Forms.TextBox txtSubtableContent;
    }
}
