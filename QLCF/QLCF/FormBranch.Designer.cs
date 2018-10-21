namespace QLCF
{
    partial class FormBranch
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
            this.label1 = new System.Windows.Forms.Label();
            this.data_branch = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_branchName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_addressBranch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_addBranch = new System.Windows.Forms.Button();
            this.btn_editBranch = new System.Windows.Forms.Button();
            this.btn_deleteBranch = new System.Windows.Forms.Button();
            this.num_empExpect = new System.Windows.Forms.NumericUpDown();
            this.num_emp = new System.Windows.Forms.NumericUpDown();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_branch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_empExpect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý chi nhánh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // data_branch
            // 
            this.data_branch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_branch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_branch.Location = new System.Drawing.Point(0, 273);
            this.data_branch.Name = "data_branch";
            this.data_branch.RowTemplate.Height = 28;
            this.data_branch.Size = new System.Drawing.Size(800, 177);
            this.data_branch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chi nhánh:";
            // 
            // txt_branchName
            // 
            this.txt_branchName.Location = new System.Drawing.Point(39, 89);
            this.txt_branchName.Name = "txt_branchName";
            this.txt_branchName.Size = new System.Drawing.Size(209, 26);
            this.txt_branchName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // txt_addressBranch
            // 
            this.txt_addressBranch.Location = new System.Drawing.Point(39, 157);
            this.txt_addressBranch.Name = "txt_addressBranch";
            this.txt_addressBranch.Size = new System.Drawing.Size(209, 26);
            this.txt_addressBranch.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số nhân viên hiện tại:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số nhân viên dự kiến:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_addBranch
            // 
            this.btn_addBranch.Location = new System.Drawing.Point(562, 74);
            this.btn_addBranch.Name = "btn_addBranch";
            this.btn_addBranch.Size = new System.Drawing.Size(147, 41);
            this.btn_addBranch.TabIndex = 4;
            this.btn_addBranch.Text = "Thêm chi nhánh";
            this.btn_addBranch.UseVisualStyleBackColor = true;
            // 
            // btn_editBranch
            // 
            this.btn_editBranch.Location = new System.Drawing.Point(562, 142);
            this.btn_editBranch.Name = "btn_editBranch";
            this.btn_editBranch.Size = new System.Drawing.Size(147, 41);
            this.btn_editBranch.TabIndex = 4;
            this.btn_editBranch.Text = "Sửa thông tin";
            this.btn_editBranch.UseVisualStyleBackColor = true;
            // 
            // btn_deleteBranch
            // 
            this.btn_deleteBranch.Location = new System.Drawing.Point(562, 211);
            this.btn_deleteBranch.Name = "btn_deleteBranch";
            this.btn_deleteBranch.Size = new System.Drawing.Size(147, 41);
            this.btn_deleteBranch.TabIndex = 4;
            this.btn_deleteBranch.Text = "Xóa chi nhánh";
            this.btn_deleteBranch.UseVisualStyleBackColor = true;
            // 
            // num_empExpect
            // 
            this.num_empExpect.Location = new System.Drawing.Point(295, 90);
            this.num_empExpect.Name = "num_empExpect";
            this.num_empExpect.Size = new System.Drawing.Size(209, 26);
            this.num_empExpect.TabIndex = 5;
            // 
            // num_emp
            // 
            this.num_emp.Location = new System.Drawing.Point(295, 158);
            this.num_emp.Name = "num_emp";
            this.num_emp.Size = new System.Drawing.Size(209, 26);
            this.num_emp.TabIndex = 5;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_back.Location = new System.Drawing.Point(662, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(126, 38);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // FormBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.num_emp);
            this.Controls.Add(this.num_empExpect);
            this.Controls.Add(this.btn_deleteBranch);
            this.Controls.Add(this.btn_editBranch);
            this.Controls.Add(this.btn_addBranch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_addressBranch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_branchName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_branch);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormBranch";
            this.Text = "FormBranch";
            this.Load += new System.EventHandler(this.FormBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_branch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_empExpect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_branch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_branchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_addressBranch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_addBranch;
        private System.Windows.Forms.Button btn_editBranch;
        private System.Windows.Forms.Button btn_deleteBranch;
        private System.Windows.Forms.NumericUpDown num_empExpect;
        private System.Windows.Forms.NumericUpDown num_emp;
        private System.Windows.Forms.Button btn_back;
    }
}