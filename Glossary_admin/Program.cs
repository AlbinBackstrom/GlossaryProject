using System;
using System.Windows.Forms;

namespace Glossary_Admin
{
	static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult result;
            using (var loginform = new Login())
                result = loginform.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.Run(new Main());
            }
        }
    }
}
