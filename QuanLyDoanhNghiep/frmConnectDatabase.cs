using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.SqlServer.m;
namespace QuanLyDoanhNghiep
{
    public partial class frmConnectDatabase : Form
    {
        connectionClass conn = new connectionClass();
        public static string connectQuery = "";
        executeStringClass exeClass = new executeStringClass();
        public frmConnectDatabase()
        {
            InitializeComponent();
        }

        private void frmConnectDatabase_Load(object sender, EventArgs e)
        {
            try
            {
                //DataTable dt = Microsoft.SqlServer.Management.Smo.SmoApplication.EnumAvailableSqlServer();
                cb_Con_serverName.Items.Add("LAPTOP-O4NAKIGN");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex+"");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cb_Con_database.Text == "")
            {
                MessageBox.Show("Please Choose a Database to connect");
            }
            else
            {
                connectQuery = "Server = " + cb_Con_serverName.Text + "; Database = " + cb_Con_database.Text + ";uid = " + txt_Con_LoginName.Text + ";pwd = " + txt_Con_pwd.Text;
                connectionClass con = new connectionClass();
                con.writeConnectionString(connectQuery);
                try
                {
                    //MessageBox.Show("Connect Link Generated!");
                    //frmSplashScreen sc = new frmSplashScreen();
                    //sc.Show();
                    frmLogin log = new frmLogin();
                    log.Show();
                    con.writeConnectionString(connectQuery);
                    this.Close();
                }
                catch { MessageBox.Show("Error Information Occur!"); return; }
            }
            
        }

        private void btn_Con_check_Click(object sender, EventArgs e)
        {
            string kn = "Server="+cb_Con_serverName.Text.ToString()+";Database=master;uid="+txt_Con_LoginName.Text.ToString()+";pwd=" + txt_Con_pwd.Text.ToString();
            cb_Con_database.Items.Clear();
            SqlConnection con = new SqlConnection(kn);
            SqlCommand cmd = new SqlCommand("SP_DATABASES",con);
            SqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb_Con_database.Items.Add(reader[0].ToString());

                }
                MessageBox.Show("Connection Successful!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch ( SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open) ;
                    con.Close();
                con.Dispose();
                cmd.Dispose();
                
            }
        }

        private void cb_Con_serverName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void chb_Con_showPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Con_showPwd.Checked)
            {
                txt_Con_pwd.UseSystemPasswordChar = false;
                //chBox_showPass.Text = "Hide Password";
            }
            else
            {
                txt_Con_pwd.UseSystemPasswordChar = true;
                //chBox_showPass.Text = "Show Password";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Con_backup_Click(object sender, EventArgs e)
        {
            string tenDN = frmMain.tenDN;
            //Hash Time
            string dbName = cb_Con_database.Text;
            string dateTime = DateTime.Now.ToString();
            string[] time = dateTime.Split(' ');
            string[] hashTime = time[1].Split(':');
            string rsTime = hashTime[0] + "h" + hashTime[1] + "m" + hashTime[2] + "s";
           // Hash Date
            
            string date = exeClass.hashDateTime(DateTime.Now.ToString());
            string[] hashDate = date.Split('/');
            string rsDate = hashDate[0] + "-" + hashDate[1] + "-" + hashDate[2];
            // add hash string to path file name
            string backupFileName = "Backup database_" + dbName + "_" + rsDate +"_"+ rsTime;
            //string path = "D:\Study\CT215H - Internship";
            string query = "BACKUP DATABASE  " + dbName + " TO DISK = 'D:/" + tenDN+"/"+ backupFileName +".bak';";

            // If the directory doesn't exist, create it.
            if (!Directory.Exists("D:/" + tenDN))
            {
                Directory.CreateDirectory("D:/" + tenDN);
            }
            else
            {
                try
                {

                    conn.getConnection();
                    SqlCommand command = new SqlCommand(query, conn.con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Database backup complete\n File saved at D:/"+tenDN, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.closeConnection();
                }
            }
        }
    }
}
