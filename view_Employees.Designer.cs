namespace UHotel9
{
    partial class view_Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_Employees));
            groupBox1 = new GroupBox();
            BackButton_Edit = new Button();
            pictureBox1 = new PictureBox();
            RoomFormLabel = new Label();
            EmployeeStatusBoxView = new ComboBox();
            EmployeeDepartmentBoxView = new ComboBox();
            EmployeeGenderBoxView = new ComboBox();
            label4 = new Label();
            EmployeeSalaryBoxView = new TextBox();
            label2 = new Label();
            EmployeeCountryBoxView = new TextBox();
            label1 = new Label();
            Employee_PictureBox_View = new PictureBox();
            EmployeePasswordBoxView = new TextBox();
            EmployeeUserNameBoxView = new TextBox();
            EmployeeAgeBoxView = new TextBox();
            EmployeeCityBoxView = new TextBox();
            EmployeePhoneBoxView = new TextBox();
            EmployeeEmailBoxView = new TextBox();
            EmployeeIdBoxView = new TextBox();
            EmployeeLNameBoxView = new TextBox();
            EmployeeFNameBoxView = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)Employee_PictureBox_View).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BackButton_Edit);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(RoomFormLabel);
            groupBox1.Controls.Add(EmployeeStatusBoxView);
            groupBox1.Controls.Add(EmployeeDepartmentBoxView);
            groupBox1.Controls.Add(EmployeeGenderBoxView);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(EmployeeSalaryBoxView);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(EmployeeCountryBoxView);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Employee_PictureBox_View);
            groupBox1.Controls.Add(EmployeePasswordBoxView);
            groupBox1.Controls.Add(EmployeeUserNameBoxView);
            groupBox1.Controls.Add(EmployeeAgeBoxView);
            groupBox1.Controls.Add(EmployeeCityBoxView);
            groupBox1.Controls.Add(EmployeePhoneBoxView);
            groupBox1.Controls.Add(EmployeeEmailBoxView);
            groupBox1.Controls.Add(EmployeeIdBoxView);
            groupBox1.Controls.Add(EmployeeLNameBoxView);
            groupBox1.Controls.Add(EmployeeFNameBoxView);
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
            groupBox1.Location = new Point(177, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(743, 634);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(59, 47);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(35, 33);
            BackButton_Edit.TabIndex = 124;
            BackButton_Edit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(502, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 123;
            pictureBox1.TabStop = false;
            // 
            // RoomFormLabel
            // 
            RoomFormLabel.AutoSize = true;
            RoomFormLabel.BackColor = Color.Transparent;
            RoomFormLabel.BorderStyle = BorderStyle.Fixed3D;
            RoomFormLabel.Font = new Font("Mishaland", 32.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomFormLabel.ForeColor = Color.FromArgb(64, 64, 64);
            RoomFormLabel.Location = new Point(192, 47);
            RoomFormLabel.Name = "RoomFormLabel";
            RoomFormLabel.Size = new Size(304, 72);
            RoomFormLabel.TabIndex = 122;
            RoomFormLabel.Text = "Employee Form";
            // 
            // EmployeeStatusBoxView
            // 
            EmployeeStatusBoxView.FormattingEnabled = true;
            EmployeeStatusBoxView.Items.AddRange(new object[] { "single", "married", "engaged" });
            EmployeeStatusBoxView.Location = new Point(514, 386);
            EmployeeStatusBoxView.Name = "EmployeeStatusBoxView";
            EmployeeStatusBoxView.Size = new Size(159, 23);
            EmployeeStatusBoxView.TabIndex = 121;
            // 
            // EmployeeDepartmentBoxView
            // 
            EmployeeDepartmentBoxView.FormattingEnabled = true;
            EmployeeDepartmentBoxView.Items.AddRange(new object[] { "IT", "FrontOffice", "Housekeeping", "FoodAndBeverageService", "Kitchen", "Accounts", "Security", "HumanResources", "SalesAndMarketing", "Purchase", "EngineeringAndMaintenance", "Managment", "DataEntry" });
            EmployeeDepartmentBoxView.Location = new Point(514, 204);
            EmployeeDepartmentBoxView.Name = "EmployeeDepartmentBoxView";
            EmployeeDepartmentBoxView.Size = new Size(159, 23);
            EmployeeDepartmentBoxView.TabIndex = 120;
            // 
            // EmployeeGenderBoxView
            // 
            EmployeeGenderBoxView.FormattingEnabled = true;
            EmployeeGenderBoxView.Items.AddRange(new object[] { "Male", "Female" });
            EmployeeGenderBoxView.Location = new Point(514, 441);
            EmployeeGenderBoxView.Name = "EmployeeGenderBoxView";
            EmployeeGenderBoxView.Size = new Size(159, 23);
            EmployeeGenderBoxView.TabIndex = 119;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Assaf Font", 15.7499981F);
            label4.Location = new Point(415, 196);
            label4.Name = "label4";
            label4.Size = new Size(91, 36);
            label4.TabIndex = 118;
            label4.Text = "Department";
            // 
            // EmployeeSalaryBoxView
            // 
            EmployeeSalaryBoxView.Location = new Point(169, 526);
            EmployeeSalaryBoxView.Name = "EmployeeSalaryBoxView";
            EmployeeSalaryBoxView.Size = new Size(159, 23);
            EmployeeSalaryBoxView.TabIndex = 117;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Assaf Font", 15.7499981F);
            label2.Location = new Point(59, 518);
            label2.Name = "label2";
            label2.Size = new Size(55, 36);
            label2.TabIndex = 116;
            label2.Text = "Salary";
            // 
            // EmployeeCountryBoxView
            // 
            EmployeeCountryBoxView.Location = new Point(514, 266);
            EmployeeCountryBoxView.Name = "EmployeeCountryBoxView";
            EmployeeCountryBoxView.Size = new Size(159, 23);
            EmployeeCountryBoxView.TabIndex = 115;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Assaf Font", 15.7499981F);
            label1.Location = new Point(415, 259);
            label1.Name = "label1";
            label1.Size = new Size(67, 36);
            label1.TabIndex = 114;
            label1.Text = "Country";
            // 
            // Employee_PictureBox_View
            // 
            Employee_PictureBox_View.BackgroundImageLayout = ImageLayout.Stretch;
            Employee_PictureBox_View.Location = new Point(514, 500);
            Employee_PictureBox_View.Name = "Employee_PictureBox_View";
            Employee_PictureBox_View.Size = new Size(82, 73);
            Employee_PictureBox_View.SizeMode = PictureBoxSizeMode.StretchImage;
            Employee_PictureBox_View.TabIndex = 113;
            Employee_PictureBox_View.TabStop = false;
            // 
            // EmployeePasswordBoxView
            // 
            EmployeePasswordBoxView.Location = new Point(169, 470);
            EmployeePasswordBoxView.Name = "EmployeePasswordBoxView";
            EmployeePasswordBoxView.PasswordChar = '*';
            EmployeePasswordBoxView.Size = new Size(159, 23);
            EmployeePasswordBoxView.TabIndex = 112;
            // 
            // EmployeeUserNameBoxView
            // 
            EmployeeUserNameBoxView.Location = new Point(169, 441);
            EmployeeUserNameBoxView.Name = "EmployeeUserNameBoxView";
            EmployeeUserNameBoxView.Size = new Size(159, 23);
            EmployeeUserNameBoxView.TabIndex = 111;
            // 
            // EmployeeAgeBoxView
            // 
            EmployeeAgeBoxView.Location = new Point(514, 357);
            EmployeeAgeBoxView.MaxLength = 3;
            EmployeeAgeBoxView.Name = "EmployeeAgeBoxView";
            EmployeeAgeBoxView.Size = new Size(159, 23);
            EmployeeAgeBoxView.TabIndex = 110;
            // 
            // EmployeeCityBoxView
            // 
            EmployeeCityBoxView.Location = new Point(514, 298);
            EmployeeCityBoxView.Name = "EmployeeCityBoxView";
            EmployeeCityBoxView.Size = new Size(159, 23);
            EmployeeCityBoxView.TabIndex = 109;
            // 
            // EmployeePhoneBoxView
            // 
            EmployeePhoneBoxView.Location = new Point(169, 386);
            EmployeePhoneBoxView.Name = "EmployeePhoneBoxView";
            EmployeePhoneBoxView.Size = new Size(159, 23);
            EmployeePhoneBoxView.TabIndex = 108;
            // 
            // EmployeeEmailBoxView
            // 
            EmployeeEmailBoxView.Location = new Point(169, 357);
            EmployeeEmailBoxView.Name = "EmployeeEmailBoxView";
            EmployeeEmailBoxView.Size = new Size(159, 23);
            EmployeeEmailBoxView.TabIndex = 107;
            // 
            // EmployeeIdBoxView
            // 
            EmployeeIdBoxView.Location = new Point(170, 204);
            EmployeeIdBoxView.Name = "EmployeeIdBoxView";
            EmployeeIdBoxView.Size = new Size(159, 23);
            EmployeeIdBoxView.TabIndex = 106;
            // 
            // EmployeeLNameBoxView
            // 
            EmployeeLNameBoxView.Location = new Point(170, 298);
            EmployeeLNameBoxView.Name = "EmployeeLNameBoxView";
            EmployeeLNameBoxView.Size = new Size(159, 23);
            EmployeeLNameBoxView.TabIndex = 105;
            // 
            // EmployeeFNameBoxView
            // 
            EmployeeFNameBoxView.Location = new Point(170, 267);
            EmployeeFNameBoxView.Name = "EmployeeFNameBoxView";
            EmployeeFNameBoxView.Size = new Size(159, 23);
            EmployeeFNameBoxView.TabIndex = 104;
            // 
            // Employee_IdLabel
            // 
            Employee_IdLabel.AutoSize = true;
            Employee_IdLabel.BackColor = Color.Transparent;
            Employee_IdLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_IdLabel.Location = new Point(59, 196);
            Employee_IdLabel.Name = "Employee_IdLabel";
            Employee_IdLabel.Size = new Size(84, 36);
            Employee_IdLabel.TabIndex = 103;
            Employee_IdLabel.Text = "ID Number";
            // 
            // Employee_FNameLabel
            // 
            Employee_FNameLabel.AutoSize = true;
            Employee_FNameLabel.BackColor = Color.Transparent;
            Employee_FNameLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_FNameLabel.Location = new Point(59, 258);
            Employee_FNameLabel.Name = "Employee_FNameLabel";
            Employee_FNameLabel.Size = new Size(83, 36);
            Employee_FNameLabel.TabIndex = 102;
            Employee_FNameLabel.Text = "First Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Assaf Font", 15.7499981F);
            label10.Location = new Point(59, 462);
            label10.Name = "label10";
            label10.Size = new Size(77, 36);
            label10.TabIndex = 101;
            label10.Text = "Password";
            // 
            // Employee_PhotoLabel
            // 
            Employee_PhotoLabel.AutoSize = true;
            Employee_PhotoLabel.BackColor = Color.Transparent;
            Employee_PhotoLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_PhotoLabel.Location = new Point(419, 518);
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
            Employee_GenderLabel.Location = new Point(415, 433);
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
            Employee_StatusBox.Location = new Point(415, 378);
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
            Employee_CityLabel.Location = new Point(415, 291);
            Employee_CityLabel.Name = "Employee_CityLabel";
            Employee_CityLabel.Size = new Size(42, 36);
            Employee_CityLabel.TabIndex = 97;
            Employee_CityLabel.Text = "City";
            // 
            // Employye_EmailLabel
            // 
            Employye_EmailLabel.AutoSize = true;
            Employye_EmailLabel.BackColor = Color.Transparent;
            Employye_EmailLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employye_EmailLabel.Location = new Point(58, 349);
            Employye_EmailLabel.Name = "Employye_EmailLabel";
            Employye_EmailLabel.Size = new Size(48, 36);
            Employye_EmailLabel.TabIndex = 96;
            Employye_EmailLabel.Text = "Email";
            // 
            // Employee_AgeLabel
            // 
            Employee_AgeLabel.AutoSize = true;
            Employee_AgeLabel.BackColor = Color.Transparent;
            Employee_AgeLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_AgeLabel.Location = new Point(416, 349);
            Employee_AgeLabel.Name = "Employee_AgeLabel";
            Employee_AgeLabel.Size = new Size(41, 36);
            Employee_AgeLabel.TabIndex = 95;
            Employee_AgeLabel.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Assaf Font", 15.7499981F);
            label3.Location = new Point(58, 378);
            label3.Name = "label3";
            label3.Size = new Size(110, 36);
            label3.TabIndex = 94;
            label3.Text = "Phone Number";
            // 
            // Employye_UserNameLabel
            // 
            Employye_UserNameLabel.AutoSize = true;
            Employye_UserNameLabel.BackColor = Color.Transparent;
            Employye_UserNameLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employye_UserNameLabel.Location = new Point(59, 433);
            Employye_UserNameLabel.Name = "Employye_UserNameLabel";
            Employye_UserNameLabel.Size = new Size(86, 36);
            Employye_UserNameLabel.TabIndex = 93;
            Employye_UserNameLabel.Text = "User Name";
            // 
            // Employee_LNameLabel
            // 
            Employee_LNameLabel.AutoSize = true;
            Employee_LNameLabel.BackColor = Color.Transparent;
            Employee_LNameLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_LNameLabel.Location = new Point(59, 291);
            Employee_LNameLabel.Name = "Employee_LNameLabel";
            Employee_LNameLabel.Size = new Size(84, 36);
            Employee_LNameLabel.TabIndex = 92;
            Employee_LNameLabel.Text = "Last Name";
            // 
            // view_Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1061, 749);
            Controls.Add(groupBox1);
            Name = "view_Employees";
            Text = "view_Employees";
            Load += view_Employees_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Employee_PictureBox_View).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BackButton_Edit;
        private PictureBox pictureBox1;
        private Label RoomFormLabel;
        private ComboBox EmployeeStatusBoxView;
        private ComboBox EmployeeDepartmentBoxView;
        private ComboBox EmployeeGenderBoxView;
        private Label label4;
        private TextBox EmployeeSalaryBoxView;
        private Label label2;
        private TextBox EmployeeCountryBoxView;
        private Label label1;
        private PictureBox Employee_PictureBox_View;
        private TextBox EmployeePasswordBoxView;
        private TextBox EmployeeUserNameBoxView;
        private TextBox EmployeeAgeBoxView;
        private TextBox EmployeeCityBoxView;
        private TextBox EmployeePhoneBoxView;
        private TextBox EmployeeEmailBoxView;
        private TextBox EmployeeIdBoxView;
        private TextBox EmployeeLNameBoxView;
        private TextBox EmployeeFNameBoxView;
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