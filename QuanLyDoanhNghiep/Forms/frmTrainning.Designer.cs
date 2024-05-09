
namespace QuanLyDoanhNghiep.Forms
{
    partial class frmTrainning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrainning));
            this.txt_T_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_T_userID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_T_trainingName = new System.Windows.Forms.TextBox();
            this.txt_T_result = new System.Windows.Forms.TextBox();
            this.txt_T_time = new System.Windows.Forms.TextBox();
            this.txt_T_trainingID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_R_clear = new System.Windows.Forms.Button();
            this.btn_R_cancel = new System.Windows.Forms.Button();
            this.btn_R_update = new System.Windows.Forms.Button();
            this.btn_R_edit = new System.Windows.Forms.Button();
            this.btn_R_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_T_username
            // 
            this.txt_T_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_T_username.Location = new System.Drawing.Point(111, 167);
            this.txt_T_username.Name = "txt_T_username";
            this.txt_T_username.Size = new System.Drawing.Size(240, 27);
            this.txt_T_username.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Name";
            // 
            // txt_T_userID
            // 
            this.txt_T_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_T_userID.Location = new System.Drawing.Point(111, 118);
            this.txt_T_userID.Name = "txt_T_userID";
            this.txt_T_userID.Size = new System.Drawing.Size(240, 27);
            this.txt_T_userID.TabIndex = 7;
            this.txt_T_userID.TextChanged += new System.EventHandler(this.txt_T_userID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "User ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_T_trainingName);
            this.groupBox1.Controls.Add(this.txt_T_result);
            this.groupBox1.Controls.Add(this.txt_T_time);
            this.groupBox1.Controls.Add(this.txt_T_trainingID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 199);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training Information";
            // 
            // txt_T_trainingName
            // 
            this.txt_T_trainingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_T_trainingName.Location = new System.Drawing.Point(107, 68);
            this.txt_T_trainingName.Name = "txt_T_trainingName";
            this.txt_T_trainingName.Size = new System.Drawing.Size(298, 27);
            this.txt_T_trainingName.TabIndex = 12;
            // 
            // txt_T_result
            // 
            this.txt_T_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_T_result.Location = new System.Drawing.Point(107, 147);
            this.txt_T_result.Name = "txt_T_result";
            this.txt_T_result.Size = new System.Drawing.Size(298, 27);
            this.txt_T_result.TabIndex = 11;
            // 
            // txt_T_time
            // 
            this.txt_T_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_T_time.Location = new System.Drawing.Point(107, 111);
            this.txt_T_time.Name = "txt_T_time";
            this.txt_T_time.Size = new System.Drawing.Size(298, 27);
            this.txt_T_time.TabIndex = 10;
            // 
            // txt_T_trainingID
            // 
            this.txt_T_trainingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_T_trainingID.Location = new System.Drawing.Point(107, 31);
            this.txt_T_trainingID.Name = "txt_T_trainingID";
            this.txt_T_trainingID.Size = new System.Drawing.Size(298, 27);
            this.txt_T_trainingID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_R_clear
            // 
            this.btn_R_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_R_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_R_clear.Image")));
            this.btn_R_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R_clear.Location = new System.Drawing.Point(607, 536);
            this.btn_R_clear.Name = "btn_R_clear";
            this.btn_R_clear.Size = new System.Drawing.Size(96, 36);
            this.btn_R_clear.TabIndex = 19;
            this.btn_R_clear.Text = "   Clear";
            this.btn_R_clear.UseVisualStyleBackColor = true;
            this.btn_R_clear.Visible = false;
            // 
            // btn_R_cancel
            // 
            this.btn_R_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_R_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_R_cancel.Image")));
            this.btn_R_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R_cancel.Location = new System.Drawing.Point(505, 536);
            this.btn_R_cancel.Name = "btn_R_cancel";
            this.btn_R_cancel.Size = new System.Drawing.Size(96, 36);
            this.btn_R_cancel.TabIndex = 18;
            this.btn_R_cancel.Text = "    Cancel";
            this.btn_R_cancel.UseVisualStyleBackColor = true;
            this.btn_R_cancel.Visible = false;
            this.btn_R_cancel.Click += new System.EventHandler(this.btn_R_cancel_Click);
            // 
            // btn_R_update
            // 
            this.btn_R_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_R_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_R_update.Image")));
            this.btn_R_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R_update.Location = new System.Drawing.Point(709, 536);
            this.btn_R_update.Name = "btn_R_update";
            this.btn_R_update.Size = new System.Drawing.Size(96, 36);
            this.btn_R_update.TabIndex = 17;
            this.btn_R_update.Text = "    Update";
            this.btn_R_update.UseVisualStyleBackColor = true;
            this.btn_R_update.Visible = false;
            // 
            // btn_R_edit
            // 
            this.btn_R_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_R_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_R_edit.Image")));
            this.btn_R_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R_edit.Location = new System.Drawing.Point(849, 536);
            this.btn_R_edit.Name = "btn_R_edit";
            this.btn_R_edit.Size = new System.Drawing.Size(96, 36);
            this.btn_R_edit.TabIndex = 16;
            this.btn_R_edit.Text = "   Edit";
            this.btn_R_edit.UseVisualStyleBackColor = true;
            // 
            // btn_R_back
            // 
            this.btn_R_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_R_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_R_back.Image")));
            this.btn_R_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R_back.Location = new System.Drawing.Point(954, 536);
            this.btn_R_back.Name = "btn_R_back";
            this.btn_R_back.Size = new System.Drawing.Size(96, 36);
            this.btn_R_back.TabIndex = 15;
            this.btn_R_back.Text = "  Back";
            this.btn_R_back.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(500, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 269);
            this.dataGridView1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 69);
            this.label9.TabIndex = 25;
            this.label9.Text = "Training";
            // 
            // frmTrainning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 587);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_R_clear);
            this.Controls.Add(this.btn_R_cancel);
            this.Controls.Add(this.btn_R_update);
            this.Controls.Add(this.btn_R_edit);
            this.Controls.Add(this.btn_R_back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_T_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_T_userID);
            this.Controls.Add(this.label1);
            this.Name = "frmTrainning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Trainning";
            this.Load += new System.EventHandler(this.frmTrainning_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_T_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_T_userID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_T_trainingName;
        private System.Windows.Forms.TextBox txt_T_result;
        private System.Windows.Forms.TextBox txt_T_time;
        private System.Windows.Forms.TextBox txt_T_trainingID;
        private System.Windows.Forms.Button btn_R_clear;
        private System.Windows.Forms.Button btn_R_cancel;
        private System.Windows.Forms.Button btn_R_update;
        private System.Windows.Forms.Button btn_R_edit;
        private System.Windows.Forms.Button btn_R_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
    }
}