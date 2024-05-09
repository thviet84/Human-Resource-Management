
namespace QuanLyDoanhNghiep.Forms
{
    partial class Corporation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corporation));
            this.txt_I_incID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_I_incName = new System.Windows.Forms.TextBox();
            this.btn_I_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_I_add = new System.Windows.Forms.Button();
            this.grv_I_incList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_I_addr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_I_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_I_phone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_I_incList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_I_incID
            // 
            this.txt_I_incID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_I_incID.Location = new System.Drawing.Point(202, 113);
            this.txt_I_incID.Name = "txt_I_incID";
            this.txt_I_incID.Size = new System.Drawing.Size(181, 27);
            this.txt_I_incID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(37, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Corporation ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(37, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Corporation Name";
            // 
            // txt_I_incName
            // 
            this.txt_I_incName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_I_incName.Location = new System.Drawing.Point(202, 173);
            this.txt_I_incName.Name = "txt_I_incName";
            this.txt_I_incName.Size = new System.Drawing.Size(481, 27);
            this.txt_I_incName.TabIndex = 3;
            // 
            // btn_I_back
            // 
            this.btn_I_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_I_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_I_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_I_back.Image")));
            this.btn_I_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_I_back.Location = new System.Drawing.Point(1113, 528);
            this.btn_I_back.Name = "btn_I_back";
            this.btn_I_back.Size = new System.Drawing.Size(118, 38);
            this.btn_I_back.TabIndex = 4;
            this.btn_I_back.Text = "   Back";
            this.btn_I_back.UseVisualStyleBackColor = true;
            this.btn_I_back.Click += new System.EventHandler(this.btn_I_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(86, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 69);
            this.label3.TabIndex = 23;
            this.label3.Text = "Corporation";
            // 
            // btn_I_add
            // 
            this.btn_I_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_I_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_I_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_I_add.Image")));
            this.btn_I_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_I_add.Location = new System.Drawing.Point(989, 528);
            this.btn_I_add.Name = "btn_I_add";
            this.btn_I_add.Size = new System.Drawing.Size(118, 38);
            this.btn_I_add.TabIndex = 24;
            this.btn_I_add.Text = "  Add";
            this.btn_I_add.UseVisualStyleBackColor = true;
            // 
            // grv_I_incList
            // 
            this.grv_I_incList.AllowUserToAddRows = false;
            this.grv_I_incList.AllowUserToDeleteRows = false;
            this.grv_I_incList.AllowUserToOrderColumns = true;
            this.grv_I_incList.AllowUserToResizeColumns = false;
            this.grv_I_incList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_I_incList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grv_I_incList.Location = new System.Drawing.Point(27, 404);
            this.grv_I_incList.Name = "grv_I_incList";
            this.grv_I_incList.RowHeadersWidth = 51;
            this.grv_I_incList.RowTemplate.Height = 24;
            this.grv_I_incList.Size = new System.Drawing.Size(956, 149);
            this.grv_I_incList.TabIndex = 25;
            this.grv_I_incList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_I_incList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maDN";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenDN";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Corporation Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diaChi";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Address";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sdt";
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Hotline";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "email";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Contact Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 68);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(37, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Address";
            // 
            // txt_I_addr
            // 
            this.txt_I_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_I_addr.Location = new System.Drawing.Point(202, 232);
            this.txt_I_addr.Name = "txt_I_addr";
            this.txt_I_addr.Size = new System.Drawing.Size(481, 27);
            this.txt_I_addr.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(37, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Contact Email";
            // 
            // txt_I_mail
            // 
            this.txt_I_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_I_mail.Location = new System.Drawing.Point(202, 350);
            this.txt_I_mail.Name = "txt_I_mail";
            this.txt_I_mail.Size = new System.Drawing.Size(481, 27);
            this.txt_I_mail.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(37, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Hotline";
            // 
            // txt_I_phone
            // 
            this.txt_I_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_I_phone.Location = new System.Drawing.Point(202, 292);
            this.txt_I_phone.Name = "txt_I_phone";
            this.txt_I_phone.Size = new System.Drawing.Size(481, 27);
            this.txt_I_phone.TabIndex = 31;
            // 
            // Corporation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 578);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_I_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_I_mail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_I_addr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grv_I_incList);
            this.Controls.Add(this.btn_I_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_I_back);
            this.Controls.Add(this.txt_I_incName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_I_incID);
            this.Name = "Corporation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Corporation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_I_incList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_I_incID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_I_incName;
        private System.Windows.Forms.Button btn_I_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_I_add;
        private System.Windows.Forms.DataGridView grv_I_incList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_I_addr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_I_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_I_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}