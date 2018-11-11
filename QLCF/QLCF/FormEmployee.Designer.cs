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
            this.data_Emp = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iccardnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
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
            this.btn_search = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_idCard = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Emp
            // 
            this.data_Emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lastname,
            this.firstname,
            this.dayofbirth,
            this.address,
            this.hometown,
            this.position,
            this.phonenumber,
            this.iccardnumber,
            this.email,
            this.password,
            this.startdate,
            this.enddate,
            this.salary,
            this.bonus,
            this.branchWork});
            this.data_Emp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Emp.Location = new System.Drawing.Point(0, 344);
            this.data_Emp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_Emp.Name = "data_Emp";
            this.data_Emp.ReadOnly = true;
            this.data_Emp.RowTemplate.Height = 28;
            this.data_Emp.Size = new System.Drawing.Size(744, 143);
            this.data_Emp.TabIndex = 2;
            this.data_Emp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Emp_CellClick);
            this.data_Emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Emp_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "lastname";
            this.lastname.HeaderText = "Họ";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "firstname";
            this.firstname.HeaderText = "Tên";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // dayofbirth
            // 
            this.dayofbirth.DataPropertyName = "dayofbirth";
            this.dayofbirth.HeaderText = "Ngày sinh";
            this.dayofbirth.Name = "dayofbirth";
            this.dayofbirth.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // hometown
            // 
            this.hometown.DataPropertyName = "hometown";
            this.hometown.HeaderText = "Quê quán";
            this.hometown.Name = "hometown";
            this.hometown.ReadOnly = true;
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "Chức vụ";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // phonenumber
            // 
            this.phonenumber.DataPropertyName = "phonenumber";
            this.phonenumber.HeaderText = "Số điện thoại";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            // 
            // iccardnumber
            // 
            this.iccardnumber.DataPropertyName = "idcardnumber";
            this.iccardnumber.HeaderText = "CMND";
            this.iccardnumber.Name = "iccardnumber";
            this.iccardnumber.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Mật khẩu";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // startdate
            // 
            this.startdate.DataPropertyName = "startdate";
            this.startdate.HeaderText = "Ngày vào làm";
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            // 
            // enddate
            // 
            this.enddate.DataPropertyName = "enddate";
            this.enddate.HeaderText = "Ngày nghỉ việc";
            this.enddate.Name = "enddate";
            this.enddate.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Lương cơ bản";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // bonus
            // 
            this.bonus.DataPropertyName = "bonus";
            this.bonus.HeaderText = "Thưởng";
            this.bonus.Name = "bonus";
            this.bonus.ReadOnly = true;
            // 
            // branchWork
            // 
            this.branchWork.DataPropertyName = "branchWork";
            this.branchWork.HeaderText = "Chi nhánh";
            this.branchWork.Name = "branchWork";
            this.branchWork.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ:";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(17, 56);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(138, 20);
            this.txt_lastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên:";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(17, 99);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(138, 20);
            this.txt_firstName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(17, 187);
            this.txt_address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(138, 20);
            this.txt_address.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tìm kiếm:";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(17, 274);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(219, 20);
            this.txt_search.TabIndex = 5;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dob.Location = new System.Drawing.Point(17, 142);
            this.dtp_dob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_dob.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtp_dob.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(135, 20);
            this.dtp_dob.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quê quán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(439, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(441, 56);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(138, 20);
            this.txt_email.TabIndex = 10;
            // 
            // cbb_homeTown
            // 
            this.cbb_homeTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbb_homeTown.Location = new System.Drawing.Point(227, 55);
            this.cbb_homeTown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_homeTown.Name = "cbb_homeTown";
            this.cbb_homeTown.Size = new System.Drawing.Size(138, 21);
            this.cbb_homeTown.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Chức vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(224, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số điện thoại:";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(227, 142);
            this.txt_phoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(138, 20);
            this.txt_phoneNumber.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(224, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Chi nhánh:";
            // 
            // cb_state
            // 
            this.cb_state.AutoSize = true;
            this.cb_state.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_state.Location = new System.Drawing.Point(227, 233);
            this.cb_state.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_state.Name = "cb_state";
            this.cb_state.Size = new System.Drawing.Size(102, 18);
            this.cb_state.TabIndex = 9;
            this.cb_state.Text = "Đang làm việc";
            this.cb_state.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(224, 214);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Trạng thái";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(439, 82);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Mật khẩu:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(441, 99);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(138, 20);
            this.txt_password.TabIndex = 11;
            // 
            // cbb_branch
            // 
            this.cbb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_branch.FormattingEnabled = true;
            this.cbb_branch.Location = new System.Drawing.Point(227, 185);
            this.cbb_branch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_branch.Name = "cbb_branch";
            this.cbb_branch.Size = new System.Drawing.Size(138, 21);
            this.cbb_branch.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(439, 125);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Ngày vào làm:";
            // 
            // dtp_daystart
            // 
            this.dtp_daystart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_daystart.Location = new System.Drawing.Point(441, 142);
            this.dtp_daystart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_daystart.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtp_daystart.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_daystart.Name = "dtp_daystart";
            this.dtp_daystart.Size = new System.Drawing.Size(138, 20);
            this.dtp_daystart.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(439, 168);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Ngày nghỉ việc:";
            // 
            // dtp_dayend
            // 
            this.dtp_dayend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dayend.Location = new System.Drawing.Point(441, 185);
            this.dtp_dayend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_dayend.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtp_dayend.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_dayend.Name = "dtp_dayend";
            this.dtp_dayend.Size = new System.Drawing.Size(138, 20);
            this.dtp_dayend.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(439, 208);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "Lương cơ bản:";
            // 
            // txt_basicSalary
            // 
            this.txt_basicSalary.Location = new System.Drawing.Point(441, 226);
            this.txt_basicSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_basicSalary.Name = "txt_basicSalary";
            this.txt_basicSalary.Size = new System.Drawing.Size(138, 20);
            this.txt_basicSalary.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(439, 257);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Thưởng:";
            // 
            // txt_bonus
            // 
            this.txt_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_bonus.Location = new System.Drawing.Point(441, 274);
            this.txt_bonus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bonus.Name = "txt_bonus";
            this.txt_bonus.Size = new System.Drawing.Size(138, 20);
            this.txt_bonus.TabIndex = 15;
            // 
            // cbb_position
            // 
            this.cbb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_position.FormattingEnabled = true;
            this.cbb_position.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbb_position.Location = new System.Drawing.Point(227, 98);
            this.cbb_position.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_position.Name = "cbb_position";
            this.cbb_position.Size = new System.Drawing.Size(138, 21);
            this.cbb_position.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(105, 8);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 28);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "THÊM NHÂN VIÊN";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(231, 8);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(122, 28);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "SỬA THÔNG TIN";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(357, 8);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(122, 28);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "XÓA NHÂN VIÊN";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Maroon;
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(483, 8);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(122, 28);
            this.btn_refresh.TabIndex = 19;
            this.btn_refresh.Text = "TẢI LẠI";
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(609, 8);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 28);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_back.Location = new System.Drawing.Point(17, 12);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 25);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "QUAY LẠI";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Olive;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(239, 270);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 25);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "TÌM";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 214);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "CMND:";
            // 
            // txt_idCard
            // 
            this.txt_idCard.Location = new System.Drawing.Point(17, 231);
            this.txt_idCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_idCard.Name = "txt_idCard";
            this.txt_idCard.Size = new System.Drawing.Size(138, 20);
            this.txt_idCard.TabIndex = 4;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 487);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
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
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_idCard);
            this.Controls.Add(this.label14);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormEmployee";
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView data_Emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_search;
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
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_idCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometown;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn iccardnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchWork;
    }
}