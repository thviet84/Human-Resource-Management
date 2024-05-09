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
    public partial class frmProjectsInfor : Form
    {
        public frmProjectsInfor()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public static string tenNV = string.Empty, tenDA = string.Empty, chucVu = string.Empty, tenDN = string.Empty;
        public static string[] quyen = null;
        public void loadPlist()
        {
            string timMaNV = "select maNV from nhanVien where tenNV = N'" + tenNV + "';";
            string maNV = exe.KiemTraChuoi(timMaNV);
            string query = "SELECT duAn.maDA, duAn.tenDA from duAn " +
                            "inner join phanCong on phanCong.maDA=duAn.maDA " +
                            "inner join nhanVien on phanCong.maNV=nhanVien.maNV " +
                            "where phanCong.maNV = '" + maNV + "';";
            DataTable dt = conn.getTable(query);
            grv_PI_list.DataSource = dt;
            lbl_noti.Text = "Below is all projects that " + tenNV + " Have joined!\n" +
                            "Double Click at any project to see its detail";
            lbl_noti.ForeColor = Color.Green;
        }
        public void openFormStaffInfor(string maNV)
        {
           // string maNV = textBox1.Text;
            string inforQuery = "select *from nhanVien where maNV = '" + maNV + "';";
            string contQuery = "SELECT hopDong.maHD, hopDong.tenHD " +
                                "FROM hopDong INNER JOIN nhanVien ON hopDong.maNV = nhanVien.maNV " +
                                "WHERE nhanVien.maNV ='" + maNV + "'; ";
            DataTable dt_infor = conn.getTable(inforQuery);
            DataGridView dgv = grv_PI_staff;
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            Forms.frmNewStaff si = new Forms.frmNewStaff();
            Forms.frmNewStaff.maNV = dt_infor.Rows[0][0].ToString();
            Forms.frmNewStaff.tenNV = dt_infor.Rows[0][1].ToString();
            Forms.frmNewStaff.cccd = dt_infor.Rows[0][2].ToString();
            if (dt_infor.Rows[0][3].ToString() == "Nam")
            {
                si.radBtn_SI_male.Checked = true;
                si.radBtn_SI_female.Checked = false;
            }
            else
            {
                si.radBtn_SI_male.Checked = false;
                si.radBtn_SI_female.Checked = true;
            }
            Forms.frmNewStaff.DT = (dt_infor.Rows[0][4].ToString());
            si.cb_SI_nation.SelectedItem = Forms.frmNewStaff.DT;
            Forms.frmNewStaff.ngaySinh = dt_infor.Rows[0][5].ToString();
            si.datePicker_SI_bdate.Value = DateTime.Parse(Forms.frmNewStaff.ngaySinh);
            Forms.frmNewStaff.diaChi = dt_infor.Rows[0][6].ToString();
            Forms.frmNewStaff.sdt = dt_infor.Rows[0][7].ToString();
            Forms.frmNewStaff.email = dt_infor.Rows[0][8].ToString();
            DataTable dt_cont = conn.getTable(contQuery);
            if (dt_cont.Rows.Count > 0)
            {
                Forms.frmNewStaff.maHD = "HD_" + dt_cont.Rows[0]["maHD"].ToString();
                Forms.frmNewStaff.tenHD = dt_cont.Rows[0]["tenHD"].ToString();
            }
            /*for (int i = 0; i < frmMain.chuoiQuyen.Length; i++)
            {
                if (quyen[i] == "View Staff Resume" ||
                    quyen[i] == "View Contract Infor" ||
                    quyen[i] == "Alter Right")
                {

                    si.btn_SI_contDetail.Enabled = true;
                    si.btn_SI_staffResume.Enabled = true;
                    si.btn_SI_edit.Enabled = true;
                    break;
                }
                else if (quyen[i] == "")
                {
                    MessageBox.Show("You have not enoungh Access Right to Alter in this Window");

                    break;
                };
            }*/
            si.btn_SI_edit.Visible = false;
            si.Show();
        }
        public void loadCV()
        {
            string timCV = "select chucVu.tenCV from chucVu " +
                            "inner join nhanVien on nhanVien.maCV=chucVu.maCV " +
                            "where nhanVien.tenNV = N'" + frmProjectsInfor.tenNV + "';";
           frmProjectsInfor.chucVu = exe.KiemTraChuoi(timCV);
        }
        public void loadStaffList()
        {
            string timMaDN = "select maDN from DoanhNghiep where tenDN = N'" + frmProjectsInfor.tenDN + "';";
            string maDN = exe.KiemTraChuoi(timMaDN);
            string query = "SELECT tenNV from nhanVien where maCV like '"+maDN+"%';";
            exe.HienThiCBB(query, cb_PI_staffList, "tenNV", "tenNV");
            cb_PI_staffList.Visible = true;
        } 
        public void loadProjectList_toCCB()
        {
            String query = "SELECT tenDA from duAn;";
            exe.HienThiCBB(query,cb_PI_projName, "tenDA", "tenDA");
            cb_PI_projName.Visible = true;
        }
        public void load_chiTietDuAn()
        {
            DataGridView dgv = grv_PI_list;
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;

            string maDA = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            frmProjectsInfor.tenDA = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            string query = "SELECT duAn.maDA, duAn.tenDA, chiTietDuAn.soLuongNguoi, " +
                            "chiTietDuAn.ngayBatDau, chiTietDuAn.ngayKetThuc, " +
                            "chiTietDuAn.ketQua, chiTietDuAn.tienDo from duAn " +
                            "full join chiTietDuAn on duAn.maDA=chiTietDuAn.maDA " +
                            "where duAn.maDA = '" + maDA + "';";
            DataTable dt = conn.getTable(query);
            grv_PI_projInfor.DataSource = dt;
            grv_PI_projInfor.Visible = true;
            dgv.Visible = false;
            lbl_noti.Text = "This is all project " + frmProjectsInfor.tenDA + " information!\n" +
                                "Double Click at project to see all staff have took part in !\n" +
                                "Choose one and Press Button ESC to back !";
            txt_PI_projName.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
        }
        
        private void frmProjectsInfor_Load(object sender, EventArgs e)
        {
            loadPlist();
            loadCV();
            
            if (frmProjectsInfor.chucVu == "Trưởng Phòng" 
                || frmProjectsInfor.chucVu == "Phó Giám Đốc" 
                || frmProjectsInfor.chucVu =="Giám Đốc")
            {
                loadStaffList();
                loadProjectList_toCCB();
                DataGridView dgv = grv_PI_list;
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                string maDA = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                string tenDA = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                txt_PI_projName.Text = tenDA;
                btn_PI_addStaff.Visible = true;
                cb_PI_projName.Visible = true;
                cb_PI_staffList.Visible = true;
                lbl_PI_staffName.Visible = true;
                lbl_PI_projectName.Visible = true;
                grB_PI_addStaff.Visible = true;
            }
        }


        private void grv_PI_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (frmProjectsInfor.chucVu == "Trưởng Phòng"
                || frmProjectsInfor.chucVu == "Phó Giám Đốc"
                || frmProjectsInfor.chucVu == "Giám Đốc")
            {
                load_chiTietDuAn();
            }
            else
            {
                DataGridView dgv = grv_PI_list;
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;

                string maDA = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                string query = "Select *from chiTietDuAn where maDA = '" + maDA + "';";
                DataTable dt = conn.getTable(query);
                string memNum = "";
                string startDay = "";
                string endDay = "";
                string result = "";
                string prog = "";
                try
                {
                    memNum = dt.Rows[0][1].ToString();
                    startDay = dt.Rows[0][2].ToString();
                    endDay = dt.Rows[0][3].ToString();
                    result = dt.Rows[0][5].ToString();
                    prog = dt.Rows[0][4].ToString();
                    
                }
                catch (Exception ex)
                {
                    memNum = "0";
                    startDay = "";
                    endDay = "";
                    result = "";
                    prog = "";
                }
                frmReportProject rp = new frmReportProject();
                rp.txt_RP_id.Text = maDA;
                rp.txt_RP_name.Text = dt.Rows[0][1].ToString();
                rp.numberic_RP_memNum.Value = int.Parse(memNum);
                rp.txt_RP_prog.Text = prog;
                rp.txt_RP_result.Text = result;
                if (startDay == "")
                {
                    rp.datePicker_RP_start.Value = DateTime.Now;
                }
                else if (endDay =="")
                {
                    rp.datePicker_RP_end.Value = DateTime.Now;
                }
                else
                {
                    rp.datePicker_RP_start.Value = Convert.ToDateTime(startDay);
                    rp.datePicker_RP_end.Value = Convert.ToDateTime(endDay);
                }
                rp.Show();



            }
        }

        private void grv_P_projInfor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = grv_PI_projInfor;
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            int rowCount = dgv.Rows.Count;
            string maDA = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            string query = "Select nhanVien.maNV, nhanVien.tenNV from nhanVien " +
                            "inner join phanCong on phanCong.maNV=nhanVien.maNV " +
                            "where phanCong.maDA = '" + maDA + "';";
            DataTable dt = conn.getTable(query);
            grv_PI_staff.DataSource = dt;
            dgv.Visible = false;
            grv_PI_staff.Visible = true;
            lbl_noti.Text = "Here is "+rowCount+" Member(s) have took part in project " + frmProjectsInfor.tenDA+"\n" +
                             "Choose one and Press Button ESC to back !";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProjectsInfor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void grv_PI_projInfor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Escape)
            {
                grv_PI_list.Visible = true;
                grv_PI_projInfor.Visible = false;
                grv_PI_staff.Visible = false;
                lbl_noti.Text = "Here is all projects that " + tenNV + " Have joined!\n" +
                            "Double Click at any project to see its detail";
                lbl_noti.ForeColor = Color.Green;
            }
        }

        private void grv_PI_projInfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = grv_PI_projInfor;
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            string tenDA = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            txt_PI_projName.Text = tenDA;
        }

        private void cb_PI_staffList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curName = cb_PI_staffList.Text;
            DataGridView dgv = grv_PI_staff;
           // int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            int countRow = dgv.Rows.Count;
            string compareName = "";
            for(int i = 0; i<countRow; i++)
            {
                compareName = dgv.Rows[i].Cells[1].Value.ToString();
                if(curName == compareName)
                {
                    MessageBox.Show("This staff which you choose is already join in the Project: \n" + tenDA,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else{continue;}
            }
            if (curName != "System.Data.DataRowView" && tenDA != "")
            {
                string findMaNV = "select maNV from nhanVien where tenNV = N'" + curName + "';";
                string maNVien = exe.KiemTraChuoi(findMaNV);
                string findMaDA = "Select maDA from duAn where tenDA = N'" + tenDA + "';";
                string maDAN = exe.KiemTraChuoi(findMaDA);
                
            }
            else { }

        }

        private void btn_PI_addStaff_Click(object sender, EventArgs e)
        {
            string tenNV = cb_PI_staffList.Text;
            string tenDuAn = cb_PI_projName.Text;
            //MessageBox.Show(tenNV + "\n" + tenDA);
            string findMaNV = "select maNV from nhanVien where tenNV = N'" + tenNV + "';";
            string findMaDA = "Select maDA from duAn where tenDA = N'" + tenDuAn + "';";
            string maNV = exe.KiemTraChuoi(findMaNV);
            string maDA = exe.KiemTraChuoi(findMaDA);
            
            DataGridView dgv = grv_PI_staff;
            int countRow = dgv.Rows.Count;
            string compareName = "";
            bool check = false;
            for (int i = 0; i < countRow; i++)
            {
                compareName = dgv.Rows[i].Cells[1].Value.ToString();
                if (maNV == compareName)
                { check = false;break;}
            }
            if (check == true)
            {
                try
                {
                    string addQuery = "Insert Into phanCong values ('" + maNV + "','" + maDA + "');";
                    conn.getConnection();
                    SqlCommand cmd = new SqlCommand(addQuery, conn.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff " + tenNV + "\nhave been added on Project: \n" + tenDuAn, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadPlist();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eror\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.closeConnection(); }
            }
            else
            {
                MessageBox.Show("This Staff already take part in project:\n" + tenDuAn +
                        "\n Please choose another Staff!"
                        , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_PI_back_Click(object sender, EventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
            this.Close();
        }

        private void btn_PI_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void grv_PI_staff_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to see this staff Information ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dialog == DialogResult.Yes)
            {
                DataGridView dgv = grv_PI_staff;
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                //int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                string maNV = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                openFormStaffInfor(maNV);
            }
            else if (dialog == DialogResult.No)
            {
                
            }
        }

        private void grv_PI_staff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                grv_PI_list.Visible = false;
                grv_PI_projInfor.Visible = true;
                grv_PI_staff.Visible = false;
                lbl_noti.Text = "This is all project " + frmProjectsInfor.tenDA + " information!\n" +
                                "Double Click at project to see all staff have took part in !\n" +
                                "Choose one and Press Button ESC to back !";
            }
        }
    }
}
