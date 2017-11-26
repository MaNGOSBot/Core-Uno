using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBDocs_Editor.Properties;

namespace DBDocs_Editor
{
    public partial class FrmServerSelect : Form
    {
        private bool blnEditmode;
        private List<ProgSettings.ConnectionInfo> serverList = new List<ProgSettings.ConnectionInfo>();

        public FrmServerSelect()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (blnEditmode == false)
            {   // When saving a new item, we only need to add it to the listbox and update the registry
                lstServers.Items.Add(txtServerName.Text + "-" + txtDefaultDB.Text);
            }
            else
            {   // When editing a connection, we have to allow for a changed servername and delete the old entry
                var selectedServer = lstServers.SelectedIndex;

                if (selectedServer > 0)
                {
                    if (serverList.Count > 0)
                    {
                        var thisServer = serverList[selectedServer - 1];
                        var dummyServerName = thisServer.ServerNameorIp;
                        var dummyDefaultDb = thisServer.DatabaseName;

                        // Delete the old connection from the registry
                        ProgSettings.DeleteConnection(dummyServerName + "-" + dummyDefaultDb);
                    }
                }
            }
            ProgSettings.DbName = txtDefaultDB.Text;
            ProgSettings.ServerName = txtServerName.Text;
            ProgSettings.UserName = txtUsername.Text;
            ProgSettings.Password = txtPassword.Text;
            ProgSettings.Port = txtPort.Text;

            ProgSettings.WriteRegistry();

            // Repopulate from datastore
            frmServerSelect_Load(sender, e);

            // Set the screen to 'Normal' Mode
            ToggleControls(false);

            btnConnect.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Set the screen to 'Edit' Mode
            ToggleControls(true);
            blnEditmode = true;
        }

        private void ToggleControls(bool editmode)
        {
            if (editmode)
            {
                // Set the 4 Textboxes to Editable
                txtDefaultDB.Enabled = true;
                txtPassword.Enabled = true;
                txtServerName.Enabled = true;
                txtUsername.Enabled = true;
                txtPort.Enabled = true;

                // Display Save/Cancel buttons
                btnCancel.Visible = true;
                btnSave.Visible = true;
                btnDelete.Enabled = true;

                //Disable other buttons.
                btnNew.Enabled = false;
                btnConnect.Enabled = false;
                lstServers.Enabled = false;
            }
            else
            {
                // Set the 4 Textboxes to Editable
                txtDefaultDB.Enabled = false;
                txtPassword.Enabled = false;
                txtServerName.Enabled = false;
                txtUsername.Enabled = false;
                txtPort.Enabled = false;

                // Display Save/Cancel buttons
                btnCancel.Visible = false;
                btnSave.Visible = false;
                btnDelete.Enabled = false;

                //Disable other buttons.
                btnNew.Enabled = true;
                btnConnect.Enabled = true;
                lstServers.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Set the screen to 'Normal' Mode
            ToggleControls(false);

            // Revert settings back to selected item settings
            lstServers_SelectedIndexChanged(sender, e);
            if (lstServers.SelectedIndex != 1)
            {
                btnConnect.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Set the screen to 'Edit' Mode
            ToggleControls(true);
        }

        /// <summary>
        /// Populate the entry information when the item is selected in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedServer = lstServers.SelectedIndex;

            if (serverList.Count > 0)
            {
                if (selectedServer >= 0)
                {
                    var thisServer = serverList[selectedServer];

                    txtServerName.Text = thisServer.ServerNameorIp;
                    txtUsername.Text = thisServer.DatabaseUserName;
                    txtPassword.Text = thisServer.DatabasePassword;
                    txtDefaultDB.Text = thisServer.DatabaseName;
                    txtPort.Text = thisServer.DatabasePort;

                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnConnect.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false; // Can't edit the localhost entry
                    btnDelete.Enabled = false; // Can't delete the localhost entry
                    btnConnect.Enabled = false;
                }
            }
            else
            {
                btnEdit.Enabled = false; // Can't edit the localhost entry
                btnDelete.Enabled = false; // Can't delete the localhost entry
                btnConnect.Enabled = false;
            }
        }

        private void frmServerSelect_Load(object sender, EventArgs e)
        {
            lstServers.Items.Clear();

            //// Add default entry
            //lstServers.Items.Add("localhost-*");

            serverList = ProgSettings.PopulateConnections();
            if (serverList == null) return;
            if (serverList.Count <= 0) return;

            foreach (var thisConnection in serverList)
            {
                lstServers.Items.Add(thisConnection.ServerNameorIp + "-" + thisConnection.DatabaseName);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ProgSettings.DbName = txtDefaultDB.Text;
            ProgSettings.Password = txtPassword.Text;
            ProgSettings.UserName = txtUsername.Text;
            ProgSettings.ServerName = txtServerName.Text;
            ProgSettings.Port = txtPort.Text;

            if (!txtDefaultDB.Text.Contains("*"))
            {
                // Display Table List screen
                var tablesScreen = new FrmTables { Text = Resources.DBDocs__Using_database_ + txtDefaultDB.Text };
                tablesScreen.Show();
                Hide();
            }
            else
            {
                // Display Database List screen
                var dbScreen = new FrmDatabaseSelect { Text = Resources.DBDocs__Using_Server + txtServerName.Text };
                dbScreen.Show();
                Hide();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProgSettings.DeleteConnection(txtServerName.Text + "-" + txtDefaultDB.Text);
            lstServers.Items.RemoveAt(lstServers.SelectedIndex);
        }
    }
}