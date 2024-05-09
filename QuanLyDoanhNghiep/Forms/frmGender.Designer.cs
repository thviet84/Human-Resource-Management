
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmGender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGender));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_G_genName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_G_add = new System.Windows.Forms.Button();
            this.btn_G_back = new System.Windows.Forms.Button();
            this.grv_G_genList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_G_genList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // txt_G_genName
            // 
            this.txt_G_genName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_G_genName.Location = new System.Drawing.Point(186, 182);
            this.txt_G_genName.Name = "txt_G_genName";
            this.txt_G_genName.Size = new System.Drawing.Size(220, 27);
            this.txt_G_genName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender Name";
            // 
            // btn_G_add
            // 
            this.btn_G_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_G_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_G_add.Image")));
            this.btn_G_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_G_add.Location = new System.Drawing.Point(559, 397);
            this.btn_G_add.Name = "btn_G_add";
            this.btn_G_add.Size = new System.Drawing.Size(108, 41);
            this.btn_G_add.TabIndex = 5;
            this.btn_G_add.Text = "   Add";
            this.btn_G_add.UseVisualStyleBackColor = true;
            this.btn_G_add.Click += new System.EventHandler(this.btn_G_add_Click);
            // 
            // btn_G_back
            // 
            this.btn_G_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_G_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_G_back.Image")));
            this.btn_G_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_G_back.Location = new System.Drawing.Point(680, 397);
            this.btn_G_back.Name = "btn_G_back";
            this.btn_G_back.Size = new System.Drawing.Size(108, 41);
            this.btn_G_back.TabIndex = 6;
            this.btn_G_back.Text = "   Back";
            this.btn_G_back.UseVisualStyleBackColor = true;
            this.btn_G_back.Click += new System.EventHandler(this.btn_G_back_Click);
            // 
            // grv_G_genList
            // 
            this.grv_G_genList.AllowUserToAddRows = false;
            this.grv_G_genList.AllowUserToDeleteRows = false;
            this.grv_G_genList.AllowUserToOrderColumns = true;
            this.grv_G_genList.AllowUserToResizeColumns = false;
            this.grv_G_genList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_G_genList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.grv_G_genList.Location = new System.Drawing.Point(50, 236);
            this.grv_G_genList.Name = "grv_G_genList";
            this.grv_G_genList.RowHeadersWidth = 51;
            this.grv_G_genList.RowTemplate.Height = 24;
            this.grv_G_genList.Size = new System.Drawing.Size(416, 159);
            this.grv_G_genList.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 74);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenGT";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 125;
            // 
            // frmGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grv_G_genList);
            this.Controls.Add(this.btn_G_back);
            this.Controls.Add(this.btn_G_add);
            this.Controls.Add(this.txt_G_genName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmGender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gender";
            this.Load += new System.EventHandler(this.frmGender_Load);
            this.VisibleChanged += new System.EventHandler(this.frmGender_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.grv_G_genList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_G_genName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_G_add;
        private System.Windows.Forms.Button btn_G_back;
        private System.Windows.Forms.DataGridView grv_G_genList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}