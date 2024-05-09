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
    public partial class Nation : Form
    {
        public Nation()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void loadDGV()
        {
            try
            {
                DataGridView dgv = grv_N_natList;
                string query = "Select *from danToc ;";
                conn.getConnection();
                SqlDataAdapter adt = new SqlDataAdapter(query, conn.con);
                DataTable dt = new DataTable();

                adt.Fill(dt);
                dgv.DataSource = dt;

            }catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.closeConnection();
        }
        private void btn_N_add_Click(object sender, EventArgs e)
        {
            //string id = txt_N_natID.Text;
            string name = txt_N_natName.Text;
            string query = "insert into danToc values('" + name + "');";
            conn.getConnection();
            SqlCommand cmd = new SqlCommand(query,conn.con);
            cmd.ExecuteNonQuery();
            conn.closeConnection();
            MessageBox.Show("New Nation Added!");
            loadDGV();
        }

        private void Nation_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void btn_N_back_Click(object sender, EventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
            this.Close();
        }

        private void grv_N_natList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
