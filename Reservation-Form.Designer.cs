namespace UHotel9
{
    partial class Reservation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation_Form));
            groupBox1 = new GroupBox();
            BackButton_Edit = new Button();
            pictureBox1 = new PictureBox();
            CheckInDateBox = new DateTimePicker();
            CheckOutDateBox = new DateTimePicker();
            RoomIDReservationBox = new TextBox();
            GuestIDReservationBox = new TextBox();
            Confirm = new Button();
            label1 = new Label();
            GuestReservationLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            totalCost = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            groupBox1.Controls.Add(GuestIDReservationBox);
            groupBox1.Controls.Add(Confirm);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(GuestReservationLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(149, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(551, 436);
            groupBox1.TabIndex = 14;
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
            pictureBox1.Location = new Point(163, 22);
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
            RoomIDReservationBox.Location = new Point(306, 117);
            RoomIDReservationBox.Name = "RoomIDReservationBox";
            RoomIDReservationBox.Size = new Size(143, 16);
            RoomIDReservationBox.TabIndex = 0;
            // 
            // GuestIDReservationBox
            // 
            GuestIDReservationBox.BorderStyle = BorderStyle.None;
            GuestIDReservationBox.Location = new Point(306, 167);
            GuestIDReservationBox.Name = "GuestIDReservationBox";
            GuestIDReservationBox.Size = new Size(143, 16);
            GuestIDReservationBox.TabIndex = 1;
            // 
            // Confirm
            // 
            Confirm.BackgroundImage = (Image)resources.GetObject("Confirm.BackgroundImage");
            Confirm.BackgroundImageLayout = ImageLayout.Stretch;
            Confirm.FlatStyle = FlatStyle.Flat;
            Confirm.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Confirm.ForeColor = SystemColors.Info;
            Confirm.Location = new Point(163, 327);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(225, 50);
            Confirm.TabIndex = 9;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += NextButton_Click_1;
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
            // totalCost
            // 
            totalCost.BackgroundImage = (Image)resources.GetObject("totalCost.BackgroundImage");
            totalCost.BackgroundImageLayout = ImageLayout.Stretch;
            totalCost.FlatStyle = FlatStyle.Flat;
            totalCost.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCost.ForeColor = SystemColors.Info;
            totalCost.Location = new Point(149, 626);
            totalCost.Name = "totalCost";
            totalCost.Size = new Size(111, 36);
            totalCost.TabIndex = 93;
            totalCost.Text = "Total Cost";
            totalCost.UseVisualStyleBackColor = true;
            totalCost.Click += totalCost_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Athletic Outfit", 38.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(257, 48);
            label4.Name = "label4";
            label4.Size = new Size(341, 65);
            label4.TabIndex = 11;
            label4.Text = "Reservation Form";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Vanilla Extract", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(24, -7);
            label5.Name = "label5";
            label5.Size = new Size(167, 36);
            label5.TabIndex = 15;
            label5.Text = ". . . . . . . . ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Vanilla Extract", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(681, 682);
            label6.Name = "label6";
            label6.Size = new Size(167, 36);
            label6.TabIndex = 16;
            label6.Text = ". . . . . . . . ";
            // 
            // Reservation_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(860, 749);
            Controls.Add(totalCost);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Reservation_Form";
            Text = "Reservation_Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private DateTimePicker CheckInDateBox;
        private DateTimePicker CheckOutDateBox;
        private TextBox RoomIDReservationBox;
        private TextBox GuestIDReservationBox;
        private Button Confirm;
        private Label label1;
        private Label GuestReservationLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BackButton_Edit;
        private Button totalCost;
        // private Button TotalCost;
    }
}