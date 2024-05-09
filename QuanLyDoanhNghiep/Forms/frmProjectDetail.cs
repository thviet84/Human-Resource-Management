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
    public partial class frmProjectDetail : Form
    {
        public frmProjectDetail()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public void loadProjectDetailList()
        {
            conn.getConnection();
            string query = "SELECT duAn.maDA, duAn.tenDA, chiTietDuAn.soLuongNguoi, chiTietDuAn.ngayBatDau, chiTietDuAn.ngayKetThuc, chiTietDuAn.ketQua, chiTietDuAn.tienDo FROM duAn JOIN chiTietDuAn ON duAn.maDA = chiTietDuAn.maDA ; ";
            SqlDataAdapter adt = new SqlDataAdapter(query,conn.con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            grv_projDetail_list.DataSource = dt;
            conn.closeConnection();
        }
        private void btn_P_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string query = "SELECT duAn.maDA, duAn.tenDA, chiTietDuAn.soLuongNguoi, chiTietDuAn.ngayBatDau, chiTietDuAn.ngayKetThuc, chiTietDuAn.ketQua, chiTietDuAn.tienDo FROM duAn JOIN chiTietDuAn ON duAn.maDA = chiTietDuAn.maDA ;";
            DataTable dt = conn.getTable(query);
            DataGridView dgv = grv_projDetail_list;
            // get index of the row for the selected cell
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            string memNum = dgv.Rows[rowIndex].Cells[2].Value.ToString();


            txt_PD_id.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            txt_PD_name.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            numberic_PD_memNum.Value = int.Parse(memNum);

            datePicker_PD_start.Value = Convert.ToDateTime(dt.Rows[rowIndex][3].ToString());
            datePicker_PD_end.Value = Convert.ToDateTime(dt.Rows[rowIndex][4].ToString());

            txt_PD_result.Text = dgv.Rows[rowIndex].Cells[5].Value.ToString();
            txt_PD_prog.Text = dgv.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void grv_projDetail_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProjectDetail_Load(object sender, EventArgs e)
        {
            loadProjectDetailList();
            string query = "SELECT duAn.maDA, duAn.tenDA, chiTietDuAn.soLuongNguoi, chiTietDuAn.ngayBatDau, chiTietDuAn.ngayKetThuc, chiTietDuAn.ketQua, chiTietDuAn.tienDo FROM duAn JOIN chiTietDuAn ON duAn.maDA = chiTietDuAn.maDA ;";
            DataTable dt = conn.getTable(query);
            DataGridView dgv = grv_projDetail_list;
            // get index of the row for the selected cell
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            string memNum = dgv.Rows[rowIndex].Cells[2].Value.ToString();


            txt_PD_id.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            txt_PD_name.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            numberic_PD_memNum.Value = int.Parse(memNum);

            datePicker_PD_start.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
            datePicker_PD_end.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());

            txt_PD_result.Text = dgv.Rows[rowIndex].Cells[5].Value.ToString();
            txt_PD_prog.Text = dgv.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btn_projDetail_clear_Click(object sender, EventArgs e)
        {
            txt_PD_prog.Text = "";
            txt_PD_result.Text = "";
            numberic_PD_memNum.Value = 0;
            datePicker_PD_end.Value = DateTime.Now;
            datePicker_PD_start.Value = DateTime.Now;
        }

        private void btn_D_add_Click(object sender, EventArgs e)
        {
            string maDA = txt_PD_id.Text;
            int memNum = Convert.ToInt32(numberic_PD_memNum.Value);
            string startDay = datePicker_PD_start.Value.ToString();
            string sD = exe.hashDateTime(startDay);
            string endday = datePicker_PD_end.Value.ToString();
            string eD = exe.hashDateTime(endday);
            string result = txt_PD_result.Text;
            //string proj
            //MessageBox.Show("" + maDA + memNum+" | " + sD+" | " + eD);
            string insertQuery = "INSERT INTO chiTietDuAn VALUES ('"+maDA+"',"+memNum+",'"+sD+"','"+eD+"','','');";
        }
    }
}
