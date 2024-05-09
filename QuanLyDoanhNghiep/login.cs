using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep
{
    public partial class Login : Form
    {
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public string UserName;
        Label ten = new Label();
        Label tenDN = new Label();

        public Login()
        {
            InitializeComponent();
            
        }
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        

        private void btn_Login_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    db.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM taikhoan WHERE tentaikhoan= @Username AND matkhau= @Userpass", db.con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    SqlParameter p1 = new SqlParameter("@Username", SqlDbType.NVarChar);
                    p1.Value = txtTK.Text;
                    SqlParameter p2 = new SqlParameter("@Userpass", SqlDbType.NVarChar);
                    p2.Value = txtMK.Text;

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {

                        Form frm2 = new HomePage();
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng thử lại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }*/
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
        private void Login_Load_1(object sender, EventArgs e)
        {

        }

       /* private void txtTK_Click(object sender, EventArgs e)
        {
            txt_L_UN.BackColor = Color.White;
            panel3.BackColor = Color.White;
            txt_L_PWD.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;

        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            txt_L_PWD.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txt_L_UN.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }*/

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            txt_L_PWD.UseSystemPasswordChar = false;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            txt_L_PWD.UseSystemPasswordChar = true;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_L_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                                    "where taiKhoan.username = '" + userName + "'; ";
                sho.contr();
                frmMain.hoten = exe.KiemTra_Ten(query_timTen, ten);
                frmMain.tenDN = exe.KiemTra_Ten(query_timCT, tenDN);
                frmMain.chuoiQuyen = exe.getQuyen(txt_L_UN.Text, exe.getLevel(txt_L_UN.Text));
                frmMain.quyen = exe.getQuyen(txt_L_UN.Text, exe.getLevel(txt_L_UN.Text)).Split('/'); /// đưa danh sách các quyền vào mảng 'quyen'

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

        private void chBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_showPass.Checked)
            {
                txt_L_PWD.UseSystemPasswordChar = false;
                //chBox_showPass.Text = "Hide Password";
            }
            else
            {
                txt_L_PWD.UseSystemPasswordChar = true;
                //chBox_showPass.Text = "Show Password";
            }
        }
        

        private void txt_L_UN_Click(object sender, EventArgs e)
        {
            txt_L_UN.BackColor = Color.White;
            panel3.BackColor = Color.White;
            txt_L_PWD.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void txt_L_PWD_Click(object sender, EventArgs e)
        {
            txt_L_PWD.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txt_L_UN.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }
    }
}
