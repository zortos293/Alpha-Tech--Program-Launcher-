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
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string MC = @"C:\Users\Kiosk\AppData\Local\Temp\Minecraft.exe";
            if (File.Exists(MC))
            {
                Process.Start(MC);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Minecraft.exe https://launcher.mojang.com/download/Minecraft.exe");
                processx.WaitForExit();
                MessageBox.Show("Download Minecraft Press Again to Open;)");

            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string Roblox = @"C:\Users\Kiosk\AppData\Local\Temp\Roblox.exe";
            if (File.Exists(Roblox))
            {
                Process.Start(Roblox);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Roblox.exe https://setup.rbxcdn.com/version-f44a4c3c254d47db-Roblox.exe");
                processx.WaitForExit();
                MessageBox.Show("Download Roblox Press Again to Open;)");

            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void userid1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton3_Click_1(object sender, EventArgs e)
        {
            string Zipoexe = @"C:\Users\Kiosk\AppData\Local\Temp\ZombsRoyaleio\content\zombsroyale.exe";
            if (File.Exists(Zipoexe))
            {
                Process.Start(Zipoexe);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o ZombsRoyaleio.zip https://use.imfast.io/ZombsRoyaleio.zip");
                processl.WaitForExit();
                var procesol = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\ZombsRoyaleio.zip");
                procesol.WaitForExit();
                MessageBox.Show("Installed ZombsRoyale Press Again to Open;)");
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            string Zipoexe = @"C:\Users\Kiosk\AppData\Local\Temp\SteamUnsupported.bat";
            if (File.Exists(Zipoexe))
            {
                Process.Start(Zipoexe);
            }
            else
            {
                var processl = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o SteamUnsupported.bat https://cdn.discordapp.com/attachments/748202403672883349/748244729866485880/SteamUnsupported.bat");
                processl.WaitForExit();
                MessageBox.Show("Press Again to Open steam.exe.old ;)");
                MessageBox.Show("Dont CLOSE THE CMD PROMPT and Uplay MINIMIZE IT WHEN OPENED");
            }
        }
    }
}
