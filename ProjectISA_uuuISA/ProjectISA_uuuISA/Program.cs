using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectISA_uuuISA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                // Initialize any required static resources
                // For example, if you need FormUtama.guru to be initialized:
                // FormUtama.InitializeStaticResources();

                // Create and run the main form
                FormUtama mainForm = new FormUtama();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting application: " + ex.Message,
                                "Application Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
