using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace QuanLyDoanhNghiep
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
           
        }
        

        private void SplashScreen_Shown(object sender, EventArgs e)

        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Thread.Sleep(20);
            if (loadBar.Width < 997)
            {
                loadBar.Width = loadBar.Width + 10;
                //MessageBox.Show(loadBar.Width+"");
                //lbl_not.Text = "Connecting to Database! Please Wait!";
                //lbl_not.Visible = false;
            }
            else
            //if (loadBar.Width >= 580)
            {
                //lbl_not.Text = "Database Connected!";
                //lbl_not.Location = new Point(350,398);
                timer1.Stop();
                loadBar.Width = loadBar.Width + 3;
                
                Thread.Sleep(400);
                //MessageBox.Show("Database connected!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Realizing that you are not logged in, please log in to be able to enter the system");
                frmMain main = new frmMain();
                main.Show();
                /*frmLogin login = new frmLogin();
                login.Show();*/
                this.Hide();
                
                
            }
            
        }

        private void frmSplashScreen_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
