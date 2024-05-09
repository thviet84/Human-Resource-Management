
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmDivision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDivision));
            this.label2 = new System.Windows.Forms.Label();
            this.grv_P_list = new System.Windows.Forms.DataGridView();
            this.btn_P_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_D_staffID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_D_add = new System.Windows.Forms.Button();
            this.cb_D_projID = new System.Windows.Forms.ComboBox();
            this.grv_D_list = new System.Windows.Forms.DataGridView();
            this.lbl_noti = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_P_list)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_D_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Project ID";
            // 
            // grv_P_list
            // 
            this.grv_P_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_P_list.Location = new System.Drawing.Point(549, 111);
            this.grv_P_list.Name = "grv_P_list";
            this.grv_P_list.RowHeadersWidth = 51;
            this.grv_P_list.RowTemplate.Height = 24;
            this.grv_P_list.Size = new System.Drawing.Size(1177, 168);
            this.grv_P_list.TabIndex = 10;
            // 
            // btn_P_back
            // 
            this.btn_P_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_P_back.Image")));
            this.btn_P_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_P_back.Location = new System.Drawing.Point(1585, 547);
            this.btn_P_back.Name = "btn_P_back";
            this.btn_P_back.Size = new System.Drawing.Size(141, 39);
            this.btn_P_back.TabIndex = 9;
            this.btn_P_back.Text = "   Back";
            this.btn_P_back.UseVisualStyleBackColor = true;
            this.btn_P_back.Click += new System.EventHandler(this.btn_P_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Division Project Implementation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_D_staffID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_D_projID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // cb_D_staffID
            // 
            this.cb_D_staffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_D_staffID.FormattingEnabled = true;
            this.cb_D_staffID.Location = new System.Drawing.Point(137, 105);
            this.cb_D_staffID.Name = "cb_D_staffID";
            this.cb_D_staffID.Size = new System.Drawing.Size(361, 28);
            this.cb_D_staffID.TabIndex = 17;
            this.cb_D_staffID.SelectedIndexChanged += new System.EventHandler(this.cb_D_staffID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Staff ID";
            // 
            // btn_D_add
            // 
            this.btn_D_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_D_add.Image")));
            this.btn_D_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_D_add.Location = new System.Drawing.Point(1420, 547);
            this.btn_D_add.Name = "btn_D_add";
            this.btn_D_add.Size = new System.Drawing.Size(141, 39);
            this.btn_D_add.TabIndex = 15;
            this.btn_D_add.Text = "   Add";
            this.btn_D_add.UseVisualStyleBackColor = true;
            this.btn_D_add.Click += new System.EventHandler(this.btn_D_add_Click);
            // 
            // cb_D_projID
            // 
            this.cb_D_projID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_D_projID.FormattingEnabled = true;
            this.cb_D_projID.Location = new System.Drawing.Point(137, 47);
            this.cb_D_projID.Name = "cb_D_projID";
            this.cb_D_projID.Size = new System.Drawing.Size(361, 28);
            this.cb_D_projID.TabIndex = 16;
            this.cb_D_projID.SelectedIndexChanged += new System.EventHandler(this.cb_D_projID_SelectedIndexChanged);
            // 
            // grv_D_list
            // 
            this.grv_D_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_D_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.grv_D_list.Location = new System.Drawing.Point(549, 319);
            this.grv_D_list.Name = "grv_D_list";
            this.grv_D_list.RowHeadersWidth = 51;
            this.grv_D_list.RowTemplate.Height = 24;
            this.grv_D_list.Size = new System.Drawing.Size(1177, 168);
            this.grv_D_list.TabIndex = 17;
            // 
            // lbl_noti
            // 
            this.lbl_noti.AutoSize = true;
            this.lbl_noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_noti.Location = new System.Drawing.Point(545, 490);
            this.lbl_noti.Name = "lbl_noti";
            this.lbl_noti.Size = new System.Drawing.Size(153, 20);
            this.lbl_noti.TabIndex = 18;
            this.lbl_noti.Text = "dasaaaaaaaaaaaaa";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenNV";
            this.Column2.HeaderText = "Staff Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 320;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "tenDA";
            this.Column1.HeaderText = "Project Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1738, 639);
            this.Controls.Add(this.lbl_noti);
            this.Controls.Add(this.grv_D_list);
            this.Controls.Add(this.btn_D_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grv_P_list);
            this.Controls.Add(this.btn_P_back);
            this.Controls.Add(this.label1);
            this.Name = "frmDivision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDivision";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDivision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_P_list)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_D_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grv_P_list;
        private System.Windows.Forms.Button btn_P_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_D_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_D_projID;
        private System.Windows.Forms.ComboBox cb_D_staffID;
        private System.Windows.Forms.DataGridView grv_D_list;
        private System.Windows.Forms.Label lbl_noti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}