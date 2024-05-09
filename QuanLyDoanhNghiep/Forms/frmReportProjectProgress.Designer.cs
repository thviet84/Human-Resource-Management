
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmReportProjectProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportProjectProgress));
            this.label1 = new System.Windows.Forms.Label();
            this.grv_RPP_allStaff = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rpp_maDA = new System.Windows.Forms.TextBox();
            this.txt_rpp_tenDA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rpp_soLuongNguoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_rpp_ngayBatDau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rpp_ngayKetThuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rpp_ketQua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_rpp_tienDo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTime_rpp_from = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTime_rpp_to = new System.Windows.Forms.DateTimePicker();
            this.btn_rpp_find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grv_rpp_allProject = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_rpp_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_RPP_allStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_rpp_allProject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report Project Progress";
            // 
            // grv_RPP_allStaff
            // 
            this.grv_RPP_allStaff.AllowUserToAddRows = false;
            this.grv_RPP_allStaff.AllowUserToDeleteRows = false;
            this.grv_RPP_allStaff.AllowUserToOrderColumns = true;
            this.grv_RPP_allStaff.AllowUserToResizeColumns = false;
            this.grv_RPP_allStaff.AllowUserToResizeRows = false;
            this.grv_RPP_allStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_RPP_allStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9});
            this.grv_RPP_allStaff.Location = new System.Drawing.Point(21, 479);
            this.grv_RPP_allStaff.Name = "grv_RPP_allStaff";
            this.grv_RPP_allStaff.RowHeadersWidth = 51;
            this.grv_RPP_allStaff.RowTemplate.Height = 24;
            this.grv_RPP_allStaff.Size = new System.Drawing.Size(527, 285);
            this.grv_RPP_allStaff.TabIndex = 5;
            this.grv_RPP_allStaff.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "maNV";
            this.Column8.HeaderText = "Staff ID";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "tenNV";
            this.Column9.HeaderText = "Staff Full Name";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Project ID";
            this.label2.Visible = false;
            // 
            // txt_rpp_maDA
            // 
            this.txt_rpp_maDA.Enabled = false;
            this.txt_rpp_maDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rpp_maDA.Location = new System.Drawing.Point(789, 476);
            this.txt_rpp_maDA.Name = "txt_rpp_maDA";
            this.txt_rpp_maDA.Size = new System.Drawing.Size(362, 27);
            this.txt_rpp_maDA.TabIndex = 7;
            // 
            // txt_rpp_tenDA
            // 
            this.txt_rpp_tenDA.Enabled = false;
            this.txt_rpp_tenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rpp_tenDA.Location = new System.Drawing.Point(789, 519);
            this.txt_rpp_tenDA.Name = "txt_rpp_tenDA";
            this.txt_rpp_tenDA.Size = new System.Drawing.Size(362, 27);
            this.txt_rpp_tenDA.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Project Name";
            this.label3.Visible = false;
            // 
            // txt_rpp_soLuongNguoi
            // 
            this.txt_rpp_soLuongNguoi.Enabled = false;
            this.txt_rpp_soLuongNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rpp_soLuongNguoi.Location = new System.Drawing.Point(789, 563);
            this.txt_rpp_soLuongNguoi.Name = "txt_rpp_soLuongNguoi";
            this.txt_rpp_soLuongNguoi.Size = new System.Drawing.Size(177, 27);
            this.txt_rpp_soLuongNguoi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Maximum Member";
            this.label4.Visible = false;
            // 
            // txt_rpp_ngayBatDau
            // 
            this.txt_rpp_ngayBatDau.Enabled = false;
            this.txt_rpp_ngayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rpp_ngayBatDau.Location = new System.Drawing.Point(789, 612);
            this.txt_rpp_ngayBatDau.Name = "txt_rpp_ngayBatDau";
            this.txt_rpp_ngayBatDau.Size = new System.Drawing.Size(362, 27);
            this.txt_rpp_ngayBatDau.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(611, 615);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Start Day";
            this.label5.Visible = false;
            // 
            // txt_rpp_ngayKetThuc
            // 
            this.txt_rpp_ngayKetThuc.Enabled = false;
            this.txt_rpp_ngayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rpp_ngayKetThuc.Location = new System.Drawing.Point(789, 662);
            this.txt_rpp_ngayKetThuc.Name = "txt_rpp_ngayKetThuc";
            this.txt_rpp_ngayKetThuc.Size = new System.Drawing.Size(362, 27);
            this.txt_rpp_ngayKetThuc.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(611, 665);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "End Day";
            this.label6.Visible = false;
            // 
            // txt_rpp_ketQua
            // 
            this.txt_rpp_ketQua.Enabled = false;
            this.txt_rpp_ketQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rpp_ketQua.Location = new System.Drawing.Point(789, 710);
            this.txt_rpp_ketQua.Name = "txt_rpp_ketQua";
            this.txt_rpp_ketQua.Size = new System.Drawing.Size(362, 27);
            this.txt_rpp_ketQua.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(611, 713);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Result";
            this.label7.Visible = false;
            // 
            // txt_rpp_tienDo
            // 
            this.txt_rpp_tienDo.Enabled = false;
            this.txt_rpp_tienDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rpp_tienDo.Location = new System.Drawing.Point(789, 757);
            this.txt_rpp_tienDo.Name = "txt_rpp_tienDo";
            this.txt_rpp_tienDo.Size = new System.Drawing.Size(177, 27);
            this.txt_rpp_tienDo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(611, 760);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Progress";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "From";
            // 
            // dateTime_rpp_from
            // 
            this.dateTime_rpp_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_rpp_from.Location = new System.Drawing.Point(111, 106);
            this.dateTime_rpp_from.Name = "dateTime_rpp_from";
            this.dateTime_rpp_from.Size = new System.Drawing.Size(316, 30);
            this.dateTime_rpp_from.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(433, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "to";
            // 
            // dateTime_rpp_to
            // 
            this.dateTime_rpp_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_rpp_to.Location = new System.Drawing.Point(513, 106);
            this.dateTime_rpp_to.Name = "dateTime_rpp_to";
            this.dateTime_rpp_to.Size = new System.Drawing.Size(316, 30);
            this.dateTime_rpp_to.TabIndex = 23;
            // 
            // btn_rpp_find
            // 
            this.btn_rpp_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rpp_find.Location = new System.Drawing.Point(863, 106);
            this.btn_rpp_find.Name = "btn_rpp_find";
            this.btn_rpp_find.Size = new System.Drawing.Size(155, 32);
            this.btn_rpp_find.TabIndex = 24;
            this.btn_rpp_find.Text = "Find";
            this.btn_rpp_find.UseVisualStyleBackColor = true;
            this.btn_rpp_find.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1571, 238);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Visible = false;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // grv_rpp_allProject
            // 
            this.grv_rpp_allProject.AllowUserToAddRows = false;
            this.grv_rpp_allProject.AllowUserToDeleteRows = false;
            this.grv_rpp_allProject.AllowUserToOrderColumns = true;
            this.grv_rpp_allProject.AllowUserToResizeRows = false;
            this.grv_rpp_allProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_rpp_allProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grv_rpp_allProject.Location = new System.Drawing.Point(21, 208);
            this.grv_rpp_allProject.Name = "grv_rpp_allProject";
            this.grv_rpp_allProject.RowHeadersWidth = 51;
            this.grv_rpp_allProject.RowTemplate.Height = 24;
            this.grv_rpp_allProject.Size = new System.Drawing.Size(1571, 238);
            this.grv_rpp_allProject.TabIndex = 26;
            this.grv_rpp_allProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_rpp_allProject_CellContentClick);
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
            // Column6
            // 
            this.Column6.DataPropertyName = "ketQua";
            this.Column6.HeaderText = "Result";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tienDo";
            this.Column7.HeaderText = "Progress";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // btn_rpp_close
            // 
            this.btn_rpp_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rpp_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_rpp_close.Image")));
            this.btn_rpp_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rpp_close.Location = new System.Drawing.Point(1353, 743);
            this.btn_rpp_close.Name = "btn_rpp_close";
            this.btn_rpp_close.Size = new System.Drawing.Size(137, 37);
            this.btn_rpp_close.TabIndex = 27;
            this.btn_rpp_close.Text = "    Close";
            this.btn_rpp_close.UseVisualStyleBackColor = true;
            // 
            // frmReportProjectProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 952);
            this.Controls.Add(this.btn_rpp_close);
            this.Controls.Add(this.grv_rpp_allProject);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_rpp_find);
            this.Controls.Add(this.dateTime_rpp_to);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTime_rpp_from);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_rpp_tienDo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_rpp_ketQua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_rpp_ngayKetThuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_rpp_ngayBatDau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_rpp_soLuongNguoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_rpp_tenDA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_rpp_maDA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grv_RPP_allStaff);
            this.Controls.Add(this.label1);
            this.Name = "frmReportProjectProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Project Progress";
            this.Load += new System.EventHandler(this.frmReportProjectProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_RPP_allStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_rpp_allProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grv_RPP_allStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rpp_maDA;
        private System.Windows.Forms.TextBox txt_rpp_tenDA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rpp_soLuongNguoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_rpp_ngayBatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_rpp_ngayKetThuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_rpp_ketQua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_rpp_tienDo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTime_rpp_from;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTime_rpp_to;
        private System.Windows.Forms.Button btn_rpp_find;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView grv_rpp_allProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btn_rpp_close;
    }
}