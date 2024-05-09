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
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        
        public void loadDgv_dep()
        {
            string query = "SELECT maPB AS 'Mã phòng ban', tenPB AS 'Tên phòng ban' FROM phongBan;";
            conn.getConnection();
            SqlDataAdapter adt = new SqlDataAdapter(query, conn.con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            grv_D_depList.DataSource = dt;

            // Loại bỏ dòng trống ở đầu DataGridView
            if (grv_D_depList.Rows.Count > 0)
            {
                grv_D_depList.AllowUserToAddRows = false;
            }

            // Đặt tên hiển thị cho các cột
            grv_D_depList.Columns["Mã phòng ban"].HeaderText = "Mã phòng ban";
            grv_D_depList.Columns["Tên phòng ban"].HeaderText = "Tên phòng ban";

            // Tự động điều chỉnh độ rộng các cột
            foreach (DataGridViewColumn column in grv_D_depList.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            exe.changeFormValue(exe.returnFormName(this + ""));
            this.Close();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            loadDgv_dep();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //string corID = "1";
            string depID = txt_dep_depID.Text;
            string depName = txt_dep_depName.Text;
            string query = "INSERT INTO phongBan VALUES ('"+depID+"',N'"+depName+"')";

            try
            {
                conn.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(depName + " Has been added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.closeConnection();
            
            txt_dep_depID.Text = "";
            txt_dep_depName.Text = "";
            loadDgv_dep();
        }

        

        private void grv_D_depList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = grv_D_depList;
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;

            
            string maPB = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            string tenPB = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            
            txt_dep_depID.Text = maPB;
            txt_dep_depName.Text = tenPB;
            txt_dep_depID.Enabled = false;
            txt_dep_depName.Enabled = false;
            //MessageBox.Show(maDN + tenPB + maPB);

        }

        private void grv_D_depList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*string query = "UPDATE phongBan SET maPB = '" + txt_dep_depID.Text + "'," +
                            " tenPB=N'" + txt_dep_depName.Text + "' " +
                            "WHERE maDN = '" + cb_dep_corID.Text + "';";*//*
            string query = "UPDATE phongBan SET tenPB = N'" + txt_dep_depName.Text + "' " +
                            "WHERE maPB = '" + txt_dep_depID.Text + "';";
            conn.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn.con);
            cmd.ExecuteNonQuery();
            conn.closeConnection();
            loadDgv_dep();*/
            string query = "UPDATE phongBan SET tenPB = N'" + txt_dep_depName.Text + "' " +
                    "WHERE maPB = '" + txt_dep_depID.Text + "';";

            conn.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn.con);
            int rowsAffected = cmd.ExecuteNonQuery(); // Lấy số hàng bị ảnh hưởng

            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDgv_dep(); // Cập nhật DataGridView sau khi thay đổi dữ liệu
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conn.closeConnection();

        }

        private void cb_dep_corID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cb_dep_corID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_dep_corID_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void txt_dep_corName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_dep_corID_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_dep_depID.Enabled = true;
            txt_dep_depName.Enabled = true;
            btn_D_update.Visible = true;
            btn_D_cancel.Visible = true;
            btn_dep_add.Enabled = false;
            btn_dep_back.Enabled = false;
            btn_D_edit.Enabled = false; ;

        }

        private void btn_D_cancel_Click(object sender, EventArgs e)
        {
            txt_dep_depID.Enabled = false;
            txt_dep_depName.Enabled = false;
            btn_D_update.Visible = false;
            btn_D_cancel.Visible = false;
            btn_dep_add.Enabled = true;
            btn_dep_back.Enabled = true;
            btn_D_edit.Enabled = true;
        }

        private void btn_D_delete_Click(object sender, EventArgs e)
        {
            
            // Xóa hàng từ database
            string query = "DELETE FROM phongBan WHERE maPB = '" + txt_dep_depID.Text + "';";
            conn.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn.con);
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Hàng đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDgv_dep();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.closeConnection();
        }

        private void btn_dep_add_Click(object sender, EventArgs e)
        {
            string depID = txt_dep_depID.Text;
            string depName = txt_dep_depName.Text;
            string query = "INSERT INTO phongBan VALUES ('" + depID + "',N'" + depName + "')";

            try
            {
                conn.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(depName + " Has been added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.closeConnection();

            txt_dep_depID.Text = "";
            txt_dep_depName.Text = "";
            loadDgv_dep();
        }
    }
}
