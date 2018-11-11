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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBranch));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.data_branch = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNumberExpect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.num_empExpect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_branch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chi nhánh:";
            // 
            // txt_branchName
            // 
            this.txt_branchName.Location = new System.Drawing.Point(167, 40);
            this.txt_branchName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_branchName.Name = "txt_branchName";
            this.txt_branchName.Size = new System.Drawing.Size(176, 20);
            this.txt_branchName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // txt_addressBranch
            // 
            this.txt_addressBranch.Location = new System.Drawing.Point(167, 70);
            this.txt_addressBranch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_addressBranch.Name = "txt_addressBranch";
            this.txt_addressBranch.Size = new System.Drawing.Size(176, 20);
            this.txt_addressBranch.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số nhân viên hiện tại:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số nhân viên dự kiến:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_addBranch
            // 
            this.btn_addBranch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_addBranch.ForeColor = System.Drawing.Color.White;
            this.btn_addBranch.Location = new System.Drawing.Point(113, 6);
            this.btn_addBranch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addBranch.Name = "btn_addBranch";
            this.btn_addBranch.Size = new System.Drawing.Size(103, 27);
            this.btn_addBranch.TabIndex = 4;
            this.btn_addBranch.Text = "THÊM CHI NHÁNH";
            this.btn_addBranch.UseVisualStyleBackColor = false;
            this.btn_addBranch.Click += new System.EventHandler(this.btn_addBranch_Click);
            // 
            // btn_editBranch
            // 
            this.btn_editBranch.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_editBranch.ForeColor = System.Drawing.Color.White;
            this.btn_editBranch.Location = new System.Drawing.Point(220, 6);
            this.btn_editBranch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_editBranch.Name = "btn_editBranch";
            this.btn_editBranch.Size = new System.Drawing.Size(103, 27);
            this.btn_editBranch.TabIndex = 4;
            this.btn_editBranch.Text = "SỬA THÔNG TIN";
            this.btn_editBranch.UseVisualStyleBackColor = false;
            this.btn_editBranch.Click += new System.EventHandler(this.btn_editBranch_Click);
            // 
            // btn_deleteBranch
            // 
            this.btn_deleteBranch.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_deleteBranch.ForeColor = System.Drawing.Color.White;
            this.btn_deleteBranch.Location = new System.Drawing.Point(327, 6);
            this.btn_deleteBranch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deleteBranch.Name = "btn_deleteBranch";
            this.btn_deleteBranch.Size = new System.Drawing.Size(103, 27);
            this.btn_deleteBranch.TabIndex = 4;
            this.btn_deleteBranch.Text = "XÓA CHI NHÁNH";
            this.btn_deleteBranch.UseVisualStyleBackColor = false;
            // 
            // num_empExpect
            // 
            this.num_empExpect.Location = new System.Drawing.Point(167, 102);
            this.num_empExpect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_empExpect.Name = "num_empExpect";
            this.num_empExpect.Size = new System.Drawing.Size(175, 20);
            this.num_empExpect.TabIndex = 5;
            // 
            // num_emp
            // 
            this.num_emp.Location = new System.Drawing.Point(167, 134);
            this.num_emp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_emp.Name = "num_emp";
            this.num_emp.Size = new System.Drawing.Size(175, 20);
            this.num_emp.TabIndex = 5;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_back.Location = new System.Drawing.Point(25, 8);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 25);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "QUAY LẠI";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // data_branch
            // 
            this.data_branch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_branch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_branch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.branchName,
            this.address,
            this.eNumber,
            this.eNumberExpect});
            this.data_branch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_branch.Location = new System.Drawing.Point(0, 177);
            this.data_branch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_branch.Name = "data_branch";
            this.data_branch.ReadOnly = true;
            this.data_branch.RowTemplate.Height = 28;
            this.data_branch.Size = new System.Drawing.Size(445, 249);
            this.data_branch.TabIndex = 12;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // branchName
            // 
            this.branchName.DataPropertyName = "branchName";
            this.branchName.HeaderText = "Chi nhánh";
            this.branchName.Name = "branchName";
            this.branchName.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // eNumber
            // 
            this.eNumber.DataPropertyName = "eNumber";
            this.eNumber.HeaderText = "Số nhân viên";
            this.eNumber.Name = "eNumber";
            this.eNumber.ReadOnly = true;
            // 
            // eNumberExpect
            // 
            this.eNumberExpect.DataPropertyName = "eNumberExpect";
            this.eNumberExpect.HeaderText = "Nhân viên dự kiến";
            this.eNumberExpect.Name = "eNumberExpect";
            this.eNumberExpect.ReadOnly = true;
            // 
            // FormBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 426);
            this.Controls.Add(this.data_branch);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormBranch";
            this.Text = "QUẢN LÝ CHI NHÁNH";
            this.Load += new System.EventHandler(this.FormBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_empExpect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_branch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView data_branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNumberExpect;
    }
}