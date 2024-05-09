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
    public partial class frmReportProject : Form
    {
        public frmReportProject()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public void updateFunc() 
        {
            string maDA = txt_RP_id.Text;

            string memNum = numberic_RP_memNum.Value.ToString();
            string startDay = exe.hashDateTime(datePicker_RP_start.Value.ToString());
            string endDay = exe.hashDateTime(datePicker_RP_end.Value.ToString());
            string result = txt_RP_result.Text;
            string prog = txt_RP_prog.Text;
            string query = "update chiTietDuAn set " +
                                "soLuongNguoi =" + memNum + " ," +
                                "ngayBatDau = '" + startDay + "'," +
                                "ngayKetThuc = '" + endDay + "'," +
                                "ketQua = '" + result + "', " +
                                "tienDo = '" + prog + "' " +
                                "where maDA = '" + maDA + "';";
            conn.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Project Information Updated!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void addNewFunc()
        {
            string maDA = txt_RP_id.Text;

            string memNum = numberic_RP_memNum.Value.ToString();
            string startDay = exe.hashDateTime(datePicker_RP_start.Value.ToString());
            string endDay = exe.hashDateTime(datePicker_RP_end.Value.ToString());
            string result = txt_RP_result.Text;
            string prog = txt_RP_prog.Text;
            string query = "insert into chiTietDuAn values('" + maDA + "'," +
                                                            "'" + memNum + "'," +
                                                            "'" + startDay + "'," +
                                                            "'" + endDay + "'," +
                                                            "'" + result + "'," +
                                                            "'" + prog + "');";
            conn.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Project Information Updated!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_RP_back_Click(object sender, EventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
            this.Close();
        }

        private void btn_RP_edit_Click(object sender, EventArgs e)
        {
            numberic_RP_memNum.Enabled = true;
            datePicker_RP_start.Enabled = true;
            datePicker_RP_end.Enabled = true;
            txt_RP_prog.Enabled = true;
            txt_RP_result.Enabled = true;
            btn_RP_back.Enabled = false;
            btn_RP_edit.Enabled = false;
            btn_RP_cancel.Visible = true;
            btn_RP_clear.Visible = true;
            btn_RP_update.Visible = true;

        }

        private void btn_RP_update_Click(object sender, EventArgs e)
        {
            string result = txt_RP_result.Text;
            try
            {
                if (result != "")
                {
                    addNewFunc();
                }
                
                
            }catch (Exception ex)
            {
                updateFunc();
                //MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.closeConnection();
                numberic_RP_memNum.Enabled = false;
                datePicker_RP_start.Enabled = false;
                datePicker_RP_end.Enabled = false;
                txt_RP_prog.Enabled = false;
                txt_RP_result.Enabled = false;
                btn_RP_back.Enabled = true;
                btn_RP_edit.Enabled = true;
                btn_RP_cancel.Visible = false;
                btn_RP_clear.Visible = false;
                btn_RP_update.Visible = false;
            }
            
        }

        private void btn_RP_cancel_Click(object sender, EventArgs e)
        {
            numberic_RP_memNum.Enabled = false;
            datePicker_RP_start.Enabled = false;
            datePicker_RP_end.Enabled = false;
            txt_RP_prog.Enabled = false;
            txt_RP_result.Enabled = false;
            btn_RP_back.Enabled = true;
            btn_RP_edit.Enabled = true;
            btn_RP_cancel.Visible = false;
            btn_RP_clear.Visible = false;
            btn_RP_update.Visible = false;
        }
    
    }
}
