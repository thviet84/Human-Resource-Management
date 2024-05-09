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

namespace QuanLyDoanhNghiep
{
    public partial class frmLogin : Form
    {
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public string UserName;
        Label ten = new Label();
        Label tenDN = new Label();
       
        public frmLogin()
        {

            InitializeComponent();
        }

        public bool checkLogin(string user, string pass)
        {
            bool check;
            string query = "SELECT * from taiKhoan WHERE username='" + user + "' AND passwd='" + pass + "';";
            try
            {
                UserName = user;
                conn.getConnection();
                conn._cmd.CommandText = query;
                SqlDataReader dr = conn._cmd.ExecuteReader();
                if (dr.Read())
                    check = true;
                else
                    check = false;
                conn.closeConnection();
                return check;
            }
            catch
            {
                return false;
            }
        }
        
        private void btn_L_Login_Click(object sender, EventArgs e)
        {
            frmMain sho = new frmMain();
            string userName = txt_L_UN.Text;
            string pwd = txt_L_PWD.Text;
            conn.getConnection();
            if (exe.getIDLogin(userName, pwd) == userName)
            {
                string query_timTen = "select nhanVien.tenNV from nhanVien inner join " +
                                        "taiKhoan on nhanVien.maNV = taiKhoan.maNV where" +
                                        " username = '" + userName + "' and passwd = '" + pwd + "'";
                string query_timCT = "select DoanhNghiep.tenDN from DoanhNghiep " +
                                    "inner join phongBan on phongBan.maDN = DoanhNghiep.maDN " +
                                    "inner join nhanVienPhongBan on nhanVienPhongBan.maPB = phongBan.maPB " +
                                    "inner join nhanVien on nhanVien.maNV = nhanVienPhongBan.maNV " +
                                    "inner join taiKhoan on taiKhoan.maNV = nhanVien.maNV " +
                                    "where taiKhoan.username = '"+userName+"'; ";
                sho.contr();
                frmMain.hoten = exe.KiemTra_Ten(query_timTen, ten);
                frmMain.tenDN = exe.KiemTra_Ten(query_timCT,tenDN);
                frmMain.chuoiQuyen = exe.getQuyen(txt_L_UN.Text,exe.getLevel(txt_L_UN.Text));
                frmMain.quyen = exe.getQuyen(txt_L_UN.Text,exe.getLevel(txt_L_UN.Text)).Split('/'); /// đưa danh sách các quyền vào mảng 'quyen'

                frmMain main = (frmMain)this.MdiParent;
                main.contr();
                main.textBox1.Text = userName;
                this.Close();
            }
            /*
                //push hoten qua frmMain.Label 
                string query_timCV = "SELECT chucVu.tenCV FROM chucVu INNER JOIN nhanVien ON nhanVien.maCV=chucVu.maCV INNER JOIN taiKhoan ON nhanVien.maNV=taiKhoan.maNV WHERE taiKhoan.username = '" + userName + "';";
                frmMain.vitri = exe.KiemTraChuoi(query_timCV);                     
            }*/
                
        }

        private void btn_L_cancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_showPass.Checked)
            {
                txt_L_PWD.UseSystemPasswordChar=false;
                //chBox_showPass.Text = "Hide Password";
            }
            else
            {
                txt_L_PWD.UseSystemPasswordChar = true;
                //chBox_showPass.Text = "Show Password";
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_L_UN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txt_L_UN.Equals(""))
            {
                txt_L_PWD.Enabled = true;
                chBox_showPass.Enabled = true;

            }
            else
            {
                txt_L_PWD.Enabled = false;
                chBox_showPass.Enabled = false;
            }
        }

        private void txt_L_PWD_TextChanged(object sender, EventArgs e)
        {
            if (!txt_L_PWD.Text.Equals(""))
            {
                btn_L_Login.Enabled = true;
            }
            else
            {
                btn_L_Login.Enabled = false;
            }
        }
    }
}
