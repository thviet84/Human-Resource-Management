
namespace QuanLyDoanhNghiep
{
    partial class frmConnectDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectDatabase));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Con_LoginName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Con_pwd = new System.Windows.Forms.TextBox();
            this.cb_Con_serverName = new System.Windows.Forms.ComboBox();
            this.btn_Con_check = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Con_database = new System.Windows.Forms.ComboBox();
            this.btn_Con_connect = new System.Windows.Forms.Button();
            this.btn_Con_close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chb_Con_showPwd = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Con_backup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // txt_Con_LoginName
            // 
            this.txt_Con_LoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Con_LoginName.Location = new System.Drawing.Point(160, 163);
            this.txt_Con_LoginName.Name = "txt_Con_LoginName";
            this.txt_Con_LoginName.Size = new System.Drawing.Size(349, 27);
            this.txt_Con_LoginName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(46, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(30, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login Name";
            // 
            // txt_Con_pwd
            // 
            this.txt_Con_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Con_pwd.Location = new System.Drawing.Point(160, 216);
            this.txt_Con_pwd.Name = "txt_Con_pwd";
            this.txt_Con_pwd.Size = new System.Drawing.Size(349, 27);
            this.txt_Con_pwd.TabIndex = 4;
            this.txt_Con_pwd.UseSystemPasswordChar = true;
            // 
            // cb_Con_serverName
            // 
            this.cb_Con_serverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Con_serverName.FormattingEnabled = true;
            this.cb_Con_serverName.Items.AddRange(new object[] {
            "",
            "test1"});
            this.cb_Con_serverName.Location = new System.Drawing.Point(160, 97);
            this.cb_Con_serverName.Name = "cb_Con_serverName";
            this.cb_Con_serverName.Size = new System.Drawing.Size(349, 28);
            this.cb_Con_serverName.TabIndex = 5;
            this.cb_Con_serverName.SelectedIndexChanged += new System.EventHandler(this.cb_Con_serverName_SelectedIndexChanged);
            // 
            // btn_Con_check
            // 
            this.btn_Con_check.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Con_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Con_check.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Con_check.Image = ((System.Drawing.Image)(resources.GetObject("btn_Con_check.Image")));
            this.btn_Con_check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Con_check.Location = new System.Drawing.Point(160, 276);
            this.btn_Con_check.Name = "btn_Con_check";
            this.btn_Con_check.Size = new System.Drawing.Size(154, 38);
            this.btn_Con_check.TabIndex = 6;
            this.btn_Con_check.Text = "   Check";
            this.btn_Con_check.UseVisualStyleBackColor = false;
            this.btn_Con_check.Click += new System.EventHandler(this.btn_Con_check_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(54, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database";
            // 
            // cb_Con_database
            // 
            this.cb_Con_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Con_database.FormattingEnabled = true;
            this.cb_Con_database.Items.AddRange(new object[] {
            "",
            "QUANLYDOANHNGHIEP",
            "QLSV"});
            this.cb_Con_database.Location = new System.Drawing.Point(160, 335);
            this.cb_Con_database.Name = "cb_Con_database";
            this.cb_Con_database.Size = new System.Drawing.Size(349, 28);
            this.cb_Con_database.TabIndex = 8;
            // 
            // btn_Con_connect
            // 
            this.btn_Con_connect.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Con_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Con_connect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Con_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_Con_connect.Image")));
            this.btn_Con_connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Con_connect.Location = new System.Drawing.Point(170, 388);
            this.btn_Con_connect.Name = "btn_Con_connect";
            this.btn_Con_connect.Size = new System.Drawing.Size(111, 38);
            this.btn_Con_connect.TabIndex = 9;
            this.btn_Con_connect.Text = "  Connect";
            this.btn_Con_connect.UseVisualStyleBackColor = false;
            this.btn_Con_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Con_close
            // 
            this.btn_Con_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Con_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Con_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Con_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Con_close.Image")));
            this.btn_Con_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Con_close.Location = new System.Drawing.Point(339, 388);
            this.btn_Con_close.Name = "btn_Con_close";
            this.btn_Con_close.Size = new System.Drawing.Size(111, 38);
            this.btn_Con_close.TabIndex = 10;
            this.btn_Con_close.Text = "   Close";
            this.btn_Con_close.UseVisualStyleBackColor = false;
            this.btn_Con_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 51);
            this.label5.TabIndex = 11;
            this.label5.Text = "Connect to Database";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(563, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(232, 111);
            this.dataGridView1.TabIndex = 12;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // chb_Con_showPwd
            // 
            this.chb_Con_showPwd.AutoSize = true;
            this.chb_Con_showPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chb_Con_showPwd.Location = new System.Drawing.Point(160, 249);
            this.chb_Con_showPwd.Name = "chb_Con_showPwd";
            this.chb_Con_showPwd.Size = new System.Drawing.Size(129, 21);
            this.chb_Con_showPwd.TabIndex = 13;
            this.chb_Con_showPwd.Text = "Show Password";
            this.chb_Con_showPwd.UseVisualStyleBackColor = true;
            this.chb_Con_showPwd.CheckedChanged += new System.EventHandler(this.chb_Con_showPwd_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 67);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Con_backup
            // 
            this.btn_Con_backup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Con_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Con_backup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Con_backup.Image = ((System.Drawing.Image)(resources.GetObject("btn_Con_backup.Image")));
            this.btn_Con_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Con_backup.Location = new System.Drawing.Point(339, 276);
            this.btn_Con_backup.Name = "btn_Con_backup";
            this.btn_Con_backup.Size = new System.Drawing.Size(154, 38);
            this.btn_Con_backup.TabIndex = 15;
            this.btn_Con_backup.Text = "   Back Up";
            this.btn_Con_backup.UseVisualStyleBackColor = false;
            this.btn_Con_backup.Click += new System.EventHandler(this.btn_Con_backup_Click);
            // 
            // frmConnectDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.btn_Con_backup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chb_Con_showPwd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Con_close);
            this.Controls.Add(this.btn_Con_connect);
            this.Controls.Add(this.cb_Con_database);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Con_check);
            this.Controls.Add(this.cb_Con_serverName);
            this.Controls.Add(this.txt_Con_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Con_LoginName);
            this.Controls.Add(this.label1);
            this.Name = "frmConnectDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Database";
            this.Load += new System.EventHandler(this.frmConnectDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Con_LoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Con_pwd;
        private System.Windows.Forms.ComboBox cb_Con_serverName;
        private System.Windows.Forms.Button btn_Con_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Con_database;
        private System.Windows.Forms.Button btn_Con_connect;
        private System.Windows.Forms.Button btn_Con_close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chb_Con_showPwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Con_backup;
    }
}