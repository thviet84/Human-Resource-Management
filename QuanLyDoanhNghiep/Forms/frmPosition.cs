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
    public partial class Position : Form
    {
        public Position()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public static string maDN = string.Empty, maPB = string.Empty;
        public void loadDgv_cor()
        {
            string query = "Select chucVu.maCV, chucVu.tenCV from chucVu  where chucVu.maPB LIKE '"+ Position.maDN+"%' ;";
            conn.getConnection();
            SqlDataAdapter adt = new SqlDataAdapter(query, conn.con);
            DataTable dt = new DataTable();

            adt.Fill(dt);
            grv_P_posList.DataSource = dt;
        }
        public void loadDep()
        {
            string dep = "SELECT *FROM phongBan where maPB LIKE '"+Position.maDN+"%';";
            exe.HienThiCBB(dep, cb_P_depList, "maPB", "tenPB");
        }

        private void btn_P_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Position_Load(object sender, EventArgs e)
        {
            loadDgv_cor();
            loadDep();
            lbl_corName.Text = frmMain.tenDN;
        }

        private void btn_P_add_Click(object sender, EventArgs e)
        {
            string posID = txt_P_posID.Text;
            string posName = txt_P_posName.Text;
            string depName = cb_P_depList.Text;
            string findDep = "select maPB from phongBan where tenPB = N'" + depName + "' and maPB LIKE '"+Position.maDN+"%';";
            string depID = exe.KiemTraChuoi(findDep);
            string insert = "INSERT INTO chucVu VALUES ('"+posID+"','"+posName+"','"+depID+"');";
            //string 
            try
            {
                conn.getConnection();
                SqlCommand cmd = new SqlCommand(insert, conn.con);
                cmd.ExecuteNonQuery();
                loadDgv_cor();
            }catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.closeConnection();
            }
        }

        private void grv_P_posList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = grv_P_posList;
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            string maPB = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            string tenPB = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            txt_P_posID.Text = maPB;
            txt_P_posName.Text = tenPB;
        }

        private void txt_P_posID_MouseClick(object sender, MouseEventArgs e)
        {
            string depName = cb_P_depList.Text;
            string findDep = "select maPB from phongBan where tenPB = N'" + depName + "' and maPB LIKE '" + Position.maDN + "%';";
            string depID = exe.KiemTraChuoi(findDep);
            txt_P_posID.Text = depID + "_";

        }
    }
}
