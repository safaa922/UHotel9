namespace UHotel9
{
    partial class Employee_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Registration));
            groupBox1 = new GroupBox();
            BackButton_Edit = new Button();
            pictureBox1 = new PictureBox();
            RoomFormLabel = new Label();
            Photo_Upload = new Button();
            EmployeeStatusBox = new ComboBox();
            Employee_DepartmentBox = new ComboBox();
            Employee_GenderBox = new ComboBox();
            label4 = new Label();
            Employee_SalaryBox = new TextBox();
            label2 = new Label();
            Employee_CountryBox = new TextBox();
            label1 = new Label();
            Employee_PictureBox = new PictureBox();
            Employee_PasswordBox = new TextBox();
            Employee_UserNameBox = new TextBox();
            Employee_AgeBox = new TextBox();
            Employee_CityBox = new TextBox();
            Employee_PhoneBox = new TextBox();
            Employee_EmailBox = new TextBox();
            Employee_IdBox = new TextBox();
            Employee_LNameBox = new TextBox();
            Employee_FNameBox = new TextBox();
            Employee_ButtonBox = new Button();
            Employee_IdLabel = new Label();
            Employee_FNameLabel = new Label();
            label10 = new Label();
            Employee_PhotoLabel = new Label();
            Employee_GenderLabel = new Label();
            Employee_StatusBox = new Label();
            Employee_CityLabel = new Label();
            Employye_EmailLabel = new Label();
            Employee_AgeLabel = new Label();
            label3 = new Label();
            Employye_UserNameLabel = new Label();
            Employee_LNameLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Employee_PictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BackButton_Edit);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(RoomFormLabel);
            groupBox1.Controls.Add(Photo_Upload);
            groupBox1.Controls.Add(EmployeeStatusBox);
            groupBox1.Controls.Add(Employee_DepartmentBox);
            groupBox1.Controls.Add(Employee_GenderBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Employee_SalaryBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Employee_CountryBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Employee_PictureBox);
            groupBox1.Controls.Add(Employee_PasswordBox);
            groupBox1.Controls.Add(Employee_UserNameBox);
            groupBox1.Controls.Add(Employee_AgeBox);
            groupBox1.Controls.Add(Employee_CityBox);
            groupBox1.Controls.Add(Employee_PhoneBox);
            groupBox1.Controls.Add(Employee_EmailBox);
            groupBox1.Controls.Add(Employee_IdBox);
            groupBox1.Controls.Add(Employee_LNameBox);
            groupBox1.Controls.Add(Employee_FNameBox);
            groupBox1.Controls.Add(Employee_ButtonBox);
            groupBox1.Controls.Add(Employee_IdLabel);
            groupBox1.Controls.Add(Employee_FNameLabel);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(Employee_PhotoLabel);
            groupBox1.Controls.Add(Employee_GenderLabel);
            groupBox1.Controls.Add(Employee_StatusBox);
            groupBox1.Controls.Add(Employee_CityLabel);
            groupBox1.Controls.Add(Employye_EmailLabel);
            groupBox1.Controls.Add(Employee_AgeLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Employye_UserNameLabel);
            groupBox1.Controls.Add(Employee_LNameLabel);
            groupBox1.Location = new Point(165, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 657);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(31, 36);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(35, 33);
            BackButton_Edit.TabIndex = 126;
            BackButton_Edit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(501, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 125;
            pictureBox1.TabStop = false;
            // 
            // RoomFormLabel
            // 
            RoomFormLabel.AutoSize = true;
            RoomFormLabel.BackColor = Color.Transparent;
            RoomFormLabel.BorderStyle = BorderStyle.Fixed3D;
            RoomFormLabel.Font = new Font("Athletic Outfit", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomFormLabel.ForeColor = Color.FromArgb(64, 64, 64);
            RoomFormLabel.Location = new Point(200, 36);
            RoomFormLabel.Name = "RoomFormLabel";
            RoomFormLabel.Size = new Size(295, 63);
            RoomFormLabel.TabIndex = 124;
            RoomFormLabel.Text = "Employee Form";
            // 
            // Photo_Upload
            // 
            Photo_Upload.BackColor = SystemColors.ControlDark;
            Photo_Upload.Font = new Font("AL-Majd", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Photo_Upload.Location = new Point(605, 492);
            Photo_Upload.Name = "Photo_Upload";
            Photo_Upload.Size = new Size(86, 27);
            Photo_Upload.TabIndex = 123;
            Photo_Upload.Text = "upload";
            Photo_Upload.UseVisualStyleBackColor = false;
            Photo_Upload.Click += Photo_Upload_Click_1;
            // 
            // EmployeeStatusBox
            // 
            EmployeeStatusBox.FormattingEnabled = true;
            EmployeeStatusBox.Items.AddRange(new object[] { "single", "married", "engaged" });
            EmployeeStatusBox.Location = new Point(491, 351);
            EmployeeStatusBox.Name = "EmployeeStatusBox";
            EmployeeStatusBox.Size = new Size(145, 23);
            EmployeeStatusBox.TabIndex = 122;
            // 
            // Employee_DepartmentBox
            // 
            Employee_DepartmentBox.FormattingEnabled = true;
            Employee_DepartmentBox.Items.AddRange(new object[] { "IT", "FrontOffice", "Housekeeping", "FoodAndBeverageService", "Kitchen", "Accounts", "Security", "HumanResources", "SalesAndMarketing", "Purchase", "EngineeringAndMaintenance", "Managment", "DataEntry" });
            Employee_DepartmentBox.Location = new Point(491, 170);
            Employee_DepartmentBox.Name = "Employee_DepartmentBox";
            Employee_DepartmentBox.Size = new Size(145, 23);
            Employee_DepartmentBox.TabIndex = 121;
            // 
            // Employee_GenderBox
            // 
            Employee_GenderBox.FormattingEnabled = true;
            Employee_GenderBox.Items.AddRange(new object[] { "Male", "Female" });
            Employee_GenderBox.Location = new Point(491, 416);
            Employee_GenderBox.Name = "Employee_GenderBox";
            Employee_GenderBox.Size = new Size(145, 23);
            Employee_GenderBox.TabIndex = 120;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Assaf Font", 15.7499981F);
            label4.Location = new Point(399, 162);
            label4.Name = "label4";
            label4.Size = new Size(91, 36);
            label4.TabIndex = 119;
            label4.Text = "Department";
            // 
            // Employee_SalaryBox
            // 
            Employee_SalaryBox.Location = new Point(167, 496);
            Employee_SalaryBox.Name = "Employee_SalaryBox";
            Employee_SalaryBox.Size = new Size(145, 23);
            Employee_SalaryBox.TabIndex = 118;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Assaf Font", 15F);
            label2.Location = new Point(62, 488);
            label2.Name = "label2";
            label2.Size = new Size(52, 34);
            label2.TabIndex = 117;
            label2.Text = "Salary";
            // 
            // Employee_CountryBox
            // 
            Employee_CountryBox.Location = new Point(491, 229);
            Employee_CountryBox.Name = "Employee_CountryBox";
            Employee_CountryBox.Size = new Size(145, 23);
            Employee_CountryBox.TabIndex = 116;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Assaf Font", 15.7499981F);
            label1.Location = new Point(399, 222);
            label1.Name = "label1";
            label1.Size = new Size(67, 36);
            label1.TabIndex = 115;
            label1.Text = "Country";
            // 
            // Employee_PictureBox
            // 
            Employee_PictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            Employee_PictureBox.Location = new Point(491, 465);
            Employee_PictureBox.Name = "Employee_PictureBox";
            Employee_PictureBox.Size = new Size(81, 74);
            Employee_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Employee_PictureBox.TabIndex = 114;
            Employee_PictureBox.TabStop = false;
            // 
            // Employee_PasswordBox
            // 
            Employee_PasswordBox.Location = new Point(166, 443);
            Employee_PasswordBox.Name = "Employee_PasswordBox";
            Employee_PasswordBox.PasswordChar = '*';
            Employee_PasswordBox.Size = new Size(145, 23);
            Employee_PasswordBox.TabIndex = 113;
            // 
            // Employee_UserNameBox
            // 
            Employee_UserNameBox.Location = new Point(166, 413);
            Employee_UserNameBox.Name = "Employee_UserNameBox";
            Employee_UserNameBox.Size = new Size(145, 23);
            Employee_UserNameBox.TabIndex = 112;
            // 
            // Employee_AgeBox
            // 
            Employee_AgeBox.Location = new Point(491, 318);
            Employee_AgeBox.MaxLength = 3;
            Employee_AgeBox.Name = "Employee_AgeBox";
            Employee_AgeBox.Size = new Size(145, 23);
            Employee_AgeBox.TabIndex = 111;
            // 
            // Employee_CityBox
            // 
            Employee_CityBox.Location = new Point(491, 261);
            Employee_CityBox.Name = "Employee_CityBox";
            Employee_CityBox.Size = new Size(145, 23);
            Employee_CityBox.TabIndex = 110;
            // 
            // Employee_PhoneBox
            // 
            Employee_PhoneBox.Location = new Point(167, 351);
            Employee_PhoneBox.Name = "Employee_PhoneBox";
            Employee_PhoneBox.Size = new Size(145, 23);
            Employee_PhoneBox.TabIndex = 109;
            // 
            // Employee_EmailBox
            // 
            Employee_EmailBox.Location = new Point(166, 318);
            Employee_EmailBox.Name = "Employee_EmailBox";
            Employee_EmailBox.Size = new Size(145, 23);
            Employee_EmailBox.TabIndex = 108;
            // 
            // Employee_IdBox
            // 
            Employee_IdBox.Location = new Point(167, 170);
            Employee_IdBox.Name = "Employee_IdBox";
            Employee_IdBox.Size = new Size(145, 23);
            Employee_IdBox.TabIndex = 107;
            // 
            // Employee_LNameBox
            // 
            Employee_LNameBox.Location = new Point(167, 261);
            Employee_LNameBox.Name = "Employee_LNameBox";
            Employee_LNameBox.Size = new Size(145, 23);
            Employee_LNameBox.TabIndex = 106;
            // 
            // Employee_FNameBox
            // 
            Employee_FNameBox.Location = new Point(167, 229);
            Employee_FNameBox.Name = "Employee_FNameBox";
            Employee_FNameBox.Size = new Size(145, 23);
            Employee_FNameBox.TabIndex = 105;
            // 
            // Employee_ButtonBox
            // 
            Employee_ButtonBox.BackColor = Color.Gray;
            Employee_ButtonBox.BackgroundImage = (Image)resources.GetObject("Employee_ButtonBox.BackgroundImage");
            Employee_ButtonBox.BackgroundImageLayout = ImageLayout.Stretch;
            Employee_ButtonBox.FlatStyle = FlatStyle.Flat;
            Employee_ButtonBox.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employee_ButtonBox.ForeColor = SystemColors.Control;
            Employee_ButtonBox.Location = new Point(272, 558);
            Employee_ButtonBox.Name = "Employee_ButtonBox";
            Employee_ButtonBox.Size = new Size(194, 62);
            Employee_ButtonBox.TabIndex = 104;
            Employee_ButtonBox.Text = "Registrate";
            Employee_ButtonBox.UseVisualStyleBackColor = false;
            Employee_ButtonBox.Click += Employee_ButtonBox_Click_1;
            // 
            // Employee_IdLabel
            // 
            Employee_IdLabel.AutoSize = true;
            Employee_IdLabel.BackColor = Color.Transparent;
            Employee_IdLabel.Font = new Font("Assaf Font", 15F);
            Employee_IdLabel.Location = new Point(62, 162);
            Employee_IdLabel.Name = "Employee_IdLabel";
            Employee_IdLabel.Size = new Size(80, 34);
            Employee_IdLabel.TabIndex = 103;
            Employee_IdLabel.Text = "ID Number";
            // 
            // Employee_FNameLabel
            // 
            Employee_FNameLabel.AutoSize = true;
            Employee_FNameLabel.BackColor = Color.Transparent;
            Employee_FNameLabel.Font = new Font("Assaf Font", 15F);
            Employee_FNameLabel.Location = new Point(62, 222);
            Employee_FNameLabel.Name = "Employee_FNameLabel";
            Employee_FNameLabel.Size = new Size(79, 34);
            Employee_FNameLabel.TabIndex = 102;
            Employee_FNameLabel.Text = "First Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Assaf Font", 15F);
            label10.Location = new Point(62, 438);
            label10.Name = "label10";
            label10.Size = new Size(74, 34);
            label10.TabIndex = 101;
            label10.Text = "Password";
            // 
            // Employee_PhotoLabel
            // 
            Employee_PhotoLabel.AutoSize = true;
            Employee_PhotoLabel.BackColor = Color.Transparent;
            Employee_PhotoLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_PhotoLabel.Location = new Point(399, 487);
            Employee_PhotoLabel.Name = "Employee_PhotoLabel";
            Employee_PhotoLabel.Size = new Size(53, 36);
            Employee_PhotoLabel.TabIndex = 100;
            Employee_PhotoLabel.Text = "Photo";
            // 
            // Employee_GenderLabel
            // 
            Employee_GenderLabel.AutoSize = true;
            Employee_GenderLabel.BackColor = Color.Transparent;
            Employee_GenderLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_GenderLabel.Location = new Point(399, 408);
            Employee_GenderLabel.Name = "Employee_GenderLabel";
            Employee_GenderLabel.Size = new Size(62, 36);
            Employee_GenderLabel.TabIndex = 99;
            Employee_GenderLabel.Text = "Gender";
            // 
            // Employee_StatusBox
            // 
            Employee_StatusBox.AutoSize = true;
            Employee_StatusBox.BackColor = Color.Transparent;
            Employee_StatusBox.Font = new Font("Assaf Font", 15.7499981F);
            Employee_StatusBox.Location = new Point(399, 343);
            Employee_StatusBox.Name = "Employee_StatusBox";
            Employee_StatusBox.Size = new Size(57, 36);
            Employee_StatusBox.TabIndex = 98;
            Employee_StatusBox.Text = "Status";
            // 
            // Employee_CityLabel
            // 
            Employee_CityLabel.AutoSize = true;
            Employee_CityLabel.BackColor = Color.Transparent;
            Employee_CityLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_CityLabel.Location = new Point(399, 248);
            Employee_CityLabel.Name = "Employee_CityLabel";
            Employee_CityLabel.Size = new Size(42, 36);
            Employee_CityLabel.TabIndex = 97;
            Employee_CityLabel.Text = "City";
            // 
            // Employye_EmailLabel
            // 
            Employye_EmailLabel.AutoSize = true;
            Employye_EmailLabel.BackColor = Color.Transparent;
            Employye_EmailLabel.Font = new Font("Assaf Font", 14.25F);
            Employye_EmailLabel.Location = new Point(62, 310);
            Employye_EmailLabel.Name = "Employye_EmailLabel";
            Employye_EmailLabel.Size = new Size(44, 32);
            Employye_EmailLabel.TabIndex = 96;
            Employye_EmailLabel.Text = "Email";
            // 
            // Employee_AgeLabel
            // 
            Employee_AgeLabel.AutoSize = true;
            Employee_AgeLabel.BackColor = Color.Transparent;
            Employee_AgeLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_AgeLabel.Location = new Point(399, 310);
            Employee_AgeLabel.Name = "Employee_AgeLabel";
            Employee_AgeLabel.Size = new Size(41, 36);
            Employee_AgeLabel.TabIndex = 95;
            Employee_AgeLabel.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Assaf Font", 15F);
            label3.Location = new Point(62, 343);
            label3.Name = "label3";
            label3.Size = new Size(103, 34);
            label3.TabIndex = 94;
            label3.Text = "Phone Number";
            // 
            // Employye_UserNameLabel
            // 
            Employye_UserNameLabel.AutoSize = true;
            Employye_UserNameLabel.BackColor = Color.Transparent;
            Employye_UserNameLabel.Font = new Font("Assaf Font", 15F);
            Employye_UserNameLabel.Location = new Point(62, 408);
            Employye_UserNameLabel.Name = "Employye_UserNameLabel";
            Employye_UserNameLabel.Size = new Size(81, 34);
            Employye_UserNameLabel.TabIndex = 93;
            Employye_UserNameLabel.Text = "User Name";
            // 
            // Employee_LNameLabel
            // 
            Employee_LNameLabel.AutoSize = true;
            Employee_LNameLabel.BackColor = Color.Transparent;
            Employee_LNameLabel.Font = new Font("Assaf Font", 15F);
            Employee_LNameLabel.Location = new Point(62, 253);
            Employee_LNameLabel.Name = "Employee_LNameLabel";
            Employee_LNameLabel.Size = new Size(79, 34);
            Employee_LNameLabel.TabIndex = 92;
            Employee_LNameLabel.Text = "Last Name";
            // 
            // Employee_Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 731);
            Controls.Add(groupBox1);
            Name = "Employee_Registration";
            Text = "Employee_Registration";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Employee_PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BackButton_Edit;
        private PictureBox pictureBox1;
        private Label RoomFormLabel;
        private Button Photo_Upload;
        private ComboBox EmployeeStatusBox;
        private ComboBox Employee_DepartmentBox;
        private ComboBox Employee_GenderBox;
        private Label label4;
        private TextBox Employee_SalaryBox;
        private Label label2;
        private TextBox Employee_CountryBox;
        private Label label1;
        private PictureBox Employee_PictureBox;
        private TextBox Employee_PasswordBox;
        private TextBox Employee_UserNameBox;
        private TextBox Employee_AgeBox;
        private TextBox Employee_CityBox;
        private TextBox Employee_PhoneBox;
        private TextBox Employee_EmailBox;
        private TextBox Employee_IdBox;
        private TextBox Employee_LNameBox;
        private TextBox Employee_FNameBox;
        private Button Employee_ButtonBox;
        private Label Employee_IdLabel;
        private Label Employee_FNameLabel;
        private Label label10;
        private Label Employee_PhotoLabel;
        private Label Employee_GenderLabel;
        private Label Employee_StatusBox;
        private Label Employee_CityLabel;
        private Label Employye_EmailLabel;
        private Label Employee_AgeLabel;
        private Label label3;
        private Label Employye_UserNameLabel;
        private Label Employee_LNameLabel;
    }
}