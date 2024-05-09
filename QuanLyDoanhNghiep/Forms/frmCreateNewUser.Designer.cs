
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmCreateNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewUser));
            this.txt_CNU_userID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CNU_userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CNU_pwd = new System.Windows.Forms.TextBox();
            this.txt_CNU_rePwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CNU_back = new System.Windows.Forms.Button();
            this.btn_CNU_create = new System.Windows.Forms.Button();
            this.btn_CNU_clear = new System.Windows.Forms.Button();
            this.lbl_CNU_noti = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chBox_CNU_showPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CNU_userID
            // 
            this.txt_CNU_userID.Enabled = false;
            this.txt_CNU_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CNU_userID.Location = new System.Drawing.Point(152, 136);
            this.txt_CNU_userID.Name = "txt_CNU_userID";
            this.txt_CNU_userID.Size = new System.Drawing.Size(248, 27);
            this.txt_CNU_userID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID";
            // 
            // txt_CNU_userName
            // 
            this.txt_CNU_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CNU_userName.Location = new System.Drawing.Point(152, 206);
            this.txt_CNU_userName.Name = "txt_CNU_userName";
            this.txt_CNU_userName.Size = new System.Drawing.Size(318, 27);
            this.txt_CNU_userName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_CNU_pwd
            // 
            this.txt_CNU_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CNU_pwd.Location = new System.Drawing.Point(152, 257);
            this.txt_CNU_pwd.Name = "txt_CNU_pwd";
            this.txt_CNU_pwd.Size = new System.Drawing.Size(318, 27);
            this.txt_CNU_pwd.TabIndex = 7;
            // 
            // txt_CNU_rePwd
            // 
            this.txt_CNU_rePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CNU_rePwd.Location = new System.Drawing.Point(152, 313);
            this.txt_CNU_rePwd.Name = "txt_CNU_rePwd";
            this.txt_CNU_rePwd.Size = new System.Drawing.Size(318, 27);
            this.txt_CNU_rePwd.TabIndex = 9;
            this.txt_CNU_rePwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CNU_rePwd_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Retype Password";
            // 
            // btn_CNU_back
            // 
            this.btn_CNU_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CNU_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_CNU_back.Image")));
            this.btn_CNU_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CNU_back.Location = new System.Drawing.Point(778, 402);
            this.btn_CNU_back.Name = "btn_CNU_back";
            this.btn_CNU_back.Size = new System.Drawing.Size(149, 36);
            this.btn_CNU_back.TabIndex = 10;
            this.btn_CNU_back.Text = "  Back";
            this.btn_CNU_back.UseVisualStyleBackColor = true;
            this.btn_CNU_back.Click += new System.EventHandler(this.btn_CNU_back_Click);
            // 
            // btn_CNU_create
            // 
            this.btn_CNU_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CNU_create.Image = ((System.Drawing.Image)(resources.GetObject("btn_CNU_create.Image")));
            this.btn_CNU_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CNU_create.Location = new System.Drawing.Point(468, 402);
            this.btn_CNU_create.Name = "btn_CNU_create";
            this.btn_CNU_create.Size = new System.Drawing.Size(149, 36);
            this.btn_CNU_create.TabIndex = 11;
            this.btn_CNU_create.Text = "   Create";
            this.btn_CNU_create.UseVisualStyleBackColor = true;
            this.btn_CNU_create.Click += new System.EventHandler(this.btn_CNU_create_Click);
            // 
            // btn_CNU_clear
            // 
            this.btn_CNU_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CNU_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_CNU_clear.Image")));
            this.btn_CNU_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CNU_clear.Location = new System.Drawing.Point(623, 402);
            this.btn_CNU_clear.Name = "btn_CNU_clear";
            this.btn_CNU_clear.Size = new System.Drawing.Size(149, 36);
            this.btn_CNU_clear.TabIndex = 12;
            this.btn_CNU_clear.Text = "  Clear";
            this.btn_CNU_clear.UseVisualStyleBackColor = true;
            this.btn_CNU_clear.Click += new System.EventHandler(this.btn_CNU_clear_Click);
            // 
            // lbl_CNU_noti
            // 
            this.lbl_CNU_noti.AutoSize = true;
            this.lbl_CNU_noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CNU_noti.ForeColor = System.Drawing.Color.Red;
            this.lbl_CNU_noti.Location = new System.Drawing.Point(56, 263);
            this.lbl_CNU_noti.Name = "lbl_CNU_noti";
            this.lbl_CNU_noti.Size = new System.Drawing.Size(0, 20);
            this.lbl_CNU_noti.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 69);
            this.label5.TabIndex = 24;
            this.label5.Text = "Create New User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 66);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // chBox_CNU_showPass
            // 
            this.chBox_CNU_showPass.AutoSize = true;
            this.chBox_CNU_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBox_CNU_showPass.Location = new System.Drawing.Point(152, 357);
            this.chBox_CNU_showPass.Name = "chBox_CNU_showPass";
            this.chBox_CNU_showPass.Size = new System.Drawing.Size(151, 24);
            this.chBox_CNU_showPass.TabIndex = 26;
            this.chBox_CNU_showPass.Text = "Show Password";
            this.chBox_CNU_showPass.UseVisualStyleBackColor = true;
            this.chBox_CNU_showPass.CheckedChanged += new System.EventHandler(this.chBox_CNU_showPass_CheckedChanged);
            // 
            // frmCreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.chBox_CNU_showPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_CNU_noti);
            this.Controls.Add(this.btn_CNU_clear);
            this.Controls.Add(this.btn_CNU_create);
            this.Controls.Add(this.btn_CNU_back);
            this.Controls.Add(this.txt_CNU_rePwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CNU_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CNU_userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CNU_userID);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreateNewUser_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CNU_userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CNU_pwd;
        private System.Windows.Forms.TextBox txt_CNU_rePwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_CNU_back;
        private System.Windows.Forms.Button btn_CNU_create;
        private System.Windows.Forms.Button btn_CNU_clear;
        private System.Windows.Forms.Label lbl_CNU_noti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chBox_CNU_showPass;
        public System.Windows.Forms.TextBox txt_CNU_userID;
    }
}