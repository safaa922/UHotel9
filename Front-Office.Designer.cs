namespace UHotel9
{
    partial class Front_Office
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Front_Office));
            pictureBox1 = new PictureBox();
            BackButton_Edit = new Button();
            Dresrvation = new Button();
            FsShowRoomInfoButton = new Button();
            Home_Page_Label = new Label();
            FsReservationFormButton = new Button();
            pictureBox2 = new PictureBox();
            EmptyRooms = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(388, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 500);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.FlatStyle = FlatStyle.Popup;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(22, 21);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(30, 30);
            BackButton_Edit.TabIndex = 97;
            BackButton_Edit.UseVisualStyleBackColor = false;
            // 
            // Dresrvation
            // 
            Dresrvation.BackColor = Color.Transparent;
            Dresrvation.BackgroundImageLayout = ImageLayout.Stretch;
            Dresrvation.FlatStyle = FlatStyle.Popup;
            Dresrvation.Font = new Font("Cocon® Next Arabic", 12.75F);
            Dresrvation.ForeColor = Color.Coral;
            Dresrvation.Location = new Point(107, 329);
            Dresrvation.Name = "Dresrvation";
            Dresrvation.Size = new Size(160, 40);
            Dresrvation.TabIndex = 96;
            Dresrvation.Text = "Data Reservation";
            Dresrvation.UseVisualStyleBackColor = false;
            Dresrvation.Click += Dresrvation_Click_1;
            // 
            // FsShowRoomInfoButton
            // 
            FsShowRoomInfoButton.BackColor = Color.Transparent;
            FsShowRoomInfoButton.BackgroundImageLayout = ImageLayout.Stretch;
            FsShowRoomInfoButton.FlatStyle = FlatStyle.Popup;
            FsShowRoomInfoButton.Font = new Font("Cocon® Next Arabic", 12.75F);
            FsShowRoomInfoButton.ForeColor = Color.Coral;
            FsShowRoomInfoButton.Location = new Point(107, 270);
            FsShowRoomInfoButton.Name = "FsShowRoomInfoButton";
            FsShowRoomInfoButton.Size = new Size(160, 40);
            FsShowRoomInfoButton.TabIndex = 94;
            FsShowRoomInfoButton.Text = "Show Room Info";
            FsShowRoomInfoButton.UseVisualStyleBackColor = false;
            FsShowRoomInfoButton.Click += FsShowRoomInfoButton_Click;
            // 
            // Home_Page_Label
            // 
            Home_Page_Label.AutoSize = true;
            Home_Page_Label.BackColor = Color.Transparent;
            Home_Page_Label.Font = new Font("Mishaland", 32.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Home_Page_Label.ForeColor = Color.DarkSalmon;
            Home_Page_Label.Location = new Point(76, 81);
            Home_Page_Label.Name = "Home_Page_Label";
            Home_Page_Label.Size = new Size(229, 70);
            Home_Page_Label.TabIndex = 93;
            Home_Page_Label.Text = "Front Office";
            // 
            // FsReservationFormButton
            // 
            FsReservationFormButton.BackColor = Color.Transparent;
            FsReservationFormButton.BackgroundImageLayout = ImageLayout.Stretch;
            FsReservationFormButton.FlatStyle = FlatStyle.Popup;
            FsReservationFormButton.Font = new Font("Cocon® Next Arabic", 12.75F);
            FsReservationFormButton.ForeColor = Color.Coral;
            FsReservationFormButton.Location = new Point(107, 206);
            FsReservationFormButton.Name = "FsReservationFormButton";
            FsReservationFormButton.Size = new Size(160, 40);
            FsReservationFormButton.TabIndex = 92;
            FsReservationFormButton.Text = "Reservation Form";
            FsReservationFormButton.UseVisualStyleBackColor = false;
            FsReservationFormButton.Click += FsReservationFormButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(11, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 18);
            pictureBox2.TabIndex = 98;
            pictureBox2.TabStop = false;
            // 
            // EmptyRooms
            // 
            EmptyRooms.BackColor = Color.Transparent;
            EmptyRooms.BackgroundImageLayout = ImageLayout.Stretch;
            EmptyRooms.FlatStyle = FlatStyle.Popup;
            EmptyRooms.Font = new Font("Cocon® Next Arabic", 12.75F);
            EmptyRooms.ForeColor = Color.Coral;
            EmptyRooms.Location = new Point(107, 386);
            EmptyRooms.Name = "EmptyRooms";
            EmptyRooms.Size = new Size(160, 40);
            EmptyRooms.TabIndex = 99;
            EmptyRooms.Text = "Free Rooms";
            EmptyRooms.UseVisualStyleBackColor = false;
            EmptyRooms.Click += EmptyRooms_Click;
            // 
            // Front_Office
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 491);
            Controls.Add(EmptyRooms);
            Controls.Add(pictureBox2);
            Controls.Add(BackButton_Edit);
            Controls.Add(Dresrvation);
            Controls.Add(FsShowRoomInfoButton);
            Controls.Add(Home_Page_Label);
            Controls.Add(FsReservationFormButton);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Front_Office";
            Text = "Front_Office";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button BackButton_Edit;
        private Button Dresrvation;
        private Button FsShowRoomInfoButton;
        private Label Home_Page_Label;
        private Button FsReservationFormButton;
        private PictureBox pictureBox2;
        private Button EmptyRooms;
    }
}