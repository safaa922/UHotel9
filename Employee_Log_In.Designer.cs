namespace UHotel9
{
    partial class Employee_Log_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Log_In));
            User_Name_Label = new Label();
            Password_Label = new Label();
            EmployeeUserName_Log = new TextBox();
            EmployeePassword_Log = new TextBox();
            Employee_LogInBox = new Button();
            Registrate = new LinkLabel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            BackButton_Edit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // User_Name_Label
            // 
            User_Name_Label.AutoSize = true;
            User_Name_Label.Font = new Font("Assaf Font", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_Name_Label.ForeColor = Color.MidnightBlue;
            User_Name_Label.Location = new Point(535, 79);
            User_Name_Label.Name = "User_Name_Label";
            User_Name_Label.Size = new Size(99, 41);
            User_Name_Label.TabIndex = 0;
            User_Name_Label.Text = "User Name";
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Font = new Font("Assaf Font", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_Label.ForeColor = Color.MidnightBlue;
            Password_Label.Location = new Point(535, 153);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(89, 41);
            Password_Label.TabIndex = 1;
            Password_Label.Text = "Password";
            // 
            // EmployeeUserName_Log
            // 
            EmployeeUserName_Log.BorderStyle = BorderStyle.None;
            EmployeeUserName_Log.Location = new Point(544, 118);
            EmployeeUserName_Log.Name = "EmployeeUserName_Log";
            EmployeeUserName_Log.Size = new Size(141, 16);
            EmployeeUserName_Log.TabIndex = 2;
            // 
            // EmployeePassword_Log
            // 
            EmployeePassword_Log.BorderStyle = BorderStyle.None;
            EmployeePassword_Log.Location = new Point(544, 192);
            EmployeePassword_Log.Name = "EmployeePassword_Log";
            EmployeePassword_Log.PasswordChar = '*';
            EmployeePassword_Log.Size = new Size(141, 16);
            EmployeePassword_Log.TabIndex = 3;
            // 
            // Employee_LogInBox
            // 
            Employee_LogInBox.BackgroundImage = (Image)resources.GetObject("Employee_LogInBox.BackgroundImage");
            Employee_LogInBox.FlatStyle = FlatStyle.Flat;
            Employee_LogInBox.Font = new Font("ArabicModern", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employee_LogInBox.ForeColor = SystemColors.Window;
            Employee_LogInBox.Location = new Point(526, 239);
            Employee_LogInBox.Name = "Employee_LogInBox";
            Employee_LogInBox.Size = new Size(198, 49);
            Employee_LogInBox.TabIndex = 4;
            Employee_LogInBox.Text = "Log In";
            Employee_LogInBox.UseVisualStyleBackColor = true;
            Employee_LogInBox.Click += Employee_LogInBox_Click;
            // 
            // Registrate
            // 
            Registrate.AutoSize = true;
            Registrate.Location = new Point(592, 331);
            Registrate.Name = "Registrate";
            Registrate.Size = new Size(59, 15);
            Registrate.TabIndex = 5;
            Registrate.TabStop = true;
            Registrate.Text = "Registrate";
            Registrate.LinkClicked += Registrate_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("BlueOcean", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(572, 304);
            label3.Name = "label3";
            label3.Size = new Size(106, 16);
            label3.TabIndex = 6;
            label3.Text = "Not Registrated ?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(735, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(544, 397);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(159, 28);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(691, 186);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 22);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(694, 113);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(17, 21);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(455, 23);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(28, 25);
            BackButton_Edit.TabIndex = 91;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // Employee_Log_In
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton_Edit);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(Registrate);
            Controls.Add(Employee_LogInBox);
            Controls.Add(EmployeePassword_Log);
            Controls.Add(EmployeeUserName_Log);
            Controls.Add(Password_Label);
            Controls.Add(User_Name_Label);
            Name = "Employee_Log_In";
            Text = "Employee_Log_In";
            Load += Employee_Log_In_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label User_Name_Label;
        private Label Password_Label;
        private TextBox EmployeeUserName_Log;
        private TextBox EmployeePassword_Log;
        private LinkLabel Registrate;
        private Label label3;
        public Button Employee_LogInBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button BackButton_Edit;
    }
}