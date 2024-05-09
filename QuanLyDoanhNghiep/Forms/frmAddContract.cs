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
    public partial class frmAddContract : Form
    {
        public frmAddContract()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public static string maNV = string.Empty, 
                            maHD = string.Empty, 
                            tenHD = string.Empty, 
                            maDN = string.Empty;
        public void loadConList()
        {
            string query = "SELECT hopDong.maHD,hopDong.tenHD, chiTietHopDong.ngayBatDau, " +
                           "chiTietHopDong.ngayKetThuc, chiTietHopDong.thoiHan, chiTietHopDong.moTa " +
                           "from hopDong FULL JOIN chiTietHopDong ON hopDong.maHD = chitietHopDong.maHD; ";
            DataTable dt = conn.getTable(query);
            grv_AC_contList.DataSource = dt;
        }
        public void loadContID()
        {
            string[] cutMANV = frmAddContract.maNV.Split('-');
            frmAddContract.maHD = "Contract_" + cutMANV[2] + "_" + cutMANV[3];
            txt_AC_contID.Text = frmAddContract.maHD;
        }
        
        
        private void frmAddContract_Load(object sender, EventArgs e)
        {
            loadConList();
            loadContID();
        }

        

        private void txt_AC_contName_KeyPress(object sender, KeyPressEventArgs e)
        {
            String contName = txt_AC_contName.Text;
            if (contName.Length >= 255)
            {
                MessageBox.Show("Your String you entered is longer than 255!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_AC_add_Click(object sender, EventArgs e)
        {

            string maHD = txt_AC_contID.Text;
            string tenHD = txt_AC_contName.Text;
            frmAddContract.tenHD = tenHD;
            frmStaffInfor.maNV = frmAddContract.maNV;
            string staffID = frmAddContract.maNV;
            string startDay = datePicker_AC_startDay.Value.ToString();

            string endDay = datePicker_AC_endDay.Value.ToString();
            string val = txt_AC_ValPeri.Text;
            string descr = richtxt_AC_descr.Text;
            string insertHD = "INSERT INTO hopDong VALUES ('"+maHD+"',N'"+tenHD+"','"+staffID+"');";
            string insertCTHD = "INSERT INTO chiTietHopDong VALUES ('"+maHD+"'," +
                                                                    "'"+exe.hashDateTime(startDay)+"'," +
                                                                    "'"+exe.hashDateTime(endDay)+"'," +
                                                                    "'"+val+"'," +
                                                                    "'"+descr+"');";
            
            try{
                conn.getConnection();
                SqlCommand cmd = new SqlCommand(insertHD, conn.con);
                SqlCommand cmd2 = new SqlCommand(insertCTHD, conn.con);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();}
            catch (Exception ex){
                MessageBox.Show("Some error existed! please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally{conn.closeConnection();}
        }

        private void grv_AC_contList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = grv_AC_contList;
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            frmStaffInfor si = new frmStaffInfor();
            si.control();
            string maHD = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            string tenHD = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("You sure you want to select this Contract? " +
                            "\nContract: " + maHD +
                            " " + tenHD, "Confirm Your Choice",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                frmStaffInfor.maHD = maHD;
                frmStaffInfor.tenHD = tenHD;
                Forms.frmStaffInfor show = new frmStaffInfor() ;
                show.control();
                show.Show();
            }
            
        }

        private void frmAddContract_FormClosed(object sender, FormClosedEventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));

            this.Close();
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
