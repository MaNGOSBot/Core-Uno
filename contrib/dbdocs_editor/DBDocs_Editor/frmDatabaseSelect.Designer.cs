namespace DBDocs_Editor
{
    partial class FrmDatabaseSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatabaseSelect));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstDatabases = new System.Windows.Forms.ListBox();
            this.txtDefaultDB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(268, 213);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 24);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(181, 213);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 24);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Back";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selected Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Available Databases";
            // 
            // lstDatabases
            // 
            this.lstDatabases.FormattingEnabled = true;
            this.lstDatabases.Location = new System.Drawing.Point(12, 25);
            this.lstDatabases.Name = "lstDatabases";
            this.lstDatabases.Size = new System.Drawing.Size(163, 212);
            this.lstDatabases.TabIndex = 11;
            this.lstDatabases.SelectedIndexChanged += new System.EventHandler(this.lstDatabases_SelectedIndexChanged);
            // 
            // txtDefaultDB
            // 
            this.txtDefaultDB.Enabled = false;
            this.txtDefaultDB.Location = new System.Drawing.Point(181, 41);
            this.txtDefaultDB.Name = "txtDefaultDB";
            this.txtDefaultDB.Size = new System.Drawing.Size(162, 20);
            this.txtDefaultDB.TabIndex = 12;
            this.txtDefaultDB.Text = "*";
            // 
            // FrmDatabaseSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 251);
            this.Controls.Add(this.txtDefaultDB);
            this.Controls.Add(this.lstDatabases);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDatabaseSelect";
            this.Text = "Select Database";
            this.Load += new System.EventHandler(this.frmDatabaseSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstDatabases;
        private System.Windows.Forms.TextBox txtDefaultDB;
    }
}