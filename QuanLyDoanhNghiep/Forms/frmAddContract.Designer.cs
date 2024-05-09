
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmAddContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddContract));
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_AC_contName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AC_contID = new System.Windows.Forms.TextBox();
            this.txt_AC_staffID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richtxt_AC_descr = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker_AC_startDay = new System.Windows.Forms.DateTimePicker();
            this.datePicker_AC_endDay = new System.Windows.Forms.DateTimePicker();
            this.txt_AC_ValPeri = new System.Windows.Forms.TextBox();
            this.txt_VC_dep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_AC_add = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.grv_AC_contList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_AC_contList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(1748, 684);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(138, 41);
            this.btn_back.TabIndex = 37;
            this.btn_back.Text = "   Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_AC_contName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_AC_contID);
            this.panel1.Controls.Add(this.txt_AC_staffID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 181);
            this.panel1.TabIndex = 38;
            // 
            // txt_AC_contName
            // 
            this.txt_AC_contName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AC_contName.Location = new System.Drawing.Point(137, 122);
            this.txt_AC_contName.Name = "txt_AC_contName";
            this.txt_AC_contName.Size = new System.Drawing.Size(227, 27);
            this.txt_AC_contName.TabIndex = 45;
            this.txt_AC_contName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AC_contName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Contract Name";
            // 
            // txt_AC_contID
            // 
            this.txt_AC_contID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AC_contID.Location = new System.Drawing.Point(137, 70);
            this.txt_AC_contID.Name = "txt_AC_contID";
            this.txt_AC_contID.Size = new System.Drawing.Size(227, 27);
            this.txt_AC_contID.TabIndex = 40;
            // 
            // txt_AC_staffID
            // 
            this.txt_AC_staffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AC_staffID.Location = new System.Drawing.Point(137, 20);
            this.txt_AC_staffID.Name = "txt_AC_staffID";
            this.txt_AC_staffID.Size = new System.Drawing.Size(227, 27);
            this.txt_AC_staffID.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Staff ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Contract ID";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.richtxt_AC_descr);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.datePicker_AC_startDay);
            this.panel2.Controls.Add(this.datePicker_AC_endDay);
            this.panel2.Controls.Add(this.txt_AC_ValPeri);
            this.panel2.Controls.Add(this.txt_VC_dep);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(17, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 317);
            this.panel2.TabIndex = 39;
            // 
            // richtxt_AC_descr
            // 
            this.richtxt_AC_descr.Location = new System.Drawing.Point(137, 180);
            this.richtxt_AC_descr.Name = "richtxt_AC_descr";
            this.richtxt_AC_descr.Size = new System.Drawing.Size(227, 90);
            this.richtxt_AC_descr.TabIndex = 53;
            this.richtxt_AC_descr.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Describe";
            // 
            // datePicker_AC_startDay
            // 
            this.datePicker_AC_startDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_AC_startDay.Location = new System.Drawing.Point(137, 78);
            this.datePicker_AC_startDay.Name = "datePicker_AC_startDay";
            this.datePicker_AC_startDay.Size = new System.Drawing.Size(227, 27);
            this.datePicker_AC_startDay.TabIndex = 51;
            // 
            // datePicker_AC_endDay
            // 
            this.datePicker_AC_endDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_AC_endDay.Location = new System.Drawing.Point(137, 25);
            this.datePicker_AC_endDay.Name = "datePicker_AC_endDay";
            this.datePicker_AC_endDay.Size = new System.Drawing.Size(227, 27);
            this.datePicker_AC_endDay.TabIndex = 48;
            // 
            // txt_AC_ValPeri
            // 
            this.txt_AC_ValPeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AC_ValPeri.Location = new System.Drawing.Point(137, 130);
            this.txt_AC_ValPeri.Name = "txt_AC_ValPeri";
            this.txt_AC_ValPeri.Size = new System.Drawing.Size(227, 27);
            this.txt_AC_ValPeri.TabIndex = 46;
            // 
            // txt_VC_dep
            // 
            this.txt_VC_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VC_dep.Location = new System.Drawing.Point(23, -114);
            this.txt_VC_dep.Name = "txt_VC_dep";
            this.txt_VC_dep.Size = new System.Drawing.Size(227, 27);
            this.txt_VC_dep.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-80, -104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Start Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "End Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Validity Period";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 18);
            this.label10.TabIndex = 46;
            this.label10.Text = "Contract";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 18);
            this.label11.TabIndex = 47;
            this.label11.Text = "Contract Detail";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btn_AC_add
            // 
            this.btn_AC_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AC_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_AC_add.Image")));
            this.btn_AC_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AC_add.Location = new System.Drawing.Point(1604, 684);
            this.btn_AC_add.Name = "btn_AC_add";
            this.btn_AC_add.Size = new System.Drawing.Size(138, 41);
            this.btn_AC_add.TabIndex = 48;
            this.btn_AC_add.Text = "   Add";
            this.btn_AC_add.UseVisualStyleBackColor = true;
            this.btn_AC_add.Click += new System.EventHandler(this.btn_AC_add_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(98, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(378, 69);
            this.label13.TabIndex = 50;
            this.label13.Text = "Add Contract";
            // 
            // grv_AC_contList
            // 
            this.grv_AC_contList.AllowUserToAddRows = false;
            this.grv_AC_contList.AllowUserToDeleteRows = false;
            this.grv_AC_contList.AllowUserToOrderColumns = true;
            this.grv_AC_contList.AllowUserToResizeColumns = false;
            this.grv_AC_contList.AllowUserToResizeRows = false;
            this.grv_AC_contList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_AC_contList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.grv_AC_contList.Location = new System.Drawing.Point(425, 147);
            this.grv_AC_contList.Name = "grv_AC_contList";
            this.grv_AC_contList.RowHeadersWidth = 51;
            this.grv_AC_contList.RowTemplate.Height = 24;
            this.grv_AC_contList.Size = new System.Drawing.Size(1461, 340);
            this.grv_AC_contList.TabIndex = 51;
            this.grv_AC_contList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grv_AC_contList_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maHD";
            this.Column1.HeaderText = "Contract ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenHD";
            this.Column2.HeaderText = "Contract Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 450;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ngayBatDau";
            this.Column3.HeaderText = "Start Day";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngayKetThuc";
            this.Column4.HeaderText = "End Day";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "thoiHan";
            this.Column5.HeaderText = "Validity Period";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "moTa";
            this.Column6.HeaderText = "Describe";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 70);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 737);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grv_AC_contList);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_AC_add);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Name = "frmAddContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Contract";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddContract_FormClosed);
            this.Load += new System.EventHandler(this.frmAddContract_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_AC_contList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_AC_contID;
        public System.Windows.Forms.TextBox txt_AC_staffID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_AC_ValPeri;
        private System.Windows.Forms.TextBox txt_VC_dep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_AC_contName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datePicker_AC_startDay;
        private System.Windows.Forms.DateTimePicker datePicker_AC_endDay;
        private System.Windows.Forms.Button btn_AC_add;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView grv_AC_contList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richtxt_AC_descr;
    }
}