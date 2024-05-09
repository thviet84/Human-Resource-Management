
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmTrainCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrainCategories));
            this.label3 = new System.Windows.Forms.Label();
            this.grv_TC_catList = new System.Windows.Forms.DataGridView();
            this.btn_TC_add = new System.Windows.Forms.Button();
            this.btn_TC_back = new System.Windows.Forms.Button();
            this.txt_TC_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TC_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_TC_catList)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 69);
            this.label3.TabIndex = 24;
            this.label3.Text = "Train Categories";
            // 
            // grv_TC_catList
            // 
            this.grv_TC_catList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_TC_catList.Location = new System.Drawing.Point(57, 234);
            this.grv_TC_catList.Name = "grv_TC_catList";
            this.grv_TC_catList.RowHeadersWidth = 51;
            this.grv_TC_catList.RowTemplate.Height = 24;
            this.grv_TC_catList.Size = new System.Drawing.Size(687, 149);
            this.grv_TC_catList.TabIndex = 32;
            // 
            // btn_TC_add
            // 
            this.btn_TC_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TC_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_TC_add.Image")));
            this.btn_TC_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TC_add.Location = new System.Drawing.Point(529, 421);
            this.btn_TC_add.Name = "btn_TC_add";
            this.btn_TC_add.Size = new System.Drawing.Size(117, 36);
            this.btn_TC_add.TabIndex = 31;
            this.btn_TC_add.Text = "   Add";
            this.btn_TC_add.UseVisualStyleBackColor = true;
            // 
            // btn_TC_back
            // 
            this.btn_TC_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TC_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_TC_back.Image")));
            this.btn_TC_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TC_back.Location = new System.Drawing.Point(652, 421);
            this.btn_TC_back.Name = "btn_TC_back";
            this.btn_TC_back.Size = new System.Drawing.Size(117, 36);
            this.btn_TC_back.TabIndex = 30;
            this.btn_TC_back.Text = "   Back";
            this.btn_TC_back.UseVisualStyleBackColor = true;
            // 
            // txt_TC_name
            // 
            this.txt_TC_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TC_name.Location = new System.Drawing.Point(204, 168);
            this.txt_TC_name.Name = "txt_TC_name";
            this.txt_TC_name.Size = new System.Drawing.Size(481, 27);
            this.txt_TC_name.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Category ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_TC_id
            // 
            this.txt_TC_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TC_id.Location = new System.Drawing.Point(204, 108);
            this.txt_TC_id.Name = "txt_TC_id";
            this.txt_TC_id.Size = new System.Drawing.Size(181, 27);
            this.txt_TC_id.TabIndex = 26;
            // 
            // frmTrainCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 469);
            this.Controls.Add(this.grv_TC_catList);
            this.Controls.Add(this.btn_TC_add);
            this.Controls.Add(this.btn_TC_back);
            this.Controls.Add(this.txt_TC_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TC_id);
            this.Controls.Add(this.label3);
            this.Name = "frmTrainCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train Categories";
            ((System.ComponentModel.ISupportInitialize)(this.grv_TC_catList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grv_TC_catList;
        private System.Windows.Forms.Button btn_TC_add;
        private System.Windows.Forms.Button btn_TC_back;
        private System.Windows.Forms.TextBox txt_TC_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TC_id;
    }
}