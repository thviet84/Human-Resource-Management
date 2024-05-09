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
    public partial class frmResume : Form
    {
        public frmResume()
        {
            InitializeComponent();
        }
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        public void loadResume(string uid)
        {
            string query = "select *from lyLich where maNV = '" + uid + "';";
            try
            {
                
                txt_R_faName.Text = conn.getTable(query).Rows[0][2].ToString();
                txt_R_faPhone.Text = conn.getTable(query).Rows[0][3].ToString();
                txt_R_faJob.Text = conn.getTable(query).Rows[0][4].ToString();
                txt_R_moName.Text = conn.getTable(query).Rows[0][5].ToString();
                txt_R_moPhone.Text = conn.getTable(query).Rows[0][6].ToString();
                txt_R_moJob.Text = conn.getTable(query).Rows[0][7].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmResume_Load(object sender, EventArgs e)
        {
            loadResume(txt_R_uid.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_R_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_R_edit_Click(object sender, EventArgs e)
        {
            
           // MessageBox.Show(exe.KiemTraChuoi("select *from lyLich where maNV='" + txt_R_uid.Text + "';"+""));
            if (exe.KiemTraChuoi("select *from lyLich where maNV='" + txt_R_uid.Text + "';") == "")
            {
                MessageBox.Show("Your Resume has not Insert into database yet!\n Insert it now ?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                
            }
            else
            {
                loadResume(txt_R_uid.Text);
            }
            btn_R_cancel.Visible = true;
            btn_R_update.Visible = true;
            btn_R_clear.Visible = true;

            txt_R_faName.Enabled = true;
            txt_R_faPhone.Enabled = true;
            txt_R_faJob.Enabled = true;
            txt_R_moName.Enabled = true;
            txt_R_moPhone.Enabled = true;
            txt_R_moJob.Enabled = true;
        }

        private void btn_R_cancel_Click(object sender, EventArgs e)
        {
            btn_R_cancel.Visible = false;
            btn_R_update.Visible = false;
            btn_R_clear.Visible = false;
            txt_R_faName.Enabled = false;
            txt_R_faPhone.Enabled = false;
            txt_R_faJob.Enabled = false;
            txt_R_moName.Enabled = false;
            txt_R_moPhone.Enabled = false;
            txt_R_moJob.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_R_update_Click(object sender, EventArgs e)
        {
            string uid = txt_R_uid.Text;
            string maLL = "LL_" + uid;
            string tenBa = txt_R_faName.Text;
            string sdtBa = txt_R_faPhone.Text;
            string nnBa = txt_R_faJob.Text;
            string tenMe = txt_R_moName.Text;
            string sdtMe = txt_R_moPhone.Text;
            string nnMe = txt_R_moJob.Text;

            string query = "insert into lyLich values('"+uid+"','"+maLL+"'," +
                            "N'"+tenBa+"','"+sdtBa+"',N'"+nnBa+ "'," +
                            "N'"+tenMe+"','"+sdtMe+"',N'"+nnMe+"') ";
            try
            {
                conn.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_R_cancel.Visible = false;
                btn_R_update.Visible = false;
                btn_R_clear.Visible = false;
                txt_R_faName.Enabled = false;
                txt_R_faPhone.Enabled = false;
                txt_R_faJob.Enabled = false;
                txt_R_moName.Enabled = false;
                txt_R_moPhone.Enabled = false;
                txt_R_moJob.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.closeConnection();
            }

        }

        private void btn_R_clear_Click(object sender, EventArgs e)
        {
            
            txt_R_faName.Text = null;
            txt_R_faPhone.Text = null;
            txt_R_faJob.Text = null;
            txt_R_moName.Text = null;
            txt_R_moPhone.Text = null;
            txt_R_moJob.Text = null;
        }
    }
}
