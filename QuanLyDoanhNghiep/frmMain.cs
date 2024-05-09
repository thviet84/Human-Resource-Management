using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace QuanLyDoanhNghiep
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;
        connectionClass conn = new connectionClass();
        executeStringClass exe = new executeStringClass();
        translateClass trans = new translateClass();
        public static string hoten = string.Empty, 
                            chuoiQuyen = string.Empty, 
                            vitri = string.Empty, 
                            search_Key = string.Empty, 
                            tenDN = string.Empty;
        public static string[] quyen;
        public static string[] formIsOpen = { "frmMain" };
        public static int btn = 0;

        public frmMain()
        {
            InitializeComponent();

        }

        
        public void PhanQuyen_()
        {
            switch (btn)
            {
                case 1: // Create Account + Add Access Right + Add Contract Infor
                    {
                        
                        Forms.frmStaffInfor si = new Forms.frmStaffInfor();
                        //MessageBox.Show("|" + exe.returnFormName(si + ""));
                        //si.btn_NS_createAcc.Enabled = true;
                        //si.btb_NS_accessRight.Enabled = true;
                        if (exe.checkFormOpen(exe.returnFormName(si + "")) == false)
                        {
                            si.btn_NS_add1.Enabled = true;
                            si.txt_NS_cor.Text = lbl_corName.Text;
                            Forms.frmStaffInfor.maDN = exe.cutString(frmMain.tenDN);
                            si.Show(); 
                            exe.changeFormValue(exe.returnFormName(si + "")); 
                        }
                        else {si.Focus();this.SendToBack();}
                        
                        

                    }
                    break;
                case 2: // View all Lists
                    {
                        grv_staffList.Visible = true;

                    }break;
                case 3:
                    {
                        pushInforToStaffInfor();
                        /*Forms.frmNewStaff ns =(Forms.frmNewStaff)this.MdiParent;*/
                        Forms.frmNewStaff ns = new Forms.frmNewStaff();
                        if (exe.checkFormOpen(exe.returnFormName(ns + "")) == false)
                        {
                            ns.btn_SI_contDetail.Enabled = true;
                            ns.btn_SI_staffResume.Enabled = true;
                            ns.btb_SI_accessRight.Enabled = true;
                            ns.btn_SI_edit.Enabled = true;
                            ns.Show(); exe.changeFormValue(exe.returnFormName(ns + "")); }
                        else { ns.Focus(); this.SendToBack(); }
                    }
                    break;
                case 4:
                    {
                        string maDN2 = exe.cutString(frmMain.tenDN);
                        Forms.Position pos = new Forms.Position();
                        if (exe.checkFormOpen(exe.returnFormName(pos + "")) == false)
                        {
                            Forms.Position.maDN = maDN2;
                            pos.Show(); exe.changeFormValue(exe.returnFormName(pos + "")); }
                        else { pos.Focus(); this.SendToBack(); }
                    }
                    break;
                case 5:
                    {
                        Forms.frmGender gen = new Forms.frmGender();
                        if (exe.checkFormOpen(exe.returnFormName(gen + "")) == false)
                        { gen.Show(); exe.changeFormValue(exe.returnFormName(gen + "")); }
                        else { gen.Focus(); this.SendToBack(); }
                    }
                    break;
                case 6:
                    {
                        Forms.Nation nat = new Forms.Nation();
                        if (exe.checkFormOpen(exe.returnFormName(nat + "")) == false)
                        { nat.Show(); exe.changeFormValue(exe.returnFormName(nat + "")); }
                        else { nat.Focus(); this.SendToBack(); }

                    }
                    break;
                case 7:
                    {
                        Forms.frmDivision di = new Forms.frmDivision();
                        if (exe.checkFormOpen(exe.returnFormName(di + "")) == false)
                        { di.Show(); exe.changeFormValue(exe.returnFormName(di + "")); }
                        else { di.Focus(); this.SendToBack(); }
                    }
                    break;
                case 8:
                    {
                        Forms.frmProjectsInfor pi = new Forms.frmProjectsInfor();
                        if (exe.checkFormOpen(exe.returnFormName(pi + "")) == false)
                        {
                            Forms.frmProjectsInfor.tenNV = frmMain.hoten;
                            Forms.frmProjectsInfor.quyen = frmMain.quyen;
                            Forms.frmProjectsInfor.tenDN = frmMain.tenDN;
                            pi.Show(); exe.changeFormValue(exe.returnFormName(pi + "")); }
                        else { pi.Focus(); this.SendToBack(); }
                    }
                    break;
               
            }
        }
        public void showInforToStaffInfor()
        {
            /////////////////////////////////////////
            //////Personal information zone//////////
            DataGridView dgv = grv_staffList;
            //int totalRows = dgv.Rows.Count;
            // get index of the row for the selected cell
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            string tenGT = dgv.Rows[rowIndex].Cells[3].Value.ToString();
            string tenDT = dgv.Rows[rowIndex].Cells[4].Value.ToString();
            string ngaySinh = dgv.Rows[rowIndex].Cells[5].Value.ToString();
            //string tencv = dgv.Rows[rowIndex].Cells[9].Value.ToString();
            Forms.frmNewStaff si = new Forms.frmNewStaff();
            si.txt_SI_userID.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            si.txt_SI_ufname.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            si.txt_SI_cccd.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString();
            if (tenGT == "Nam")
            {
                si.radBtn_SI_male.Checked = true;
                si.radBtn_SI_female.Checked = false;
            }
            else
            {
                si.radBtn_SI_male.Checked = false;
                si.radBtn_SI_female.Checked = true;
            }
            si.cb_SI_nation.Items.Add(tenDT);
            si.cb_SI_nation.SelectedItem = tenDT;
            si.datePicker_SI_bdate.Value = DateTime.Parse(ngaySinh);
            si.txt_SI_addr.Text = dgv.Rows[rowIndex].Cells[6].Value.ToString();
            si.txt_SI_phone.Text = dgv.Rows[rowIndex].Cells[7].Value.ToString();
            si.txt_SI_email.Text = dgv.Rows[rowIndex].Cells[8].Value.ToString();
            //////////////////////////////////////////////////////////
            ///Contract zone//////////////////
            string contQuery = "SELECT hopDong.maHD, hopDong.tenHD FROM hopDong " +
                                "INNER JOIN nhanVien ON hopDong.maNV = nhanVien.maNV" +
                                " WHERE nhanVien.maNV = '" + dgv.Rows[rowIndex].Cells[0].Value.ToString() + "'; ";
            SqlDataAdapter adt = new SqlDataAdapter(contQuery, conn.con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                si.txt_SI_contID.Text = dt.Rows[0]["maHD"].ToString();
                si.txt_SI_contName.Text = dt.Rows[0]["tenHD"].ToString();
            }
        }
        public void pushInforToStaffInfor()
        {
            /////////////////////////////////////////
            //////Personal information zone//////////
            DataGridView dgv = grv_staffList;
            //int totalRows = dgv.Rows.Count;
            // get index of the row for the selected cell
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            string tenGT = dgv.Rows[rowIndex].Cells[3].Value.ToString();
            string tenDT = dgv.Rows[rowIndex].Cells[4].Value.ToString();
            string ngaySinh = dgv.Rows[rowIndex].Cells[5].Value.ToString();
            //string tencv = dgv.Rows[rowIndex].Cells[9].Value.ToString();
            
            Forms.frmNewStaff.maNV = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            Forms.frmNewStaff.tenNV = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            Forms.frmNewStaff.cccd = dgv.Rows[rowIndex].Cells[2].Value.ToString();
            if (tenGT == "Nam"){
                Forms.frmNewStaff.GT = true;
            }else{
                Forms.frmNewStaff.GT = false;
            }
            Forms.frmNewStaff.DT = tenDT;
            Forms.frmNewStaff.ngaySinh = ngaySinh;
            Forms.frmNewStaff.diaChi= dgv.Rows[rowIndex].Cells[6].Value.ToString();
            Forms.frmNewStaff.sdt = dgv.Rows[rowIndex].Cells[7].Value.ToString();
            Forms.frmNewStaff.email = dgv.Rows[rowIndex].Cells[8].Value.ToString();
            //////////////////////////////////////////////////////////
            ///Contract zone//////////////////
            string contQuery = "SELECT hopDong.maHD, hopDong.tenHD FROM hopDong " +
                                "INNER JOIN nhanVien ON hopDong.maNV = nhanVien.maNV" +
                                " WHERE nhanVien.maNV = '" + dgv.Rows[rowIndex].Cells[0].Value.ToString() + "'; ";
            SqlDataAdapter adt = new SqlDataAdapter(contQuery, conn.con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Forms.frmNewStaff.maHD = dt.Rows[0]["maHD"].ToString();
                Forms.frmNewStaff.tenHD = dt.Rows[0]["tenHD"].ToString();
            }
            Forms.frmNewStaff ns = new Forms.frmNewStaff();
            
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        public void showStaffList()
        {
            DataGridView tb = grv_staffList;
            string query = "select nhanVien.maNV, nhanVien.tenNV,nhanVien.cccd," +
                            "nhanVien.tenGT, nhanVien.tenDT,nhanVien.ngaySinh," +
                            "nhanVien.diaChi,nhanVien.sdt,nhanVien.email,chucVu.tenCV " +
                            "from nhanVien inner join chucVu on " +
                            "chucVu.maCV = nhanVien.maCV; ";
            conn.getConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(query, conn.con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            tb.DataSource = dt;
            grv_staffList.ForeColor = Color.Black;
        }
        public static int Contr_ = 0;
        public void contr()
        {
            lbl_staffName.Text = frmMain.hoten;
            lbl_corName.Text = frmMain.tenDN;
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string query = "update isOpenForm set Openned = 0 ;";
            conn.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn.con);
            cmd.ExecuteNonQuery();
            conn.closeConnection();
            System.Windows.Forms.Application.Exit();
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grv_staffList.Visible == false)
            {
                for (int i = 0; i < frmMain.chuoiQuyen.Length; i++)
                {
                    if (quyen[i] == "ViewLists")
                    {
                        btn = 2; PhanQuyen_();
                        showStaffList();
                        staffListToolStripMenuItem.CheckOnClick = true;
                        break;
                    }
                    else if (quyen[i] == "")
                    {
                        MessageBox.Show("You have not enoungh Access Right to View this List");
                        break;
                    };
                }
                grv_staffList.Visible = true;
                btn_Excel.Visible = true;

            }
            else
            {
                grv_staffList.Visible = false;
            }
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(pn_search.Visible == false)
            {
                pn_search.Visible = true;
                lbl_search.Visible = true;
                txt_M_searchKey.Visible = true;
            }else if(pn_search.Visible == true)
            {
                pn_search.Visible = false;
                lbl_search.Visible = false;
                txt_M_searchKey.Visible = false;
            }
            
        }

        private void btn_M_clear_Click(object sender, EventArgs e)
        {
            txt_M_searchKey.Text = "";
        }

        private void btn_M_search_Click(object sender, EventArgs e)
        {
            string query = null;
            string key = txt_M_searchKey.Text;
            frmMain.search_Key = key;
            if (key == "")
            {
                showStaffList();
            }
            else
            {
                grv_staffList.Visible = true;
                staffListToolStripMenuItem.Checked = true;
            }
            if (key != null)
            {
                /////////search by gender
                if(key == "Nam" || key == "Nữ")
                {
                    string findGen = "select *from nhanVien where tenGT = '" + key + "';";
                    query = findGen;
                    lbl_M_searchType.Visible = true;
                    lbl_M_searchType.Text = "Search By Gender";
                }else if(key == "Kinh"||key=="Hoa" || key == "Khomer")
                {
                    string findNat = "select *from nhanVien where tenDT LIKE '"+key+"';";
                    query = findNat;
                    lbl_M_searchType.Visible = true;
                    lbl_M_searchType.Text = "Search By Nation";
                }
                else if (key.StartsWith("0") & key.Length==10 || key.StartsWith("+"))
                {
                    string findPhone = "select *from nhanVien where sdt LIKE'"+key+"%'";
                    query = findPhone;
                    lbl_M_searchType.Visible = true;
                    lbl_M_searchType.Text = "Search By Phone Number";
                }
                else if (key.StartsWith("0") & key.Length > 10)
                {
                    string findCCCD = "select *from nhanVien where cccd LIKE'" + key + "%'";
                    query = findCCCD;
                    lbl_M_searchType.Visible = true;
                    lbl_M_searchType.Text = "Search By Citizen Identification";
                }
                else
                {
                    string findTen = "select *from nhanVien where tenNV LIKE N'%" + key + "%';";
                    query = findTen;
                    lbl_M_searchType.Visible = true;
                    lbl_M_searchType.Text = "Search By Staff Name";
                }

            }
            conn.getConnection();
            SqlDataAdapter adt = new SqlDataAdapter(query, conn.con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            grv_staffList.DataSource = dt;
            grv_staffList.ForeColor = Color.Black;
            conn.closeConnection();
        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void grv_staffList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < frmMain.chuoiQuyen.Length; i++)
            {
                if (quyen[i] == "View Staff Resume" ||
                    quyen[i] == "View Contract Infor" ||
                    quyen[i] == "Alter Right")
                { btn = 3;
                    PhanQuyen_();
                    break; }
                else if (quyen[i] == "")
                {
                    MessageBox.Show("You have not enoungh Access Right to Alter in this Window");
                    
                    break;
                };
            }
            
        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void departmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmDepartment d = new Forms.frmDepartment();
            //MessageBox.Show("|" + exe.returnFormName(d + ""));
            if (exe.checkFormOpen(exe.returnFormName(d + "")) == false)
            { d.Show(); exe.changeFormValue(exe.returnFormName(d + "")); }
            else { d.Focus(); this.SendToBack(); }
        }

        private void positionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < frmMain.chuoiQuyen.Length; i++)
            {
                if (quyen[i] == "View Staff Resume" ||
                    quyen[i] == "View Contract Infor" ||
                    quyen[i] == "Alter Right")
                { btn = 4; PhanQuyen_(); break; }
                else if (quyen[i] == "")
                {
                    MessageBox.Show("You have not enoungh Access Right to Alter in this Window");
                    break;
                };
            }
        }

        private void genderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < frmMain.chuoiQuyen.Length; i++)
            {
                if (quyen[i] == "View Staff Resume" ||
                    quyen[i] == "View Contract Infor" ||
                    quyen[i] == "Alter Right")
                { btn = 5; PhanQuyen_(); break; }
                else if(quyen[i] == "")
                {
                    MessageBox.Show("You have not enoungh Access Right to Alter in this Window");
                    break;
                };
            }
        }

        private void nationListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < frmMain.chuoiQuyen.Length; i++)
            {
                if (quyen[i] == "View Staff Resume" ||
                    quyen[i] == "View Contract Infor" ||
                    quyen[i] == "Alter Right")
                { btn = 6; PhanQuyen_(); break; }
                else if(quyen[i]=="")
                {
                    MessageBox.Show("You have not enoungh Access Right to Alter in this Window");
                    break;
                };
            }
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            executeStringClass exeClass = new executeStringClass();
            //connectionClass conn = new connectionClass();
            label3.Text = frmMain.hoten;
            label1.Text = frmMain.tenDN;
            contr();
            if (exeClass.checkConnection() == false)
            {
                frmConnectDatabase frmconnect = new frmConnectDatabase();
                conn.ShowForm(frmconnect, this);
            }
            else
            {
                Login log = new Login();
                conn.ShowForm(log, this);
            }

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void changeDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnectDatabase connectDatabase = new frmConnectDatabase();
            //MessageBox.Show("|" + exe.returnFormName(connectDatabase + ""));
            connectDatabase.Show();
        }

        private void corporationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Corporation cor = new Forms.Corporation();
            conn.ShowForm(cor, this);
        }

        private void grv_staffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(lbl_staffName  != null)
            {
                frmLogin log = new frmLogin();
                conn.ShowForm(log, this);
                lbl_staffName.Text = "";
                frmMain.hoten = string.Empty;
                frmMain.quyen = null;
                frmMain.vitri = string.Empty;
                frmMain.chuoiQuyen = string.Empty;
            }
            else
            {
                MessageBox.Show("Error! You have not Log In so you can not Log Out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           // this.Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            conn.ShowForm(log, this);
        }

        private void lbl_staffName_Click(object sender, EventArgs e)
        {
            string maNV = textBox1.Text;
            string inforQuery = "select *from nhanVien inner join taiKhoan on taiKhoan.maNV=nhanVien.maNV where taiKhoan.username = '"+maNV+"';";
            string contQuery = "SELECT hopDong.maHD, hopDong.tenHD " +
                                "FROM hopDong INNER JOIN nhanVien ON hopDong.maNV = nhanVien.maNV " +
                                "INNER JOIN taiKhoan ON taiKhoan.maNV=taiKhoan.maNV " +
                                "WHERE taiKhoan.username ='" + maNV + "'; ";
            DataTable dt_infor = conn.getTable(inforQuery);
            Forms.frmNewStaff si = new Forms.frmNewStaff();
            Forms.frmNewStaff.maNV = dt_infor.Rows[0][0].ToString();
            Forms.frmNewStaff.tenNV = dt_infor.Rows[0][1].ToString();
            Forms.frmNewStaff.cccd = dt_infor.Rows[0][2].ToString();
            if (dt_infor.Rows[0][3].ToString() == "Nam"){
                si.radBtn_SI_male.Checked = true;
                si.radBtn_SI_female.Checked = false;
            } else{
                si.radBtn_SI_male.Checked = false;
                si.radBtn_SI_female.Checked = true;
            }
            Forms.frmNewStaff.DT = (dt_infor.Rows[0][4].ToString());
            si.cb_SI_nation.SelectedItem = Forms.frmNewStaff.DT;
            Forms.frmNewStaff.ngaySinh = dt_infor.Rows[0][5].ToString();
            si.datePicker_SI_bdate.Value = DateTime.Parse(Forms.frmNewStaff.ngaySinh);
            Forms.frmNewStaff.diaChi = dt_infor.Rows[0][6].ToString();
            Forms.frmNewStaff.sdt = dt_infor.Rows[0][7].ToString();
            Forms.frmNewStaff.email = dt_infor.Rows[0][8].ToString();
            DataTable dt_cont = conn.getTable(contQuery);
            if (dt_cont.Rows.Count > 0){
                Forms.frmNewStaff.maHD ="HD_"+ dt_cont.Rows[0]["maHD"].ToString();
                Forms.frmNewStaff.tenHD = dt_cont.Rows[0]["tenHD"].ToString();
            }
            for (int i = 0; i < frmMain.chuoiQuyen.Length; i++)
            {
                if (quyen[i] == "View Staff Resume" ||
                    quyen[i] == "View Contract Infor" ||
                    quyen[i] == "Alter Right")
                {
                    
                    si.btn_SI_contDetail.Enabled = true;
                    si.btn_SI_staffResume.Enabled = true;
                    si.btn_SI_edit.Enabled = true;
                    break;
                }
                else if (quyen[i] == "")
                {
                    MessageBox.Show("You have not enoungh Access Right to Alter in this Window");

                    break;
                };
            }
            si.Show();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i < frmMain.chuoiQuyen.Length; i++)
            {
                if (quyen[i] == "Create Account" ||
                    quyen[i] == "Add Access Right" ||
                    quyen[i] == "Add Contract Infor")
                { btn = 1; PhanQuyen_(); break; }
                else if(quyen[i]=="")
                {
                    MessageBox.Show("You have not enoungh Access Right to Alter in this Window\nBut you still can see it","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                };
            }
            
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmProject p = new Forms.frmProject();
            if(exe.checkFormOpen(exe.returnFormName(p + ""))==false) 
            { p.Show(); exe.changeFormValue(exe.returnFormName(p + "")); }
            else 
            {p.Focus(); this.SendToBack();}
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vietnameseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sys = systemToolStripMenuItem.Text;
            string new1  = newToolStripMenuItem1.Text;
            string view = viewMenu.Text;
            string tools = toolsMenu.Text;
            string statictis = statisticsToolStripMenuItem.Text;
            string window = windowsMenu.Text;
            string help = helpMenu.Text;
            MenuStrip menu = menuStrip;
            string curLan = "en";
            string newLan = "vi";
            //MessageBox.Show(trans.translate(sys, curLan, newLan));
            systemToolStripMenuItem.Text = trans.translateText(sys, curLan, newLan);
            newToolStripMenuItem1.Text = trans.translateText(new1, curLan, newLan);
            viewMenu.Text = trans.translateText(view, curLan, newLan);
            toolsMenu.Text = trans.translateText(tools, curLan, newLan);
            statisticsToolStripMenuItem.Text = trans.translateText(statictis, curLan, newLan);
            windowsMenu.Text = trans.translateText(window, curLan, newLan);
            helpMenu.Text = trans.translateText(help, curLan, newLan);
            //menuStrip.Text = trans.translateMenu(menu, curLan, newLan);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewMenu_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < chuoiQuyen.Length; i++){
                if (frmMain.quyen[i] != ""){
                    if (frmMain.quyen[i] == "ViewLists"){
                        cnt = cnt + 1; ;
                    }
                }else break;
            }
            if (cnt > 0){
                staffListToolStripMenuItem.Visible = true;
                departmentListToolStripMenuItem.Visible = true;
                positionListToolStripMenuItem.Visible = true;
                genderListToolStripMenuItem.Visible = true;
                nationListToolStripMenuItem.Visible = true;
            }else{
                staffListToolStripMenuItem.Visible = false;
                departmentListToolStripMenuItem.Visible = false;
                positionListToolStripMenuItem.Visible = false;
                genderListToolStripMenuItem.Visible = false;
                nationListToolStripMenuItem.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < chuoiQuyen.Length; i++)
            {
                if (frmMain.quyen[i] != "")
                {
                    if (frmMain.quyen[i] == "Division")
                    {cnt = cnt + 1; }
                }else break;
            }
            if(cnt > 0) { divisionProjectImplementToolStripMenuItem.Visible = true; }
            else { divisionProjectImplementToolStripMenuItem.Visible = false; }
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < chuoiQuyen.Length; i++)
            {
                if (frmMain.quyen[i] != "")
                {
                    if (frmMain.quyen[i] == "Change Database")
                    {
                        cnt = cnt + 1; ;
                    }
                }
                else break;
            }
            if (cnt > 0) { changeDataBaseToolStripMenuItem.Visible = true; }
            else { changeDataBaseToolStripMenuItem.Visible = false; }
            if (lbl_staffName.Text != "" || lbl_staffName.Text == "label3daaaaaaaaaa") /// Neu da Login  thì: 
            { loginToolStripMenuItem.Enabled = false;  logOutToolStripMenuItem.Enabled = true; }//// tắt nút login, bật nút logout
            else { loginToolStripMenuItem.Enabled = true; logOutToolStripMenuItem.Enabled = false; }//// ngược lại thì bật login, tắt logout

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < chuoiQuyen.Length; i++)
            {
                if (frmMain.quyen[i] != "")
                {
                    if (frmMain.quyen[i] == "New User")
                    {cnt = cnt + 1;
                        userToolStripMenuItem.Visible = true;
                    }
                    if(frmMain.quyen[i] == "New Project")
                    { cnt = cnt + 5;
                        projectToolStripMenuItem.Visible = true;
                    }
                }
                else break;
            }
            if(cnt == 0)
            {
                projectToolStripMenuItem.Visible = false;
                userToolStripMenuItem.Visible = false;
                MessageBox.Show("Warning!! \nYou can not Add new anything\nBecause you has not enough Access Right", "Warnign", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { newToolStripMenuItem1.Visible = true; }
            
        }

        private void lbl_staffName_MouseEnter(object sender, EventArgs e)
        {
            lbl_staffName.ForeColor = Color.DarkBlue;
            lbl_staffName.BackColor = Color.Yellow;
        }

        private void lbl_staffName_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void toolsMenu_MouseEnter(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < chuoiQuyen.Length; i++)
            {
                if (frmMain.quyen[i] != "")
                {
                    if (frmMain.quyen[i] == "Division")
                    { cnt = cnt + 1; }
                }
                else break;
            }
            if (cnt > 0) { divisionProjectImplementToolStripMenuItem.Visible = true; }
            else { divisionProjectImplementToolStripMenuItem.Visible = false; }
        }

        private void newToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {

            int cnt = 0;
            for (int i = 0; i < chuoiQuyen.Length; i++)
            {
                if (frmMain.quyen[i] != "")
                {
                    if (frmMain.quyen[i] == "New User")
                    {
                        cnt = cnt + 1;
                        userToolStripMenuItem.Visible = true;
                    }
                    if (frmMain.quyen[i] == "New Project")
                    {
                        cnt = cnt + 5;
                        projectToolStripMenuItem.Visible = true;
                    }
                }
                else break;
            }
            if (cnt == 0)
            {
                projectToolStripMenuItem.Visible = false;
                userToolStripMenuItem.Visible = false;
                //MessageBox.Show("Warning!! \nYou can not Add new anything\nBecause you has not enough Access Right", "Warnign", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { newToolStripMenuItem1.Visible = true; }
        }

        private void viewMenu_MouseEnter(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < chuoiQuyen.Length; i++)
            {
                if (frmMain.quyen[i] != "")
                {
                    if (frmMain.quyen[i] == "ViewLists")
                    {
                        cnt = cnt + 1; ;
                    }
                }
                else break;
            }
            if (cnt > 0)
            {
                staffListToolStripMenuItem.Visible = true;
                departmentListToolStripMenuItem.Visible = true;
                positionListToolStripMenuItem.Visible = true;
                genderListToolStripMenuItem.Visible = true;
                nationListToolStripMenuItem.Visible = true;
            }
            else
            {
                staffListToolStripMenuItem.Visible = false;
                departmentListToolStripMenuItem.Visible = false;
                positionListToolStripMenuItem.Visible = false;
                genderListToolStripMenuItem.Visible = false;
                nationListToolStripMenuItem.Visible = false;
            }
        }

        private void systemToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < chuoiQuyen.Length; i++)
            {
                if (frmMain.quyen[i] != "")
                {
                    if (frmMain.quyen[i] == "Change Database")
                    {
                        cnt = cnt + 1; ;
                    }
                }
                else break;
            }
            if (cnt > 0) { changeDataBaseToolStripMenuItem.Visible = true; }
            else { changeDataBaseToolStripMenuItem.Visible = false; }
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContact c = new frmContact();
           // MessageBox.Show("|" + exe.returnFormName(c + ""));
            c.Show();
        }

        private void restoreDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "D:/" + frmMain.tenDN + "/";
            openFileDialog1.Filter = "Database files (*.mdb, *.accdb, *.bak)|*.mdb;*.accdb;*.bak";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            string selectedFileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 selectedFileName = openFileDialog1.FileName;
                MessageBox.Show(selectedFileName);
            }
            string[] hashDB = selectedFileName.Split('_');
            string[] hashPath = selectedFileName.Split('\\');
            string query = "RESTORE DATABASE " + hashDB[1] + " FROM DISK = '"+ "D:/" + frmMain.tenDN + "/" +hashPath[2]+"';";
            // to restore a database much be not connect to any database
            // so the connection class normaly cannot use
            // => make a new connection which connect to " master database

            conn.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn.con);
            cmd.ExecuteNonQuery();
            conn.closeConnection();
        }

        private void projectInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < frmMain.chuoiQuyen.Length; i++)
            {
                //MessageBox.Show(quyen[i]);
                if (quyen[i] == "View Project Infor")

                { btn = 8; PhanQuyen_();  break; }
                else if (quyen[i] == "")
                {
                    MessageBox.Show("You have not enoungh Access Right to Alter in this Window");
                    break;
                };
            }
            
        }

        private void txt_M_searchKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmSplashScreen ss = new frmSplashScreen();
            ss.Show();
            this.Hide();
        }

        private void newToolStripMenuItem1_MouseEnter_1(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < chuoiQuyen.Length; i++)
            {
                if (frmMain.quyen[i] != "")
                {
                    if (frmMain.quyen[i] == "New User")
                    {
                        cnt = cnt + 1;
                        userToolStripMenuItem.Visible = true;
                    }
                    if (frmMain.quyen[i] == "New Project")
                    {
                        cnt = cnt + 5;
                        projectToolStripMenuItem.Visible = true;
                    }
                }
                else break;
            }
            if (cnt == 0)
            {
                projectToolStripMenuItem.Visible = false;
                userToolStripMenuItem.Visible = false;
                //MessageBox.Show("Warning!! \nYou can not Add new anything\nBecause you has not enough Access Right", "Warnign", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { newToolStripMenuItem1.Visible = true; }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projectsAreCompletedAndUnfinishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmReportProjectProgress rpp = new Forms.frmReportProjectProgress();
            rpp.Show();
        }

        private void numberOfCompletedEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmReportProjectProgress rpp = new Forms.frmReportProjectProgress();
            if (exe.checkFormOpen(exe.returnFormName(rpp + "")) == false)
            { rpp.Show(); exe.changeFormValue(exe.returnFormName(rpp + "")); }
            else{ rpp.Focus(); this.SendToBack(); }
            
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet worksheet = (Worksheet)workbook.Worksheets[1];

            // Lấy dữ liệu từ DataGridView và đưa vào Excel
            for (int i = 1; i < grv_staffList.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grv_staffList.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < grv_staffList.Rows.Count; i++)
            {
                for (int j = 0; j < grv_staffList.Columns.Count; j++)
                {
                    string cellValue = grv_staffList.Rows[i].Cells[j].Value.ToString();

                    // Kiểm tra nếu giá trị bắt đầu bằng số 0, đặt định dạng là văn bản
                    if (cellValue.StartsWith("0"))
                    {
                        Range cell = (Range)worksheet.Cells[i + 2, j + 1];
                        cell.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        cell.NumberFormat = "@";
                    }

                    worksheet.Cells[i + 2, j + 1] = cellValue;
                }
            }
            Range columns = worksheet.UsedRange.Columns;
            columns.AutoFit();
            // Lưu file Excel

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                excelApp.Quit();
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                ReleaseObject(excelApp);
                MessageBox.Show("Danh sách nhân viên đã được lưu vào tệp Excel!");

                string excelFilePath = saveFileDialog.FileName;
                string excelFileDirectory = Path.GetDirectoryName(excelFilePath);
                Process.Start("explorer.exe", excelFileDirectory);
            }
        }

        // Giải phóng đối tượng Excel khi không sử dụng nữa
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void lbl_staffName_MouseLeave(object sender, EventArgs e)
        {
            lbl_staffName.ForeColor = Color.Black;
            lbl_staffName.BackColor = Color.White;
        }

        private void txt_M_searchKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string query = null;
                string key = txt_M_searchKey.Text;
                frmMain.search_Key = key;
                if (key == "")
                {
                    showStaffList();
                }
                else
                {
                    grv_staffList.Visible = true;
                    staffListToolStripMenuItem.Checked = true;
                }
                if (key != null){
                    /////////search by gender/////////////
                    if (key == "Nam" || key == "Nữ"){
                        string findGen = "select *from nhanVien where tenGT = '" + key + "';";
                        query = findGen;
                        lbl_M_searchType.Visible = true;
                        lbl_M_searchType.Text = "Search By Gender";
                    }
                    else if (key == "Kinh" || key == "Hoa" || key == "Khomer") {
                        string findNat = "select *from nhanVien where tenDT LIKE '" + key + "';";
                        query = findNat;
                        lbl_M_searchType.Visible = true;
                        lbl_M_searchType.Text = "Search By Nation";
                    }
                    else if (key.StartsWith("0") & key.Length == 10){
                        string findPhone = "select *from nhanVien where sdt LIKE'" + key + "%'";
                        query = findPhone;
                        lbl_M_searchType.Visible = true;
                        lbl_M_searchType.Text = "Search By Phone Number";
                    }
                    else if (key.StartsWith("0") & key.Length > 10){
                        string findCCCD = "select *from nhanVien where cccd LIKE'" + key + "%'";
                        query = findCCCD;
                        lbl_M_searchType.Visible = true;
                        lbl_M_searchType.Text = "Search By Citizen Identification";
                    }else{
                        string findTen = "select *from nhanVien where tenNV LIKE N'%" + key + "%';";
                        query = findTen;
                        lbl_M_searchType.Visible = true;
                        lbl_M_searchType.Text = "Search By Staff Name";
                    }
                }
                conn.getConnection();
                SqlDataAdapter adt = new SqlDataAdapter(query, conn.con);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                grv_staffList.DataSource = dt;
                grv_staffList.ForeColor = Color.Black;
                conn.closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chuoiQuyen+"\n\n"+exe.getLevel(textBox1.Text));
            MessageBox.Show("D:/");
            /*for (int i = 0; i < chuoiQuyen.Length; i++)
            {
                if (frmMain.quyen[i] != "")
                {
                    MessageBox.Show(frmMain.quyen[i]);
                    continue;
                }
                else break;
            }*/

           
        }

        private void divisionProjectImplementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frmMain.access = exe.KT_quyen(userName, grv_staffName);
            for (int i = 0; i < frmMain.chuoiQuyen.Length; i++)
            {
                //MessageBox.Show(quyen[i]);
                if (quyen[i] == "Division")
                    
                { btn = 7; PhanQuyen_(); break; }
                else if(quyen[i] =="")
                {
                    MessageBox.Show("You have not enoungh Access Right to Alter in this Window");
                    break;
                };
            }
        }
    }
}
