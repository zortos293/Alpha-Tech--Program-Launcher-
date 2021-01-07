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
    public partial class Chetos : Form
    {
        public Chetos()
        {
            InitializeComponent();
        }

        private void userid1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click_1(object sender, EventArgs e)
        {
            string Robfps = @"C:\Users\Kiosk\AppData\Local\Temp\rbxfpsunlocker.exe";
            if (File.Exists(Robfps))
            {
                Process.Start(Robfps);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o rbxfpsunlocker-x64.zip https://github.com/axstin/rbxfpsunlocker/files/4200559/rbxfpsunlocker-x64.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\rbxfpsunlocker-x64.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed Roblox FPS Unlocker Press Again to Open;)");

            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            string EXECUTE = @"C:\Users\Kiosk\AppData\Local\Temp\Xedved_v3\Xedved v3.exe";
            if (File.Exists(EXECUTE))
            {
                Process.Start(EXECUTE);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Xedved_v3.zip https://cdn.discordapp.com/attachments/688317519215329302/736173619226476573/Xedved_v3.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\Xedved_v3.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed Xedved Press Again to Open;)");

            }
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            string Synapse = @"C:\Users\Kiosk\AppData\Local\Temp\Synapse\Synapse.exe";
            if (File.Exists(Synapse))
            {
                Process.Start(Synapse);
            }
            else
            {
                var processx = Process.Start("C:\\Users\\Kiosk\\AppData\\Local\\Temp\\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Synapse.zip https://cdn.discordapp.com/attachments/748202403672883349/748212352649920573/Synapse.zip");
                processx.WaitForExit();
                var procesox = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\9z.exe", @"-oC:\Users\Kiosk\AppData\Local\temp\ x C:\Users\Kiosk\AppData\Local\Temp\Synapse.zip");
                procesox.WaitForExit();
                MessageBox.Show("Installed Synapse Press Again to Open;)");

            }
        }
    }
}
