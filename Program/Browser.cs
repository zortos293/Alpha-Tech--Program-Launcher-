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
    

    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string Ffoxexe = @"C:\Users\Kiosk\AppData\Local\Temp\Firefox\Runthis.exe";
            if (File.Exists(Ffoxexe))
            {
                
                if (File.Exists(Ffoxexe))
                {
                    Process.Start(Ffoxexe);
                }
                else
                {
                    var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Firefox.zip https://use.imfast.io/Firefox.zip");
                    processx.WaitForExit();
                    var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\Firefox.zip");
                    procesox.WaitForExit();
                    MessageBox.Show("Installed Firefox Press Again to Open;)");

                }
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            string Water = @"C:\Users\Kiosk\AppData\Local\Temp\Water\sky.exe";
            if (File.Exists(Water))
            {
                Process.Start(Water);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Water.zip https://use.imfast.io/Water.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\Water.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed Waterfox Press Again to Open;)");
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string QT = @"C:\Users\Kiosk\AppData\Local\Temp\QtWeb.exe";
            if (File.Exists(QT))
            {
                Process.Start(QT);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @" -d C:\Users\Kiosk\AppData\Local\Temp -o QtWeb.exe http://www.qtweb.net/downloads/QtWeb.exe");
                processx.WaitForExit();
                MessageBox.Show("Installed Qtweb Press Again to Open;)");
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            string Qup = @"C:\Users\Kiosk\AppData\Local\Temp\kmelon\fly.exe";
            if (File.Exists(Qup))
            {
                Process.Start(Qup);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o kmelon.zip https://use.imfast.io/kmelon.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\kmelon.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed K-melon Press Again to Open;)");
            }
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            string WEX = @"C:\Users\Kiosk\AppData\Local\Temp\Wexond\Wexond.exe";
            if (File.Exists(WEX))
            {
                Process.Start(WEX);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o wexond.zip https://use.imfast.io/wexond.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\wexond.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed Wexond Press Again to Open;)");
            }
        }
    }
}
