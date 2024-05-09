
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProject));
            this.txt_P_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grv_P_list = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_P_back = new System.Windows.Forms.Button();
            this.txt_P_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_P_addDetail = new System.Windows.Forms.Button();
            this.btn_P_add = new System.Windows.Forms.Button();
            this.btn_P_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_P_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_P_name
            // 
            this.txt_P_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_P_name.Location = new System.Drawing.Point(183, 178);
            this.txt_P_name.Name = "txt_P_name";
            this.txt_P_name.Size = new System.Drawing.Size(549, 27);
            this.txt_P_name.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(39, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(66, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Project ID";
            // 
            // grv_P_list
            // 
            this.grv_P_list.AllowUserToAddRows = false;
            this.grv_P_list.AllowUserToDeleteRows = false;
            this.grv_P_list.AllowUserToOrderColumns = true;
            this.grv_P_list.AllowUserToResizeColumns = false;
            this.grv_P_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_P_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grv_P_list.Location = new System.Drawing.Point(29, 232);
            this.grv_P_list.Name = "grv_P_list";
            this.grv_P_list.RowHeadersWidth = 51;
            this.grv_P_list.RowTemplate.Height = 24;
            this.grv_P_list.Size = new System.Drawing.Size(947, 264);
            this.grv_P_list.TabIndex = 10;
            this.grv_P_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_P_list_CellContentClick);
            this.grv_P_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grv_P_list_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maDA";
            this.Column1.HeaderText = "Project ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tenDA";
            this.Column2.HeaderText = "Project Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btn_P_back
            // 
            this.btn_P_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_P_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_P_back.Image")));
            this.btn_P_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_P_back.Location = new System.Drawing.Point(830, 527);
            this.btn_P_back.Name = "btn_P_back";
            this.btn_P_back.Size = new System.Drawing.Size(160, 39);
            this.btn_P_back.TabIndex = 9;
            this.btn_P_back.Text = "Back";
            this.btn_P_back.UseVisualStyleBackColor = true;
            this.btn_P_back.Click += new System.EventHandler(this.btn_P_back_Click);
            // 
            // txt_P_id
            // 
            this.txt_P_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_P_id.Location = new System.Drawing.Point(183, 105);
            this.txt_P_id.Name = "txt_P_id";
            this.txt_P_id.Size = new System.Drawing.Size(549, 27);
            this.txt_P_id.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Project List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 53);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_P_addDetail
            // 
            this.btn_P_addDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P_addDetail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_P_addDetail.Image = ((System.Drawing.Image)(resources.GetObject("btn_P_addDetail.Image")));
            this.btn_P_addDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_P_addDetail.Location = new System.Drawing.Point(740, 93);
            this.btn_P_addDetail.Name = "btn_P_addDetail";
            this.btn_P_addDetail.Size = new System.Drawing.Size(236, 39);
            this.btn_P_addDetail.TabIndex = 15;
            this.btn_P_addDetail.Text = "Add Project Detail";
            this.btn_P_addDetail.UseVisualStyleBackColor = true;
            this.btn_P_addDetail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_P_add
            // 
            this.btn_P_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_P_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_P_add.Image")));
            this.btn_P_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_P_add.Location = new System.Drawing.Point(664, 527);
            this.btn_P_add.Name = "btn_P_add";
            this.btn_P_add.Size = new System.Drawing.Size(160, 39);
            this.btn_P_add.TabIndex = 16;
            this.btn_P_add.Text = "    Add Project";
            this.btn_P_add.UseVisualStyleBackColor = true;
            this.btn_P_add.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_P_clear
            // 
            this.btn_P_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_P_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_P_clear.Image")));
            this.btn_P_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_P_clear.Location = new System.Drawing.Point(498, 528);
            this.btn_P_clear.Name = "btn_P_clear";
            this.btn_P_clear.Size = new System.Drawing.Size(160, 39);
            this.btn_P_clear.TabIndex = 17;
            this.btn_P_clear.Text = "Clear";
            this.btn_P_clear.UseVisualStyleBackColor = true;
            this.btn_P_clear.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 579);
            this.Controls.Add(this.btn_P_clear);
            this.Controls.Add(this.btn_P_add);
            this.Controls.Add(this.btn_P_addDetail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_P_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grv_P_list);
            this.Controls.Add(this.btn_P_back);
            this.Controls.Add(this.txt_P_id);
            this.Controls.Add(this.label1);
            this.Name = "frmProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProject";
            this.Load += new System.EventHandler(this.frmProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_P_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_P_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grv_P_list;
        private System.Windows.Forms.Button btn_P_back;
        private System.Windows.Forms.TextBox txt_P_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_P_addDetail;
        private System.Windows.Forms.Button btn_P_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_P_clear;
    }
}