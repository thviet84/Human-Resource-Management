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
    public partial class frmDivision : Form
    {
        public frmDivision()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public void loadStaffList()
        {
            string queryNV = "SELECT maNV,tenNV FROM nhanVien";
            DataTable dt1 = conn.getTable(queryNV);
            int totalRows = dt1.Rows.Count;
            int totalCells = dt1.Columns.Count;
            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalCells; j++)
                {
                    if (j == 0)
                    {
                        cb_D_staffID.Items.Add(dt1.Rows[i][j].ToString() + "_" + dt1.Rows[i][j + 1].ToString());
                    }
                    else { continue; }
                }
            }
        }
        public void loadProjectList()
        {
            string queryP = "select maDA, tenDA from duAn;";
            DataTable dt1 = conn.getTable(queryP);
            int totalRows = dt1.Rows.Count;
            int totalCells = dt1.Columns.Count;
            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalCells; j++)
                {
                    if (j == 0)
                    {
                        cb_D_projID.Items.Add(dt1.Rows[i][j].ToString() + "_" + dt1.Rows[i][j + 1].ToString());
                    }
                    else { continue; }
                }
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_P_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDivision_Load(object sender, EventArgs e)
        {
            loadStaffList();
            loadProjectList();

            string queryP = "select duAn.maDA,duAn.tenDA, chiTietDuAn.ngayBatDau," +
                            "chiTietDuAn.ngayKetThuc,chiTietDuAn.soLuongNguoi,chiTietDuAn.tienDo " +
                            "from duAn full join chiTietDuAn " +
                            "on chiTietDuAn.maDA = duAn.maDA; ";
            
            DataTable dt2 = conn.getTable(queryP);
            grv_P_list.DataSource = dt2;

        }

        private void txt_P_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_staffName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cb_D_staffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] mavatenNV = cb_D_staffID.Text.Split('_');
            string maNV = mavatenNV[0];
            string tenNV = mavatenNV[1];
            string queryD = "SELECT nhanVien.tenNV, duAn.tenDA from duAn " +
                            "inner join phanCong on phanCong.maDA=duAn.maDA " +
                            "inner join nhanVien on phanCong.maNV=nhanVien.maNV " +
                            "where phanCong.maNV = '" + maNV + "';";
            try
            {
                DataTable dt = conn.getTable(queryD);
                grv_D_list.DataSource = dt;
                //MessageBox.Show(dt.Rows.Count.ToString());
                lbl_noti.Text = "Total all Project that " + tenNV + " have in"
                    + "\nAre: " + dt.Rows.Count.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void cb_D_projID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] mavatenDA = cb_D_projID.Text.Split('_');
            string maDA = mavatenDA[0];
            string tenDA = mavatenDA[1];
            string queryD = "SELECT duAn.tenDA, nhanVien.tenNV from duAn " +
                            "inner join phanCong on phanCong.maDA=duAn.maDA " +
                            "inner join nhanVien on phanCong.maNV=nhanVien.maNV " +
                            "where phanCong.maDA = '"+maDA+"';";
            try
            {
                DataTable dt = conn.getTable(queryD);
                grv_D_list.DataSource = dt;
                //MessageBox.Show(dt.Rows.Count.ToString());
                lbl_noti.Text = "Total all member in Project: " + tenDA
                    + "\nAre: " + dt.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_D_add_Click(object sender, EventArgs e)
        {
            string[] mavatenNV = cb_D_staffID.Text.Split('_');
            string maNV = mavatenNV[0];
            string[] mavatenDA = cb_D_projID.Text.Split('_');
            string maDA = mavatenDA[0];

            string query = "INSERT INTO phanCong VALUES ('" + maNV + "','" + maDA + "');";
            try
            {
                conn.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn.con);
                cmd.ExecuteNonQuery();
                loadProjectList();
            }catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.closeConnection();
            }
            
        }
    }
}
