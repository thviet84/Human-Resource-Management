using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep.Forms
{
    public partial class frmCreateNewUser : Form
    {
        public frmCreateNewUser()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_CNU_clear_Click(object sender, EventArgs e)
        {
            txt_CNU_pwd.Text = "";
            txt_CNU_rePwd.Text = "";
            txt_CNU_userName.Text = "";

        }

        private void btn_CNU_back_Click(object sender, EventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
            this.Close();
        }

        private void txt_CNU_rePwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pass = txt_CNU_pwd.Text;
            string rePass = txt_CNU_rePwd.Text;
            if (!pass.Equals(rePass))
            {
                lbl_CNU_noti.Text = pass + "---" + rePass;
                // lbl_CNU_noti.Text = "Your Retype Password not correct with Password \n Please Check again!";
            }else
            {
                lbl_CNU_noti.Text = "";
            }
        }

        private void chBox_CNU_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_CNU_showPass.Checked)
            {
                txt_CNU_pwd.UseSystemPasswordChar = false;
                txt_CNU_rePwd.UseSystemPasswordChar = false;
                //chBox_showPass.Text = "Hide Password";
            }
            else
            {
                txt_CNU_pwd.UseSystemPasswordChar = true;
                txt_CNU_rePwd.UseSystemPasswordChar = true;
                //chBox_showPass.Text = "Show Password";
            }
        }

        private void btn_CNU_create_Click(object sender, EventArgs e)
        {
            string maNV = txt_CNU_userID.Text;
            string UN = txt_CNU_userName.Text;
            string PWD = txt_CNU_pwd.Text;
            string rePWD = txt_CNU_rePwd.Text;
            if (PWD == rePWD) {
                string query = "insert into taiKhoan values('" + maNV + "','" + UN + "','" + PWD + "');";
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmStaffInfor.username = UN;
                } catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Password and Retype Password are not Similar\n Please check its again!!" , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCreateNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
        }
    }
}
