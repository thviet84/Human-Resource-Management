
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmResume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResume));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_R_uid = new System.Windows.Forms.TextBox();
            this.btn_R_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_R_faJob = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_R_faPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_R_faName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_R_un = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_R_moJob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_R_moPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_R_moName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_R_edit = new System.Windows.Forms.Button();
            this.btn_R_update = new System.Windows.Forms.Button();
            this.btn_R_cancel = new System.Windows.Forms.Button();
            this.btn_R_clear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_R_uid
            // 
            this.txt_R_uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R_uid.Location = new System.Drawing.Point(141, 114);
            this.txt_R_uid.Name = "txt_R_uid";
            this.txt_R_uid.Size = new System.Drawing.Size(240, 27);
            this.txt_R_uid.TabIndex = 1;
            this.txt_R_uid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_R_back
            // 
            this.btn_R_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_R_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_R_back.Image")));
            this.btn_R_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R_back.Location = new System.Drawing.Point(938, 496);
            this.btn_R_back.Name = "btn_R_back";
            this.btn_R_back.Size = new System.Drawing.Size(121, 35);
            this.btn_R_back.TabIndex = 2;
            this.btn_R_back.Text = "   Back";
            this.btn_R_back.UseVisualStyleBackColor = true;
            this.btn_R_back.Click += new System.EventHandler(this.btn_R_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_R_faJob);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_R_faPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_R_faName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(45, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Father";
            // 
            // txt_R_faJob
            // 
            this.txt_R_faJob.Enabled = false;
            this.txt_R_faJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R_faJob.Location = new System.Drawing.Point(105, 143);
            this.txt_R_faJob.Name = "txt_R_faJob";
            this.txt_R_faJob.Size = new System.Drawing.Size(348, 27);
            this.txt_R_faJob.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Job";
            // 
            // txt_R_faPhone
            // 
            this.txt_R_faPhone.Enabled = false;
            this.txt_R_faPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R_faPhone.Location = new System.Drawing.Point(105, 92);
            this.txt_R_faPhone.Name = "txt_R_faPhone";
            this.txt_R_faPhone.Size = new System.Drawing.Size(348, 27);
            this.txt_R_faPhone.TabIndex = 9;
            this.txt_R_faPhone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone \r\nNumber";
            // 
            // txt_R_faName
            // 
            this.txt_R_faName.Enabled = false;
            this.txt_R_faName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R_faName.Location = new System.Drawing.Point(105, 39);
            this.txt_R_faName.Name = "txt_R_faName";
            this.txt_R_faName.Size = new System.Drawing.Size(348, 27);
            this.txt_R_faName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fullname";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // txt_R_un
            // 
            this.txt_R_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R_un.Location = new System.Drawing.Point(141, 163);
            this.txt_R_un.Name = "txt_R_un";
            this.txt_R_un.Size = new System.Drawing.Size(240, 27);
            this.txt_R_un.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_R_moJob);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_R_moPhone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_R_moName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(600, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 204);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mother";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_R_moJob
            // 
            this.txt_R_moJob.Enabled = false;
            this.txt_R_moJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R_moJob.Location = new System.Drawing.Point(103, 143);
            this.txt_R_moJob.Name = "txt_R_moJob";
            this.txt_R_moJob.Size = new System.Drawing.Size(350, 27);
            this.txt_R_moJob.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Job";
            // 
            // txt_R_moPhone
            // 
            this.txt_R_moPhone.Enabled = false;
            this.txt_R_moPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R_moPhone.Location = new System.Drawing.Point(103, 92);
            this.txt_R_moPhone.Name = "txt_R_moPhone";
            this.txt_R_moPhone.Size = new System.Drawing.Size(350, 27);
            this.txt_R_moPhone.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone \r\nNumber";
            // 
            // txt_R_moName
            // 
            this.txt_R_moName.Enabled = false;
            this.txt_R_moName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R_moName.Location = new System.Drawing.Point(103, 39);
            this.txt_R_moName.Name = "txt_R_moName";
            this.txt_R_moName.Size = new System.Drawing.Size(350, 27);
            this.txt_R_moName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fullname";
            // 
            // btn_R_edit
            // 
            this.btn_R_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_R_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_R_edit.Image")));
            this.btn_R_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R_edit.Location = new System.Drawing.Point(813, 496);
            this.btn_R_edit.Name = "btn_R_edit";
            this.btn_R_edit.Size = new System.Drawing.Size(121, 35);
            this.btn_R_edit.TabIndex = 11;
            this.btn_R_edit.Text = "   Edit";
            this.btn_R_edit.UseVisualStyleBackColor = true;
            this.btn_R_edit.Click += new System.EventHandler(this.btn_R_edit_Click);
            // 
            // btn_R_update
            // 
            this.btn_R_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_R_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_R_update.Image")));
            this.btn_R_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R_update.Location = new System.Drawing.Point(674, 496);
            this.btn_R_update.Name = "btn_R_update";
            this.btn_R_update.Size = new System.Drawing.Size(133, 35);
            this.btn_R_update.TabIndex = 12;
            this.btn_R_update.Text = "    Update";
            this.btn_R_update.UseVisualStyleBackColor = true;
            this.btn_R_update.Visible = false;
            this.btn_R_update.Click += new System.EventHandler(this.btn_R_update_Click);
            // 
            // btn_R_cancel
            // 
            this.btn_R_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_R_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_R_cancel.Image")));
            this.btn_R_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R_cancel.Location = new System.Drawing.Point(391, 496);
            this.btn_R_cancel.Name = "btn_R_cancel";
            this.btn_R_cancel.Size = new System.Drawing.Size(133, 35);
            this.btn_R_cancel.TabIndex = 13;
            this.btn_R_cancel.Text = "    Cancel";
            this.btn_R_cancel.UseVisualStyleBackColor = true;
            this.btn_R_cancel.Visible = false;
            this.btn_R_cancel.Click += new System.EventHandler(this.btn_R_cancel_Click);
            // 
            // btn_R_clear
            // 
            this.btn_R_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_R_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_R_clear.Image")));
            this.btn_R_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R_clear.Location = new System.Drawing.Point(536, 496);
            this.btn_R_clear.Name = "btn_R_clear";
            this.btn_R_clear.Size = new System.Drawing.Size(133, 35);
            this.btn_R_clear.TabIndex = 14;
            this.btn_R_clear.Text = "   Clear";
            this.btn_R_clear.UseVisualStyleBackColor = true;
            this.btn_R_clear.Visible = false;
            this.btn_R_clear.Click += new System.EventHandler(this.btn_R_clear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 69);
            this.label9.TabIndex = 24;
            this.label9.Text = "Resume";
            // 
            // frmResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 543);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_R_clear);
            this.Controls.Add(this.btn_R_cancel);
            this.Controls.Add(this.btn_R_update);
            this.Controls.Add(this.btn_R_edit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_R_un);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_R_back);
            this.Controls.Add(this.txt_R_uid);
            this.Controls.Add(this.label1);
            this.Name = "frmResume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume";
            this.Load += new System.EventHandler(this.frmResume_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_R_uid;
        private System.Windows.Forms.Button btn_R_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_R_un;
        private System.Windows.Forms.TextBox txt_R_faPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_R_faName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_R_faJob;
        private System.Windows.Forms.TextBox txt_R_moJob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_R_moPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_R_moName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_R_edit;
        private System.Windows.Forms.Button btn_R_update;
        private System.Windows.Forms.Button btn_R_cancel;
        private System.Windows.Forms.Button btn_R_clear;
        private System.Windows.Forms.Label label9;
    }
}