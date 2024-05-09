
namespace QuanLyDoanhNghiep
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_L_UN = new System.Windows.Forms.TextBox();
            this.txt_L_PWD = new System.Windows.Forms.TextBox();
            this.btn_L_Login = new System.Windows.Forms.Button();
            this.btn_L_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chBox_showPass = new System.Windows.Forms.CheckBox();
            this.grv_staffName = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grv_staffName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(55, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(55, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txt_L_UN
            // 
            this.txt_L_UN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_L_UN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_L_UN.Location = new System.Drawing.Point(183, 96);
            this.txt_L_UN.Name = "txt_L_UN";
            this.txt_L_UN.Size = new System.Drawing.Size(410, 30);
            this.txt_L_UN.TabIndex = 2;
            this.txt_L_UN.Text = "qwe";
            this.txt_L_UN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_L_UN_KeyPress);
            // 
            // txt_L_PWD
            // 
            this.txt_L_PWD.Enabled = false;
            this.txt_L_PWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_L_PWD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_L_PWD.Location = new System.Drawing.Point(183, 156);
            this.txt_L_PWD.Name = "txt_L_PWD";
            this.txt_L_PWD.Size = new System.Drawing.Size(410, 30);
            this.txt_L_PWD.TabIndex = 3;
            this.txt_L_PWD.Text = "qwe";
            this.txt_L_PWD.UseSystemPasswordChar = true;
            this.txt_L_PWD.TextChanged += new System.EventHandler(this.txt_L_PWD_TextChanged);
            // 
            // btn_L_Login
            // 
            this.btn_L_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_L_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_L_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_L_Login.Image")));
            this.btn_L_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_L_Login.Location = new System.Drawing.Point(172, 253);
            this.btn_L_Login.Name = "btn_L_Login";
            this.btn_L_Login.Size = new System.Drawing.Size(124, 38);
            this.btn_L_Login.TabIndex = 4;
            this.btn_L_Login.Text = "  Login";
            this.btn_L_Login.UseVisualStyleBackColor = true;
            this.btn_L_Login.Click += new System.EventHandler(this.btn_L_Login_Click);
            // 
            // btn_L_cancel
            // 
            this.btn_L_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_L_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_L_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_L_cancel.Image")));
            this.btn_L_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_L_cancel.Location = new System.Drawing.Point(367, 253);
            this.btn_L_cancel.Name = "btn_L_cancel";
            this.btn_L_cancel.Size = new System.Drawing.Size(124, 38);
            this.btn_L_cancel.TabIndex = 5;
            this.btn_L_cancel.Text = "    Cancel";
            this.btn_L_cancel.UseVisualStyleBackColor = true;
            this.btn_L_cancel.Click += new System.EventHandler(this.btn_L_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(268, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // chBox_showPass
            // 
            this.chBox_showPass.AutoSize = true;
            this.chBox_showPass.Enabled = false;
            this.chBox_showPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chBox_showPass.Location = new System.Drawing.Point(183, 204);
            this.chBox_showPass.Name = "chBox_showPass";
            this.chBox_showPass.Size = new System.Drawing.Size(129, 21);
            this.chBox_showPass.TabIndex = 7;
            this.chBox_showPass.Text = "Show Password";
            this.chBox_showPass.UseVisualStyleBackColor = true;
            this.chBox_showPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grv_staffName
            // 
            this.grv_staffName.AllowUserToAddRows = false;
            this.grv_staffName.AllowUserToDeleteRows = false;
            this.grv_staffName.AllowUserToOrderColumns = true;
            this.grv_staffName.AllowUserToResizeColumns = false;
            this.grv_staffName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_staffName.Location = new System.Drawing.Point(497, 224);
            this.grv_staffName.Name = "grv_staffName";
            this.grv_staffName.RowHeadersWidth = 51;
            this.grv_staffName.RowTemplate.Height = 24;
            this.grv_staffName.Size = new System.Drawing.Size(161, 97);
            this.grv_staffName.TabIndex = 8;
            this.grv_staffName.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 322);
            this.Controls.Add(this.grv_staffName);
            this.Controls.Add(this.chBox_showPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_L_cancel);
            this.Controls.Add(this.btn_L_Login);
            this.Controls.Add(this.txt_L_PWD);
            this.Controls.Add(this.txt_L_UN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_staffName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_L_UN;
        private System.Windows.Forms.TextBox txt_L_PWD;
        private System.Windows.Forms.Button btn_L_Login;
        private System.Windows.Forms.Button btn_L_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chBox_showPass;
        private System.Windows.Forms.DataGridView grv_staffName;
    }
}

