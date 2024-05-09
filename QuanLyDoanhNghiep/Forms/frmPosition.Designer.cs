
namespace QuanLyDoanhNghiep.Forms
{
    partial class Position
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Position));
            this.grv_P_posList = new System.Windows.Forms.DataGridView();
            this.btn_P_back = new System.Windows.Forms.Button();
            this.btn_P_add = new System.Windows.Forms.Button();
            this.txt_P_posName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_P_posID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_corName = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_P_depList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_P_posList)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_P_posList
            // 
            this.grv_P_posList.AllowUserToAddRows = false;
            this.grv_P_posList.AllowUserToDeleteRows = false;
            this.grv_P_posList.AllowUserToResizeColumns = false;
            this.grv_P_posList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_P_posList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grv_P_posList.Location = new System.Drawing.Point(48, 281);
            this.grv_P_posList.Name = "grv_P_posList";
            this.grv_P_posList.RowHeadersWidth = 51;
            this.grv_P_posList.RowTemplate.Height = 24;
            this.grv_P_posList.Size = new System.Drawing.Size(929, 218);
            this.grv_P_posList.TabIndex = 15;
            this.grv_P_posList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grv_P_posList_MouseDoubleClick);
            // 
            // btn_P_back
            // 
            this.btn_P_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_P_back.Image")));
            this.btn_P_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_P_back.Location = new System.Drawing.Point(882, 526);
            this.btn_P_back.Name = "btn_P_back";
            this.btn_P_back.Size = new System.Drawing.Size(127, 39);
            this.btn_P_back.TabIndex = 14;
            this.btn_P_back.Text = "  Back";
            this.btn_P_back.UseVisualStyleBackColor = true;
            this.btn_P_back.Click += new System.EventHandler(this.btn_P_back_Click);
            // 
            // btn_P_add
            // 
            this.btn_P_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_P_add.Image")));
            this.btn_P_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_P_add.Location = new System.Drawing.Point(749, 526);
            this.btn_P_add.Name = "btn_P_add";
            this.btn_P_add.Size = new System.Drawing.Size(127, 39);
            this.btn_P_add.TabIndex = 13;
            this.btn_P_add.Text = "  Add";
            this.btn_P_add.UseVisualStyleBackColor = true;
            this.btn_P_add.Click += new System.EventHandler(this.btn_P_add_Click);
            // 
            // txt_P_posName
            // 
            this.txt_P_posName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P_posName.Location = new System.Drawing.Point(232, 227);
            this.txt_P_posName.Name = "txt_P_posName";
            this.txt_P_posName.Size = new System.Drawing.Size(220, 27);
            this.txt_P_posName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Position Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 69);
            this.label2.TabIndex = 10;
            this.label2.Text = "Position";
            // 
            // txt_P_posID
            // 
            this.txt_P_posID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P_posID.Location = new System.Drawing.Point(232, 167);
            this.txt_P_posID.Name = "txt_P_posID";
            this.txt_P_posID.Size = new System.Drawing.Size(220, 27);
            this.txt_P_posID.TabIndex = 9;
            this.txt_P_posID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_P_posID_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Position ID";
            // 
            // lbl_corName
            // 
            this.lbl_corName.AutoSize = true;
            this.lbl_corName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_corName.Location = new System.Drawing.Point(62, 88);
            this.lbl_corName.Name = "lbl_corName";
            this.lbl_corName.Size = new System.Drawing.Size(164, 46);
            this.lbl_corName.TabIndex = 16;
            this.lbl_corName.Text = "Position";
            this.lbl_corName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maCV";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tenCV";
            this.Column2.HeaderText = "Position Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Department";
            // 
            // cb_P_depList
            // 
            this.cb_P_depList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_P_depList.FormattingEnabled = true;
            this.cb_P_depList.Location = new System.Drawing.Point(664, 166);
            this.cb_P_depList.Name = "cb_P_depList";
            this.cb_P_depList.Size = new System.Drawing.Size(285, 28);
            this.cb_P_depList.TabIndex = 18;
            // 
            // Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 579);
            this.Controls.Add(this.cb_P_depList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_corName);
            this.Controls.Add(this.grv_P_posList);
            this.Controls.Add(this.btn_P_back);
            this.Controls.Add(this.btn_P_add);
            this.Controls.Add(this.txt_P_posName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_P_posID);
            this.Controls.Add(this.label1);
            this.Name = "Position";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPosition";
            this.Load += new System.EventHandler(this.Position_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_P_posList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grv_P_posList;
        private System.Windows.Forms.Button btn_P_back;
        private System.Windows.Forms.Button btn_P_add;
        private System.Windows.Forms.TextBox txt_P_posName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_P_posID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_corName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_P_depList;
    }
}