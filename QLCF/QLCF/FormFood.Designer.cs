namespace QLCF
{
    partial class FormFood
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
            this.data_Food = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_foodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.cbb_foodState = new System.Windows.Forms.ComboBox();
            this.btn_deleteFood = new System.Windows.Forms.Button();
            this.btn_editFood = new System.Windows.Forms.Button();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý món ăn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // data_Food
            // 
            this.data_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Food.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Food.Location = new System.Drawing.Point(0, 300);
            this.data_Food.Name = "data_Food";
            this.data_Food.RowTemplate.Height = 28;
            this.data_Food.Size = new System.Drawing.Size(655, 150);
            this.data_Food.TabIndex = 1;
            this.data_Food.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Food_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên món ăn:";
            // 
            // txt_foodName
            // 
            this.txt_foodName.Location = new System.Drawing.Point(54, 90);
            this.txt_foodName.Name = "txt_foodName";
            this.txt_foodName.Size = new System.Drawing.Size(215, 26);
            this.txt_foodName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trạng thái:";
            // 
            // num_price
            // 
            this.num_price.Location = new System.Drawing.Point(54, 156);
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(215, 26);
            this.num_price.TabIndex = 4;
            // 
            // cbb_foodState
            // 
            this.cbb_foodState.FormattingEnabled = true;
            this.cbb_foodState.Items.AddRange(new object[] {
            "Đang bán",
            "Ngừng bán",
            "Sắp ra mắt"});
            this.cbb_foodState.Location = new System.Drawing.Point(54, 229);
            this.cbb_foodState.Name = "cbb_foodState";
            this.cbb_foodState.Size = new System.Drawing.Size(215, 28);
            this.cbb_foodState.TabIndex = 5;
            // 
            // btn_deleteFood
            // 
            this.btn_deleteFood.Enabled = false;
            this.btn_deleteFood.Location = new System.Drawing.Point(366, 227);
            this.btn_deleteFood.Name = "btn_deleteFood";
            this.btn_deleteFood.Size = new System.Drawing.Size(147, 41);
            this.btn_deleteFood.TabIndex = 6;
            this.btn_deleteFood.Text = "Xóa món ăn";
            this.btn_deleteFood.UseVisualStyleBackColor = true;
            // 
            // btn_editFood
            // 
            this.btn_editFood.Location = new System.Drawing.Point(366, 158);
            this.btn_editFood.Name = "btn_editFood";
            this.btn_editFood.Size = new System.Drawing.Size(147, 41);
            this.btn_editFood.TabIndex = 7;
            this.btn_editFood.Text = "Sửa thông tin";
            this.btn_editFood.UseVisualStyleBackColor = true;
            // 
            // btn_addFood
            // 
            this.btn_addFood.Location = new System.Drawing.Point(366, 90);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(147, 41);
            this.btn_addFood.TabIndex = 8;
            this.btn_addFood.Text = "Thêm món ăn";
            this.btn_addFood.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_back.Location = new System.Drawing.Point(517, 5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(126, 38);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // FormFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_deleteFood);
            this.Controls.Add(this.btn_editFood);
            this.Controls.Add(this.btn_addFood);
            this.Controls.Add(this.cbb_foodState);
            this.Controls.Add(this.num_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_foodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_Food);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormFood";
            this.Text = "                     ";
            this.Load += new System.EventHandler(this.FormFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_Food;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_foodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_price;
        private System.Windows.Forms.ComboBox cbb_foodState;
        private System.Windows.Forms.Button btn_deleteFood;
        private System.Windows.Forms.Button btn_editFood;
        private System.Windows.Forms.Button btn_addFood;
        private System.Windows.Forms.Button btn_back;
    }
}