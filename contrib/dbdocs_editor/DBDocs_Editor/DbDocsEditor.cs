using System;
using System.Windows.Forms;
using DBDocs_Editor.Properties;

namespace DBDocs_Editor
{
    internal static class DbDocsEditor
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainform = new FrmServerSelect();
            ProgSettings.MainForm = mainform;
            mainform.Text = Resources.DBDocs_Editor_v + Application.ProductVersion;
            Application.Run(mainform);
        }
    }
}