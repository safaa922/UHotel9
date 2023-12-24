namespace UHotel9
{
    partial class Edit_Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Reservation));
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            BackButton_Edit = new Button();
            pictureBox1 = new PictureBox();
            CheckInDateBox_Edit = new DateTimePicker();
            CheckOutDateBox_Edit = new DateTimePicker();
            RoomID_Reservation_Box_Edit = new TextBox();
            GuestIDReservationBox_Edit = new TextBox();
            NextButton_Edit = new Button();
            label1 = new Label();
            GuestReservationLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Vanilla Extract", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(38, 16);
            label5.Name = "label5";
            label5.Size = new Size(167, 36);
            label5.TabIndex = 18;
            label5.Text = ". . . . . . . . ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Athletic Outfit", 38.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(279, 66);
            label4.Name = "label4";
            label4.Size = new Size(325, 65);
            label4.TabIndex = 16;
            label4.Text = "Edit Reservation";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(BackButton_Edit);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(CheckInDateBox_Edit);
            groupBox1.Controls.Add(CheckOutDateBox_Edit);
            groupBox1.Controls.Add(RoomID_Reservation_Box_Edit);
            groupBox1.Controls.Add(GuestIDReservationBox_Edit);
            groupBox1.Controls.Add(NextButton_Edit);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(GuestReservationLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(179, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(551, 436);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(25, 11);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(35, 33);
            BackButton_Edit.TabIndex = 11;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(163, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 36);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // CheckInDateBox_Edit
            // 
            CheckInDateBox_Edit.Location = new Point(306, 208);
            CheckInDateBox_Edit.Name = "CheckInDateBox_Edit";
            CheckInDateBox_Edit.Size = new Size(143, 23);
            CheckInDateBox_Edit.TabIndex = 3;
            // 
            // CheckOutDateBox_Edit
            // 
            CheckOutDateBox_Edit.Location = new Point(306, 257);
            CheckOutDateBox_Edit.Name = "CheckOutDateBox_Edit";
            CheckOutDateBox_Edit.Size = new Size(143, 23);
            CheckOutDateBox_Edit.TabIndex = 4;
            // 
            // RoomID_Reservation_Box_Edit
            // 
            RoomID_Reservation_Box_Edit.BackColor = SystemColors.HighlightText;
            RoomID_Reservation_Box_Edit.BorderStyle = BorderStyle.None;
            RoomID_Reservation_Box_Edit.Location = new Point(306, 117);
            RoomID_Reservation_Box_Edit.Name = "RoomID_Reservation_Box_Edit";
            RoomID_Reservation_Box_Edit.Size = new Size(143, 16);
            RoomID_Reservation_Box_Edit.TabIndex = 0;
            // 
            // GuestIDReservationBox_Edit
            // 
            GuestIDReservationBox_Edit.BorderStyle = BorderStyle.None;
            GuestIDReservationBox_Edit.Location = new Point(306, 167);
            GuestIDReservationBox_Edit.Name = "GuestIDReservationBox_Edit";
            GuestIDReservationBox_Edit.Size = new Size(143, 16);
            GuestIDReservationBox_Edit.TabIndex = 1;
            // 
            // NextButton_Edit
            // 
            NextButton_Edit.BackgroundImage = (Image)resources.GetObject("NextButton_Edit.BackgroundImage");
            NextButton_Edit.BackgroundImageLayout = ImageLayout.Stretch;
            NextButton_Edit.FlatStyle = FlatStyle.Flat;
            NextButton_Edit.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextButton_Edit.ForeColor = SystemColors.Info;
            NextButton_Edit.Location = new Point(163, 327);
            NextButton_Edit.Name = "NextButton_Edit";
            NextButton_Edit.Size = new Size(225, 50);
            NextButton_Edit.TabIndex = 9;
            NextButton_Edit.Text = "Next";
            NextButton_Edit.UseVisualStyleBackColor = true;
            NextButton_Edit.Click += NextButton_Edit_Click;
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
            // GuestReservationLabel
            // 
            GuestReservationLabel.AutoSize = true;
            GuestReservationLabel.BackColor = Color.Transparent;
            GuestReservationLabel.Font = new Font("Segoe Print", 12.75F, FontStyle.Bold);
            GuestReservationLabel.ForeColor = SystemColors.Desktop;
            GuestReservationLabel.Location = new Point(110, 159);
            GuestReservationLabel.Name = "GuestReservationLabel";
            GuestReservationLabel.Size = new Size(85, 30);
            GuestReservationLabel.TabIndex = 8;
            GuestReservationLabel.Text = "Guest ID";
            GuestReservationLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            label3.Location = new Point(110, 109);
            label3.Name = "label3";
            label3.Size = new Size(138, 30);
            label3.TabIndex = 7;
            label3.Text = "Room Number";
            // 
            // Edit_Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(926, 700);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Edit_Reservation";
            Text = "Edit_Reservation";
            Load += Edit_Reservation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private Button BackButton_Edit;
        private PictureBox pictureBox1;
        private DateTimePicker CheckInDateBox_Edit;
        private DateTimePicker CheckOutDateBox_Edit;
        private TextBox RoomID_Reservation_Box_Edit;
        private TextBox GuestIDReservationBox_Edit;
        private Button NextButton_Edit;
        private Label label1;
        private Label GuestReservationLabel;
        private Label label2;
        private Label label3;
    }
}