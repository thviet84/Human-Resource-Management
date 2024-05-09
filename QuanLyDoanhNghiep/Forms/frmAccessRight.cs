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
    public partial class frmAccessRight : Form
    {
        public frmAccessRight()
        {
            InitializeComponent();
            
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public static string newRight = string.Empty;
        public static int countR;
        public void loadFuncList(string uid,int level)
        {
            string query = "select chucNang.maCN, chucNang.tenCN, chucNang.trangThai " +
                            "from nhanVien " +
                            "inner join taiKhoan on nhanVien.maNV = taiKhoan.maNV " +
                            "inner join phanQuyen on phanQuyen.username = taiKhoan.username " +
                            "inner join quyenTruyCap on quyenTruyCap.quyen = phanQuyen.quyen " +
                            "inner join chucNang on chucNang.quyen = quyenTruyCap.quyen " +
                            "where nhanVien.maNV = '" + uid + "'and levelFunc ="+level+"; ";
            //conn.closeConnection();
            DataTable dt = conn.getTable(query);
            grv_AR_list.DataSource = dt;
            grv_AR_list.ForeColor = Color.Black;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AR_edit_Click(object sender, EventArgs e)
        {
            grv_AR_list.Enabled = true;
            btn_AR_UAR.Visible = true;
            btn_AR_cancel.Visible = true;
            btn_AR_UF.Visible = true;
            txt_AR_staffFN.Enabled = true;
            txt_AR_curRight.Enabled = true;
            cb_AR_newRight.Enabled = true;
            btn_AR_back.Enabled = false;
            btn_AR_edit.Enabled = false;
            //////pull current right to text box//////
            string uid = txt_AR_uID.Text;
            string query = "select nhanVien.tenNV, quyenTruyCap.moTa " +
                            "from chucNang " +
                            "inner join quyenTruyCap on quyenTruyCap.quyen = chucNang.quyen " +
                            "inner join phanQuyen on phanQuyen.quyen = quyenTruyCap.quyen "+
                            "inner join taiKhoan on taiKhoan.username = phanQuyen.username "+
                            "inner join nhanVien on nhanVien.maNV=taiKhoan.maNV " +
                            "where nhanVien.maNV = '" + uid + "'; ";
            
            string tenNV;
            string quyen;
            tenNV = conn.getTable(query).Rows[0][0].ToString();
            quyen = conn.getTable(query).Rows[0][1].ToString();

            txt_AR_staffFN.Text = tenNV;
            txt_AR_curRight.Text = quyen;

            /////pull all choosable right to CBB/////
            string queryCBB = "select *from quyenTruyCap;";
            
            exe.HienThiCBB(queryCBB,cb_AR_newRight,"moTa","moTa");


        }

        private void btn_AR_cancel_Click(object sender, EventArgs e)
        {
            grv_AR_list.Enabled = false;
            btn_AR_UAR.Visible = false;
            btn_AR_cancel.Visible = false;
            btn_AR_UF.Visible = false;

            txt_AR_staffFN.Enabled = false;
            txt_AR_curRight.Enabled = false;
            cb_AR_newRight.Enabled = false;
            btn_AR_edit.Enabled = true;
            btn_AR_back.Enabled = true;

            txt_AR_staffFN.Text = null;
            txt_AR_curRight.Text = null;
            cb_AR_newRight.DataSource = null;
        }

        private void btn_AR_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccessRight_Load(object sender, EventArgs e)
        {
            string uid = txt_AR_uID.Text;
            string un = "select username from taiKhoan inner join nhanVien" +
                        " on nhanVien.maNV=taiKhoan.maNV " +
                        "where nhanVien.maNV = '"+uid+"';";
            
            loadFuncList(uid,exe.getLevel(exe.KiemTraChuoi(un)));
            //conn.closeConnection();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_AR_update_Click(object sender, EventArgs e)
        {
            ////////Update information in textBox & comboBox//////////////
            /////////////////////////////////////////////////////////////
            btn_AR_UAR.Visible = false;
            btn_AR_cancel.Visible = false;
            txt_AR_curRight.Enabled = false;
            cb_AR_newRight.Enabled = false;
            btn_AR_back.Enabled = true;
            btn_AR_edit.Enabled = true;
             newRight = cb_AR_newRight.Text;
            string uid = txt_AR_uID.Text;
            string un = exe.KiemTraChuoi("select taiKhoan.username from taiKhoan where taiKhoan.maNV='" + uid + "'");
            //MessageBox.Show(un);
            
            countR = 0;
            if(frmAccessRight.newRight == "Toàn quyền")
            {
                frmAccessRight.countR = 1;
            }
            else if(frmAccessRight.newRight == "Trưởng phòng + phó phòng")
            {
                frmAccessRight.countR = 2;
            }else if(frmAccessRight.newRight == "Trưởng nhóm + Phó nhóm")
            {
                frmAccessRight.countR = 3;
            }
            else if(frmAccessRight.newRight == "Thành viên")
            {
                frmAccessRight.countR = 4;
            }
            else { MessageBox.Show("Error! User Right didn't update!\n Please try again!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error); }
            try
            {
                string queryQuyen = "UPDATE phanQuyen SET quyen = "+ frmAccessRight.countR +" where " +
                                "phanQuyen.username='"+un+"';";
                
                conn.getConnection();
                SqlCommand cmd = new SqlCommand(queryQuyen, conn.con);
                cmd.ExecuteNonQuery();
                conn.closeConnection();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! Check again data in the TextBox or ComboBox"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.closeConnection();
            }
            
            MessageBox.Show("Data updated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_AR_curRight.Text = frmAccessRight.newRight;
            txt_AR_staffFN.Text = null;
            cb_AR_newRight.DataSource = null;
            txt_AR_staffFN.Enabled = false;
            grv_AR_list.Enabled = false;
            loadFuncList(uid, exe.getLevel(exe.getUName(uid)));
        }

        private void btn_AR_UF_Click(object sender, EventArgs e)
        {
            //////////Update information in gridView //////////////////
            ///////////////////////////////////////////////////////////
            string trangThai = null;
            int status = 0;
            string macn = null;
            string uid = txt_AR_uID.Text;
            countR = 0;
            if (txt_AR_curRight.Text == "Toàn quyền")
            {frmAccessRight.countR = 1;}
            else if (txt_AR_curRight.Text == "Trưởng phòng + phó phòng")
            {frmAccessRight.countR = 2; }
            else if (txt_AR_curRight.Text == "Trưởng nhóm + Phó nhóm")
            {frmAccessRight.countR = 3;}
            else if (txt_AR_curRight.Text == "Thành viên")
            {frmAccessRight.countR = 4;}
            else { MessageBox.Show("Error! User Right didn't update!\n Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            for (int i = 0; i < grv_AR_list.Rows.Count; i++)
            {
                DataGridViewRow row = grv_AR_list.Rows[i];
                trangThai = grv_AR_list.Rows[i].Cells[2].Value.ToString();
                macn = grv_AR_list.Rows[i].Cells[0].Value.ToString();
                //MessageBox.Show("" + trangThai);
                if (trangThai == "True")
                {status = 1;}
                else { status = 0; }
                try{
                    conn.getConnection();
                    string query = "update chucNang set  quyen='" + frmAccessRight.countR + "', trangThai = " + status + " where maCN ='" + macn + "';";
                    SqlCommand cmd = new SqlCommand(query, conn.con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex){
                    MessageBox.Show("Error! Check Again data in List View", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally{conn.closeConnection(); }
            }
            txt_AR_curRight.Text = frmAccessRight.newRight;
            txt_AR_staffFN.Text = null;
            cb_AR_newRight.DataSource = null;
            txt_AR_staffFN.Enabled = false;
            grv_AR_list.Enabled = false;
            btn_AR_edit.Enabled = true;
            btn_AR_back.Enabled = true;
            loadFuncList(uid, exe.getLevel(exe.getUName(uid)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = txt_AR_uID.Text;
            string un = "select taiKhoan.username from taiKhoan inner join nhanVien" +
                        " on nhanVien.maNV=taiKhoan.maNV " +
                        "where nhanVien.maNV = '" + uid + "';";

            int  level = exe.getLevel(exe.KiemTraChuoi(un));
            string query = "select chucNang.maCN, chucNang.tenCN, chucNang.trangThai, chucNang.levelFunc " +
                            "from nhanVien " +
                            "inner join taiKhoan on nhanVien.maNV = taiKhoan.maNV " +
                            "inner join phanQuyen on phanQuyen.username = taiKhoan.username " +
                            "inner join quyenTruyCap on quyenTruyCap.quyen = phanQuyen.quyen " +
                            "inner join chucNang on chucNang.quyen = quyenTruyCap.quyen " +
                            "where nhanVien.maNV = '" + uid + "'or levelFunc <=" + level + "; ";
            //loadFuncList(uid, exe.getLevel(exe.KiemTraChuoi(un)));
            DataTable dt = conn.getTable(query);
            grv_AR_list.DataSource = dt;
        }
    }
}
