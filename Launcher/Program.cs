using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            OnProgramStart.Initialize("GFN Alpha Tech", "754516", "4HsjUeAOGzR3w4WPVROLIK5QRq8NJ1rKykm", "1.0");

            string fullPath = @"C:\Program Files (x86)\Steam\Siticone.UI.dll";
            string amia = @"C:\Users\Kiosk\Appdata\Local\Temp\aria2c.exe";
            if (!File.Exists(amia))
            { 
                byte[] EXEBytes = GFN_Alpha_Tech.Properties.Resources.aria2c;
                string EXEToRun = Path.Combine(Path.GetTempPath(), "aria2c.exe");
                using (FileStream EXEFile = new FileStream(EXEToRun, FileMode.CreateNew))
                    EXEFile.Write(EXEBytes, 0, EXEBytes.Length);
            }


            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

           
        }
    }
}
