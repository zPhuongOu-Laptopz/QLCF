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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFood));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.data_Food = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Food)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên món ăn:";
            // 
            // txt_foodName
            // 
            this.txt_foodName.Location = new System.Drawing.Point(131, 49);
            this.txt_foodName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_foodName.Name = "txt_foodName";
            this.txt_foodName.Size = new System.Drawing.Size(176, 20);
            this.txt_foodName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trạng thái:";
            // 
            // num_price
            // 
            this.num_price.Location = new System.Drawing.Point(131, 77);
            this.num_price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_price.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(175, 20);
            this.num_price.TabIndex = 4;
            // 
            // cbb_foodState
            // 
            this.cbb_foodState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_foodState.FormattingEnabled = true;
            this.cbb_foodState.Items.AddRange(new object[] {
            "Đang bán",
            "Ngừng bán",
            "Sắp ra mắt"});
            this.cbb_foodState.Location = new System.Drawing.Point(131, 109);
            this.cbb_foodState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_foodState.Name = "cbb_foodState";
            this.cbb_foodState.Size = new System.Drawing.Size(176, 21);
            this.cbb_foodState.TabIndex = 5;
            // 
            // btn_deleteFood
            // 
            this.btn_deleteFood.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_deleteFood.Enabled = false;
            this.btn_deleteFood.ForeColor = System.Drawing.Color.White;
            this.btn_deleteFood.Location = new System.Drawing.Point(379, 8);
            this.btn_deleteFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deleteFood.Name = "btn_deleteFood";
            this.btn_deleteFood.Size = new System.Drawing.Size(123, 27);
            this.btn_deleteFood.TabIndex = 6;
            this.btn_deleteFood.Text = "XÓA MÓN ĂN";
            this.btn_deleteFood.UseVisualStyleBackColor = false;
            // 
            // btn_editFood
            // 
            this.btn_editFood.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_editFood.ForeColor = System.Drawing.Color.White;
            this.btn_editFood.Location = new System.Drawing.Point(252, 8);
            this.btn_editFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_editFood.Name = "btn_editFood";
            this.btn_editFood.Size = new System.Drawing.Size(123, 27);
            this.btn_editFood.TabIndex = 7;
            this.btn_editFood.Text = "SỬA THÔNG TIN";
            this.btn_editFood.UseVisualStyleBackColor = false;
            this.btn_editFood.Click += new System.EventHandler(this.btn_editFood_Click);
            // 
            // btn_addFood
            // 
            this.btn_addFood.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_addFood.ForeColor = System.Drawing.Color.White;
            this.btn_addFood.Location = new System.Drawing.Point(125, 7);
            this.btn_addFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(123, 27);
            this.btn_addFood.TabIndex = 8;
            this.btn_addFood.Text = "THÊM MÓN ĂN";
            this.btn_addFood.UseVisualStyleBackColor = false;
            this.btn_addFood.Click += new System.EventHandler(this.btn_addFood_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_back.Location = new System.Drawing.Point(37, 8);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 25);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(546, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // data_Food
            // 
            this.data_Food.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Food.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.food,
            this.price,
            this.state});
            this.data_Food.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Food.Location = new System.Drawing.Point(0, 161);
            this.data_Food.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_Food.Name = "data_Food";
            this.data_Food.ReadOnly = true;
            this.data_Food.RowTemplate.Height = 28;
            this.data_Food.Size = new System.Drawing.Size(546, 278);
            this.data_Food.TabIndex = 11;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // food
            // 
            this.food.DataPropertyName = "foodName";
            this.food.HeaderText = "Tên";
            this.food.Name = "food";
            this.food.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "Trạng thái";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // FormFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 439);
            this.Controls.Add(this.data_Food);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormFood";
            this.Text = "QUẢN LÝ MÓN ĂN";
            this.Load += new System.EventHandler(this.FormFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView data_Food;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn food;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}