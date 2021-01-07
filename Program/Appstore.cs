using System;
using GFN_mozarilla;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Auth.GG_Winform_Example;
using GFN_Alpha_Tech;
using Start;
using System.Collections;

namespace GFN_mozarilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string nineZ = @"C:\Users\Kiosk\AppData\Local\Temp\9z.exe";
            string aria2c = @"C:\Users\Kiosk\AppData\Local\Temp\aria2c.exe";
            if (File.Exists(nineZ))
            {
                return;
            }
            else
            {
                byte[] exeBytes = Start.Properties.Resources._9z;
                string exeToRun = Path.Combine(Path.GetTempPath(), "9z.exe");
                using (FileStream exeFile = new FileStream(exeToRun, FileMode.CreateNew))
                    exeFile.Write(exeBytes, 0, exeBytes.Length);

                byte[] DllBytes = Start.Properties.Resources._7z;
                string DllToRun = Path.Combine(Path.GetTempPath(), "7z.dll");
                using (FileStream DllFile = new FileStream(DllToRun, FileMode.CreateNew))
                    DllFile.Write(DllBytes, 0, DllBytes.Length);
            }

            if (File.Exists(aria2c))
            {
                return;
            }
            else
            {
                byte[] EXEBytes = Start.Properties.Resources.aria2c;
                string EXEToRun = Path.Combine(Path.GetTempPath(), "aria2c.exe");
                using (FileStream EXEFile = new FileStream(EXEToRun, FileMode.CreateNew))
                    EXEFile.Write(EXEBytes, 0, EXEBytes.Length);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void change_Click(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            GFN_Utilities gFN_Utilities = new GFN_Utilities();
            gFN_Utilities.Show();
            this.Hide();

        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Browser browser = new Browser();
            browser.Show();
            this.Hide();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.Show();
            this.Hide();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Launchers launchers = new Launchers();
            launchers.Show();
            this.Hide();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Next Update");
        }
    }
}
