using GFN_mozarilla;
using Program;
using Start;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string fullPath = @"C:\users\kiosk\appdata\local\temp\Siticone.UI.dll";
            if (!File.Exists(fullPath))
            {
                byte[] DllBytes = Start.Properties.Resources.Siticone_UI;
                string DllToRun = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "Siticone.UI.dll");
                using (FileStream DllFile = new FileStream(DllToRun, FileMode.CreateNew))
                    DllFile.Write(DllBytes, 0, DllBytes.Length);
            }
            Process[] end = Process.GetProcessesByName("cmd");
            Process[] lose = Process.GetProcessesByName("login");
            if (end.Length == 0)
            {
                MessageBox.Show("an error has occurred contact Zortos26#7466 for help");
            }
            else
            {
                if (lose.Length == 0)
                {
                    MessageBox.Show("an error has occurred contact Zortos26#7466 for help");
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());

                }



            }


        }
    }
}
