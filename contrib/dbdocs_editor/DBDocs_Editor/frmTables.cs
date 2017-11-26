using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DBDocs_Editor.Properties;

namespace DBDocs_Editor
{
    public partial class FrmTables : Form
    {
        private int tableId;
        private int selectedListId;
        private bool blnTextChanged;
        private bool blnSwitchOverride;

        public FrmTables()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populate the entry information when the item is selected in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            var blnSwitch = true;

            if (blnTextChanged && !blnSwitchOverride)
            {
                // Subtable text has tried to change selection without save, warn them
                var dialogResult = MessageBox.Show(this, Resources.You_have_unsaved_changes, Resources.Exit_Check, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                // If the user chose no, don't annoy the switch
                if (dialogResult == DialogResult.No)
                {
                    blnSwitch = false;
                    blnSwitchOverride = true;
                    lstTables.SelectedIndex=selectedListId;
                }
            }
            if (!blnSwitch) return;
            if (blnSwitchOverride)
            {
                blnSwitchOverride = false;
                return;
            }

            blnTextChanged = false;

            var selectedTable = lstTables.Text;
            tableId = ProgSettings.LookupTableId(selectedTable);
            selectedListId = lstTables.SelectedIndex;

            if (lstLangs.SelectedIndex < 0) lstLangs.SelectedIndex = 0;

            DataSet dbViewList;
            if (lstLangs.SelectedIndex == 0)
            {
                // If English, connect to main table
                dbViewList =
                    ProgSettings.SelectRows(
                        "SELECT `dbdocstable`.`languageId`,`dbdocstable`.`tableId`,`dbdocstable`.`tableNotes` FROM `dbdocstable` WHERE `tablename` = '" +
                        selectedTable + "'");
            }
            else
            {
                // If Non-English, join to localised table and grab field
                dbViewList =
                    ProgSettings.SelectRows(
                        "SELECT COALESCE(`dbdocstable_localised`.`languageid`,-1) AS languageId,`dbdocstable_localised`.`tableNotes`, `dbdocstable`.`tableId`, `dbdocstable`.`tableNotes` as TableNotesEnglish FROM `dbdocstable` LEFT JOIN `dbdocstable_localised` ON `dbdocstable`.`tableId` = `dbdocstable_localised`.`tableId` WHERE `tablename` = '" +
                        selectedTable + "' AND (`dbdocstable_localised`.`languageId`=" + lstLangs.SelectedIndex +
                        " OR `dbdocstable`.`languageId`=0)");
            }

            if (dbViewList != null)
            {
                if (dbViewList.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToInt32(dbViewList.Tables[0].Rows[0]["languageId"]) == lstLangs.SelectedIndex)
                    {
                        txtTableNotes.Text = dbViewList.Tables[0].Rows[0]["TableNotes"].ToString();
                        chkDBDocsEntry.Checked = true;
                    }
                    else
                    {
                        txtTableNotes.Text = "";
                        chkDBDocsEntry.Checked = false;
                    }

                    tableId = Convert.ToInt32(dbViewList.Tables[0].Rows[0]["TableId"]);

                    // If the 'Use English' if blank checkbox is ticked
                    if (chkUseEnglish.Checked)
                    {
                        // If Localised SubTable Template is blank, go grab the English
                        if (string.IsNullOrEmpty(txtTableNotes.Text))
                        {
                            txtTableNotes.Text = dbViewList.Tables[0].Rows[0]["TableNotesEnglish"].ToString();
                        }
                    }

                    txtTableNotes.Text = ProgSettings.ConvertBrToCrlf(txtTableNotes.Text);

                    //Check for Subtables
                    ProgSettings.ExtractSubTables(txtTableNotes.Text, lstSubtables);
                }
                else // No dbdocs match
                {
                    txtTableNotes.Text = "";
                    chkDBDocsEntry.Checked = false;
                }
            }
            else // No dbdocs match
            {
                txtTableNotes.Text = "";
                chkDBDocsEntry.Checked = false;
            }
            btnShowFields.Enabled = true;
            blnTextChanged = false;
            btnSave.Enabled = false;
            mnuSave.Enabled = btnSave.Enabled;
        }

        private void frmTables_Load(object sender, EventArgs e)
        {
            // Populate the Language Pulldown
            ProgSettings.LoadLangs(lstLangs);

            // The following command reads all the columns for the selected table
            var dbViewList =
                ProgSettings.SelectRows(
                    "SELECT T.TABLE_NAME AS TableName, T.ENGINE AS TableEngine, T.TABLE_COMMENT AS TableComment FROM INFORMATION_SCHEMA.Tables T WHERE T.TABLE_NAME <> 'dtproperties' AND T.TABLE_SCHEMA <> 'INFORMATION_SCHEMA' AND T.TABLE_SCHEMA='" +
                    ProgSettings.DbName + "' ORDER BY T.TABLE_NAME");

            // Did we return anything
            if (dbViewList != null)
            {
                // Do we have rows
                if (dbViewList.Tables[0].Rows.Count > 0)
                {
                    lstTables.Items.Clear();

                    // for each Field returned, populate the listbox with the table name
                    for (var thisRow = 0; thisRow <= dbViewList.Tables[0].Rows.Count - 1; thisRow++)
                    {
                        var tableName = dbViewList.Tables[0].Rows[thisRow]["TableName"].ToString();
                        lstTables.Items.Add(tableName);
                    }
                }
            }

            blnTextChanged = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dbDocsTableOutput = new StringBuilder();
            var outputFolder = Application.ExecutablePath;

            // Strip the Executable name from the path
            outputFolder = outputFolder.Substring(0, outputFolder.LastIndexOf(@"\", StringComparison.Ordinal));

            var selectedTable = lstTables.Text;

            // If the output folder doesnt exist, create it
            if (!Directory.Exists(outputFolder + @"\"))
            {
                Directory.CreateDirectory(outputFolder + @"\");
            }

            if (tableId == 0) // New Record
            {
                if (lstLangs.SelectedIndex != 0)
                {
                    // If English, connect to main table
                    dbDocsTableOutput.AppendLine("-- WARNING: The default entry should really be in english --");
                }

                //insert  into `dbdocstable`(`languageId`,`tableName`,`tableNotes`) values (2,'script_texts','xxxx');
                dbDocsTableOutput.AppendLine(
                    "insert  into `dbdocstable`(`languageId`,`tableName`,`tableNotes`) values (" +
                    lstLangs.SelectedIndex + ", '" + selectedTable + "','" +
                    ProgSettings.PrepareSqlString(ProgSettings.ConvertCrlfToBr(txtTableNotes.Text)) + "');");

                // Open the file for append and write the entries to it
                using (
                    var outfile = new StreamWriter(outputFolder + @"\" + ProgSettings.DbName + "_dbdocsTable.SQL", true)
                    )
                {
                    outfile.Write(dbDocsTableOutput.ToString());
                }

                // Write the entry out to the Database directly

                // For an insert, the record is always saved to the primary table, regardless of the language Since the system is English based, it should really have an English
                // base record.

                // Selected Table Language ID Notes
                ProgSettings.TableInsert(selectedTable, lstLangs.SelectedIndex, txtTableNotes.Text);

                blnTextChanged = false;
                btnSave.Enabled = false;
                mnuSave.Enabled = btnSave.Enabled;
            }
            else // Updated Record
            {
                if (lstLangs.SelectedIndex == 0)
                {
                    // If English, connect to main table
                    //update `dbdocstable` set `languageId`=xx,`tableName`=yy,`tableNotes`=zz where tableId=aa;
                    dbDocsTableOutput.AppendLine("update `dbdocstable` set `languageId`=" + lstLangs.SelectedIndex +
                                                 ", `tableName`='" + selectedTable + "', `tableNotes`='" +
                                                 ProgSettings.PrepareSqlString(
                                                     ProgSettings.ConvertCrlfToBr(txtTableNotes.Text)) +
                                                 "' where tableId=" + tableId + ";");

                    // Open the file for append and write the entries to it
                    using (
                        var outfile = new StreamWriter(outputFolder + @"\" + ProgSettings.DbName + "_dbdocsTable.SQL",
                            true))
                    {
                        outfile.Write(dbDocsTableOutput.ToString());
                    }
                }
                else
                {
                    dbDocsTableOutput.AppendLine("delete from `dbdocstable_localisation` where `languageId`=" +
                                                 lstLangs.SelectedIndex + " and `tableId`= " + tableId + ";");
                    dbDocsTableOutput.AppendLine(
                        "insert  into `dbdocstable_localisation`(`tableId`,`languageId`,`tableNotes`) values (" +
                        tableId + ", " + lstLangs.SelectedIndex + ", '" +
                        ProgSettings.PrepareSqlString(ProgSettings.ConvertCrlfToBr(txtTableNotes.Text)) + "');");

                    // Open the file for append and write the entries to it
                    using (
                        var outfile =
                            new StreamWriter(outputFolder + @"\" + ProgSettings.DbName + "_dbdocsTable_localised.SQL",
                                true))
                    {
                        outfile.Write(dbDocsTableOutput.ToString());
                    }
                }

                // Write the entry out to the Database directly For an update the logic to decide which table to update is in the Update function itself

                // Table ID Language ID Notes
                ProgSettings.TableUpdate(tableId, lstLangs.SelectedIndex,
                    ProgSettings.ConvertCrlfToBr(txtTableNotes.Text));

                blnTextChanged = false;
                btnSave.Enabled = false;
                mnuSave.Enabled = btnSave.Enabled;
            }
            lblStatus.Text = DateTime.Now + Resources.Save_Complete_for + selectedTable;
        }

        private void btnShowSubtables_Click(object sender, EventArgs e)
        {
            var subTableScreen = new FrmSubtables {SubTableId = 0};
            subTableScreen.Show();
        }

        private void lstSubtables_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The subtable entry in the listbox starts xx:, to need to trim everything after the :
            if (lstSubtables.Text.Contains(":"))
            {
                var thissubTableId =
                    Convert.ToInt32(lstSubtables.Text.Substring(0,
                        lstSubtables.Text.IndexOf(":", StringComparison.Ordinal)));
                var subTableScreen = new FrmSubtables {SubTableId = thissubTableId};
                subTableScreen.Show();
            }
            blnTextChanged = false;
            btnSave.Enabled = false;
            mnuSave.Enabled = btnSave.Enabled;
        }

        private void lstLangs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Are we looking for a localised version ?

            if (lstLangs.SelectedIndex == 0)
            {
                if (ProgSettings.LookupTableEntry(lstLangs.SelectedIndex, tableId))
                {
                    chkDBDocsEntry.Checked = true;
                }
                else
                {
                    chkDBDocsEntry.Checked = false;
                }
            }
            else
            {
                // Check whether a localised version exists
                if (ProgSettings.LookupTableEntryLocalised(lstLangs.SelectedIndex, tableId))
                {
                    chkDBDocsEntry.Checked = true;
                }
                else
                {
                    chkDBDocsEntry.Checked = false;

                    // If 'Use English' is not selected, clear the text
                    if (chkUseEnglish.Checked == false)
                    {
                        txtTableNotes.Text = "";
                    }
                }
            }
            blnTextChanged = false;
            btnSave.Enabled = false;
            mnuSave.Enabled = btnSave.Enabled;
        }

        private void txtTableNotes_TextChanged(object sender, EventArgs e)
        {
            blnTextChanged = true;
            btnSave.Enabled = true;
            mnuSave.Enabled = btnSave.Enabled;
        }

        private void frmTables_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Has any text changed on the form
            if (blnTextChanged)
            {
                // Ask the user if they which to close without saving
                var response = MessageBox.Show(this, Resources.You_have_unsaved_changes, Resources.Exit_Check,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.No)
                {
                    // Bail out of the form closing
                    e.Cancel = true;
                    return;
                }
            }
            ProgSettings.ShowThisForm(ProgSettings.MainForm);
        }

        private void chkUseEnglish_Click(object sender, EventArgs e)
        {
            if (chkUseEnglish.Checked == false)
            {
                chkUseEnglish.Checked = true;
            }
            else
            {
                chkUseEnglish.Checked = false;
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            if (blnTextChanged)
            {
                var response = MessageBox.Show(this, Resources.You_have_unsaved_changes, Resources.Exit_Check,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.No)
                {
                    return;
                }
            }
            ProgSettings.ShowThisForm(ProgSettings.MainForm);
            Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (blnTextChanged)
            {
                var response = MessageBox.Show(this, Resources.You_have_unsaved_changes, Resources.Exit_Check,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.No)
                {
                    return;
                }
            }
            Application.Exit();
        }


        private void btnShowFields_Click(object sender, EventArgs e)
        {
            var selectedTable = lstTables.Text;

            var fieldScreen = new FrmFields {TableName = selectedTable};
            fieldScreen.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutScreen = new About();
            aboutScreen.ShowDialog();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void btnMnuCopy_Click(object sender, EventArgs e)
        {
            if (ActiveControl.GetType() != typeof(TextBox)) return;
            var thisControl = (TextBox)ActiveControl;

            // Copy the textbox to the clipboard
            thisControl.Copy();
        }

        private void btnMnuPaste_Click(object sender, EventArgs e)
        {
            if (ActiveControl.GetType() != typeof(TextBox)) return;
            var thisControl = (TextBox)ActiveControl;

            // Paste the clipboard to the textbox
            // Determine if there is any text in the Clipboard to paste into the text box.
            var dataObject = Clipboard.GetDataObject();
            if (dataObject != null && dataObject.GetDataPresent(DataFormats.Text) != true) return;
            // Determine if any text is selected in the text box.
            if (thisControl.SelectionLength > 0)
            {
                // Ask user if they want to paste over currently selected text.
                if (
                    MessageBox.Show(@"Do you want to paste over current selection?", @"Cut Example",
                        MessageBoxButtons.YesNo) == DialogResult.No)
                    // Move selection to the point after the current selection and paste.
                    thisControl.SelectionStart = thisControl.SelectionStart + thisControl.SelectionLength;
            }
            // Paste current text in Clipboard into text box.
            thisControl.Paste();
        }

        private void btnMnuSelectAll_Click(object sender, EventArgs e)
        {
            if (ActiveControl.GetType() != typeof(TextBox)) return;
            var thisControl = (TextBox)ActiveControl;

            // Copy the textbox to the clipboard
            thisControl.Focus();
            thisControl.SelectAll();
            thisControl.SelectionStart = 0;
            thisControl.SelectionLength = thisControl.Text.Length;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveControl.GetType() != typeof(TextBox)) return;
            var thisControl = (TextBox)ActiveControl;

            // Determine if last operation can be undone in text box.
            if (thisControl.CanUndo != true) return;
            // Undo the last operation.
            thisControl.Undo();
            // Clear the undo buffer to prevent last action from being redone.
            thisControl.ClearUndo();
        }
    }
}