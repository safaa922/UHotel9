namespace UHotel9
{
    partial class check_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(check_Room));
            groupBox1 = new GroupBox();
            BackButton_Edit = new Button();
            pictureBox1 = new PictureBox();
            CheckInDateBox = new DateTimePicker();
            CheckOutDateBox = new DateTimePicker();
            RoomIDReservationBox = new TextBox();
            NextButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(BackButton_Edit);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(CheckInDateBox);
            groupBox1.Controls.Add(CheckOutDateBox);
            groupBox1.Controls.Add(RoomIDReservationBox);
            groupBox1.Controls.Add(NextButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(1, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 497);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(35, 11);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(35, 33);
            BackButton_Edit.TabIndex = 92;
            BackButton_Edit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(163, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 36);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // CheckInDateBox
            // 
            CheckInDateBox.Location = new Point(306, 208);
            CheckInDateBox.Name = "CheckInDateBox";
            CheckInDateBox.Size = new Size(143, 23);
            CheckInDateBox.TabIndex = 3;
            // 
            // CheckOutDateBox
            // 
            CheckOutDateBox.Location = new Point(306, 257);
            CheckOutDateBox.Name = "CheckOutDateBox";
            CheckOutDateBox.Size = new Size(143, 23);
            CheckOutDateBox.TabIndex = 4;
            // 
            // RoomIDReservationBox
            // 
            RoomIDReservationBox.BackColor = SystemColors.HighlightText;
            RoomIDReservationBox.BorderStyle = BorderStyle.None;
            RoomIDReservationBox.Location = new Point(306, 153);
            RoomIDReservationBox.Name = "RoomIDReservationBox";
            RoomIDReservationBox.Size = new Size(143, 16);
            RoomIDReservationBox.TabIndex = 0;
            // 
            // NextButton
            // 
            NextButton.BackgroundImage = (Image)resources.GetObject("NextButton.BackgroundImage");
            NextButton.BackgroundImageLayout = ImageLayout.Stretch;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextButton.ForeColor = SystemColors.Info;
            NextButton.Location = new Point(163, 327);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(225, 50);
            NextButton.TabIndex = 9;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 12.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(110, 252);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 5;
            label1.Text = "Check Out Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 12.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(110, 203);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 6;
            label2.Text = "Check in Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 12.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(122, 143);
            label3.Name = "label3";
            label3.Size = new Size(138, 30);
            label3.TabIndex = 7;
            label3.Text = "Room Number";
            // 
            // check_Room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "check_Room";
            Text = "check_Room";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BackButton_Edit;
        private PictureBox pictureBox1;
        private DateTimePicker CheckInDateBox;
        private DateTimePicker CheckOutDateBox;
        private TextBox RoomIDReservationBox;
        private Button NextButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}