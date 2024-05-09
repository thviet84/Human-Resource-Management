using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep.Forms
{
    public partial class frmNewStaff : Form
    {
        public frmNewStaff()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public static string maNV=null, tenNV=null, cccd = null,  DT = null, ngaySinh = null,diaChi=null, sdt = null, email = null, maHD = null, tenHD = null;
        public static bool GT = true;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NS_cccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_NS_clear_Click(object sender, EventArgs e)
        {
            txt_SI_addr.Text = "";
            txt_SI_cccd.Text = "";
            txt_SI_email.Text = "";
            txt_SI_ufname.Text = "";
            txt_SI_userID.Text = "";
            radBtn_SI_female.Checked = false;
            radBtn_SI_male.Checked = false;
            datePicker_SI_bdate.Value = DateTime.Today;
        }

        private void frmNewStaff_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////////
            //////Personal information zone//////////
            
            // get index of the row for the selected cell
            //string tencv = dgv.Rows[rowIndex].Cells[9].Value.ToString();
            

            txt_SI_userID.Text = frmNewStaff.maNV;
            txt_SI_ufname.Text = frmNewStaff.tenNV;
            txt_SI_cccd.Text = frmNewStaff.cccd;
            if (frmNewStaff.GT == true)
            {
                radBtn_SI_male.Checked = true;
                radBtn_SI_female.Checked = false;
            }
            else
            {
                radBtn_SI_male.Checked = false;
                radBtn_SI_female.Checked = true;
            }
            cb_SI_nation.Items.Add(frmNewStaff.DT);
            cb_SI_nation.SelectedItem = frmNewStaff.DT;
            datePicker_SI_bdate.Value = DateTime.Parse(frmNewStaff.ngaySinh);    
            txt_SI_addr.Text = frmNewStaff.diaChi;
            txt_SI_phone.Text = frmNewStaff.sdt;
            txt_SI_email.Text = frmNewStaff.email;
            //////////////////////////////////////////////////////////
            ///Contract zone//////////////////
            txt_SI_contID.Text = frmNewStaff.maHD;
            txt_SI_contName.Text = frmNewStaff.tenHD;
            
        }

        private void btn_SI_back_Click(object sender, EventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
            this.Close();
        }

        private void btn_SI_contDetail_Click(object sender, EventArgs e)
        {
            string uid = txt_SI_userID.Text;
            Forms.frmContractDetail cd = new Forms.frmContractDetail();
            cd.txt_CD_staffID.Text = uid;
            cd.Show();
        }

        private void btb_SI_accessRight_Click(object sender, EventArgs e)
        {
            string uid = txt_SI_userID.Text;
            frmAccessRight ac = new frmAccessRight();
            ac.txt_AR_uID.Text = uid;
            ac.Show();
            //ac.txt_AR_curRight.Enabled = false;
            ac.cb_AR_newRight.Enabled = false;
            
        }

        private void btn_SI_add_Click(object sender, EventArgs e)
        {
            btn_SI_clear.Enabled = true;
            btn_SI_cancel.Enabled = true;
            btn_SI_update.Enabled = true;
            btn_SI_back.Enabled = false;

            txt_SI_addr.Enabled = true;
            txt_SI_cccd.Enabled = true;
            
            txt_SI_contID.Enabled = true;
            txt_SI_contName.Enabled = true;
            txt_SI_email.Enabled = true;
            
            txt_SI_ufname.Enabled = true;
            txt_SI_userID.Enabled = false;

            cb_SI_nation.Enabled = true;
            datePicker_SI_bdate.Enabled = true;
            radBtn_SI_female.Enabled = true;
            radBtn_SI_male.Enabled = true;
            radBtn_SI_male.Checked = true;
        }

        private void btn_SI_cancel_Click(object sender, EventArgs e)
        {
            btn_SI_clear.Enabled = false;
            btn_SI_cancel.Enabled = false;
            btn_SI_update.Enabled = false;
            btn_SI_back.Enabled = true;

            txt_SI_addr.Enabled = false;
            txt_SI_cccd.Enabled = false;
            
            txt_SI_contID.Enabled = false;
            txt_SI_contName.Enabled = false;
            txt_SI_email.Enabled = false;
            
            txt_SI_ufname.Enabled = false;

            cb_SI_nation.Enabled = false;
            datePicker_SI_bdate.Enabled = false;

            radBtn_SI_female.Enabled = false;
            radBtn_SI_male.Enabled = false;
        }

        private void btn_SI_staffResume_Click(object sender, EventArgs e)
        {
            string uid = txt_SI_userID.Text;
            string query = "select nhanVien.tenNV from nhanVien where nhanVien.maNV = '" + uid + "';";
            string un = exe.KiemTraChuoi(query);
            //MessageBox.Show(uid + "| " + un);
            frmResume re = new frmResume();
            re.txt_R_un.Enabled = false;
            re.txt_R_uid.Enabled = false;
            re.txt_R_uid.Text = uid;
            re.txt_R_un.Text = un;
            re.Show();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
