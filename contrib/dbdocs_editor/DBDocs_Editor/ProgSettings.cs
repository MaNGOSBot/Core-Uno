using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DBDocs_Editor.Properties;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace DBDocs_Editor
{
    public class ProgSettings
    {   // Common Functions will be added in here
        private static string dbName = "";
        private static string serverName = "";
        private static string userName = "";
        private static string password = "";
        private static string port = "3306";
        public static string SqldBconn = "";
        public static Form MainForm;

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public static string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                if (dbName != "*")
                {
                    SqldBconn = "SERVER=" + serverName + ";DATABASE=" + dbName + ";PORT=" + port + ";UID=" + userName + ";PWD=" + password + ";";
                }
                else
                {
                    SqldBconn = "SERVER=" + serverName + ";PORT=" + port + ";UID=" + userName + ";PWD=" + password + ";";
                }
            }
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public static string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                if (dbName != "*")
                {
                    SqldBconn = "SERVER=" + serverName + ";DATABASE=" + dbName + ";PORT=" + port + ";UID=" + userName + ";PWD=" + password + ";";
                }
                else
                {
                    SqldBconn = "SERVER=" + serverName + ";PORT=" + port + ";UID=" + userName + ";PWD=" + password + ";";
                }
            }
        }

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>The name of the user.</value>
        public static string Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
                if (dbName != "*")
                {
                    SqldBconn = "SERVER=" + serverName + ";DATABASE=" + dbName + ";PORT=" + port + ";UID=" + userName + ";PWD=" + password + ";";
                }
                else
                {
                    SqldBconn = "SERVER=" + serverName + ";PORT=" + port + ";UID=" + userName + ";PWD=" + password + ";";
                }
            }
        }

        /// <summary>
        /// Gets or sets the name of the server.
        /// </summary>
        /// <value>The name of the server.</value>
        public static string ServerName
        {
            get
            {
                return serverName;
            }
            set
            {
                serverName = value;
                if (dbName != "*")
                {
                    SqldBconn = "SERVER=" + serverName + ";DATABASE=" + ";PORT=" + port + dbName + ";UID=" + userName + ";PWD=" + password + ";";
                }
                else
                {
                    SqldBconn = "SERVER=" + serverName + ";PORT=" + port + ";UID=" + userName + ";PWD=" + password + ";";
                }
            }
        }

        /// <summary>
        /// Gets or sets the name of the db.
        /// </summary>
        /// <value>The name of the db.</value>
        public static string DbName
        {
            get
            {
                return dbName;
            }
            set
            {
                dbName = value;
                if (dbName != "*")
                {
                    SqldBconn = "SERVER=" + serverName + ";DATABASE=" + dbName + ";PORT=" + port + ";UID=" + userName + ";PWD=" + password + ";";
                }
                else
                {
                    SqldBconn = "SERVER=" + serverName + ";PORT=" + port + ";UID=" + userName + ";PWD=" + password + ";";
                }
            }
        }

        /// <summary>
        /// Returns a dataset contain the results of the query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public static DataSet SelectRows(string query)
        {
            var conn = new MySqlConnection(SqldBconn);
            var adapter = new MySqlDataAdapter();
            var myDataset = new DataSet();
            adapter.SelectCommand = new MySqlCommand(query, conn);
            try
            {
                adapter.Fill(myDataset);
            }
            catch (Exception ex)
            {
                myDataset = null;
                MessageBox.Show(Resources.Error_Connecting_to_DB + ex.Message);
            }
            adapter.Dispose();
            conn.Close();
            return myDataset;
        }

        #region "dbdocsTable Functions"

        /// <summary>
        /// Inserts a record into the dbdocstable table
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="languageId"></param>
        /// <param name="tableNotes"></param>
        public static void TableInsert(string tableName, int languageId, string tableNotes)
        {
            var conn = new MySqlConnection(SqldBconn);
            var cmd = new MySqlCommand("", conn);
            cmd.Connection.Open();

            cmd.CommandText = "insert  into `dbdocstable`(`languageId`,`tableName`,`tableNotes`) "
                              + "VALUES (@languageId, @tablename, @tablenotes)";

            cmd.Parameters.AddWithValue("@languageId", languageId);
            cmd.Parameters.AddWithValue("@tablename", tableName);
            cmd.Parameters.AddWithValue("@tablenotes", tableNotes);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        /// <summary>
        /// Update a record in the dbdocstable or dbdocstable_localised table
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="languageId"></param>
        /// <param name="tableNotes"></param>
        public static void TableUpdate(int tableId, int languageId, string tableNotes)
        {
            var conn = new MySqlConnection(SqldBconn);
            var cmd = new MySqlCommand("", conn);
            cmd.Connection.Open();

            // Does this entry exist as a main table entry ?
            if (LookupTableEntry(languageId, tableId))
            {
                // Update dbdocs
                cmd.CommandText = "update `dbdocstable` set `tablenotes`=@tableNotes where tableId=@tableId and languageId=@languageId";
            }
            else
            {   // Does this entry exist as a localised entry ?
                if (LookupTableEntryLocalised(languageId, tableId))
                {
                    // update dbdocs_localised
                    cmd.CommandText = "update `dbdocstable_localised` set `tablenotes`=@tableNotes where tableId=@tableId and languageId=@languageId";
                }
                else
                {
                    // insert into dbdocs_localised
                    cmd.CommandText = "insert  into `dbdocstable_localised`(`tableId`,`languageId`,`tableNotes`) "
                                    + "VALUES (@tableId, @languageId, @tablenotes)";
                }
            }

            cmd.Parameters.AddWithValue("@tableId", tableId);
            cmd.Parameters.AddWithValue("@languageId", languageId);
            cmd.Parameters.AddWithValue("@tablenotes", tableNotes);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        /// <summary>
        /// Check whether the data exists in the localised or main table
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="tableId"></param>
        /// <returns></returns>
        public static bool LookupTableEntryLocalised(int languageId, int tableId)
        {
            var dbView = SelectRows("SELECT tableNotes FROM dbdocstable_localised where tableId=" + tableId + " and languageId=" + languageId + ";");
            if (dbView == null) return false;
            if (dbView.Tables[0].Rows.Count <= 0) return false;
            return true;
        }

        /// <summary>
        /// Returns the TableId for a given TableName
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static int LookupTableId(string tableName)
        {
            var dbViewSubtable = SelectRows("SELECT tableid FROM dbdocstable where tableName='" + tableName + "';");
            if (dbViewSubtable == null) return 0;
            if (dbViewSubtable.Tables[0].Rows.Count <= 0) return 0;
            return Convert.ToInt32(dbViewSubtable.Tables[0].Rows[0]["tableid"]);
        }

        /// <summary>
        /// Check whether the data exists in the main table
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="tableId"></param>
        /// <returns></returns>
        public static bool LookupTableEntry(int languageId, int tableId)
        {
            var dbView = SelectRows("SELECT tableNotes FROM dbdocstable where tableId=" + tableId + " and languageId=" + languageId + ";");
            if (dbView == null) return false;
            if (dbView.Tables[0].Rows.Count <= 0) return false;
            return true;
        }

        #endregion "dbdocsTable Functions"

        #region "dbdocsfields Functions"

        /// <summary>
        /// Inserts a record into the dbdocsfields table
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="fieldComment"></param>
        /// <param name="fieldNotes">The field notes.</param>
        public static void FieldInsert(int languageId, string tableName, string fieldName, string fieldComment, string fieldNotes)
        {
            var conn = new MySqlConnection(SqldBconn);
            var cmd = new MySqlCommand("", conn);
            cmd.Connection.Open();
            cmd.CommandText = "insert  into `dbdocsfields`(`languageId`,`tableName`,`fieldName`,`FieldComment`,`fieldNotes`) "
                              + "VALUES (@languageId,@tablename, @fieldname, @FieldComment, @fieldnotes)";

            cmd.Parameters.AddWithValue("@languageId", languageId);
            cmd.Parameters.AddWithValue("@tablename", tableName);
            cmd.Parameters.AddWithValue("@fieldName", fieldName);
            cmd.Parameters.AddWithValue("@FieldComment", fieldComment);
            cmd.Parameters.AddWithValue("@fieldNotes", fieldNotes);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        /// <summary>
        /// Updates a record in the dbdocsfields table
        /// </summary>
        /// <param name="fieldId"></param>
        /// <param name="languageId"></param>
        /// <param name="fieldComment">Name of the field.</param>
        /// <param name="fieldNotes">The field notes.</param>
        public static void FieldUpdate(int fieldId, int languageId, string fieldComment, string fieldNotes)
        {
            var conn = new MySqlConnection(SqldBconn);
            var cmd = new MySqlCommand("", conn);
            cmd.Connection.Open();

            // Does this entry exist as a main table entry ?
            if (LookupFieldEntry(languageId, fieldId))
            {
                // Update dbdocs
                cmd.CommandText = "update `dbdocsfields` set `FieldComment`=@FieldComment, `fieldnotes`=@fieldNotes where `fieldId`=@fieldId and `languageId`=@languageId;";
            }
            else
            {   // Does this entry exist as a localised entry ?
                if (LookupFieldEntryLocalised(languageId, fieldId))
                {
                    // update dbdocs_localised
                    cmd.CommandText = "update `dbdocsfields_localised` set `FieldComment`=@FieldComment, `fieldnotes`=@fieldNotes where `fieldId`=@fieldId and `languageId`=@languageId;";
                }
                else
                {
                    // insert into dbdocs_localised
                    cmd.CommandText = "insert into `dbdocsfields_localised` (`fieldId`,`languageId`,`FieldComment`,`fieldNotes`) "
                                    + "VALUES (@fieldId, @languageId, @FieldComment, @fieldNotes)";
                }
            }

            cmd.Parameters.AddWithValue("@fieldId", fieldId);
            cmd.Parameters.AddWithValue("@languageId", languageId);
            cmd.Parameters.AddWithValue("@FieldComment", fieldComment);
            cmd.Parameters.AddWithValue("@fieldNotes", fieldNotes);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Error_Saving + ex.Message);
            }
            cmd.Connection.Close();
        }

        /// <summary>
        /// Check whether the data exists in the localised or main table
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="fieldId"></param>
        /// <returns></returns>
        public static bool LookupFieldEntryLocalised(int languageId, int fieldId)
        {
            var dbView = SelectRows("SELECT fieldNotes FROM dbdocsfields_localised where fieldId=" + fieldId + " and languageId=" + languageId + ";");
            if (dbView == null) return false;
            if (dbView.Tables[0].Rows.Count <= 0) return false;
            return true;
        }

        /// <summary>
        /// Check whether the data exists in the main table
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="fieldId"></param>
        /// <returns></returns>
        public static bool LookupFieldEntry(int languageId, int fieldId)
        {
            var dbView = SelectRows("SELECT fieldNotes FROM dbdocsfields where fieldId=" + fieldId + " and languageId=" + languageId + ";");
            if (dbView == null) return false;
            if (dbView.Tables[0].Rows.Count <= 0) return false;
            return true;
        }

        /// <summary>
        /// Returns the FieldId for a given FieldName
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static int LookupFieldId(string tableName, string fieldName)
        {
            var dbViewSubtable = SelectRows("SELECT fieldid FROM dbdocsfields where tableName='" + tableName + "' and fieldname='" + fieldName + "';");
            if (dbViewSubtable == null) return 0;
            if (dbViewSubtable.Tables[0].Rows.Count <= 0) return 0;
            return Convert.ToInt32(dbViewSubtable.Tables[0].Rows[0]["fieldId"]);
        }

        #endregion "dbdocsfields Functions"

        #region "dbdocssubTable Functions"

        /// <summary>
        /// Inserts a record into the dbdocsSubtable table
        /// </summary>
        /// <param name="subTableId">Id of the subTable.</param>
        /// <param name="languageId"></param>
        /// <param name="subTableName">Name of the subTable.</param>
        /// <param name="subTableContent">This is the generated markup, build from the Template</param>
        /// <param name="subTableTemplate">This is the Template used for the table markup</param>
        public static void SubTableInsert(int subTableId, int languageId, string subTableName, string subTableContent, string subTableTemplate)
        {
            var conn = new MySqlConnection(SqldBconn);
            var cmd = new MySqlCommand("", conn);
            cmd.Connection.Open();
            cmd.CommandText = "insert  into `dbdocssubtables`(`subtableid`,`languageId`,`subtableName`,`subtablecontent`,`subtabletemplate`) "
                              + "VALUES (@subtableid, @languageId, @subtableName, @subtablecontent, @subtabletemplate)";

            cmd.Parameters.AddWithValue("@subtableid", subTableId);
            cmd.Parameters.AddWithValue("@languageId", languageId);
            cmd.Parameters.AddWithValue("@subtableName", subTableName);
            cmd.Parameters.AddWithValue("@subtablecontent", subTableContent);
            cmd.Parameters.AddWithValue("@subtabletemplate", subTableTemplate);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        /// <summary>
        /// Delete a record from the dbdocsSubtable table
        /// </summary>
        /// <param name="subTableName">Name of the subTable.</param>
        /// <param name="languageId"></param>
        public static void SubTableDelete(string subTableName, int languageId)
        {
            var conn = new MySqlConnection(SqldBconn);
            var cmd = new MySqlCommand("", conn);
            var subTableId = LookupSubTableId(subTableName);
            if (subTableId > 0)
            {
                cmd.Connection.Open();
                if (languageId==0)
                {
                    cmd.CommandText = "DELETE FROM `dbdocssubtables` WHERE subTableId = @subTableId and languageId = @languageId";
                }
                else
                {
                    cmd.CommandText = "DELETE FROM `dbdocssubtables_localised` WHERE subTableId = @subTableId and languageId = @languageId";
                }
                cmd.Parameters.AddWithValue("@subTableId", subTableId);
                cmd.Parameters.AddWithValue("@languageId", languageId);

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        /// <summary>
        /// Updates a record in the dbdocsSubtable table
        /// </summary>
        /// <param name="subTableId">Id of the subTable.</param>
        /// <param name="languageId"></param>
        /// <param name="subTableName">Name of the subTable.</param>
        /// <param name="subTableContent">This is the generated markup, build from the Template</param>
        /// <param name="subTableTemplate">This is the Template used for the table markup</param>
        public static void SubTableUpdate(int subTableId, int languageId, string subTableName, string subTableContent, string subTableTemplate)
        {
            var conn = new MySqlConnection(SqldBconn);
            var cmd = new MySqlCommand("", conn);
            cmd.Connection.Open();

            // Does this entry exist as a main table entry ?
            if (LookupSubTableEntry(languageId, subTableId))
            {
                // Update dbdocs
                cmd.CommandText = "update `dbdocssubtables` set `subTableName`=@subTableName,`subTableContent`=@subTableContent,`subTableTemplate`=@subTableTemplate where subTableId=@subTableId and languageId=@languageId;";
            }
            else
            {   // Does this entry exist as a localised entry ?
                if (LookupSubTableEntryLocalised(languageId, subTableId))
                {
                    // update dbdocs_localised
                    cmd.CommandText = "update `dbdocssubtables_localised` set `subTableContent`=@subTableContent,`subTableTemplate`=@subTableTemplate where subTableId=@subTableId and languageId=@languageId;";
                }
                else
                {
                    // insert into dbdocs_localised
                    cmd.CommandText = "insert  into `dbdocssubtables_localised`(`subtableid`,`languageId`,`subtablecontent`,`subtabletemplate`) "
                                      + "VALUES (@subtableid, @languageId, @subtablecontent, @subtabletemplate)";
                }
            }

            cmd.Parameters.AddWithValue("@subtableid", subTableId);
            cmd.Parameters.AddWithValue("@languageId", languageId);
            cmd.Parameters.AddWithValue("@subtableName", subTableName);
            cmd.Parameters.AddWithValue("@subTableContent", subTableContent);
            cmd.Parameters.AddWithValue("@subTableTemplate", subTableTemplate);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        /// <summary>
        /// Check whether the data exists in the localised or main table
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="subtableId"></param>
        /// <returns></returns>
        public static bool LookupSubTableEntryLocalised(int languageId, int subtableId)
        {
            var dbView = SelectRows("SELECT subtabletemplate FROM dbdocssubtables_localised where subtableId=" + subtableId + " and languageId=" + languageId + ";");
            if (dbView == null) return false;
            if (dbView.Tables[0].Rows.Count <= 0) return false;
            return true;
        }

        /// <summary>
        /// Check whether the data exists in the main table
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="subtableId"></param>
        /// <returns></returns>
        public static bool LookupSubTableEntry(int languageId, int subtableId)
        {
            var dbView = SelectRows("SELECT subtablename FROM dbdocssubtables where subtableId=" + subtableId + " and languageId=" + languageId + ";");
            if (dbView == null) return false;
            if (dbView.Tables[0].Rows.Count <= 0) return false;
            return true;
        }

        #endregion "dbdocssubTable Functions"

        /// <summary>
        /// Redisplays the form 'formName' passed
        /// </summary>
        /// <param name="formName"></param>
        public static void ShowThisForm(Form formName)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm != formName) continue;
                frm.Show();
                return;
            }
        }

        /// <summary>
        /// Writes the connection setting into the registry.
        /// </summary>
        public static void WriteRegistry()
        { // The name of the key must include a valid root.
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "Software\\MaNGOS\\DBDocsEditor\\Connections";
            const string keyName = userRoot + "\\" + subkey;

            // Concat all the login requirements into a single field
            string[] connectionString = { serverName, userName, password, dbName, port };

            // Write in into the registry as a key call "<servername>-<dbname>"
            Registry.SetValue(keyName, serverName + "-" + DbName, connectionString);

            // Rebuild the internal list of connections
            PopulateConnections();
        }

        /// <summary>
        /// Deletes the connection setting from the registry. Has Two uses: a) The delete the selected connect entry, b) To remove the old entry when a server connnection is renamed
        /// </summary>
        /// <param name="keyname">The keyname.</param>
        public static void DeleteConnection(string keyname)
        {
            const string subkey = "Software\\MaNGOS\\DBDocsEditor\\Connections";

            using (var key = Registry.CurrentUser.OpenSubKey(subkey, true))
            {
                if (key == null)
                {
                    // Key doesn't exist. Do whatever you want to handle this case
                }
                else
                {
                    key.DeleteValue(keyname);
                }
            }
        }

        /// <summary>
        /// Populates the connection information from the registry and returns a list of the entries.
        /// </summary>
        /// <returns></returns>
        public static List<ConnectionInfo> PopulateConnections()
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "Software\\MaNGOS\\DBDocsEditor\\Connections";

            var rk = Registry.CurrentUser;

            // Open a subKey as read-only
            var dbDocsKey = rk.OpenSubKey(subkey);
            if (dbDocsKey == null) return null;
            var names = dbDocsKey.GetValueNames();

            if (names.GetLength(0) <= 0) return null;
            var allconnections = new List<ConnectionInfo>();
            var connections = new ConnectionInfo();

            // For every Connection entry in the registry
            foreach (var connectionstring in names)
            {
                var theseValues = (string[])Registry.GetValue(userRoot + "\\" + subkey, connectionstring, "");

                // Populate a connectionInfo structure with the values from the registry
                connections.ServerNameorIp = theseValues[0];
                connections.DatabaseUserName = theseValues[1];
                connections.DatabasePassword = theseValues[2];
                connections.DatabaseName = theseValues[3];
                if (theseValues.GetUpperBound(0) < 4)
                {
                    connections.DatabasePort = "3306";
                }
                else
                {
                    connections.DatabasePort = theseValues[4];
                }
                // Add the structure to a list
                allconnections.Add(connections);
            }
            return allconnections;
        }

        /// <summary>
        /// Extracts the subtableId's from subtable markup and returns them comma delimited
        /// </summary>
        /// <param name="subTableText"></param>
        /// <returns></returns>
        private static string GetSubtables(string subTableText)
        {
            var startPos = 1;
            var retString = "";

            while (startPos > 0)
            {        //¬subtable:xxx¬
                startPos = subTableText.IndexOf("¬subtable:", startPos + 1, StringComparison.Ordinal);
                if (startPos > 0)
                {
                    startPos = startPos + 10;
                }
                if (startPos <= 0) continue;

                var endPos = subTableText.IndexOf("¬", startPos + 1, StringComparison.Ordinal);
                retString = retString + subTableText.Substring(startPos, endPos - startPos) + ",";
            }
            return retString;
        }

        /// <summary>
        /// Populates a listbox with the name of each subtable entry found in text
        /// </summary>
        /// <param name="sourceText"></param>
        /// <param name="lstSubTables"></param>
        public static void ExtractSubTables(string sourceText, ListBox lstSubTables)
        {
            lstSubTables.Items.Clear();
            if (!sourceText.Contains("¬subtable:")) return;
            var subtables = GetSubtables(sourceText);
            var stringSeparators = new[] { "," };
            var subarray = subtables.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var tableid in subarray)
            {
                if (string.IsNullOrEmpty(tableid)) continue;
                var dbViewSubtable = SelectRows("SELECT subtablename FROM dbdocssubtables where subtableid=" + tableid);
                if (dbViewSubtable == null) continue;
                if (dbViewSubtable.Tables[0].Rows.Count > 0)
                {
                    lstSubTables.Items.Add(subtables.Replace(",", "") + ":" + dbViewSubtable.Tables[0].Rows[0]["subtablename"]);
                }
            }
            // MessageBox.Show("Found subtables: " + subtables);
        }

        /// <summary>
        /// Populate the Language Listboxes
        /// </summary>
        /// <param name="lstLangs"></param>
        public static void LoadLangs(ListBox lstLangs)
        {
            // The following command reads all the columns for the selected table
            var dbViewList = SelectRows("SELECT * FROM dbdocslanguage");

            // Did we return anything
            if (dbViewList != null)
            {
                // Do we have rows
                if (dbViewList.Tables[0].Rows.Count > 0)
                {
                    lstLangs.Items.Clear();

                    // for each Field returned, populate the listbox with the table name
                    for (var thisRow = 0; thisRow <= dbViewList.Tables[0].Rows.Count - 1; thisRow++)
                    {
                        var tableName = dbViewList.Tables[0].Rows[thisRow]["LanguageName"].ToString();
                        lstLangs.Items.Add(tableName);
                    }
                }
            }

            // Should something horrible go wrong, this will attempt to at least provide an option for english
            if (lstLangs.Items.Count > 0)
            {
                if (lstLangs.SelectedIndex < 0) lstLangs.SelectedIndex = 0;
            }
            else
            {
                lstLangs.Items.Add("English");
            }
        }

        /// <summary>
        /// Populate the Language Listboxes
        /// </summary>
        /// <param name="lstLangs"></param>
        public static void LoadLangs(ToolStripComboBox lstLangs)
        {
            // The following command reads all the columns for the selected table
            var dbViewList = SelectRows("SELECT * FROM dbdocslanguage");

            // Did we return anything
            if (dbViewList != null)
            {
                // Do we have rows
                if (dbViewList.Tables[0].Rows.Count > 0)
                {
                    lstLangs.Items.Clear();

                    // for each Field returned, populate the listbox with the table name
                    for (var thisRow = 0; thisRow <= dbViewList.Tables[0].Rows.Count - 1; thisRow++)
                    {
                        var tableName = dbViewList.Tables[0].Rows[thisRow]["LanguageName"].ToString();
                        lstLangs.Items.Add(tableName);
                    }
                }
            }

            // Should something horrible go wrong, this will attempt to at least provide an option for english
            if (lstLangs.Items.Count > 0)
            {
                if (lstLangs.SelectedIndex < 0) lstLangs.SelectedIndex = 0;
            }
            else
            {
                lstLangs.Items.Add("English");
            }
        }

        /// <summary>
        /// Looks up the next available subtableId
        /// </summary>
        /// <returns></returns>
        public static string GetNewSubTableId()
        {
            var dbViewSubtable = SelectRows("SELECT max(subtableid) as MaxId FROM dbdocssubtables");
            if (dbViewSubtable == null) return "0";
            if (dbViewSubtable.Tables[0].Rows.Count <= 0) return "0";
            return Convert.ToString(Convert.ToInt32(dbViewSubtable.Tables[0].Rows[0]["MaxId"].ToString()) + 1);
        }

        /// <summary>
        /// Returns the subTableId for a given subTableName
        /// </summary>
        /// <param name="subTableName"></param>
        /// <returns></returns>
        public static int LookupSubTableId(string subTableName)
        {
            var dbViewSubtable = SelectRows("SELECT subtableid FROM dbdocssubtables where subtableName='" + subTableName + "';");
            if (dbViewSubtable == null) return 0;
            if (dbViewSubtable.Tables[0].Rows.Count <= 0) return 0;
            return Convert.ToInt32(Convert.ToString(dbViewSubtable.Tables[0].Rows[0]["SubTableId"].ToString()));
        }

        /// <summary>
        /// Attempts to Create a subtable template from a HTML table. This is messy and horrible. !!
        /// - It is only used to attempt to convert the HTML table into the Template format, some user cleanup may be required.
        /// </summary>
        /// <param name="inText"></param>
        /// <returns></returns>
        public static string ConvertHtmlToTemplate(string inText)
        {
            inText = inText.Replace("valign=\"middle\"", "");
            inText = inText.Replace("valign='middle'", "");
            inText = inText.Replace("<tr bgcolor='#f0f0ff'>", "<tr>");
            inText = inText.Replace("<tr bgcolor=\"#f0f0ff\">", "<tr>");
            inText = inText.Replace("<tr bgcolor='#FFFFEE'>", "<tr>");
            inText = inText.Replace("<tr bgcolor=\"#FFFFEE\">", "<tr>");
            inText = inText.Replace("<tr bgcolor='#FEFEFF'>", "<tr>");
            inText = inText.Replace("<tr bgcolor=\"#FEFEFF\">", "<tr>");

            inText = inText.Replace("</table>", "");

            inText = inText.Replace("<th align=left>", "<th align=left><");
            inText = inText.Replace("<th align='left'>", "<th align='left'><");
            inText = inText.Replace("<th align=\"left\">", "<th align=\"left\"><");

            inText = inText.Replace("<th align=right>", "<th align=right>>");
            inText = inText.Replace("<th align='right'>", "<th align='right'>>");
            inText = inText.Replace("<th align=\"right\">", "<th align=\"right\">>");

            // Clean up the alignment stuff
            inText = inText.Replace("align='left'", "");
            inText = inText.Replace("align=\"left\"", "");

            inText = inText.Replace("align='centre'", "");
            inText = inText.Replace("align=\"centre\"", "");
            inText = inText.Replace("align='center'", "");
            inText = inText.Replace("align=\"center\"", "");

            inText = inText.Replace("align='right'", "");
            inText = inText.Replace("align=\"right\"", "");

            // Clean up iffy td entry
            while (inText.Contains(" >"))
            {
                inText = inText.Replace(" >", ">");
            }
            inText = inText.Replace("</td><td>", "|");
            inText = inText.Replace("</td></tr>", "");
            inText = inText.Replace("<tr><td>", "");

            // Clean up Table heading stuff
            inText = inText.Replace("<th><b>", "<th>");
            inText = inText.Replace("<<b>", "<");
            inText = inText.Replace("</b></th>", "</th>");
            inText = inText.Replace("<tr>" + "\r\n" + "<th>", "<th>");
            inText = inText.Replace("<tr>" + "\r" + "<th>", "<th>");
            inText = inText.Replace("<tr>" + "\n" + "<th>", "<th>");

            inText = inText.Replace("</th>" + "\r\n" + "<th>", "|");
            inText = inText.Replace("</th>" + "\r" + "<th>", "|");
            inText = inText.Replace("</th>" + "\n" + "<th>", "|");

            inText = inText.Replace("</th><th>", "|");

            inText = inText.Replace("<tr><th>", "");
            inText = inText.Replace("</th></tr>", "|");

            inText = inText.Replace("<th>", "");
            inText = inText.Replace("</th>", "");
            inText = inText.Replace("<tr></tr>", "");
            inText = inText.Replace("\r\n" + "\r\n", "\r\n");
            inText = inText.Replace("\r" + "\r", "\r");
            inText = inText.Replace("\n" + "\n", "\n");

            if (inText.Contains("<table"))
            {
                var startPos = inText.IndexOf("<table", StringComparison.Ordinal);
                var endPos = inText.IndexOf(">", startPos + 1, StringComparison.Ordinal) + 1;
                var sourceText = inText.Substring(startPos, endPos - startPos);
                inText = inText.Replace(sourceText, "").Trim();
            }
            inText = inText.Replace("><b>", ">");
            return inText;
        }

        /// <summary>
        /// Converts the Template markup to HTML
        /// </summary>
        /// <param name="templateHeader"></param>
        /// <param name="templateText"></param>
        /// <returns></returns>
        public static string ConvertTemplateToHtml(string templateHeader, string templateText)
        {
            var blnBuild = false;
            var sbHtml = new StringBuilder();
            if (templateHeader.EndsWith("|"))
                templateHeader = templateHeader.Substring(0, templateHeader.Length - 1);

            var stringSeparators = new[] { "|" };
            var strHeaders = templateHeader.Trim().Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            string[] strHeaderCols = null;

            if (templateText.Contains("|"))
                blnBuild = true;

            if (blnBuild)
            {
                sbHtml.AppendLine("<table border='1' cellspacing='1' cellpadding='3' bgcolor='#f0f0f0'>");
                sbHtml.AppendLine("<tr bgcolor='#f0f0ff'>");
                //"<thead>")

                //Process the headers
                strHeaderCols = new string[strHeaders.GetUpperBound(0) + 1];
                for (var intHead = 0; intHead <= strHeaders.GetUpperBound(0); intHead++)
                {
                    if (strHeaders[intHead].StartsWith("<"))
                    {
                        sbHtml.AppendLine("<th align='left'><b>" + strHeaders[intHead].Substring(1) + "</b></th>");
                        strHeaderCols[intHead] = "1";
                    }
                    else if (strHeaders[intHead].StartsWith(">"))
                    {
                        sbHtml.AppendLine("<th align='right'><b>" + strHeaders[intHead].Substring(1) + "</b></th>");
                        strHeaderCols[intHead] = "2";
                    }
                    else
                    {
                        sbHtml.AppendLine("<th><b>" + strHeaders[intHead] + "</b></th>");
                    }
                }
                //SbHtml.AppendLine("</thead>")
            }

            //Now need to process the body
            var stringSeparators2 = new[] { "\r\n" };
            var strLines = templateText.Split(stringSeparators2, StringSplitOptions.RemoveEmptyEntries);

            var resyncError = false;
            for (var intLines = 0; intLines <= strLines.GetUpperBound(0); intLines++)
            {
                if (blnBuild)
                {
                    try
                    {
                        var strBody = strLines[intLines].Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                        sbHtml.Append(intLines % 2 == 0 ? "<tr bgcolor='#FFFFEE'>" : "<tr bgcolor='#FEFEFF'>");

                        for (var intFields = 0; intFields <= strBody.GetUpperBound(0); intFields++)
                        {
                            try
                            {
                                strBody[intFields] = strBody[intFields].Trim();
                                if (strBody[intFields].Length <= 0) continue;
                                if (strHeaderCols[intFields] != "1")
                                {
                                    if (strHeaderCols[intFields] == "2")
                                    {
                                        sbHtml.Append("<td align='right' valign='middle'>" + strBody[intFields] +
                                                      "</td>");
                                    }
                                    else
                                    {
                                        sbHtml.Append("<td align='center' valign='middle'>" + strBody[intFields] +
                                                      "</td>");
                                    }
                                }
                                else
                                {
                                    sbHtml.Append("<td align='left' valign='middle'>" + strBody[intFields] + "</td>");
                                }
                            }
                            catch
                            {
                                resyncError = true;
                            }
                        }
                        sbHtml.AppendLine("</tr>");
                    }
                    catch
                    {
                        resyncError = true;
                    }
                }
                else
                {
                    sbHtml.AppendLine(strLines[intLines]);
                }
            }
            if (blnBuild)
                sbHtml.AppendLine("</table>");

            if (resyncError)
            {
                MessageBox.Show(Resources.Failure_during_Resync);
            }

            return sbHtml.ToString();
        }

        /// <summary>
        /// Replace ' with an escaped \' so SQL is happy
        /// </summary>
        /// <param name="inSql"></param>
        /// <returns></returns>
        public static string PrepareSqlString(string inSql)
        {
            inSql = inSql.Replace("\'", "\\'");
            return inSql;
        }

        /// <summary>
        /// Creates a simple input box
        /// </summary>
        /// <param name="input"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static DialogResult ShowInputDialog(ref string input, string title)
        {
            var size = new System.Drawing.Size(200, 70);
            var inputBox = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = title
            };

            var textBox = new TextBox
            {
                Size = new System.Drawing.Size(size.Width - 10, 23),
                Location = new System.Drawing.Point(5, 5),
                Text = input
            };
            inputBox.Controls.Add(textBox);

            var okButton = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new System.Drawing.Size(75, 23),
                Text = Resources.OK,
                Location = new System.Drawing.Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(okButton);

            var cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new System.Drawing.Size(75, 23),
                Text = Resources.Cancel,
                Location = new System.Drawing.Point(size.Width - 80, 39)
            };
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            inputBox.StartPosition = FormStartPosition.CenterParent;

            var result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        /// <summary>
        /// Replace <br/> with standard \r\n so that text displays correctly in textboxes
        /// </summary>
        /// <param name="inText"></param>
        /// <returns></returns>
        public static string ConvertBrToCrlf(string inText)
        {
            inText = inText.Replace("<br />", "\r\n");
            inText = inText.Replace("<br/>", "\r\n");
            inText = inText.Replace("<br>", "\r\n");
            return inText;
        }

        /// <summary>
        /// Replace \r\n with <br/> so that text is stored correctly in db
        /// </summary>
        /// <param name="inText"></param>
        /// <returns></returns>
        public static string ConvertCrlfToBr(string inText)
        {
            inText = inText.Replace("\r\n", "<br />");
            return inText;
        }

        /// <summary>
        /// Basic Connectin Information Structure
        /// </summary>
        public struct ConnectionInfo
        {
            public string ServerNameorIp;
            public string DatabaseName;
            public string DatabaseUserName;
            public string DatabasePassword;
            public string DatabasePort;
        }

        public static bool IsSubtableInTable(string subtableName)
        {
            var subTableId = LookupSubTableId(subtableName);
            var dbViewSubtable = SelectRows("Select * from dbdocstable where tablenotes like '%¬subtable:" + subTableId.ToString(CultureInfo.InvariantCulture) + "¬%';");
            if (dbViewSubtable == null) return false;
            if (dbViewSubtable.Tables[0].Rows.Count <= 0) return false;

            return true;
        }

        public static bool IsSubtableLocalisedInTable(string subtableName)
        {
            var subTableId = LookupSubTableId(subtableName);
            var dbViewSubtable = SelectRows("Select * from dbdocstable_localised where tableNotes like '%¬subtable:" + subTableId.ToString(CultureInfo.InvariantCulture) + "¬%';");
            if (dbViewSubtable == null) return false;
            if (dbViewSubtable.Tables[0].Rows.Count <= 0) return false;

            return true;
        }

        public static bool IsSubtableInField(string subtableName)
        {
            var subTableId = LookupSubTableId(subtableName);
            var dbViewSubtable = SelectRows("Select * from dbdocsfields where fieldNotes like '%¬subtable:" + subTableId.ToString(CultureInfo.InvariantCulture) + "¬%';");
            if (dbViewSubtable == null) return false;
            if (dbViewSubtable.Tables[0].Rows.Count <= 0) return false;

            return true;
        }
        public static bool IsSubtableLocalisedInField(string subtableName)
        {
            var subTableId = LookupSubTableId(subtableName);
            var dbViewSubtable = SelectRows("Select * from dbdocsfields_localised where fieldNotes like '%¬subtable:" + subTableId.ToString(CultureInfo.InvariantCulture) + "¬%';");
            if (dbViewSubtable == null) return false;
            if (dbViewSubtable.Tables[0].Rows.Count <= 0) return false;

            return true;
        }
    }
}