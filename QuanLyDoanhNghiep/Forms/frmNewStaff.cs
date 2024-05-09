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
    public partial class frmStaffInfor : Form
    {
        public frmStaffInfor()
        {
            InitializeComponent();
        }
        executeStringClass exe = new executeStringClass();
        connectionClass conn = new connectionClass();
        public static string maNV = string.Empty, 
                            maHD = string.Empty, 
                            tenHD = string.Empty, 
                            maCCh = string.Empty, 
                            maDT = string.Empty,
                            username = string.Empty,
                            right = string.Empty,
                            tenPB = string.Empty;
        public static string maDN ;
        public void loadNat()
        {
            
            string query2 = "select tenDT from danToc;";
            exe.HienThiCBB(query2, cb_NS_nation, "tenDT", "tenDT");
        }
        public void loadPos()
        {
            string query = "select  distinct tenCV from chucVu where maPB LIKE '" + frmStaffInfor.maDN + "%';";
            exe.HienThiCBB(query, cb_NS_pos, "tenCV", "tenCV");
        }
        public string cutPosString(string pos)
        {
            string rs = null;
            if(pos=="Giám Đốc")
            {rs = "GĐ";}
            else if(pos =="Phó GIám Đốc") { rs = "PGĐ"; }
            else if (pos == "Trưởng Phòng") { rs = "TP"; }
            else if (pos == "Phó Phòng") { rs = "PP"; }
            else if (pos == "Nhân Viên") { rs = "NV"; }
            return rs;
        }
        public int loadLastID()
        {
            string query = "select maNV from nhanVien";
            DataTable dt = conn.getTable(query);
            return dt.Rows.Count+1;
        }
        public bool checkCCCD(string cccd)
        {
            string query ="select nhanVien.cccd from nhanVien where cccd = '"+cccd+"';";
            if (exe.KiemTraChuoi(query) != "")
            {
                return false;
            }
            else return true;
        }
        public void control()
        {
            //not use
            txt_NS_contD.Text = frmStaffInfor.maHD;
            txt_NS_contName.Text = frmStaffInfor.tenHD;
        }
        public void changeWhenClickAdd1()
        {
            btn_NS_add1.Visible = false;
            btn_NS_add2.Visible = true;
            txt_NS_ufname.Enabled = false;
            txt_NS_cccd.Enabled = false;
            radBtn_NS_female.Enabled = false;
            radBtn_NS_male.Enabled = false;
            cb_NS_nation.Enabled = false;
            datePicker_NS_bdate.Enabled = false;
            txt_NS_addr.Enabled = false;
            txt_NS_phone.Enabled = false;
            txt_NS_email.Enabled = false;
            cb_NS_dep.Enabled = false;
            cb_NS_pos.Enabled = false;
        }
        public void loadRight()
        {
            string query = "select *from quyenTruyCap ;";
            exe.HienThiCBB(query, cb_NS_right, "moTa", "moTa");
            txt_NS_contD.Enabled = true;
            txt_NS_contName.Enabled = true;
            txt_NS_userName.Enabled = true;
            txt_NS_dep.Enabled = true;
            cb_NS_right.Enabled = true;
        }
        public void loadDep()
        {
            string query = "Select phongBan.tenPB from phongBan " +
                "inner join DoanhNghiep on DoanhNghiep.maDN=phongBan.maDN"+
                " where DoanhNghiep.maDN ='"+maDN+"';";
            exe.HienThiCBB(query, cb_NS_dep, "tenPB", "tenPB");
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btb_NS_accessRight_Click(object sender, EventArgs e)
        {
            frmAccessRight ac = new frmAccessRight();
            ac.Show();
        }

        private void btn_NS_contDetail_Click(object sender, EventArgs e)
        {
            frmAddContract ac = new frmAddContract();
            ac.Show();
        }

        private void btn_NS_clear_Click(object sender, EventArgs e)
        {
            txt_NS_addr.Text = "";
            txt_NS_cccd.Text = "";
        }

        private void btn_NS_back_Click(object sender, EventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmStaffInfor_Load(object sender, EventArgs e)
        {
            //loadNat();
        }

        private void btn_NS_add_Click(object sender, EventArgs e)
        {
            if(txt_NS_ufname.Text == "") {
                MessageBox.Show("Error\n Please enter Staff Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                changeWhenClickAdd1();
                loadRight();
                string staffID = txt_NS_userID.Text;
                string hoten = txt_NS_ufname.Text;
                string cccd = txt_NS_cccd.Text;
                string gioiTinh = "";
                if(radBtn_NS_male.Checked == true)
                {
                    gioiTinh = "Nam";
                    radBtn_NS_female.Checked = false;
                }
                { gioiTinh = "Nữ"; radBtn_NS_male.Checked = false; };
                string danToc = cb_NS_nation.Text;
                string bdate = exe.hashDateTime(datePicker_NS_bdate.Value.ToString());
                string addr = txt_NS_addr.Text;
                string sdt = txt_NS_phone.Text;
                string email = txt_NS_email.Text;
                string dep = cb_NS_dep.Text;
                string pos = cb_NS_pos.Text;
                string toDay = DateTime.Now.ToString();
                string InsertNhanVien = "insert into nhanVien values('"+staffID+"'," +
                                                            "N'"+hoten+"'," +
                                                            "'"+cccd+"'," +
                                                            "N'"+gioiTinh+"'," +
                                                            "N'"+danToc+"'," +
                                                            "'"+bdate+"'," +
                                                            "N'"+addr+"'," +
                                                            "'"+sdt+"'," +
                                                            "'"+email+"'," +
                                                            "N'"+pos+"');";
                string InsertNhanVienPhongBan = "insert into nhanVienPhongBan " +
                                                  "values(N'NVPB-"+dep+"'," +
                                                        "'"+dep+"'," +
                                                        "'"+staffID+"'," +
                                                        "'"+exe.hashDateTime(toDay)+"'," +
                                                        "'');";
                try
                {
                    conn.getConnection();
                    SqlCommand cmd = new SqlCommand(InsertNhanVien, conn.con);
                    SqlCommand cmd2 = new SqlCommand(InsertNhanVienPhongBan, conn.con);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error\n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.closeConnection(); }
            }

        }

        private void btn_NS_createAcc_Click(object sender, EventArgs e)
        {
            frmCreateNewUser cnu = new frmCreateNewUser();
            cnu.txt_CNU_userID.Text = txt_NS_userID.Text;
            cnu.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txt_NS_cccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 65536 ||e.KeyChar >=97 && e.KeyChar <= 122)
            {
                MessageBox.Show("Error! Data you already entered must be Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (checkCCCD(txt_NS_cccd.Text) == false)
            {
                MessageBox.Show("Error! Your Citizen Certificate already Resigted in our Company\nPlease check it again","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if(txt_NS_cccd.Text.Length == 11) { lbl_red2.Visible =false; lbl_green2.Visible = true; }
            else if(txt_NS_cccd.Text.Length<11 || txt_NS_cccd.Text.Length > 12){ lbl_red2.Visible = true; lbl_green2.Visible = false; }
        }

        private void txt_NS_ufname_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_NS_ufname_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_NS_ufname_TextChanged(object sender, EventArgs e)
        {
            if(txt_NS_ufname.Text != "")
            {
                string hoten = txt_NS_ufname.Text;
                string hotenCut = exe.cutString(hoten);
                string cor = exe.cutString(txt_NS_cor.Text);
                string dep = cor + "-*";
                int staffNum = loadLastID();
                if (txt_NS_ufname.Text == "")
                {
                    MessageBox.Show("Error\n Please enter Staff Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txt_NS_userID.Text = dep + "-" + hotenCut + "-" + staffNum;
                    /*txt_NS_userID.Text =*/
                }
                lbl_green1.Visible = true;
                lbl_red1.Visible = false;
            }
            else
            {
                
                lbl_green1.Visible = false;
                lbl_red1.Visible = true;
            }
        }

        private void radBtn_NS_male_CheckedChanged(object sender, EventArgs e)
        {
            if(radBtn_NS_male.Checked == true ||radBtn_NS_female.Checked == true)
            {
                lbl_red3.Visible = false;
                lbl_green3.Visible = true;
            }
            else
            {
                lbl_green3.Visible = false;
                lbl_red3.Visible = true;
            }
        }

        private void radBtn_NS_female_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_NS_male.Checked == true || radBtn_NS_female.Checked == true)
            {
                lbl_red3.Visible = false;
                lbl_green3.Visible = true;
            }
            else
            {
                lbl_green3.Visible = false;
                lbl_red3.Visible = true;
            }
        }

        private void cb_NS_nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_NS_nation.Text != "")
            {
                lbl_red4.Visible = false;
                lbl_green4.Visible = true;
            }
            else
            {
                lbl_red4.Visible = true;
                lbl_green4.Visible = false;
            }
        }

        private void datePicker_NS_bdate_ValueChanged(object sender, EventArgs e)
        {
            string[] yearBD = exe.hashDateTime(datePicker_NS_bdate.Value.ToString()).Split('/');
            string[] yearNow = exe.hashDateTime(DateTime.Today.ToString()).Split('/');
            int yearOld = int.Parse(yearNow[2]) - int.Parse(yearBD[2]);
            if (yearOld >= 18)
            {
                lbl_green5.Visible = true;
                lbl_red5.Visible = false;
            }
            else 
            { 
                lbl_green5.Visible = false; 
                MessageBox.Show("This user are not enough year olds to join Company","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
            }
        }

        private void txt_NS_addr_TextChanged(object sender, EventArgs e)
        {
            if (txt_NS_ufname.Text != "")
            {
                lbl_green6.Visible = true;
                lbl_red6.Visible = false;
            }
            else
            {
                lbl_green6.Visible = false;
                lbl_red6.Visible = true;
            }
        }

        private void lbl_green12_Click(object sender, EventArgs e)
        {

        }

        private void cb_NS_right_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_NS_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_NS_nation_MouseClick(object sender, MouseEventArgs e)
        {
            loadNat();
        }

        private void cb_NS_dep_MouseClick(object sender, MouseEventArgs e)
        {
            loadDep();
        }

        private void cb_NS_dep_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar == e)
            string staffID = txt_NS_userID.Text;
            string depName = cb_NS_dep.Text;
            string timMaPB = "Select maPB from phongBan where tenPB = N'" + depName + "' and maDN = '" + maDN + "';";
            string maPB = exe.KiemTraChuoi(timMaPB);
            string corID = maDN + "-*";
            staffID = staffID.Replace(corID, maPB);
            frmAddContract.maNV = staffID;
            txt_NS_userID.Text = staffID;
            lbl_green13.Visible = true;
            lbl_red13.Visible = false;
            loadPos();
        }

        private void cb_NS_pos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_green13_Click(object sender, EventArgs e)
        {

        }

        private void lbl_red13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_NS_right_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_NS_userID.Text != "")
            {
                if (username == ""){
                    frmCreateNewUser cnu = new frmCreateNewUser(); 
                    if (exe.checkFormOpen(exe.returnFormName(cnu + "")) == false)
                    { 
                        cnu.txt_CNU_userID.Text = txt_NS_userID.Text;
                        frmAddContract.maDN = frmStaffInfor.maDN;
                        cnu.Show(); ; exe.changeFormValue(exe.returnFormName(cnu + "")); }
                    else{ cnu.Focus(); this.SendToBack(); }
                }else{txt_NS_userName.Text = frmStaffInfor.username;
                    lbl_green11.Visible = true;
                    lbl_red11.Visible = false; //txt_NS_contName.Enabled = false;
                }
            }else{
                MessageBox.Show("You has not entered any staff! Please enter a Staff and try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_NS_email_TextChanged(object sender, EventArgs e)
        {
            if (txt_NS_ufname.Text != "")
            {
                lbl_green7.Visible = true;
                lbl_red7.Visible = false;
            }
            else
            {
                lbl_green7.Visible = false;
                lbl_red7.Visible = true;
            }
        }

        private void txt_NS_certi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_NS_certi_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txt_NS_contD_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_NS_userID.Text != "")
            {
                if (txt_NS_contD.Text == "")
                {
                    txt_NS_contName.Text = "";
                    frmAddContract ac = new frmAddContract();
                    if (exe.checkFormOpen(exe.returnFormName(ac + "")) == false)
                    {
                        frmAddContract.maNV = txt_NS_userID.Text;
                        ac.txt_AC_staffID.Text = txt_NS_userID.Text;
                        frmAddContract.maDN = frmStaffInfor.maDN;
                        ac.Show(); exe.changeFormValue(exe.returnFormName(ac + "")); }
                    else{ ac.Focus(); this.SendToBack(); }


                }
                else 
                { 
                    txt_NS_contD.Text = frmAddContract.maHD; 
                    txt_NS_contName.Text = frmAddContract.tenHD;
                    lbl_green8.Visible = true;
                    lbl_green9.Visible = true;
                    lbl_red8.Visible = false;
                    lbl_red9.Visible = false;
                    txt_NS_contName.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show("You has not entered any staff! Please enter a Staff and try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_NS_contD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
