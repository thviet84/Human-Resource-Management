
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmProjectsInfor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectsInfor));
            this.grv_PI_list = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PI_back = new System.Windows.Forms.Button();
            this.grB_PI_addStaff = new System.Windows.Forms.GroupBox();
            this.btn_PI_addStaff = new System.Windows.Forms.Button();
            this.cb_PI_projName = new System.Windows.Forms.ComboBox();
            this.cb_PI_staffList = new System.Windows.Forms.ComboBox();
            this.txt_PI_projName = new System.Windows.Forms.TextBox();
            this.lbl_PI_projectName = new System.Windows.Forms.Label();
            this.lbl_PI_staffName = new System.Windows.Forms.Label();
            this.txt_PI_id = new System.Windows.Forms.TextBox();
            this.txt_PI_name = new System.Windows.Forms.TextBox();
            this.lbl_noti = new System.Windows.Forms.Label();
            this.grv_PI_projInfor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_PI_staff = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_PI_list)).BeginInit();
            this.grB_PI_addStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_PI_projInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_PI_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_PI_list
            // 
            this.grv_PI_list.AllowUserToAddRows = false;
            this.grv_PI_list.AllowUserToDeleteRows = false;
            this.grv_PI_list.AllowUserToOrderColumns = true;
            this.grv_PI_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_PI_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grv_PI_list.Location = new System.Drawing.Point(12, 130);
            this.grv_PI_list.Name = "grv_PI_list";
            this.grv_PI_list.RowHeadersWidth = 51;
            this.grv_PI_list.RowTemplate.Height = 24;
            this.grv_PI_list.Size = new System.Drawing.Size(1406, 351);
            this.grv_PI_list.TabIndex = 33;
            this.grv_PI_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grv_PI_list_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maDA";
            this.Column1.HeaderText = "Project ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tenDA";
            this.Column2.HeaderText = "Project Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 46);
            this.label1.TabIndex = 32;
            this.label1.Text = "Project Information";
            // 
            // btn_PI_back
            // 
            this.btn_PI_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PI_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_PI_back.Image")));
            this.btn_PI_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PI_back.Location = new System.Drawing.Point(1760, 917);
            this.btn_PI_back.Name = "btn_PI_back";
            this.btn_PI_back.Size = new System.Drawing.Size(152, 39);
            this.btn_PI_back.TabIndex = 30;
            this.btn_PI_back.Text = "   Back";
            this.btn_PI_back.UseVisualStyleBackColor = true;
            this.btn_PI_back.Click += new System.EventHandler(this.btn_PI_back_Click);
            // 
            // grB_PI_addStaff
            // 
            this.grB_PI_addStaff.Controls.Add(this.btn_PI_addStaff);
            this.grB_PI_addStaff.Controls.Add(this.cb_PI_projName);
            this.grB_PI_addStaff.Controls.Add(this.cb_PI_staffList);
            this.grB_PI_addStaff.Controls.Add(this.txt_PI_projName);
            this.grB_PI_addStaff.Controls.Add(this.lbl_PI_projectName);
            this.grB_PI_addStaff.Controls.Add(this.lbl_PI_staffName);
            this.grB_PI_addStaff.Controls.Add(this.txt_PI_id);
            this.grB_PI_addStaff.Controls.Add(this.txt_PI_name);
            this.grB_PI_addStaff.Location = new System.Drawing.Point(725, 488);
            this.grB_PI_addStaff.Name = "grB_PI_addStaff";
            this.grB_PI_addStaff.Size = new System.Drawing.Size(693, 233);
            this.grB_PI_addStaff.TabIndex = 29;
            this.grB_PI_addStaff.TabStop = false;
            this.grB_PI_addStaff.Text = "Add a Staff to project";
            this.grB_PI_addStaff.Visible = false;
            // 
            // btn_PI_addStaff
            // 
            this.btn_PI_addStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PI_addStaff.Image = ((System.Drawing.Image)(resources.GetObject("btn_PI_addStaff.Image")));
            this.btn_PI_addStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PI_addStaff.Location = new System.Drawing.Point(275, 168);
            this.btn_PI_addStaff.Name = "btn_PI_addStaff";
            this.btn_PI_addStaff.Size = new System.Drawing.Size(228, 39);
            this.btn_PI_addStaff.TabIndex = 40;
            this.btn_PI_addStaff.Text = "   Add Staff";
            this.btn_PI_addStaff.UseVisualStyleBackColor = true;
            this.btn_PI_addStaff.Visible = false;
            this.btn_PI_addStaff.Click += new System.EventHandler(this.btn_PI_addStaff_Click);
            // 
            // cb_PI_projName
            // 
            this.cb_PI_projName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PI_projName.FormattingEnabled = true;
            this.cb_PI_projName.Location = new System.Drawing.Point(169, 99);
            this.cb_PI_projName.Name = "cb_PI_projName";
            this.cb_PI_projName.Size = new System.Drawing.Size(484, 28);
            this.cb_PI_projName.TabIndex = 39;
            this.cb_PI_projName.Visible = false;
            // 
            // cb_PI_staffList
            // 
            this.cb_PI_staffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PI_staffList.FormattingEnabled = true;
            this.cb_PI_staffList.Location = new System.Drawing.Point(169, 35);
            this.cb_PI_staffList.Name = "cb_PI_staffList";
            this.cb_PI_staffList.Size = new System.Drawing.Size(484, 28);
            this.cb_PI_staffList.TabIndex = 38;
            this.cb_PI_staffList.Visible = false;
            this.cb_PI_staffList.SelectedIndexChanged += new System.EventHandler(this.cb_PI_staffList_SelectedIndexChanged);
            // 
            // txt_PI_projName
            // 
            this.txt_PI_projName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PI_projName.Location = new System.Drawing.Point(6, 166);
            this.txt_PI_projName.Name = "txt_PI_projName";
            this.txt_PI_projName.Size = new System.Drawing.Size(257, 27);
            this.txt_PI_projName.TabIndex = 20;
            this.txt_PI_projName.Visible = false;
            // 
            // lbl_PI_projectName
            // 
            this.lbl_PI_projectName.AutoSize = true;
            this.lbl_PI_projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PI_projectName.Location = new System.Drawing.Point(37, 107);
            this.lbl_PI_projectName.Name = "lbl_PI_projectName";
            this.lbl_PI_projectName.Size = new System.Drawing.Size(111, 20);
            this.lbl_PI_projectName.TabIndex = 22;
            this.lbl_PI_projectName.Text = "Project Name";
            this.lbl_PI_projectName.Visible = false;
            // 
            // lbl_PI_staffName
            // 
            this.lbl_PI_staffName.AutoSize = true;
            this.lbl_PI_staffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PI_staffName.Location = new System.Drawing.Point(55, 43);
            this.lbl_PI_staffName.Name = "lbl_PI_staffName";
            this.lbl_PI_staffName.Size = new System.Drawing.Size(93, 20);
            this.lbl_PI_staffName.TabIndex = 21;
            this.lbl_PI_staffName.Text = "Staff Name";
            this.lbl_PI_staffName.Visible = false;
            // 
            // txt_PI_id
            // 
            this.txt_PI_id.Enabled = false;
            this.txt_PI_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PI_id.Location = new System.Drawing.Point(6, 133);
            this.txt_PI_id.Name = "txt_PI_id";
            this.txt_PI_id.Size = new System.Drawing.Size(257, 27);
            this.txt_PI_id.TabIndex = 25;
            this.txt_PI_id.Visible = false;
            // 
            // txt_PI_name
            // 
            this.txt_PI_name.Enabled = false;
            this.txt_PI_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PI_name.Location = new System.Drawing.Point(6, 199);
            this.txt_PI_name.Name = "txt_PI_name";
            this.txt_PI_name.Size = new System.Drawing.Size(257, 27);
            this.txt_PI_name.TabIndex = 28;
            this.txt_PI_name.Visible = false;
            // 
            // lbl_noti
            // 
            this.lbl_noti.AutoSize = true;
            this.lbl_noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noti.Location = new System.Drawing.Point(8, 488);
            this.lbl_noti.Name = "lbl_noti";
            this.lbl_noti.Size = new System.Drawing.Size(93, 20);
            this.lbl_noti.TabIndex = 35;
            this.lbl_noti.Text = "Notification";
            // 
            // grv_PI_projInfor
            // 
            this.grv_PI_projInfor.AllowUserToAddRows = false;
            this.grv_PI_projInfor.AllowUserToDeleteRows = false;
            this.grv_PI_projInfor.AllowUserToOrderColumns = true;
            this.grv_PI_projInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_PI_projInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.ketQua,
            this.tienDo});
            this.grv_PI_projInfor.Location = new System.Drawing.Point(12, 130);
            this.grv_PI_projInfor.Name = "grv_PI_projInfor";
            this.grv_PI_projInfor.RowHeadersWidth = 51;
            this.grv_PI_projInfor.RowTemplate.Height = 24;
            this.grv_PI_projInfor.Size = new System.Drawing.Size(1846, 351);
            this.grv_PI_projInfor.TabIndex = 36;
            this.grv_PI_projInfor.Visible = false;
            this.grv_PI_projInfor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_PI_projInfor_CellContentClick);
            this.grv_PI_projInfor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grv_PI_projInfor_KeyPress);
            this.grv_PI_projInfor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grv_P_projInfor_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "maDA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Project ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenDA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Project Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soLuongNguoi";
            this.Column3.HeaderText = "Number of Member";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngayBatDau";
            this.Column4.HeaderText = "Start Day";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngayKetThuc";
            this.Column5.HeaderText = "End Day";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // ketQua
            // 
            this.ketQua.DataPropertyName = "ketQua";
            this.ketQua.HeaderText = "Result";
            this.ketQua.MinimumWidth = 6;
            this.ketQua.Name = "ketQua";
            this.ketQua.ReadOnly = true;
            this.ketQua.Width = 125;
            // 
            // tienDo
            // 
            this.tienDo.DataPropertyName = "tienDo";
            this.tienDo.HeaderText = "Progess";
            this.tienDo.MinimumWidth = 6;
            this.tienDo.Name = "tienDo";
            this.tienDo.ReadOnly = true;
            this.tienDo.Width = 125;
            // 
            // grv_PI_staff
            // 
            this.grv_PI_staff.AllowUserToAddRows = false;
            this.grv_PI_staff.AllowUserToDeleteRows = false;
            this.grv_PI_staff.AllowUserToOrderColumns = true;
            this.grv_PI_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_PI_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.grv_PI_staff.Location = new System.Drawing.Point(12, 130);
            this.grv_PI_staff.Name = "grv_PI_staff";
            this.grv_PI_staff.RowHeadersWidth = 51;
            this.grv_PI_staff.RowTemplate.Height = 24;
            this.grv_PI_staff.Size = new System.Drawing.Size(1406, 351);
            this.grv_PI_staff.TabIndex = 37;
            this.grv_PI_staff.Visible = false;
            this.grv_PI_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grv_PI_staff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grv_PI_staff_KeyPress);
            this.grv_PI_staff.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grv_PI_staff_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "maNV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Staff ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tenNV";
            this.dataGridViewTextBoxColumn4.HeaderText = "Staff Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // frmProjectsInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 987);
            this.Controls.Add(this.grv_PI_staff);
            this.Controls.Add(this.grv_PI_projInfor);
            this.Controls.Add(this.lbl_noti);
            this.Controls.Add(this.grv_PI_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PI_back);
            this.Controls.Add(this.grB_PI_addStaff);
            this.Name = "frmProjectsInfor";
            this.Text = "frmProjectsInfor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProjectsInfor_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProjectsInfor_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grv_PI_list)).EndInit();
            this.grB_PI_addStaff.ResumeLayout(false);
            this.grB_PI_addStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_PI_projInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_PI_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PI_back;
        public System.Windows.Forms.TextBox txt_PI_projName;
        public System.Windows.Forms.DataGridView grv_PI_list;
        private System.Windows.Forms.Label lbl_noti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridView grv_PI_projInfor;
        public System.Windows.Forms.DataGridView grv_PI_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienDo;
        public System.Windows.Forms.TextBox txt_PI_id;
        public System.Windows.Forms.TextBox txt_PI_name;
        public System.Windows.Forms.ComboBox cb_PI_staffList;
        public System.Windows.Forms.ComboBox cb_PI_projName;
        public System.Windows.Forms.Button btn_PI_addStaff;
        public System.Windows.Forms.Label lbl_PI_projectName;
        public System.Windows.Forms.Label lbl_PI_staffName;
        public System.Windows.Forms.GroupBox grB_PI_addStaff;
    }
}