
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dep_depName = new System.Windows.Forms.TextBox();
            this.txt_dep_depID = new System.Windows.Forms.TextBox();
            this.grv_D_depList = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_D_delete = new System.Windows.Forms.Button();
            this.btn_D_cancel = new System.Windows.Forms.Button();
            this.btn_D_update = new System.Windows.Forms.Button();
            this.btn_D_edit = new System.Windows.Forms.Button();
            this.btn_dep_add = new System.Windows.Forms.Button();
            this.btn_dep_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_D_depList)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 69);
            this.label3.TabIndex = 24;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Department ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Department Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_dep_depName
            // 
            this.txt_dep_depName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dep_depName.Location = new System.Drawing.Point(199, 171);
            this.txt_dep_depName.Name = "txt_dep_depName";
            this.txt_dep_depName.Size = new System.Drawing.Size(249, 27);
            this.txt_dep_depName.TabIndex = 30;
            // 
            // txt_dep_depID
            // 
            this.txt_dep_depID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dep_depID.Location = new System.Drawing.Point(199, 112);
            this.txt_dep_depID.Name = "txt_dep_depID";
            this.txt_dep_depID.Size = new System.Drawing.Size(249, 27);
            this.txt_dep_depID.TabIndex = 31;
            // 
            // grv_D_depList
            // 
            this.grv_D_depList.AllowUserToAddRows = false;
            this.grv_D_depList.AllowUserToDeleteRows = false;
            this.grv_D_depList.AllowUserToResizeColumns = false;
            this.grv_D_depList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_D_depList.Location = new System.Drawing.Point(470, 85);
            this.grv_D_depList.Name = "grv_D_depList";
            this.grv_D_depList.RowHeadersVisible = false;
            this.grv_D_depList.RowHeadersWidth = 51;
            this.grv_D_depList.RowTemplate.Height = 24;
            this.grv_D_depList.Size = new System.Drawing.Size(526, 298);
            this.grv_D_depList.TabIndex = 33;
            this.grv_D_depList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_D_depList_CellContentClick);
            this.grv_D_depList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grv_D_depList_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 22);
            this.textBox1.TabIndex = 38;
            this.textBox1.Visible = false;
            // 
            // btn_D_delete
            // 
            this.btn_D_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D_delete.Image = global::QuanLyDoanhNghiep.Properties.Resources.delete;
            this.btn_D_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_D_delete.Location = new System.Drawing.Point(470, 403);
            this.btn_D_delete.Name = "btn_D_delete";
            this.btn_D_delete.Size = new System.Drawing.Size(127, 40);
            this.btn_D_delete.TabIndex = 40;
            this.btn_D_delete.Text = "Delete";
            this.btn_D_delete.UseVisualStyleBackColor = true;
            this.btn_D_delete.Click += new System.EventHandler(this.btn_D_delete_Click);
            // 
            // btn_D_cancel
            // 
            this.btn_D_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_D_cancel.Image")));
            this.btn_D_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_D_cancel.Location = new System.Drawing.Point(471, 458);
            this.btn_D_cancel.Name = "btn_D_cancel";
            this.btn_D_cancel.Size = new System.Drawing.Size(127, 40);
            this.btn_D_cancel.TabIndex = 39;
            this.btn_D_cancel.Text = "   Cancel";
            this.btn_D_cancel.UseVisualStyleBackColor = true;
            this.btn_D_cancel.Visible = false;
            this.btn_D_cancel.Click += new System.EventHandler(this.btn_D_cancel_Click);
            // 
            // btn_D_update
            // 
            this.btn_D_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_D_update.Image")));
            this.btn_D_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_D_update.Location = new System.Drawing.Point(604, 458);
            this.btn_D_update.Name = "btn_D_update";
            this.btn_D_update.Size = new System.Drawing.Size(127, 40);
            this.btn_D_update.TabIndex = 37;
            this.btn_D_update.Text = "   Update";
            this.btn_D_update.UseVisualStyleBackColor = true;
            this.btn_D_update.Visible = false;
            this.btn_D_update.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_D_edit
            // 
            this.btn_D_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_D_edit.Image")));
            this.btn_D_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_D_edit.Location = new System.Drawing.Point(604, 403);
            this.btn_D_edit.Name = "btn_D_edit";
            this.btn_D_edit.Size = new System.Drawing.Size(127, 40);
            this.btn_D_edit.TabIndex = 36;
            this.btn_D_edit.Text = "  Edit";
            this.btn_D_edit.UseVisualStyleBackColor = true;
            this.btn_D_edit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_dep_add
            // 
            this.btn_dep_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dep_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_dep_add.Image")));
            this.btn_dep_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dep_add.Location = new System.Drawing.Point(737, 403);
            this.btn_dep_add.Name = "btn_dep_add";
            this.btn_dep_add.Size = new System.Drawing.Size(127, 40);
            this.btn_dep_add.TabIndex = 32;
            this.btn_dep_add.Text = "  Add";
            this.btn_dep_add.UseVisualStyleBackColor = true;
            this.btn_dep_add.Click += new System.EventHandler(this.btn_dep_add_Click);
            // 
            // btn_dep_back
            // 
            this.btn_dep_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dep_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_dep_back.Image")));
            this.btn_dep_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dep_back.Location = new System.Drawing.Point(869, 403);
            this.btn_dep_back.Name = "btn_dep_back";
            this.btn_dep_back.Size = new System.Drawing.Size(127, 40);
            this.btn_dep_back.TabIndex = 27;
            this.btn_dep_back.Text = "   Back";
            this.btn_dep_back.UseVisualStyleBackColor = true;
            this.btn_dep_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 542);
            this.Controls.Add(this.btn_D_delete);
            this.Controls.Add(this.btn_D_cancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_D_update);
            this.Controls.Add(this.btn_D_edit);
            this.Controls.Add(this.grv_D_depList);
            this.Controls.Add(this.btn_dep_add);
            this.Controls.Add(this.txt_dep_depID);
            this.Controls.Add(this.txt_dep_depName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dep_back);
            this.Controls.Add(this.label3);
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_D_depList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dep_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dep_depName;
        private System.Windows.Forms.TextBox txt_dep_depID;
        private System.Windows.Forms.Button btn_dep_add;
        private System.Windows.Forms.DataGridView grv_D_depList;
        private System.Windows.Forms.Button btn_D_edit;
        private System.Windows.Forms.Button btn_D_update;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_D_cancel;
        private System.Windows.Forms.Button btn_D_delete;
    }
}