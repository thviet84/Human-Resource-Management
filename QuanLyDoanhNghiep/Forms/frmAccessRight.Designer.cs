
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmAccessRight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccessRight));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AR_uID = new System.Windows.Forms.TextBox();
            this.btn_AR_back = new System.Windows.Forms.Button();
            this.btn_AR_cancel = new System.Windows.Forms.Button();
            this.btn_AR_UAR = new System.Windows.Forms.Button();
            this.btn_AR_edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grv_AR_list = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_AR_newRight = new System.Windows.Forms.ComboBox();
            this.txt_AR_curRight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_AR_staffFN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AR_UF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_AR_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // txt_AR_uID
            // 
            this.txt_AR_uID.Enabled = false;
            this.txt_AR_uID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AR_uID.Location = new System.Drawing.Point(141, 120);
            this.txt_AR_uID.Name = "txt_AR_uID";
            this.txt_AR_uID.Size = new System.Drawing.Size(217, 27);
            this.txt_AR_uID.TabIndex = 1;
            this.txt_AR_uID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_AR_back
            // 
            this.btn_AR_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AR_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_AR_back.Image")));
            this.btn_AR_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AR_back.Location = new System.Drawing.Point(930, 651);
            this.btn_AR_back.Name = "btn_AR_back";
            this.btn_AR_back.Size = new System.Drawing.Size(145, 38);
            this.btn_AR_back.TabIndex = 5;
            this.btn_AR_back.Text = "    Back";
            this.btn_AR_back.UseVisualStyleBackColor = true;
            this.btn_AR_back.Click += new System.EventHandler(this.btn_AR_back_Click);
            // 
            // btn_AR_cancel
            // 
            this.btn_AR_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AR_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_AR_cancel.Image")));
            this.btn_AR_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AR_cancel.Location = new System.Drawing.Point(619, 651);
            this.btn_AR_cancel.Name = "btn_AR_cancel";
            this.btn_AR_cancel.Size = new System.Drawing.Size(154, 38);
            this.btn_AR_cancel.TabIndex = 17;
            this.btn_AR_cancel.Text = "    Cancel";
            this.btn_AR_cancel.UseVisualStyleBackColor = true;
            this.btn_AR_cancel.Visible = false;
            this.btn_AR_cancel.Click += new System.EventHandler(this.btn_AR_cancel_Click);
            // 
            // btn_AR_UAR
            // 
            this.btn_AR_UAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AR_UAR.Image = ((System.Drawing.Image)(resources.GetObject("btn_AR_UAR.Image")));
            this.btn_AR_UAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AR_UAR.Location = new System.Drawing.Point(187, 429);
            this.btn_AR_UAR.Name = "btn_AR_UAR";
            this.btn_AR_UAR.Size = new System.Drawing.Size(268, 38);
            this.btn_AR_UAR.TabIndex = 16;
            this.btn_AR_UAR.Text = "     Update Access Right";
            this.btn_AR_UAR.UseVisualStyleBackColor = true;
            this.btn_AR_UAR.Visible = false;
            this.btn_AR_UAR.Click += new System.EventHandler(this.btn_AR_update_Click);
            // 
            // btn_AR_edit
            // 
            this.btn_AR_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AR_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_AR_edit.Image")));
            this.btn_AR_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AR_edit.Location = new System.Drawing.Point(779, 651);
            this.btn_AR_edit.Name = "btn_AR_edit";
            this.btn_AR_edit.Size = new System.Drawing.Size(145, 38);
            this.btn_AR_edit.TabIndex = 15;
            this.btn_AR_edit.Text = "    Edit";
            this.btn_AR_edit.UseVisualStyleBackColor = true;
            this.btn_AR_edit.Click += new System.EventHandler(this.btn_AR_edit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(78, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 55);
            this.label4.TabIndex = 18;
            this.label4.Text = "Access Right";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 72);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // grv_AR_list
            // 
            this.grv_AR_list.AllowUserToAddRows = false;
            this.grv_AR_list.AllowUserToDeleteRows = false;
            this.grv_AR_list.AllowUserToOrderColumns = true;
            this.grv_AR_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_AR_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5});
            this.grv_AR_list.Enabled = false;
            this.grv_AR_list.Location = new System.Drawing.Point(544, 91);
            this.grv_AR_list.Name = "grv_AR_list";
            this.grv_AR_list.RowHeadersWidth = 51;
            this.grv_AR_list.RowTemplate.Height = 24;
            this.grv_AR_list.Size = new System.Drawing.Size(561, 284);
            this.grv_AR_list.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Access Right";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cb_AR_newRight
            // 
            this.cb_AR_newRight.Enabled = false;
            this.cb_AR_newRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AR_newRight.FormattingEnabled = true;
            this.cb_AR_newRight.Items.AddRange(new object[] {
            ""});
            this.cb_AR_newRight.Location = new System.Drawing.Point(187, 347);
            this.cb_AR_newRight.Name = "cb_AR_newRight";
            this.cb_AR_newRight.Size = new System.Drawing.Size(302, 28);
            this.cb_AR_newRight.TabIndex = 6;
            // 
            // txt_AR_curRight
            // 
            this.txt_AR_curRight.Enabled = false;
            this.txt_AR_curRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AR_curRight.Location = new System.Drawing.Point(187, 270);
            this.txt_AR_curRight.Name = "txt_AR_curRight";
            this.txt_AR_curRight.Size = new System.Drawing.Size(302, 27);
            this.txt_AR_curRight.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Current Access Rights";
            // 
            // txt_AR_staffFN
            // 
            this.txt_AR_staffFN.Enabled = false;
            this.txt_AR_staffFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AR_staffFN.Location = new System.Drawing.Point(187, 195);
            this.txt_AR_staffFN.Name = "txt_AR_staffFN";
            this.txt_AR_staffFN.Size = new System.Drawing.Size(302, 27);
            this.txt_AR_staffFN.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Staff Fullname";
            // 
            // btn_AR_UF
            // 
            this.btn_AR_UF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AR_UF.Image = ((System.Drawing.Image)(resources.GetObject("btn_AR_UF.Image")));
            this.btn_AR_UF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AR_UF.Location = new System.Drawing.Point(656, 429);
            this.btn_AR_UF.Name = "btn_AR_UF";
            this.btn_AR_UF.Size = new System.Drawing.Size(268, 38);
            this.btn_AR_UF.TabIndex = 25;
            this.btn_AR_UF.Text = "     Update Function";
            this.btn_AR_UF.UseVisualStyleBackColor = true;
            this.btn_AR_UF.Visible = false;
            this.btn_AR_UF.Click += new System.EventHandler(this.btn_AR_UF_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(656, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "     View All Function";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maCN";
            this.Column1.HeaderText = "Function ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tenCN";
            this.Column4.HeaderText = "Function Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "trangThai";
            this.Column5.HeaderText = "Status";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 50;
            // 
            // frmAccessRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AR_UF);
            this.Controls.Add(this.txt_AR_staffFN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_AR_newRight);
            this.Controls.Add(this.txt_AR_curRight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grv_AR_list);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_AR_cancel);
            this.Controls.Add(this.btn_AR_UAR);
            this.Controls.Add(this.btn_AR_edit);
            this.Controls.Add(this.btn_AR_back);
            this.Controls.Add(this.txt_AR_uID);
            this.Controls.Add(this.label1);
            this.Name = "frmAccessRight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Right";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccessRight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_AR_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_AR_uID;
        private System.Windows.Forms.Button btn_AR_back;
        private System.Windows.Forms.Button btn_AR_cancel;
        private System.Windows.Forms.Button btn_AR_UAR;
        private System.Windows.Forms.Button btn_AR_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grv_AR_list;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cb_AR_newRight;
        public System.Windows.Forms.TextBox txt_AR_curRight;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_AR_staffFN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AR_UF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}