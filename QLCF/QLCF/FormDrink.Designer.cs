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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrink));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.data_Drink = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Drink)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deleteDrink
            // 
            this.btn_deleteDrink.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_deleteDrink.ForeColor = System.Drawing.Color.White;
            this.btn_deleteDrink.Location = new System.Drawing.Point(367, 6);
            this.btn_deleteDrink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deleteDrink.Name = "btn_deleteDrink";
            this.btn_deleteDrink.Size = new System.Drawing.Size(121, 27);
            this.btn_deleteDrink.TabIndex = 15;
            this.btn_deleteDrink.Text = "XÓA NƯỚC UỐNG";
            this.btn_deleteDrink.UseVisualStyleBackColor = false;
            this.btn_deleteDrink.Click += new System.EventHandler(this.btn_deleteDrink_Click);
            // 
            // btn_editDrink
            // 
            this.btn_editDrink.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_editDrink.ForeColor = System.Drawing.Color.White;
            this.btn_editDrink.Location = new System.Drawing.Point(242, 6);
            this.btn_editDrink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_editDrink.Name = "btn_editDrink";
            this.btn_editDrink.Size = new System.Drawing.Size(121, 27);
            this.btn_editDrink.TabIndex = 16;
            this.btn_editDrink.Text = "SỬA THÔNG TIN";
            this.btn_editDrink.UseVisualStyleBackColor = false;
            this.btn_editDrink.Click += new System.EventHandler(this.btn_editDrink_Click);
            // 
            // btn_addDrink
            // 
            this.btn_addDrink.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_addDrink.ForeColor = System.Drawing.Color.Transparent;
            this.btn_addDrink.Location = new System.Drawing.Point(117, 6);
            this.btn_addDrink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addDrink.Name = "btn_addDrink";
            this.btn_addDrink.Size = new System.Drawing.Size(121, 27);
            this.btn_addDrink.TabIndex = 17;
            this.btn_addDrink.Text = "THÊM NƯỚC UỐNG";
            this.btn_addDrink.UseVisualStyleBackColor = false;
            this.btn_addDrink.Click += new System.EventHandler(this.btn_addDrink_Click);
            // 
            // cbb_drinkState
            // 
            this.cbb_drinkState.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbb_drinkState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_drinkState.FormattingEnabled = true;
            this.cbb_drinkState.Items.AddRange(new object[] {
            "Đang bán",
            "Ngừng bán",
            "Sắp ra mắt"});
            this.cbb_drinkState.Location = new System.Drawing.Point(117, 122);
            this.cbb_drinkState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_drinkState.Name = "cbb_drinkState";
            this.cbb_drinkState.Size = new System.Drawing.Size(178, 21);
            this.cbb_drinkState.TabIndex = 14;
            // 
            // num_price
            // 
            this.num_price.Location = new System.Drawing.Point(119, 87);
            this.num_price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_price.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(175, 20);
            this.num_price.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá:";
            // 
            // txt_drinkName
            // 
            this.txt_drinkName.Location = new System.Drawing.Point(119, 52);
            this.txt_drinkName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_drinkName.Name = "txt_drinkName";
            this.txt_drinkName.Size = new System.Drawing.Size(176, 20);
            this.txt_drinkName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên nước uống:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_back.Location = new System.Drawing.Point(29, 8);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 25);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "QUAY LẠI";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // data_Drink
            // 
            this.data_Drink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Drink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Drink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dName,
            this.price,
            this.state});
            this.data_Drink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Drink.Location = new System.Drawing.Point(0, 169);
            this.data_Drink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_Drink.Name = "data_Drink";
            this.data_Drink.ReadOnly = true;
            this.data_Drink.RowTemplate.Height = 28;
            this.data_Drink.Size = new System.Drawing.Size(512, 270);
            this.data_Drink.TabIndex = 20;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // dName
            // 
            this.dName.DataPropertyName = "drinkName";
            this.dName.HeaderText = "Tên";
            this.dName.Name = "dName";
            this.dName.ReadOnly = true;
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
            // FormDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 439);
            this.Controls.Add(this.data_Drink);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormDrink";
            this.Text = "QUẢN LÝ NƯỚC UỐNG";
            this.Load += new System.EventHandler(this.FormDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Drink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView data_Drink;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}