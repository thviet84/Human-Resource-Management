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
    public partial class frmCertificate : Form
    {
        public frmCertificate()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public void loadCerList()
        {
            string query = "select maHD, tenChungChi from chungChi;";

            DataTable dt = conn.getTable(query);
            grv_cerList.DataSource = dt;
        }
        private void frmCertificate_Load(object sender, EventArgs e)
        {
            loadCerList();
        }

        private void btn_C_push_Click(object sender, EventArgs e)
        {

        }

        private void btn_C_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grv_cerList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grv_cerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = grv_cerList;
            //int totalRows = dgv.Rows.Count;
            // get index of the row for the selected cell
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            string tenCChi = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            frmStaffInfor.maCCh = tenCChi;
        }
    }
}
