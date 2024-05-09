using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep.Forms
{
    public partial class frmContractDetail : Form
    {
        public frmContractDetail()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public static DateTime ToDateTime(string value) {
            DateTime convertedDate;
            convertedDate = Convert.ToDateTime(value);
            return convertedDate;
        }
        public void loadContInfor()
        {
            string uid = txt_CD_staffID.Text;
            string query = "SELECT hopDong.maHD,hopDong.tenHD, chiTietHopDong.ngayBatDau, chiTietHopDong.ngayKetThuc, chiTietHopDong.thoiHan, chiTietHopDong.moTa from hopDong JOIN chiTietHopDong ON hopDong.maHD=chitietHopDong.maHD WHERE hopDong.maNV = '" + uid + "';";
            try
            {
                DataTable dt = conn.getTable(query);
                txt_CD_staffID.Text = uid;
                txt_CD_contID.Text ="HD_"+ dt.Rows[0][0].ToString();
                txt_CD_contName.Text = dt.Rows[0][1].ToString();
                txt_CD_ValPeri.Text = dt.Rows[0][4].ToString();
                txt_CD_describe.Text = dt.Rows[0][5].ToString();
                //MessageBox.Show(dt.Rows[0][2].ToString() + "");
                datePicker_CD_startDay.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                datePicker_CD_endDay.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
            }
            catch { MessageBox.Show("Error!\n Not Enough data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_CD_add_Click(object sender, EventArgs e)
        {
            //cb_CD_pos.Enabled = true;
            //cb_CD_type.Enabled = true;
            //cb_CD_resType.Enabled = true;
            datePicker_CD_endDay.Enabled = true;
            datePicker_CD_startDay.Enabled = true;
            txt_CD_contID.Text = "HD_" + txt_CD_staffID.Text;
            txt_CD_contName.Enabled = true;
            txt_CD_ValPeri.Enabled = true;
            txt_CD_describe.Enabled = true;

            btn_CD_cancel.Visible = true;
            btn_CD_clear.Visible = true;
            btn_CD_update.Visible = true;

            btn_CD_edit.Enabled = false;
            btn_CD_back.Enabled = false;

        }

        private void btn_CD_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CD_cancel_Click(object sender, EventArgs e)
        {
     
            datePicker_CD_endDay.Enabled = false;
            datePicker_CD_startDay.Enabled = false;
            txt_CD_ValPeri.Enabled = false;
            txt_CD_contName.Enabled = false;
            txt_CD_describe.Enabled = false;
            btn_CD_cancel.Visible = false;
            btn_CD_clear.Visible = false;
            btn_CD_update.Visible = false;
            btn_CD_back.Enabled = true;
            btn_CD_edit.Enabled = true;
        }

        private void frmContractDetail_Load(object sender, EventArgs e)
        {
            loadContInfor();
        }

        private void btn_CD_clear_Click(object sender, EventArgs e)
        {
            txt_CD_staffID.Text = null;
            txt_CD_ValPeri.Text = null;
            txt_CD_contID.Text = null;
            txt_CD_contName.Text = null;

            datePicker_CD_startDay.Value = DateTime.Today;
            datePicker_CD_endDay.Value = DateTime.Today;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_CD_update_Click(object sender, EventArgs e)
        {
            string maHD = txt_CD_contID.Text;
            string maNV = txt_CD_staffID.Text;
            string tenHD = txt_CD_contName.Text;
            string startDay = datePicker_CD_startDay.Value.ToString();
            string endDay = datePicker_CD_endDay.Value.ToString();
            string sD = exe.hashDateTime(startDay);
            string eD = exe.hashDateTime(endDay);
            string val = txt_CD_ValPeri.Text;
            //MessageBox.Show(/*maHD + maNV + tenHD +*/ sD +" | "+ eD);
            
            string query_HD = "insert into hopDong values('"+maHD+"','"+tenHD+"','"+maNV+"'); ";
            string query_CTHD = "insert into chiTietHopDong values('"+maHD+"','"+sD+"','"+eD+"','"+val+"'); ";
            try
            {

                conn.getConnection();
                SqlCommand cmd1 = new SqlCommand(query_HD);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(query_CTHD);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Data Inserted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.closeConnection();
            }
        }
    }
}
