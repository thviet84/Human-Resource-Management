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
    public partial class Corporation : Form
    {
        public Corporation()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        public void loadDgv_cor()
        {
            string query = "Select *from doanhNghiep ;";
            conn.getConnection();
            SqlDataAdapter adt = new SqlDataAdapter(query, conn.con);
            DataTable dt = new DataTable();
            conn.getConnection();
            adt.Fill(dt);
            grv_I_incList.DataSource = dt;
        }
        private void btn_I_back_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grv_I_incList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Corporation_Load(object sender, EventArgs e)
        {
            loadDgv_cor();
        }
    }
}
