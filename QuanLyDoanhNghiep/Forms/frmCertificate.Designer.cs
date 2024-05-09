
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificate));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_C_cerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_C_back = new System.Windows.Forms.Button();
            this.btn_C_add = new System.Windows.Forms.Button();
            this.grv_cerList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_C_push = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_C_contID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grv_cerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 69);
            this.label2.TabIndex = 22;
            this.label2.Text = "Certificate";
            // 
            // txt_C_cerName
            // 
            this.txt_C_cerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C_cerName.Location = new System.Drawing.Point(186, 158);
            this.txt_C_cerName.Name = "txt_C_cerName";
            this.txt_C_cerName.Size = new System.Drawing.Size(260, 27);
            this.txt_C_cerName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Certificate Name";
            // 
            // btn_C_back
            // 
            this.btn_C_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_C_back.Image")));
            this.btn_C_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_C_back.Location = new System.Drawing.Point(692, 400);
            this.btn_C_back.Name = "btn_C_back";
            this.btn_C_back.Size = new System.Drawing.Size(114, 38);
            this.btn_C_back.TabIndex = 30;
            this.btn_C_back.Text = "   Back";
            this.btn_C_back.UseVisualStyleBackColor = true;
            this.btn_C_back.Click += new System.EventHandler(this.btn_C_back_Click);
            // 
            // btn_C_add
            // 
            this.btn_C_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_C_add.Image")));
            this.btn_C_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_C_add.Location = new System.Drawing.Point(452, 400);
            this.btn_C_add.Name = "btn_C_add";
            this.btn_C_add.Size = new System.Drawing.Size(114, 38);
            this.btn_C_add.TabIndex = 29;
            this.btn_C_add.Text = "   Add";
            this.btn_C_add.UseVisualStyleBackColor = true;
            // 
            // grv_cerList
            // 
            this.grv_cerList.AllowUserToAddRows = false;
            this.grv_cerList.AllowUserToDeleteRows = false;
            this.grv_cerList.AllowUserToOrderColumns = true;
            this.grv_cerList.AllowUserToResizeColumns = false;
            this.grv_cerList.AllowUserToResizeRows = false;
            this.grv_cerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_cerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grv_cerList.Location = new System.Drawing.Point(14, 205);
            this.grv_cerList.Name = "grv_cerList";
            this.grv_cerList.RowHeadersWidth = 51;
            this.grv_cerList.RowTemplate.Height = 24;
            this.grv_cerList.Size = new System.Drawing.Size(792, 157);
            this.grv_cerList.TabIndex = 31;
            this.grv_cerList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_cerList_CellContentDoubleClick);
            this.grv_cerList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grv_cerList_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 72);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btn_C_push
            // 
            this.btn_C_push.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C_push.Image = ((System.Drawing.Image)(resources.GetObject("btn_C_push.Image")));
            this.btn_C_push.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_C_push.Location = new System.Drawing.Point(572, 400);
            this.btn_C_push.Name = "btn_C_push";
            this.btn_C_push.Size = new System.Drawing.Size(114, 38);
            this.btn_C_push.TabIndex = 33;
            this.btn_C_push.Text = "   Push";
            this.btn_C_push.UseVisualStyleBackColor = true;
            this.btn_C_push.Click += new System.EventHandler(this.btn_C_push_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "tenChungChi";
            this.Column1.HeaderText = "Certificate Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // txt_C_contID
            // 
            this.txt_C_contID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C_contID.Location = new System.Drawing.Point(186, 111);
            this.txt_C_contID.Name = "txt_C_contID";
            this.txt_C_contID.Size = new System.Drawing.Size(260, 27);
            this.txt_C_contID.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Contract ID";
            // 
            // frmCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.btn_C_push);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grv_cerList);
            this.Controls.Add(this.btn_C_back);
            this.Controls.Add(this.btn_C_add);
            this.Controls.Add(this.txt_C_contID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_C_cerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmCertificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate";
            this.Load += new System.EventHandler(this.frmCertificate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_cerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_C_cerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_C_back;
        private System.Windows.Forms.Button btn_C_add;
        private System.Windows.Forms.DataGridView grv_cerList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_C_push;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txt_C_contID;
        private System.Windows.Forms.Label label4;
    }
}