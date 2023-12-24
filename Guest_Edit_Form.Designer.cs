namespace UHotel9
{
    partial class Guest_Edit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_Edit_Form));
            groupBox1 = new GroupBox();
            BackButton_Edit = new Button();
            RoomFormLabel = new Label();
            GuestSaveEditButton = new Button();
            GuestRoomNumberBoxEdit = new TextBox();
            RoomNumLabel = new Label();
            GuestStatusBoxEdit = new ComboBox();
            Guest_GenderBoxEdit = new ComboBox();
            Guest_CountryBoxEdit = new TextBox();
            label1 = new Label();
            Guest_CityBoxEdit = new TextBox();
            Guest_PhoneBoxEdit = new TextBox();
            Guest_EmailBoxEdit = new TextBox();
            Guest_IdBoxEdit = new TextBox();
            Guest_LNameBoxEdit = new TextBox();
            Guest_FNameBoxEdit = new TextBox();
            Employee_IdLabel = new Label();
            Employee_FNameLabel = new Label();
            Employee_GenderLabel = new Label();
            Employee_StatusBox = new Label();
            Employee_CityLabel = new Label();
            Employye_EmailLabel = new Label();
            label3 = new Label();
            Employee_LNameLabel = new Label();
            pictureBox1 = new PictureBox();
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
            groupBox1.Controls.Add(GuestSaveEditButton);
            groupBox1.Controls.Add(GuestRoomNumberBoxEdit);
            groupBox1.Controls.Add(RoomNumLabel);
            groupBox1.Controls.Add(GuestStatusBoxEdit);
            groupBox1.Controls.Add(Guest_GenderBoxEdit);
            groupBox1.Controls.Add(Guest_CountryBoxEdit);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Guest_CityBoxEdit);
            groupBox1.Controls.Add(Guest_PhoneBoxEdit);
            groupBox1.Controls.Add(Guest_EmailBoxEdit);
            groupBox1.Controls.Add(Guest_IdBoxEdit);
            groupBox1.Controls.Add(Guest_LNameBoxEdit);
            groupBox1.Controls.Add(Guest_FNameBoxEdit);
            groupBox1.Controls.Add(Employee_IdLabel);
            groupBox1.Controls.Add(Employee_FNameLabel);
            groupBox1.Controls.Add(Employee_GenderLabel);
            groupBox1.Controls.Add(Employee_StatusBox);
            groupBox1.Controls.Add(Employee_CityLabel);
            groupBox1.Controls.Add(Employye_EmailLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Employee_LNameLabel);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(186, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(686, 617);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(40, 38);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(35, 33);
            BackButton_Edit.TabIndex = 91;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // RoomFormLabel
            // 
            RoomFormLabel.AutoSize = true;
            RoomFormLabel.BackColor = Color.Transparent;
            RoomFormLabel.BorderStyle = BorderStyle.Fixed3D;
            RoomFormLabel.FlatStyle = FlatStyle.System;
            RoomFormLabel.Font = new Font("Mishaland", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomFormLabel.ForeColor = Color.RoyalBlue;
            RoomFormLabel.Location = new Point(343, 29);
            RoomFormLabel.Name = "RoomFormLabel";
            RoomFormLabel.Size = new Size(280, 80);
            RoomFormLabel.TabIndex = 88;
            RoomFormLabel.Text = "Guests Form";
            // 
            // GuestSaveEditButton
            // 
            GuestSaveEditButton.BackColor = Color.Goldenrod;
            GuestSaveEditButton.BackgroundImage = (Image)resources.GetObject("GuestSaveEditButton.BackgroundImage");
            GuestSaveEditButton.BackgroundImageLayout = ImageLayout.Stretch;
            GuestSaveEditButton.FlatStyle = FlatStyle.Flat;
            GuestSaveEditButton.Font = new Font("AlHadari ", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            GuestSaveEditButton.ForeColor = SystemColors.ControlLightLight;
            GuestSaveEditButton.Location = new Point(252, 521);
            GuestSaveEditButton.Name = "GuestSaveEditButton";
            GuestSaveEditButton.Size = new Size(199, 50);
            GuestSaveEditButton.TabIndex = 87;
            GuestSaveEditButton.Text = "Save";
            GuestSaveEditButton.UseVisualStyleBackColor = false;
            GuestSaveEditButton.Click += GuestSaveButton_Click_1;
            // 
            // GuestRoomNumberBoxEdit
            // 
            GuestRoomNumberBoxEdit.BackColor = Color.SandyBrown;
            GuestRoomNumberBoxEdit.Location = new Point(474, 434);
            GuestRoomNumberBoxEdit.Name = "GuestRoomNumberBoxEdit";
            GuestRoomNumberBoxEdit.Size = new Size(149, 23);
            GuestRoomNumberBoxEdit.TabIndex = 86;
            // 
            // RoomNumLabel
            // 
            RoomNumLabel.AutoSize = true;
            RoomNumLabel.BackColor = Color.Transparent;
            RoomNumLabel.Font = new Font("Assaf Font", 15.7499981F);
            RoomNumLabel.ForeColor = Color.DarkSlateBlue;
            RoomNumLabel.Location = new Point(368, 426);
            RoomNumLabel.Name = "RoomNumLabel";
            RoomNumLabel.Size = new Size(106, 36);
            RoomNumLabel.TabIndex = 85;
            RoomNumLabel.Text = "Room Number";
            // 
            // GuestStatusBoxEdit
            // 
            GuestStatusBoxEdit.BackColor = Color.FromArgb(255, 192, 128);
            GuestStatusBoxEdit.FormattingEnabled = true;
            GuestStatusBoxEdit.Items.AddRange(new object[] { "single", "married", "engaged" });
            GuestStatusBoxEdit.Location = new Point(474, 396);
            GuestStatusBoxEdit.Name = "GuestStatusBoxEdit";
            GuestStatusBoxEdit.Size = new Size(149, 23);
            GuestStatusBoxEdit.TabIndex = 84;
            // 
            // Guest_GenderBoxEdit
            // 
            Guest_GenderBoxEdit.BackColor = Color.SeaShell;
            Guest_GenderBoxEdit.FormattingEnabled = true;
            Guest_GenderBoxEdit.Items.AddRange(new object[] { "Male", "Female" });
            Guest_GenderBoxEdit.Location = new Point(474, 211);
            Guest_GenderBoxEdit.Name = "Guest_GenderBoxEdit";
            Guest_GenderBoxEdit.Size = new Size(149, 23);
            Guest_GenderBoxEdit.TabIndex = 83;
            // 
            // Guest_CountryBoxEdit
            // 
            Guest_CountryBoxEdit.BackColor = Color.BlanchedAlmond;
            Guest_CountryBoxEdit.Location = new Point(474, 285);
            Guest_CountryBoxEdit.Name = "Guest_CountryBoxEdit";
            Guest_CountryBoxEdit.Size = new Size(149, 23);
            Guest_CountryBoxEdit.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Assaf Font", 15.7499981F);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(363, 277);
            label1.Name = "label1";
            label1.Size = new Size(67, 36);
            label1.TabIndex = 81;
            label1.Text = "Country";
            // 
            // Guest_CityBoxEdit
            // 
            Guest_CityBoxEdit.BackColor = Color.NavajoWhite;
            Guest_CityBoxEdit.Location = new Point(474, 328);
            Guest_CityBoxEdit.Name = "Guest_CityBoxEdit";
            Guest_CityBoxEdit.Size = new Size(149, 23);
            Guest_CityBoxEdit.TabIndex = 80;
            // 
            // Guest_PhoneBoxEdit
            // 
            Guest_PhoneBoxEdit.BackColor = SystemColors.Menu;
            Guest_PhoneBoxEdit.Location = new Point(158, 434);
            Guest_PhoneBoxEdit.Name = "Guest_PhoneBoxEdit";
            Guest_PhoneBoxEdit.Size = new Size(149, 23);
            Guest_PhoneBoxEdit.TabIndex = 79;
            // 
            // Guest_EmailBoxEdit
            // 
            Guest_EmailBoxEdit.BackColor = SystemColors.GradientInactiveCaption;
            Guest_EmailBoxEdit.Location = new Point(158, 396);
            Guest_EmailBoxEdit.Name = "Guest_EmailBoxEdit";
            Guest_EmailBoxEdit.Size = new Size(149, 23);
            Guest_EmailBoxEdit.TabIndex = 78;
            // 
            // Guest_IdBoxEdit
            // 
            Guest_IdBoxEdit.BackColor = Color.SteelBlue;
            Guest_IdBoxEdit.Location = new Point(158, 211);
            Guest_IdBoxEdit.Name = "Guest_IdBoxEdit";
            Guest_IdBoxEdit.Size = new Size(149, 23);
            Guest_IdBoxEdit.TabIndex = 77;
            // 
            // Guest_LNameBoxEdit
            // 
            Guest_LNameBoxEdit.BackColor = SystemColors.GradientActiveCaption;
            Guest_LNameBoxEdit.Location = new Point(158, 328);
            Guest_LNameBoxEdit.Name = "Guest_LNameBoxEdit";
            Guest_LNameBoxEdit.Size = new Size(149, 23);
            Guest_LNameBoxEdit.TabIndex = 76;
            // 
            // Guest_FNameBoxEdit
            // 
            Guest_FNameBoxEdit.BackColor = Color.CornflowerBlue;
            Guest_FNameBoxEdit.Location = new Point(158, 285);
            Guest_FNameBoxEdit.Name = "Guest_FNameBoxEdit";
            Guest_FNameBoxEdit.Size = new Size(149, 23);
            Guest_FNameBoxEdit.TabIndex = 75;
            // 
            // Employee_IdLabel
            // 
            Employee_IdLabel.AutoSize = true;
            Employee_IdLabel.BackColor = Color.Transparent;
            Employee_IdLabel.Font = new Font("Assaf Font", 15.7499981F);
            Employee_IdLabel.ForeColor = Color.DarkSlateBlue;
            Employee_IdLabel.Location = new Point(41, 203);
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
            Employee_FNameLabel.Location = new Point(41, 272);
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
            Employee_GenderLabel.Location = new Point(363, 203);
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
            Employee_StatusBox.Location = new Point(368, 383);
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
            Employee_CityLabel.Location = new Point(368, 320);
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
            Employye_EmailLabel.Location = new Point(40, 383);
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
            label3.Location = new Point(40, 426);
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
            Employee_LNameLabel.Location = new Point(40, 315);
            Employee_LNameLabel.Name = "Employee_LNameLabel";
            Employee_LNameLabel.Size = new Size(84, 36);
            Employee_LNameLabel.TabIndex = 67;
            Employee_LNameLabel.Text = "Last Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(273, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 18);
            pictureBox1.TabIndex = 92;
            pictureBox1.TabStop = false;
            // 
            // Guest_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1047, 749);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Guest_Edit_Form";
            Text = "EditForm";
            Load += EditForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label RoomFormLabel;
        private Button GuestSaveEditButton;
        private TextBox GuestRoomNumberBoxEdit;
        private Label RoomNumLabel;
        private ComboBox GuestStatusBoxEdit;
        private ComboBox Guest_GenderBoxEdit;
        private TextBox Guest_CountryBoxEdit;
        private Label label1;
        private TextBox Guest_CityBoxEdit;
        private TextBox Guest_PhoneBoxEdit;
        private TextBox Guest_EmailBoxEdit;
        private TextBox Guest_IdBoxEdit;
        private TextBox Guest_LNameBoxEdit;
        private TextBox Guest_FNameBoxEdit;
        private Label Employee_IdLabel;
        private Label Employee_FNameLabel;
        private Label Employee_GenderLabel;
        private Label Employee_StatusBox;
        private Label Employee_CityLabel;
        private Label Employye_EmailLabel;
        private Label label3;
        private Label Employee_LNameLabel;
        private Button BackButton_Edit;
        private PictureBox pictureBox1;
    }
}