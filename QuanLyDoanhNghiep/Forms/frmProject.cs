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
    public partial class frmProject : Form
    {
        public frmProject()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public void loadProjectList()
        {
            string query = "SELECT *FROM duAn;";
            conn.getConnection();
            SqlDataAdapter adt = new SqlDataAdapter(query, conn.con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            grv_P_list.DataSource = dt;
            conn.closeConnection();
        }
        private void btn_P_back_Click(object sender, EventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
            this.Close();
            
        }

        private void grv_P_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maDA = txt_P_id.Text;
            string tenDA = txt_P_name.Text;
            if (!maDA.Equals("") || !tenDA.Equals(""))
            {

                frmProjectDetail pd = new frmProjectDetail(); 
                if (exe.checkFormOpen(exe.returnFormName(pd + "")) == false)
                {
                    pd.txt_PD_id.Text = maDA;
                    pd.txt_PD_name.Text = tenDA;
                    pd.Show(); exe.changeFormValue(exe.returnFormName(pd + "")); }
                else { pd.Focus(); this.SendToBack(); }
            }
            else
            {
                MessageBox.Show("Please choose a Project to add Project Detail", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string proID = txt_P_id.Text;
            string proName = txt_P_name.Text;
            conn.getConnection();
            string query = "INSERT INTO duAn VALUES ('"+proID+"',N'"+proName+"');";
            SqlCommand cmd = new SqlCommand(query,conn.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Project Inserted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.closeConnection();
            txt_P_id.Text = "";
            txt_P_name.Text = "";
            loadProjectList();

        }

        private void frmProject_Load(object sender, EventArgs e)
        {
            loadProjectList();
            grv_P_list.ForeColor = Color.Black;
        }

        private void grv_P_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = grv_P_list;
            //int totalRows = dgv.Rows.Count;
            // get index of the row for the selected cell
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;

            string maDA = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            string tenDA = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            txt_P_id.Text = maDA;
            txt_P_name.Text = tenDA;
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            txt_P_id.Text = "";
            txt_P_name.Text = "";
        }
    }
}
