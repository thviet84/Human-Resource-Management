
namespace QuanLyDoanhNghiep.Forms
{
    partial class Nation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nation));
            this.grv_N_natList = new System.Windows.Forms.DataGridView();
            this.btn_N_back = new System.Windows.Forms.Button();
            this.btn_N_add = new System.Windows.Forms.Button();
            this.txt_N_natName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_N_natList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_N_natList
            // 
            this.grv_N_natList.AllowUserToAddRows = false;
            this.grv_N_natList.AllowUserToDeleteRows = false;
            this.grv_N_natList.AllowUserToOrderColumns = true;
            this.grv_N_natList.AllowUserToResizeRows = false;
            this.grv_N_natList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_N_natList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grv_N_natList.Location = new System.Drawing.Point(37, 201);
            this.grv_N_natList.Name = "grv_N_natList";
            this.grv_N_natList.RowHeadersWidth = 51;
            this.grv_N_natList.RowTemplate.Height = 24;
            this.grv_N_natList.Size = new System.Drawing.Size(410, 159);
            this.grv_N_natList.TabIndex = 15;
            this.grv_N_natList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_N_natList_CellContentClick);
            // 
            // btn_N_back
            // 
            this.btn_N_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_N_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_N_back.Image")));
            this.btn_N_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_N_back.Location = new System.Drawing.Point(642, 402);
            this.btn_N_back.Name = "btn_N_back";
            this.btn_N_back.Size = new System.Drawing.Size(135, 36);
            this.btn_N_back.TabIndex = 14;
            this.btn_N_back.Text = "   Back";
            this.btn_N_back.UseVisualStyleBackColor = true;
            this.btn_N_back.Click += new System.EventHandler(this.btn_N_back_Click);
            // 
            // btn_N_add
            // 
            this.btn_N_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_N_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_N_add.Image")));
            this.btn_N_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_N_add.Location = new System.Drawing.Point(501, 402);
            this.btn_N_add.Name = "btn_N_add";
            this.btn_N_add.Size = new System.Drawing.Size(135, 36);
            this.btn_N_add.TabIndex = 13;
            this.btn_N_add.Text = "   Add";
            this.btn_N_add.UseVisualStyleBackColor = true;
            this.btn_N_add.Click += new System.EventHandler(this.btn_N_add_Click);
            // 
            // txt_N_natName
            // 
            this.txt_N_natName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_N_natName.Location = new System.Drawing.Point(190, 141);
            this.txt_N_natName.Name = "txt_N_natName";
            this.txt_N_natName.Size = new System.Drawing.Size(220, 27);
            this.txt_N_natName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nation Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 69);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenDT";
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 125;
            // 
            // Nation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grv_N_natList);
            this.Controls.Add(this.btn_N_back);
            this.Controls.Add(this.btn_N_add);
            this.Controls.Add(this.txt_N_natName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Nation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNation";
            this.Load += new System.EventHandler(this.Nation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_N_natList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grv_N_natList;
        private System.Windows.Forms.Button btn_N_back;
        private System.Windows.Forms.Button btn_N_add;
        private System.Windows.Forms.TextBox txt_N_natName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}