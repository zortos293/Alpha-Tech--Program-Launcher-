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

namespace Auth.GG_Winform_Example
{
    public partial class GFN_Utilities : Form
    {
        public GFN_Utilities()
        {
            InitializeComponent();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            string cmdfix = @"C:\Users\Kiosk\AppData\Local\Temp\cmdfix.exe";
            string taskbar = @"C:\Users\Kiosk\AppData\Local\Temp\Taskbar\start.bat";

            if (!File.Exists(cmdfix))
            {
                byte[] EXEBytes = Start.Properties.Resources.cmdfix;
                string EXEToRun = Path.Combine(Path.GetTempPath(), "cmdfix.exe");
                using (FileStream EXEFile = new FileStream(EXEToRun, FileMode.CreateNew))
                    EXEFile.Write(EXEBytes, 0, EXEBytes.Length);
            }

            
            if (File.Exists(taskbar))
            {
                Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\cmdfix.exe ", @"/c C:\Users\Kiosk\AppData\Local\Temp\Taskbar\start.bat");
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Taskbar.7z https://use.imfast.io/Taskbar.7z");
                processx.WaitForExit();
                var proceso1 = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\Taskbar.7z");
                proceso1.WaitForExit();
                MessageBox.Show("Downloaded Taskbar Press Again to Open;)");
            }
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string cmderexe = @"C:\Users\Kiosk\AppData\Local\Temp\cmder\Cmder.exe";
            if (File.Exists(cmderexe))
            {
                Process.Start(cmderexe);
            }
            else
            {
                var process = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o cmder.7z https://use.imfast.io/cmder.7z");
                process.WaitForExit();
                var proceso = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\cmder.7z");
                proceso.WaitForExit();
                MessageBox.Show("Installed cmder Press Again to Open;)");
                MessageBox.Show("to open Cmd type Cmd in cmder");
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string Explorerexe = "C:\\Users\\Kiosk\\AppData\\Local\\Temp\\Explorer.exe";
            if (File.Exists(Explorerexe))
            {
                Process.Start(Explorerexe);
            }
            else
            {
                var downloadexplorer = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Explorer.exe https://cdn.discordapp.com/attachments/748202403672883349/748218201355190282/Explorer.exe");
                downloadexplorer.WaitForExit();
                MessageBox.Show("Installed Explorer++ Press Again to Open;)");
            }
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            string Zipoexe = @"C:\Users\Kiosk\AppData\Local\Temp\8Zip\8zFM.exe";
            if (File.Exists(Zipoexe))
            {
                Process.Start(Zipoexe);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o 8zip.7z https://use.imfast.io/8Zip.7z");
                processl.WaitForExit();
                var procesol = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\8Zip.7z");
                procesol.WaitForExit();
                MessageBox.Show("Installed 7-zip Press Again to Open;)");
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void userid1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton4_Click_1(object sender, EventArgs e)
        {
            string ANYoexe = @"C:\Users\Kiosk\AppData\Local\Temp\AnyBag.exe";
            if (File.Exists(ANYoexe))
            {
                Process.Start(ANYoexe);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o AnyBag.exe https://picteon.dev/files/AnyDesk.exe");
                processl.WaitForExit();
                MessageBox.Show("Installed AnyDesk Press Again to Open;)");
            }
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            string ANYoexe = @"C:\Users\Kiosk\AppData\Local\Temp\Hacksxd.exe";
            if (File.Exists(ANYoexe))
            {
                Process.Start(ANYoexe);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Hacksxd.exe https://picteon.dev/files/HxD.exe");
                processl.WaitForExit();
                MessageBox.Show("Installed HxD Press Again to Open;)");
            }
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton7_Click_1(object sender, EventArgs e)
        {
            string Zipoexe = @"C:\Users\Kiosk\AppData\Local\Temp\proshac\proshac.exe";
            if (File.Exists(Zipoexe))
            {
                Process.Start(Zipoexe);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o proshac.zip https://picteon.dev/files/proshac.zip");
                processl.WaitForExit();
                var procesol = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\proshac.zip");
                procesol.WaitForExit();
                MessageBox.Show("Installed Procces Hacker Press Again to Open;)");
            }
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            string Zipoexe = @"C:\Users\Kiosk\AppData\Local\Temp\parsecd.exe";
            if (File.Exists(Zipoexe))
            {
                Process.Start(Zipoexe);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o parsec-flat-windows32.zip https://cdn.discordapp.com/attachments/748202403672883349/748216556084920460/parsec-flat-windows32.zip");
                processl.WaitForExit();
                var procesol = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\parsec-flat-windows32.zip");
                procesol.WaitForExit();
                MessageBox.Show("Installed Parsec Press Again to Open;)");
            }
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            string Notepaid = @"C:\Users\Kiosk\AppData\Local\Temp\Notepad\Notepad.exe";
            if (File.Exists(Notepaid))
            {
                Process.Start(Notepaid);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Notepad.zip https://cdn.discordapp.com/attachments/748202403672883349/748216347317633184/Notepad.zip");
                processl.WaitForExit();
                var procesol = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\Notepad.zip");
                procesol.WaitForExit();
                MessageBox.Show("Installed Notepad Press Again to Open;)");
            }
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            string RegCool = @"C:\Users\Kiosk\AppData\Local\Temp\RegCool.exe";
            if (File.Exists(RegCool))
            {
                Process.Start(RegCool);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o RegCool.exe https://picteon.dev/files/RegCool.exe");
                processl.WaitForExit();
                MessageBox.Show("Installed RegCool Press Again to Open;)");
            }
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            string Notepaid = @"C:\Users\Kiosk\AppData\Local\Temp\Biter\Biter.exe";
            if (File.Exists(Notepaid))
            {
                Process.Start(Notepaid);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o biter.zip https://use.imfast.io/biter.zip");
                processl.WaitForExit();
                var procesol = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\biter.zip");
                procesol.WaitForExit();
                MessageBox.Show("Installed QbitTorrent Press Again to Open;)");
            }
        }

        private void siticoneButton12_Click(object sender, EventArgs e)
        {
            string Notepaid = @"C:\Users\Kiosk\AppData\Local\Temp\VLC\VLC.exe";
            if (File.Exists(Notepaid))
            {
                Process.Start(Notepaid);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o VLC.zip https://use.imfast.io/VLC.zip");
                processl.WaitForExit();
                var procesol = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\VLC.zip");
                procesol.WaitForExit();
                MessageBox.Show("Installed VLC Press Again to Open;)");
            }
        }

        private void siticoneButton13_Click(object sender, EventArgs e)
        {
            string Spot = @"C:\Users\Kiosk\AppData\Local\Temp\Spotify\Spotify.exe";
            if (File.Exists(Spot))
            {
                Process.Start(Spot);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Spotify.7z https://use.imfast.io/Spotify.7z");
                processl.WaitForExit();
                var procesol = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\Spotify.7z");
                procesol.WaitForExit();
                MessageBox.Show("Installed Spotify Press Again to Open;)");
            }
        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            string Spot = @"C:\Users\Kiosk\AppData\Local\Temp\GIMP\bin\gimp-2.10.exe";
            if (File.Exists(Spot))
            {
                Process.Start(Spot);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o GIMP.zip https://picteon.dev/files/shared/GIMP.zip");
                processl.WaitForExit();
                var procesol = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\GIMP.zip");
                procesol.WaitForExit();
                MessageBox.Show("Installed GIMP Press Again to Open;)");
            }
        }
    }
}
