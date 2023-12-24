namespace UHotel9
{
    partial class ViewGuests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewGuests));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            BackButton_Edit = new Button();
            RoomFormLabel = new Label();
            GuestRoomNumberBox = new TextBox();
            RoomNumLabel = new Label();
            GuestStatusBox = new ComboBox();
            Guest_GenderBox = new ComboBox();
            Guest_CountryBox = new TextBox();
            label1 = new Label();
            Guest_CityBox = new TextBox();
            Guest_PhoneBox = new TextBox();
            Guest_EmailBox = new TextBox();
            Guest_IdBox = new TextBox();
            Guest_LNameBox = new TextBox();
            Guest_FNameBox = new TextBox();
            Employee_IdLabel = new Label();
            Employee_FNameLabel = new Label();
            Employee_GenderLabel = new Label();
            Employee_StatusBox = new Label();
            Employee_CityLabel = new Label();
            Employye_EmailLabel = new Label();
            label3 = new Label();
            Employee_LNameLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GhostWhite;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(BackButton_Edit);
            groupBox1.Controls.Add(RoomFormLabel);
            groupBox1.Controls.Add(GuestRoomNumberBox);
            groupBox1.Controls.Add(RoomNumLabel);
            groupBox1.Controls.Add(GuestStatusBox);
            groupBox1.Controls.Add(Guest_GenderBox);
            groupBox1.Controls.Add(Guest_CountryBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Guest_CityBox);
            groupBox1.Controls.Add(Guest_PhoneBox);
            groupBox1.Controls.Add(Guest_EmailBox);
            groupBox1.Controls.Add(Guest_IdBox);
            groupBox1.Controls.Add(Guest_LNameBox);
            groupBox1.Controls.Add(Guest_FNameBox);
            groupBox1.Controls.Add(Employee_IdLabel);
            groupBox1.Controls.Add(Employee_FNameLabel);
            groupBox1.Controls.Add(Employee_GenderLabel);
            groupBox1.Controls.Add(Employee_StatusBox);
            groupBox1.Controls.Add(Employee_CityLabel);
            groupBox1.Controls.Add(Employye_EmailLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Employee_LNameLabel);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(169, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(707, 537);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(286, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 18);
            pictureBox1.TabIndex = 91;
            pictureBox1.TabStop = false;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(60, 32);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(35, 33);
            BackButton_Edit.TabIndex = 90;
            BackButton_Edit.UseVisualStyleBackColor = false;
            // 
            // RoomFormLabel
            // 
            RoomFormLabel.AutoSize = true;
            RoomFormLabel.BackColor = Color.Transparent;
            RoomFormLabel.BorderStyle = BorderStyle.Fixed3D;
            RoomFormLabel.Font = new Font("Mishaland", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomFormLabel.ForeColor = Color.RoyalBlue;
            RoomFormLabel.Location = new Point(356, 32);
            RoomFormLabel.Name = "RoomFormLabel";
            RoomFormLabel.Size = new Size(280, 80);
            RoomFormLabel.TabIndex = 88;
            RoomFormLabel.Text = "Guests Form";
            // 
            // GuestRoomNumberBox
            // 
            GuestRoomNumberBox.BackColor = Color.SandyBrown;
            GuestRoomNumberBox.Location = new Point(487, 443);
            GuestRoomNumberBox.Name = "GuestRoomNumberBox";
            GuestRoomNumberBox.Size = new Size(149, 23);
            GuestRoomNumberBox.TabIndex = 86;
            // 
            // RoomNumLabel
            // 
            RoomNumLabel.AutoSize = true;
            RoomNumLabel.BackColor = Color.Transparent;
            RoomNumLabel.Font = new Font("Assaf Font", 15.7499981F);
            RoomNumLabel.ForeColor = Color.DarkSlateBlue;
            RoomNumLabel.Location = new Point(375, 435);
            RoomNumLabel.Name = "RoomNumLabel";
            RoomNumLabel.Size = new Size(106, 36);
            RoomNumLabel.TabIndex = 85;
            RoomNumLabel.Text = "Room Number";
            // 
            // GuestStatusBox
            // 
            GuestStatusBox.BackColor = Color.FromArgb(255, 192, 128);
            GuestStatusBox.FormattingEnabled = true;
            GuestStatusBox.Items.AddRange(new object[] { "single", "married", "engaged" });
            GuestStatusBox.Location = new Point(487, 405);
            GuestStatusBox.Name = "GuestStatusBox";
            GuestStatusBox.Size = new Size(149, 23);
            GuestStatusBox.TabIndex = 84;
            // 
            // Guest_GenderBox
            // 
            Guest_GenderBox.BackColor = Color.SeaShell;
            Guest_GenderBox.FormattingEnabled = true;
            Guest_GenderBox.Items.AddRange(new object[] { "Male", "Female" });
            Guest_GenderBox.Location = new Point(487, 218);
            Guest_GenderBox.Name = "Guest_GenderBox";
            Guest_GenderBox.Size = new Size(149, 23);
            Guest_GenderBox.TabIndex = 83;
            // 
            // Guest_CountryBox
            // 
            Guest_CountryBox.BackColor = Color.BlanchedAlmond;
            Guest_CountryBox.Location = new Point(487, 284);
            Guest_CountryBox.Name = "Guest_CountryBox";
            Guest_CountryBox.Size = new Size(149, 23);
            Guest_CountryBox.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Assaf Font", 15.7499981F);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(375, 276);
            label1.Name = "label1";
            label1.Size = new Size(67, 36);
            label1.TabIndex = 81;
            label1.Text = "Country";
            // 
            // Guest_CityBox
            // 
            Guest_CityBox.BackColor = Color.NavajoWhite;
            Guest_CityBox.Location = new Point(487, 327);
            Guest_CityBox.Name = "Guest_CityBox";
            Guest_CityBox.Size = new Size(149, 23);
            Guest_CityBox.TabIndex = 80;
            // 
            // Guest_PhoneBox
            // 
            Guest_PhoneBox.BackColor = Color.Lavender;
            Guest_PhoneBox.Location = new Point(165, 443);
            Guest_PhoneBox.Name = "Guest_PhoneBox";
            Guest_PhoneBox.Size = new Size(149, 23);
            Guest_PhoneBox.TabIndex = 79;
            // 
            // Guest_EmailBox
            // 
            Guest_EmailBox.BackColor = SystemColors.GradientInactiveCaption;
            Guest_EmailBox.Location = new Point(165, 405);
            Guest_EmailBox.Name = "Guest_EmailBox";
            Guest_EmailBox.Size = new Size(149, 23);
            Guest_EmailBox.TabIndex = 78;
            // 
            // Guest_IdBox
            // 
            Guest_IdBox.BackColor = Color.SteelBlue;
            Guest_IdBox.Location = new Point(165, 213);
            Guest_IdBox.Name = "Guest_IdBox";
            Guest_IdBox.Size = new Size(149, 23);
            Guest_IdBox.TabIndex = 77;
            // 
            // Guest_LNameBox
            // 
            Guest_LNameBox.BackColor = SystemColors.GradientActiveCaption;
            Guest_LNameBox.Location = new Point(165, 327);
            Guest_LNameBox.Name = "Guest_LNameBox";
            Guest_LNameBox.Size = new Size(149, 23);
            Guest_LNameBox.TabIndex = 76;
            // 
            // Guest_FNameBox
            // 
            Guest_FNameBox.BackColor = Color.CornflowerBlue;
            Guest_FNameBox.Location = new Point(165, 284);
            Guest_FNameBox.Name = "Guest_FNameBox";
            Guest_FNameBox.Size = new Size(149, 23);
            Guest_FNameBox.TabIndex = 75;
            // 
            // Employee_IdLabel
            // 
            Employee_IdLabel.AutoSize = true;
            Employee_IdLabel.BackColor = Color.Transparent;
            Employee_IdLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_IdLabel.ForeColor = Color.DarkSlateBlue;
            Employee_IdLabel.Location = new Point(48, 210);
            Employee_IdLabel.Name = "Employee_IdLabel";
            Employee_IdLabel.Size = new Size(84, 36);
            Employee_IdLabel.TabIndex = 74;
            Employee_IdLabel.Text = "ID Number";
            // 
            // Employee_FNameLabel
            // 
            Employee_FNameLabel.AutoSize = true;
            Employee_FNameLabel.BackColor = Color.Transparent;
            Employee_FNameLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_FNameLabel.ForeColor = Color.DarkSlateBlue;
            Employee_FNameLabel.Location = new Point(48, 276);
            Employee_FNameLabel.Name = "Employee_FNameLabel";
            Employee_FNameLabel.Size = new Size(83, 36);
            Employee_FNameLabel.TabIndex = 73;
            Employee_FNameLabel.Text = "First Name";
            // 
            // Employee_GenderLabel
            // 
            Employee_GenderLabel.AutoSize = true;
            Employee_GenderLabel.BackColor = Color.Transparent;
            Employee_GenderLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_GenderLabel.ForeColor = Color.DarkSlateBlue;
            Employee_GenderLabel.Location = new Point(375, 210);
            Employee_GenderLabel.Name = "Employee_GenderLabel";
            Employee_GenderLabel.Size = new Size(62, 36);
            Employee_GenderLabel.TabIndex = 72;
            Employee_GenderLabel.Text = "Gender";
            // 
            // Employee_StatusBox
            // 
            Employee_StatusBox.AutoSize = true;
            Employee_StatusBox.BackColor = Color.Transparent;
            Employee_StatusBox.Font = new Font("Assaf Font", 15.7499981F);
            Employee_StatusBox.ForeColor = Color.DarkSlateBlue;
            Employee_StatusBox.Location = new Point(375, 392);
            Employee_StatusBox.Name = "Employee_StatusBox";
            Employee_StatusBox.Size = new Size(57, 36);
            Employee_StatusBox.TabIndex = 71;
            Employee_StatusBox.Text = "Status";
            // 
            // Employee_CityLabel
            // 
            Employee_CityLabel.AutoSize = true;
            Employee_CityLabel.BackColor = Color.Transparent;
            Employee_CityLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_CityLabel.ForeColor = Color.DarkSlateBlue;
            Employee_CityLabel.Location = new Point(375, 319);
            Employee_CityLabel.Name = "Employee_CityLabel";
            Employee_CityLabel.Size = new Size(42, 36);
            Employee_CityLabel.TabIndex = 70;
            Employee_CityLabel.Text = "City";
            // 
            // Employye_EmailLabel
            // 
            Employye_EmailLabel.AutoSize = true;
            Employye_EmailLabel.BackColor = Color.Transparent;
            Employye_EmailLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employye_EmailLabel.ForeColor = Color.DarkSlateBlue;
            Employye_EmailLabel.Location = new Point(47, 392);
            Employye_EmailLabel.Name = "Employye_EmailLabel";
            Employye_EmailLabel.Size = new Size(48, 36);
            Employye_EmailLabel.TabIndex = 69;
            Employye_EmailLabel.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Assaf Font", 15.7499981F);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(47, 435);
            label3.Name = "label3";
            label3.Size = new Size(110, 36);
            label3.TabIndex = 68;
            label3.Text = "Phone Number";
            // 
            // Employee_LNameLabel
            // 
            Employee_LNameLabel.AutoSize = true;
            Employee_LNameLabel.BackColor = Color.Transparent;
            Employee_LNameLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_LNameLabel.ForeColor = Color.DarkSlateBlue;
            Employee_LNameLabel.Location = new Point(47, 319);
            Employee_LNameLabel.Name = "Employee_LNameLabel";
            Employee_LNameLabel.Size = new Size(84, 36);
            Employee_LNameLabel.TabIndex = 67;
            Employee_LNameLabel.Text = "Last Name";
            // 
            // ViewGuests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 749);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewGuests";
            Text = "ViewGuests";
            Load += ViewGuests_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BackButton_Edit;
        private Label RoomFormLabel;
        private TextBox GuestRoomNumberBox;
        private Label RoomNumLabel;
        private ComboBox GuestStatusBox;
        private ComboBox Guest_GenderBox;
        private TextBox Guest_CountryBox;
        private Label label1;
        private TextBox Guest_CityBox;
        private TextBox Guest_PhoneBox;
        private TextBox Guest_EmailBox;
        private TextBox Guest_IdBox;
        private TextBox Guest_LNameBox;
        private TextBox Guest_FNameBox;
        private Label Employee_IdLabel;
        private Label Employee_FNameLabel;
        private Label Employee_GenderLabel;
        private Label Employee_StatusBox;
        private Label Employee_CityLabel;
        private Label Employye_EmailLabel;
        private Label label3;
        private Label Employee_LNameLabel;
        private PictureBox pictureBox1;
    }
}