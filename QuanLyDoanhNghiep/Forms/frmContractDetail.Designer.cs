
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmContractDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContractDetail));
            this.btn_CD_back = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.datePicker_CD_startDay = new System.Windows.Forms.DateTimePicker();
            this.datePicker_CD_endDay = new System.Windows.Forms.DateTimePicker();
            this.txt_CD_ValPeri = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_CD_describe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CD_contName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CD_contID = new System.Windows.Forms.TextBox();
            this.txt_CD_staffID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CD_edit = new System.Windows.Forms.Button();
            this.btn_CD_clear = new System.Windows.Forms.Button();
            this.btn_CD_cancel = new System.Windows.Forms.Button();
            this.btn_CD_update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CD_back
            // 
            this.btn_CD_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CD_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_CD_back.Image")));
            this.btn_CD_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CD_back.Location = new System.Drawing.Point(753, 531);
            this.btn_CD_back.Name = "btn_CD_back";
            this.btn_CD_back.Size = new System.Drawing.Size(138, 34);
            this.btn_CD_back.TabIndex = 48;
            this.btn_CD_back.Text = "Back";
            this.btn_CD_back.UseVisualStyleBackColor = true;
            this.btn_CD_back.Click += new System.EventHandler(this.btn_CD_back_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(100, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(426, 69);
            this.label12.TabIndex = 53;
            this.label12.Text = "Contract Detail";
            // 
            // datePicker_CD_startDay
            // 
            this.datePicker_CD_startDay.Enabled = false;
            this.datePicker_CD_startDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_CD_startDay.Location = new System.Drawing.Point(126, 34);
            this.datePicker_CD_startDay.Name = "datePicker_CD_startDay";
            this.datePicker_CD_startDay.Size = new System.Drawing.Size(317, 27);
            this.datePicker_CD_startDay.TabIndex = 63;
            // 
            // datePicker_CD_endDay
            // 
            this.datePicker_CD_endDay.Enabled = false;
            this.datePicker_CD_endDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_CD_endDay.Location = new System.Drawing.Point(126, 87);
            this.datePicker_CD_endDay.Name = "datePicker_CD_endDay";
            this.datePicker_CD_endDay.Size = new System.Drawing.Size(317, 27);
            this.datePicker_CD_endDay.TabIndex = 61;
            // 
            // txt_CD_ValPeri
            // 
            this.txt_CD_ValPeri.Enabled = false;
            this.txt_CD_ValPeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CD_ValPeri.Location = new System.Drawing.Point(126, 143);
            this.txt_CD_ValPeri.Name = "txt_CD_ValPeri";
            this.txt_CD_ValPeri.Size = new System.Drawing.Size(317, 27);
            this.txt_CD_ValPeri.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Start Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "End Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Validity Period";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_CD_describe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.datePicker_CD_startDay);
            this.groupBox2.Controls.Add(this.datePicker_CD_endDay);
            this.groupBox2.Controls.Add(this.txt_CD_ValPeri);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(596, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 280);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contract Detail";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_CD_describe
            // 
            this.txt_CD_describe.Enabled = false;
            this.txt_CD_describe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CD_describe.Location = new System.Drawing.Point(126, 194);
            this.txt_CD_describe.Name = "txt_CD_describe";
            this.txt_CD_describe.Size = new System.Drawing.Size(317, 27);
            this.txt_CD_describe.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Describe";
            // 
            // txt_CD_contName
            // 
            this.txt_CD_contName.Enabled = false;
            this.txt_CD_contName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CD_contName.Location = new System.Drawing.Point(137, 136);
            this.txt_CD_contName.Name = "txt_CD_contName";
            this.txt_CD_contName.Size = new System.Drawing.Size(317, 27);
            this.txt_CD_contName.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "Contract Name";
            // 
            // txt_CD_contID
            // 
            this.txt_CD_contID.Enabled = false;
            this.txt_CD_contID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CD_contID.Location = new System.Drawing.Point(137, 84);
            this.txt_CD_contID.Name = "txt_CD_contID";
            this.txt_CD_contID.Size = new System.Drawing.Size(317, 27);
            this.txt_CD_contID.TabIndex = 68;
            // 
            // txt_CD_staffID
            // 
            this.txt_CD_staffID.Enabled = false;
            this.txt_CD_staffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CD_staffID.Location = new System.Drawing.Point(137, 34);
            this.txt_CD_staffID.Name = "txt_CD_staffID";
            this.txt_CD_staffID.Size = new System.Drawing.Size(317, 27);
            this.txt_CD_staffID.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Staff ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Contract ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_CD_contName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_CD_contID);
            this.groupBox3.Controls.Add(this.txt_CD_staffID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(17, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 194);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contract";
            // 
            // btn_CD_edit
            // 
            this.btn_CD_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CD_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_CD_edit.Image")));
            this.btn_CD_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CD_edit.Location = new System.Drawing.Point(609, 531);
            this.btn_CD_edit.Name = "btn_CD_edit";
            this.btn_CD_edit.Size = new System.Drawing.Size(138, 34);
            this.btn_CD_edit.TabIndex = 72;
            this.btn_CD_edit.Text = "Edit";
            this.btn_CD_edit.UseVisualStyleBackColor = true;
            this.btn_CD_edit.Click += new System.EventHandler(this.btn_CD_add_Click);
            // 
            // btn_CD_clear
            // 
            this.btn_CD_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CD_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_CD_clear.Image")));
            this.btn_CD_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CD_clear.Location = new System.Drawing.Point(321, 531);
            this.btn_CD_clear.Name = "btn_CD_clear";
            this.btn_CD_clear.Size = new System.Drawing.Size(138, 34);
            this.btn_CD_clear.TabIndex = 75;
            this.btn_CD_clear.Text = "  Clear";
            this.btn_CD_clear.UseVisualStyleBackColor = true;
            this.btn_CD_clear.Visible = false;
            this.btn_CD_clear.Click += new System.EventHandler(this.btn_CD_clear_Click);
            // 
            // btn_CD_cancel
            // 
            this.btn_CD_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CD_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_CD_cancel.Image")));
            this.btn_CD_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CD_cancel.Location = new System.Drawing.Point(177, 531);
            this.btn_CD_cancel.Name = "btn_CD_cancel";
            this.btn_CD_cancel.Size = new System.Drawing.Size(138, 34);
            this.btn_CD_cancel.TabIndex = 74;
            this.btn_CD_cancel.Text = "   Cancel";
            this.btn_CD_cancel.UseVisualStyleBackColor = true;
            this.btn_CD_cancel.Visible = false;
            this.btn_CD_cancel.Click += new System.EventHandler(this.btn_CD_cancel_Click);
            // 
            // btn_CD_update
            // 
            this.btn_CD_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CD_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_CD_update.Image")));
            this.btn_CD_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CD_update.Location = new System.Drawing.Point(465, 531);
            this.btn_CD_update.Name = "btn_CD_update";
            this.btn_CD_update.Size = new System.Drawing.Size(138, 34);
            this.btn_CD_update.TabIndex = 73;
            this.btn_CD_update.Text = "    Update";
            this.btn_CD_update.UseVisualStyleBackColor = true;
            this.btn_CD_update.Visible = false;
            this.btn_CD_update.Click += new System.EventHandler(this.btn_CD_update_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // frmContractDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_CD_clear);
            this.Controls.Add(this.btn_CD_edit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_CD_cancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_CD_update);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_CD_back);
            this.Name = "frmContractDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contract Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContractDetail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_CD_back;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker datePicker_CD_startDay;
        public System.Windows.Forms.DateTimePicker datePicker_CD_endDay;
        public System.Windows.Forms.TextBox txt_CD_ValPeri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txt_CD_contName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_CD_contID;
        public System.Windows.Forms.TextBox txt_CD_staffID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_CD_edit;
        private System.Windows.Forms.Button btn_CD_clear;
        private System.Windows.Forms.Button btn_CD_cancel;
        private System.Windows.Forms.Button btn_CD_update;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_CD_describe;
        private System.Windows.Forms.Label label2;
    }
}