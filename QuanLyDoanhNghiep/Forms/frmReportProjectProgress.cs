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
    public partial class frmReportProjectProgress : Form
    {
        public frmReportProjectProgress()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public void loadAllList()
        {
            string query = "SELECT duAn.maDA, duAn.tenDA, " +
                            "chiTietDuAn.soLuongNguoi, chiTietDuAn.ngayBatDau, " +
                            "chiTietDuAn.ngayKetThuc, chiTietDuAn.ketQua, " +
                            "chiTietDuAn.tienDo FROM duAn JOIN chiTietDuAn ON " +
                            "duAn.maDA = chiTietDuAn.maDA ; ";
            DataTable dt = conn.getTable(query);
            grv_rpp_allProject.DataSource = dt;
        }
        public void loadIncompleteList()
        {
            string query = "SELECT duAn.maDA, duAn.tenDA, " +
                            "chiTietDuAn.soLuongNguoi, chiTietDuAn.ngayBatDau, " +
                            "chiTietDuAn.ngayKetThuc, chiTietDuAn.ketQua, " +
                            "chiTietDuAn.tienDo FROM duAn JOIN chiTietDuAn ON " +
                            "duAn.maDA = chiTietDuAn.maDA " +
                            "where chiTietDuAn.ketQua = 'Incomplete' ; ";
            DataTable dt = conn.getTable(query);
            //grv_RPP_incomplete.DataSource = dt;
        }
        public void loadAllStaff(string maDA)
        {
            string query = "select nhanVien.maNV, nhanVien.tenNV from nhanVien " +
                            "inner join phanCong on phanCong.maNV=nhanVien.maNV " +
                            "where phanCong.maDA = '" + maDA + "';";
            DataTable dt = conn.getTable(query);
            grv_RPP_allStaff.DataSource = dt;
        }
        public void hideLblAndTxt()
        {
            grv_RPP_allStaff.Visible = false;
            ///txt
            txt_rpp_maDA.Visible = false;
            txt_rpp_tenDA.Visible = false;
            txt_rpp_soLuongNguoi.Visible = false;
            txt_rpp_ngayBatDau.Visible = false;
            txt_rpp_ngayKetThuc.Visible = false;
            txt_rpp_ketQua.Visible = false;
            txt_rpp_tienDo.Visible = false;
            /// lbl
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }
        public void showLblAndTxt()
        {
            ///txt
            txt_rpp_maDA.Visible = true;
            txt_rpp_tenDA.Visible = true;
            txt_rpp_soLuongNguoi.Visible = true;
            txt_rpp_ngayBatDau.Visible = true;
            txt_rpp_ngayKetThuc.Visible = true;
            txt_rpp_ketQua.Visible = true;
            txt_rpp_tienDo.Visible = true;
            /// lbl
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
        }
        private void frmReportProjectProgress_Load(object sender, EventArgs e)
        {
            loadAllList();
            //loadIncompleteList();
        }

        private void btn_RPP_completed_Click(object sender, EventArgs e)
        {
            //grv_RPP_incomplete.Visible = false;
            //grv_RPP_completedList.Visible = true;
            grv_RPP_allStaff.Visible = false;
            //btn_RPP_completed.BackColor = Color.Cyan;
            //btn_RRP_incomplete.BackColor = Color.SeaShell;
            hideLblAndTxt();
        }

        private void btn_RRP_incomplete_Click(object sender, EventArgs e)
        {
            //grv_RPP_incomplete.Visible = true;
            //grv_RPP_completedList.Visible = false;
            grv_RPP_allStaff.Visible = false;
            //btn_RPP_completed.BackColor = Color.SeaShell;
           // btn_RRP_incomplete.BackColor = Color.Cyan;
            hideLblAndTxt();
        }

        private void grv_RPP_completedList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*DataGridView dgv = grv_RPP_completedList;
            int totalRows = dgv.Rows.Count;
            // get index of the row for the selected cell
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;

            string maDA = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            string tenDA = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            string soLuongNguoi = dgv.Rows[rowIndex].Cells[2].Value.ToString();
            string ngayBatDau = dgv.Rows[rowIndex].Cells[3].Value.ToString();
            string ngayKetThuc = dgv.Rows[rowIndex].Cells[4].Value.ToString();
            string ketQua = dgv.Rows[rowIndex].Cells[5].Value.ToString();
            string tienDo = dgv.Rows[rowIndex].Cells[6].Value.ToString();
            loadAllStaff(maDA);
            grv_RPP_allStaff.Visible = true;
            txt_rpp_maDA.Text = maDA;
            txt_rpp_tenDA.Text = tenDA;
            txt_rpp_soLuongNguoi.Text = soLuongNguoi;
            txt_rpp_ngayBatDau.Text = ngayBatDau;
            txt_rpp_ngayKetThuc.Text = ngayKetThuc;
            txt_rpp_ketQua.Text = ketQua;
            txt_rpp_tienDo.Text = tienDo;

            grv_RPP_allStaff.Visible = true;
            showLblAndTxt();*/
        }

        private void grv_RPP_incomplete_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*DataGridView dgv = grv_RPP_incomplete;
            int totalRows = dgv.Rows.Count;
            // get index of the row for the selected cell
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;

            string maDA = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            string tenDA = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            string soLuongNguoi = dgv.Rows[rowIndex].Cells[2].Value.ToString();
            string ngayBatDau = dgv.Rows[rowIndex].Cells[3].Value.ToString();
            string ngayKetThuc = dgv.Rows[rowIndex].Cells[4].Value.ToString();
            string ketQua = dgv.Rows[rowIndex].Cells[5].Value.ToString();
            string tienDo = dgv.Rows[rowIndex].Cells[6].Value.ToString();
            loadAllStaff(maDA);
            grv_RPP_allStaff.Visible = true;
            txt_rpp_maDA.Text = maDA;
            txt_rpp_tenDA.Text = tenDA;
            txt_rpp_soLuongNguoi.Text = soLuongNguoi;
            txt_rpp_ngayBatDau.Text = ngayBatDau;
            txt_rpp_ngayKetThuc.Text = ngayKetThuc;
            txt_rpp_ketQua.Text = ketQua;
            txt_rpp_tienDo.Text = tienDo;*/

            showLblAndTxt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataGridView dgv = grv_RPP_incomplete;
            /* string fromDate = dateTime_rpp_from.Value.ToString();
             string toDate = dateTime_rpp_to.Value.ToString();
             DateTime fromD = DateTime.Parse(exe.hashDateTime(fromDate));
             DateTime toD = DateTime.Parse(exe.hashDateTime(toDate));
             int result = DateTime.Compare(fromD, toD);
             if (result < 0)        MessageBox.Show("sớm hơn\n đúng");
             else if (result == 0)  MessageBox.Show("cùng ngày \n sai");
             else                   MessageBox.Show("trễ hơn\n sai luon");*/
            //grv_RPP_allStaff.Refresh();
            string fromDay = exe.hashDateTime(dateTime_rpp_from.Value.ToString());
            string toDay = exe.hashDateTime(dateTime_rpp_to.Value.ToString());
            int rs;
            string maDA = "",sD = "", eD = "";
            string selectNgay = "select * from chiTietDuAn;";
            DataTable dt = conn.getTable(selectNgay);
            int totalRows = dt.Rows.Count;

            DataTable dtRS = null; //// generate new datatable
            dtRS = new DataTable();//// add datatable collumns
            dtRS.Columns.Add("Project ID");
            dtRS.Columns.Add("Project Name");
            dtRS.Columns.Add("Number of Members");
            dtRS.Columns.Add("Start Day");
            dtRS.Columns.Add("End Day");
            dtRS.Columns.Add("Result");
            dtRS.Columns.Add("Progress");
            for (int i = 0; i < totalRows; i++)
            {
                maDA = dt.Rows[i][0].ToString();                                            ///comparation
                sD = dt.Rows[i][3].ToString();
                eD = dt.Rows[i][4].ToString();
                //MessageBox.Show(fromDay + "---" + toDay + "\n" + sD + "---" + eD);
                rs = DateTime.Compare(DateTime.Parse(fromDay), DateTime.Parse(sD));
                //MessageBox.Show(DateTime.Parse(fromDay) +  "\n" + DateTime.Parse(sD));
                string getDA = "select duAn.maDA, duAn.tenDA, " +                           /// find duAn which true condition
                                "chiTietDuAn.soLuongNguoi, chiTietDuAn.ngayBatDau, " +
                                "chiTietDuAn.ngayKetThuc, chiTietDuAn.ketQua, " +
                                "chiTietDuAn.tienDo FROM duAn JOIN chiTietDuAn ON " +
                                "duAn.maDA = chiTietDuAn.maDA " +
                                "where chiTietDuAn.maDA = '" + maDA + "' ;";
                DataTable DTgetDA = conn.getTable(getDA);
                if (rs<=0)
                {
                    //dtRS.Clear();                                                         /// add duAn which true condition to dataTable null
                    DataRow _ravi = dtRS.NewRow();
                    _ravi["Project ID"] = DTgetDA.Rows[0][0].ToString();
                    _ravi["Project Name"] = DTgetDA.Rows[0][1].ToString();
                    _ravi["Number of Members"] = DTgetDA.Rows[0][2].ToString();
                    _ravi["Start Day"] = DTgetDA.Rows[0][3].ToString();
                    _ravi["End Day"] = DTgetDA.Rows[0][4].ToString();
                    _ravi["Result"] = DTgetDA.Rows[0][5].ToString();
                    _ravi["Progress"] = DTgetDA.Rows[0][6].ToString();
                    dtRS.Rows.Add(_ravi);
                }
            }
            dataGridView1.DataSource = dtRS;                                                ///show dataTable
            dataGridView1.Visible = true;
            grv_rpp_allProject.Visible = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = dataGridView1;
            int totalRows = dgv.Rows.Count;
            // get index of the row for the selected cell
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;

            string maDA = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            string tenDA = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            string soLuongNguoi = dgv.Rows[rowIndex].Cells[2].Value.ToString();
            string ngayBatDau = dgv.Rows[rowIndex].Cells[3].Value.ToString();
            string ngayKetThuc = dgv.Rows[rowIndex].Cells[4].Value.ToString();
            string ketQua = dgv.Rows[rowIndex].Cells[5].Value.ToString();
            string tienDo = dgv.Rows[rowIndex].Cells[6].Value.ToString();
            loadAllStaff(maDA);
            grv_RPP_allStaff.Visible = true;
            txt_rpp_maDA.Text = maDA;
            txt_rpp_tenDA.Text = tenDA;
            txt_rpp_soLuongNguoi.Text = soLuongNguoi;
            txt_rpp_ngayBatDau.Text = ngayBatDau;
            txt_rpp_ngayKetThuc.Text = ngayKetThuc;
            txt_rpp_ketQua.Text = ketQua;
            txt_rpp_tienDo.Text = tienDo;

            grv_RPP_allStaff.Visible = true;
            showLblAndTxt();
        }

        private void grv_rpp_allProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
