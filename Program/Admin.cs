using GFN_mozarilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            

        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string Citra = @"C:\Users\Kiosk\AppData\Local\Temp\nightly-mingw\citra-qt.exe";
            if (File.Exists(Citra))
            {
                Process.Start(Citra);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o citra.7z https://github.com/citra-emu/citra-nightly/releases/download/nightly-1601/citra-windows-mingw-20200807-f72be7a.7z");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\citra.7z");
                procesox.WaitForExit();
                MessageBox.Show("Installed Citra Press Again to Open;)");

            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string Cemu = @"C:\Users\Kiosk\AppData\Local\Temp\cemu_1.20.2\Gaymu.exe";
            if (File.Exists(Cemu))
            {
                Process.Start(Cemu);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o cemu_1.20.2.zip https://cdn.discordapp.com/attachments/748202403672883349/748208532540882974/cemu_1.20.2.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\cemu_1.20.2.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed Cemu Press Again to Open;)");


            }
        }
    }
}
