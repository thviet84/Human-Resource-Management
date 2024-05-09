
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmProjectDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datePicker_PD_end = new System.Windows.Forms.DateTimePicker();
            this.datePicker_PD_start = new System.Windows.Forms.DateTimePicker();
            this.numberic_PD_memNum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PD_prog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PD_result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PD_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PD_id = new System.Windows.Forms.TextBox();
            this.btn_PD_add = new System.Windows.Forms.Button();
            this.btn_PD_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grv_projDetail_list = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_PD_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberic_PD_memNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_projDetail_list)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datePicker_PD_end);
            this.groupBox1.Controls.Add(this.datePicker_PD_start);
            this.groupBox1.Controls.Add(this.numberic_PD_memNum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_PD_prog);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_PD_result);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(24, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 351);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Detail";
            // 
            // datePicker_PD_end
            // 
            this.datePicker_PD_end.Enabled = false;
            this.datePicker_PD_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_PD_end.Location = new System.Drawing.Point(182, 174);
            this.datePicker_PD_end.Name = "datePicker_PD_end";
            this.datePicker_PD_end.Size = new System.Drawing.Size(257, 27);
            this.datePicker_PD_end.TabIndex = 25;
            // 
            // datePicker_PD_start
            // 
            this.datePicker_PD_start.Enabled = false;
            this.datePicker_PD_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_PD_start.Location = new System.Drawing.Point(182, 110);
            this.datePicker_PD_start.Name = "datePicker_PD_start";
            this.datePicker_PD_start.Size = new System.Drawing.Size(257, 27);
            this.datePicker_PD_start.TabIndex = 24;
            // 
            // numberic_PD_memNum
            // 
            this.numberic_PD_memNum.Enabled = false;
            this.numberic_PD_memNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberic_PD_memNum.Location = new System.Drawing.Point(182, 47);
            this.numberic_PD_memNum.Name = "numberic_PD_memNum";
            this.numberic_PD_memNum.Size = new System.Drawing.Size(257, 27);
            this.numberic_PD_memNum.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "End Day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Start Day";
            // 
            // txt_PD_prog
            // 
            this.txt_PD_prog.Enabled = false;
            this.txt_PD_prog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PD_prog.Location = new System.Drawing.Point(182, 300);
            this.txt_PD_prog.Name = "txt_PD_prog";
            this.txt_PD_prog.Size = new System.Drawing.Size(257, 27);
            this.txt_PD_prog.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Progress";
            // 
            // txt_PD_result
            // 
            this.txt_PD_result.Enabled = false;
            this.txt_PD_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PD_result.Location = new System.Drawing.Point(182, 237);
            this.txt_PD_result.Name = "txt_PD_result";
            this.txt_PD_result.Size = new System.Drawing.Size(257, 27);
            this.txt_PD_result.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Member Number";
            // 
            // txt_PD_name
            // 
            this.txt_PD_name.Enabled = false;
            this.txt_PD_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PD_name.Location = new System.Drawing.Point(206, 212);
            this.txt_PD_name.Name = "txt_PD_name";
            this.txt_PD_name.Size = new System.Drawing.Size(257, 27);
            this.txt_PD_name.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Project ID";
            // 
            // txt_PD_id
            // 
            this.txt_PD_id.Enabled = false;
            this.txt_PD_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PD_id.Location = new System.Drawing.Point(206, 153);
            this.txt_PD_id.Name = "txt_PD_id";
            this.txt_PD_id.Size = new System.Drawing.Size(257, 27);
            this.txt_PD_id.TabIndex = 15;
            // 
            // btn_PD_add
            // 
            this.btn_PD_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PD_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_PD_add.Image")));
            this.btn_PD_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PD_add.Location = new System.Drawing.Point(1538, 590);
            this.btn_PD_add.Name = "btn_PD_add";
            this.btn_PD_add.Size = new System.Drawing.Size(141, 39);
            this.btn_PD_add.TabIndex = 21;
            this.btn_PD_add.Text = "   Add";
            this.btn_PD_add.UseVisualStyleBackColor = true;
            this.btn_PD_add.Click += new System.EventHandler(this.btn_D_add_Click);
            // 
            // btn_PD_back
            // 
            this.btn_PD_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PD_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_PD_back.Image")));
            this.btn_PD_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PD_back.Location = new System.Drawing.Point(1703, 590);
            this.btn_PD_back.Name = "btn_PD_back";
            this.btn_PD_back.Size = new System.Drawing.Size(141, 39);
            this.btn_PD_back.TabIndex = 20;
            this.btn_PD_back.Text = "   Back";
            this.btn_PD_back.UseVisualStyleBackColor = true;
            this.btn_PD_back.Click += new System.EventHandler(this.btn_P_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "Project Detail";
            // 
            // grv_projDetail_list
            // 
            this.grv_projDetail_list.AllowUserToAddRows = false;
            this.grv_projDetail_list.AllowUserToDeleteRows = false;
            this.grv_projDetail_list.AllowUserToOrderColumns = true;
            this.grv_projDetail_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_projDetail_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grv_projDetail_list.Location = new System.Drawing.Point(503, 106);
            this.grv_projDetail_list.Name = "grv_projDetail_list";
            this.grv_projDetail_list.RowHeadersWidth = 51;
            this.grv_projDetail_list.RowTemplate.Height = 24;
            this.grv_projDetail_list.Size = new System.Drawing.Size(1341, 351);
            this.grv_projDetail_list.TabIndex = 23;
            this.grv_projDetail_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_projDetail_list_CellContentClick);
            this.grv_projDetail_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maDA";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Project ID";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "tenDA";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Project Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 400;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soLuongNguoi";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Number of Member ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngayBatDau";
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Start Day";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngayKetThuc";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "End Day";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 75;
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
            // btn_PD_clear
            // 
            this.btn_PD_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PD_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_PD_clear.Image")));
            this.btn_PD_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PD_clear.Location = new System.Drawing.Point(1373, 590);
            this.btn_PD_clear.Name = "btn_PD_clear";
            this.btn_PD_clear.Size = new System.Drawing.Size(141, 39);
            this.btn_PD_clear.TabIndex = 24;
            this.btn_PD_clear.Text = "   Clear";
            this.btn_PD_clear.UseVisualStyleBackColor = true;
            this.btn_PD_clear.Click += new System.EventHandler(this.btn_projDetail_clear_Click);
            // 
            // frmProjectDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 641);
            this.Controls.Add(this.btn_PD_clear);
            this.Controls.Add(this.grv_projDetail_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PD_add);
            this.Controls.Add(this.btn_PD_back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_PD_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PD_id);
            this.Name = "frmProjectDetail";
            this.Text = "frmProjectDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProjectDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberic_PD_memNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_projDetail_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker datePicker_PD_start;
        public System.Windows.Forms.NumericUpDown numberic_PD_memNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_PD_prog;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_PD_result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_PD_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_PD_id;
        private System.Windows.Forms.Button btn_PD_add;
        private System.Windows.Forms.Button btn_PD_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grv_projDetail_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btn_PD_clear;
        public System.Windows.Forms.DateTimePicker datePicker_PD_end;
    }
}