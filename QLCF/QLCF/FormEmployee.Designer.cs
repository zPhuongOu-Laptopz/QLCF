namespace QLCF
{
    partial class FormEmployee
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
            this.data_Emp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_idCardNumber = new System.Windows.Forms.TextBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.cbb_homeTown = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_state = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cbb_branch = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp_daystart = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtp_dayend = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_basicSalary = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_bonus = new System.Windows.Forms.TextBox();
            this.cbb_position = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1149, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // data_Emp
            // 
            this.data_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Emp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Emp.Location = new System.Drawing.Point(0, 830);
            this.data_Emp.Name = "data_Emp";
            this.data_Emp.RowTemplate.Height = 28;
            this.data_Emp.Size = new System.Drawing.Size(1149, 220);
            this.data_Emp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ:";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(26, 86);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(205, 26);
            this.txt_lastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên:";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(26, 153);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(205, 26);
            this.txt_firstName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(26, 287);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(205, 26);
            this.txt_address.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chứng minh nhân dân:";
            // 
            // txt_idCardNumber
            // 
            this.txt_idCardNumber.Location = new System.Drawing.Point(26, 356);
            this.txt_idCardNumber.Name = "txt_idCardNumber";
            this.txt_idCardNumber.Size = new System.Drawing.Size(205, 26);
            this.txt_idCardNumber.TabIndex = 5;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dob.Location = new System.Drawing.Point(26, 219);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(200, 26);
            this.dtp_dob.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quê quán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(658, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(662, 86);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(205, 26);
            this.txt_email.TabIndex = 5;
            // 
            // cbb_homeTown
            // 
            this.cbb_homeTown.FormattingEnabled = true;
            this.cbb_homeTown.Items.AddRange(new object[] {
            "Thành phố Hà Nội",
            "Tỉnh Hà Giang",
            "Tỉnh Cao Bằng",
            "Tỉnh Bắc Kạn",
            "Tỉnh Tuyên Quang",
            "Tỉnh Lào Cai",
            "Tỉnh Điện Biên",
            "Tỉnh Lai Châu",
            "Tỉnh Sơn La",
            "Tỉnh Yên Bái",
            "Tỉnh Hoà Bình",
            "Tỉnh Thái Nguyên",
            "Tỉnh Lạng Sơn",
            "Tỉnh Quảng Ninh",
            "Tỉnh Bắc Giang",
            "Tỉnh Phú Thọ",
            "Tỉnh Vĩnh Phúc",
            "Tỉnh Bắc Ninh",
            "Tỉnh Hải Dương",
            "Thành phố Hải Phòng",
            "Tỉnh Hưng Yên",
            "Tỉnh Thái Bình",
            "Tỉnh Hà Nam",
            "Tỉnh Nam Định",
            "Tỉnh Ninh Bình",
            "Tỉnh Thanh Hóa",
            "Tỉnh Nghệ An",
            "Tỉnh Hà Tĩnh",
            "Tỉnh Quảng Bình",
            "Tỉnh Quảng Trị",
            "Tỉnh Thừa Thiên Huế",
            "Thành phố Đà Nẵng",
            "Tỉnh Quảng Nam",
            "Tỉnh Quảng Ngãi",
            "Tỉnh Bình Định",
            "Tỉnh Phú Yên",
            "Tỉnh Khánh Hòa",
            "Tỉnh Ninh Thuận",
            "Tỉnh Bình Thuận",
            "Tỉnh Kon Tum",
            "Tỉnh Gia Lai",
            "Tỉnh Đắk Lắk",
            "Tỉnh Đắk Nông",
            "Tỉnh Lâm Đồng",
            "Tỉnh Bình Phước",
            "Tỉnh Tây Ninh",
            "Tỉnh Bình Dương",
            "Tỉnh Đồng Nai",
            "Tỉnh Bà Rịa - Vũng Tàu",
            "Thành phố Hồ Chí Minh",
            "Tỉnh Long An",
            "Tỉnh Tiền Giang",
            "Tỉnh Bến Tre",
            "Tỉnh Trà Vinh",
            "Tỉnh Vĩnh Long",
            "Tỉnh Đồng Tháp",
            "Tỉnh An Giang",
            "Tỉnh Kiên Giang",
            "Thành phố Cần Thơ",
            "Tỉnh Hậu Giang",
            "Tỉnh Sóc Trăng",
            "Tỉnh Bạc Liêu",
            "Tỉnh Cà Mau"});
            this.cbb_homeTown.Location = new System.Drawing.Point(340, 84);
            this.cbb_homeTown.Name = "cbb_homeTown";
            this.cbb_homeTown.Size = new System.Drawing.Size(205, 28);
            this.cbb_homeTown.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(336, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Chức vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(336, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số điện thoại:";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(340, 219);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(205, 26);
            this.txt_phoneNumber.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "Chi nhánh:";
            // 
            // cb_state
            // 
            this.cb_state.AutoSize = true;
            this.cb_state.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_state.Location = new System.Drawing.Point(340, 359);
            this.cb_state.Name = "cb_state";
            this.cb_state.Size = new System.Drawing.Size(142, 23);
            this.cb_state.TabIndex = 8;
            this.cb_state.Text = "Đang làm việc";
            this.cb_state.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(336, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "Trạng thái";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(658, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Mật khẩu:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(662, 153);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.ReadOnly = true;
            this.txt_password.Size = new System.Drawing.Size(205, 26);
            this.txt_password.TabIndex = 5;
            // 
            // cbb_branch
            // 
            this.cbb_branch.FormattingEnabled = true;
            this.cbb_branch.Location = new System.Drawing.Point(340, 285);
            this.cbb_branch.Name = "cbb_branch";
            this.cbb_branch.Size = new System.Drawing.Size(205, 28);
            this.cbb_branch.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(658, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 24);
            this.label15.TabIndex = 4;
            this.label15.Text = "Ngày vào làm:";
            // 
            // dtp_daystart
            // 
            this.dtp_daystart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_daystart.Location = new System.Drawing.Point(662, 219);
            this.dtp_daystart.Name = "dtp_daystart";
            this.dtp_daystart.Size = new System.Drawing.Size(205, 26);
            this.dtp_daystart.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(658, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 24);
            this.label16.TabIndex = 4;
            this.label16.Text = "Ngày nghỉ việc:";
            // 
            // dtp_dayend
            // 
            this.dtp_dayend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dayend.Location = new System.Drawing.Point(662, 285);
            this.dtp_dayend.Name = "dtp_dayend";
            this.dtp_dayend.Size = new System.Drawing.Size(205, 26);
            this.dtp_dayend.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(658, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 24);
            this.label17.TabIndex = 4;
            this.label17.Text = "Lương cơ bản:";
            // 
            // txt_basicSalary
            // 
            this.txt_basicSalary.Location = new System.Drawing.Point(662, 347);
            this.txt_basicSalary.Name = "txt_basicSalary";
            this.txt_basicSalary.Size = new System.Drawing.Size(205, 26);
            this.txt_basicSalary.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(658, 395);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 24);
            this.label18.TabIndex = 4;
            this.label18.Text = "Thưởng:";
            // 
            // txt_bonus
            // 
            this.txt_bonus.Location = new System.Drawing.Point(662, 422);
            this.txt_bonus.Name = "txt_bonus";
            this.txt_bonus.Size = new System.Drawing.Size(205, 26);
            this.txt_bonus.TabIndex = 5;
            // 
            // cbb_position
            // 
            this.cbb_position.FormattingEnabled = true;
            this.cbb_position.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbb_position.Location = new System.Drawing.Point(340, 151);
            this.cbb_position.Name = "cbb_position";
            this.cbb_position.Size = new System.Drawing.Size(205, 28);
            this.cbb_position.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(920, 86);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(183, 43);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Thêm nhân viên";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(920, 143);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(183, 43);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Sửa thông tin";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(920, 202);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(183, 43);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Xóa nhân viên";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(920, 261);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(183, 43);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "Tải lại";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(920, 324);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(183, 43);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_back.Location = new System.Drawing.Point(1011, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(126, 38);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 1050);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_state);
            this.Controls.Add(this.cbb_branch);
            this.Controls.Add(this.cbb_position);
            this.Controls.Add(this.cbb_homeTown);
            this.Controls.Add(this.dtp_dayend);
            this.Controls.Add(this.dtp_daystart);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.txt_idCardNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_bonus);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_basicSalary);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_Emp);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormEmployee";
            this.Text = "x``";
            ((System.ComponentModel.ISupportInitialize)(this.data_Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_Emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_idCardNumber;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox cbb_homeTown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cb_state;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ComboBox cbb_branch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp_daystart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtp_dayend;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_basicSalary;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_bonus;
        private System.Windows.Forms.ComboBox cbb_position;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_back;
    }
}