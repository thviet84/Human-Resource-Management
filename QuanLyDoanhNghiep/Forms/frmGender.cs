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
    public partial class frmGender : Form
    {
        public frmGender()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public void loadDGV_gen()
        {
            DataGridView dgv = grv_G_genList;
            string query = "Select *from gioiTinh ;";
            conn.getConnection();
            SqlDataAdapter adt = new SqlDataAdapter(query, conn.con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dgv.DataSource = dt;
        }
        

        private void frmGender_Load(object sender, EventArgs e)
        {
            loadDGV_gen();
        }

        private void btn_G_add_Click(object sender, EventArgs e)
        {
            string name = txt_G_genName.Text;
            string query = "insert into gioiTinh values(N'" + name + "');";
            conn.getConnection();
            SqlCommand cmd = new SqlCommand(query);
            cmd.ExecuteNonQuery();
            conn.closeConnection();
            MessageBox.Show("New Gender Added!");
            loadDGV_gen();
        }

        private void btn_G_back_Click(object sender, EventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
            this.Close();
        }

        private void frmGender_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
