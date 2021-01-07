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

namespace GFN_Alpha_Tech
{
    public partial class Launchers : Form
    {
        public Launchers()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string batnetexe = @"C:\Users\Kiosk\AppData\Local\Temp\Battle.net\Battle.net.exe";
            if (File.Exists(batnetexe))
            {
                Process.Start(batnetexe);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Battle.net.zip https://picteon.dev/files/Battle.net.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\Battle.net.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed Battle.net Press Again to Open;)");

            }
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string TwitchStudioexe = @"C:\Users\Kiosk\AppData\Local\Temp\TwitchStudio\Bin\TwitchStudio.exe";
            if (File.Exists(TwitchStudioexe))
            {
                Process.Start(TwitchStudioexe);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o TwitchStudio.zip https://use.imfast.io/TwitchStudio.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\TwitchStudio.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed Twitch Studio Press Again to Open;)");

            }
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            string discordexe = @"C:\Users\Kiosk\AppData\Local\Temp\DiscordPort\discord-portable.exe";
            if (File.Exists(discordexe))
            {
                Process.Start(discordexe);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o DiscordPort.zip https://use.imfast.io/DiscordPort.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\DiscordPort.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed Twitch Studio Press Again to Open;)");

            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            string Origin = @"C:\Users\Kiosk\AppData\Local\Temp\Origin\Origin.exe";
            if (File.Exists(Origin))
            {
                Process.Start(Origin);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Origin.zip https://picteon.dev/files/shared/Origin.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\Origin.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed Origin Press Again to Open;)");

            }
        }
    }
}
