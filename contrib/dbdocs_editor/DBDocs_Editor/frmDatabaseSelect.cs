using System;
using System.Windows.Forms;
using DBDocs_Editor.Properties;

namespace DBDocs_Editor
{
    public partial class FrmDatabaseSelect : Form
    {
        public FrmDatabaseSelect()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            ProgSettings.ShowThisForm(ProgSettings.MainForm);
            Close();
        }

        private void frmDatabaseSelect_Load(object sender, EventArgs e)
        {
            var dbViewList = ProgSettings.SelectRows("SHOW DATABASES");
            if (dbViewList == null) return;
            if (dbViewList.Tables[0].Rows.Count <= 0) return;
            for (var thisRow = 0; thisRow <= dbViewList.Tables[0].Rows.Count - 1; thisRow++)
            {
                lstDatabases.Items.Add(dbViewList.Tables[0].Rows[thisRow]["database"].ToString());
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtDefaultDB.Text != @"*")
            {
                ProgSettings.DbName = txtDefaultDB.Text;

                var tablesScreen = new FrmTables { Text = Resources.DBDocs__Using_database_ + txtDefaultDB.Text };
                tablesScreen.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(Resources.Please_select_a_database_from_the_list);
            }
        }

        private void lstDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDefaultDB.Text = lstDatabases.Text;
            btnConnect.Enabled = true;
        }
    }
}