namespace QLCF
{
    partial class FormDrink
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
            this.data_Drink = new System.Windows.Forms.DataGridView();
            this.btn_deleteDrink = new System.Windows.Forms.Button();
            this.btn_editDrink = new System.Windows.Forms.Button();
            this.btn_addDrink = new System.Windows.Forms.Button();
            this.cbb_drinkState = new System.Windows.Forms.ComboBox();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_drinkName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Drink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nước uống";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // data_Drink
            // 
            this.data_Drink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Drink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Drink.Location = new System.Drawing.Point(0, 300);
            this.data_Drink.Name = "data_Drink";
            this.data_Drink.RowTemplate.Height = 28;
            this.data_Drink.Size = new System.Drawing.Size(605, 150);
            this.data_Drink.TabIndex = 1;
            this.data_Drink.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Drink_CellClick);
            // 
            // btn_deleteDrink
            // 
            this.btn_deleteDrink.Enabled = false;
            this.btn_deleteDrink.Location = new System.Drawing.Point(349, 222);
            this.btn_deleteDrink.Name = "btn_deleteDrink";
            this.btn_deleteDrink.Size = new System.Drawing.Size(147, 41);
            this.btn_deleteDrink.TabIndex = 15;
            this.btn_deleteDrink.Text = "Xóa nước uống";
            this.btn_deleteDrink.UseVisualStyleBackColor = true;
            // 
            // btn_editDrink
            // 
            this.btn_editDrink.Location = new System.Drawing.Point(349, 153);
            this.btn_editDrink.Name = "btn_editDrink";
            this.btn_editDrink.Size = new System.Drawing.Size(147, 41);
            this.btn_editDrink.TabIndex = 16;
            this.btn_editDrink.Text = "Sửa thông tin";
            this.btn_editDrink.UseVisualStyleBackColor = true;
            // 
            // btn_addDrink
            // 
            this.btn_addDrink.Location = new System.Drawing.Point(349, 85);
            this.btn_addDrink.Name = "btn_addDrink";
            this.btn_addDrink.Size = new System.Drawing.Size(147, 41);
            this.btn_addDrink.TabIndex = 17;
            this.btn_addDrink.Text = "Thêm nước uống\r\n";
            this.btn_addDrink.UseVisualStyleBackColor = true;
            // 
            // cbb_drinkState
            // 
            this.cbb_drinkState.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbb_drinkState.FormattingEnabled = true;
            this.cbb_drinkState.Items.AddRange(new object[] {
            "Đang bán",
            "Ngừng bán",
            "Sắp ra mắt"});
            this.cbb_drinkState.Location = new System.Drawing.Point(37, 224);
            this.cbb_drinkState.Name = "cbb_drinkState";
            this.cbb_drinkState.Size = new System.Drawing.Size(215, 28);
            this.cbb_drinkState.TabIndex = 14;
            // 
            // num_price
            // 
            this.num_price.Location = new System.Drawing.Point(37, 151);
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(215, 26);
            this.num_price.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá:";
            // 
            // txt_drinkName
            // 
            this.txt_drinkName.Location = new System.Drawing.Point(37, 85);
            this.txt_drinkName.Name = "txt_drinkName";
            this.txt_drinkName.Size = new System.Drawing.Size(215, 26);
            this.txt_drinkName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên nước uống:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_back.Location = new System.Drawing.Point(479, 11);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(126, 38);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // FormDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_deleteDrink);
            this.Controls.Add(this.btn_editDrink);
            this.Controls.Add(this.btn_addDrink);
            this.Controls.Add(this.cbb_drinkState);
            this.Controls.Add(this.num_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_drinkName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_Drink);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormDrink";
            this.Text = "FormDrink";
            this.Load += new System.EventHandler(this.FormDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Drink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_Drink;
        private System.Windows.Forms.Button btn_deleteDrink;
        private System.Windows.Forms.Button btn_editDrink;
        private System.Windows.Forms.Button btn_addDrink;
        private System.Windows.Forms.ComboBox cbb_drinkState;
        private System.Windows.Forms.NumericUpDown num_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_drinkName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
    }
}