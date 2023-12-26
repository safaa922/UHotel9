namespace UHotel9
{
    partial class RoomsEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsEdit));
            BackButton_Edit = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            labellll = new Label();
            labelllll = new Label();
            SaveButton = new Button();
            RoomPriceEditBox = new TextBox();
            RoomTypeEditBox = new ComboBox();
            RoomFormLabel = new Label();
            RoomFloorNumberEditBox = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.FlatStyle = FlatStyle.Popup;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(51, 30);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(35, 33);
            BackButton_Edit.TabIndex = 92;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labellll);
            groupBox1.Controls.Add(labelllll);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(RoomPriceEditBox);
            groupBox1.Controls.Add(RoomTypeEditBox);
            groupBox1.Controls.Add(RoomFormLabel);
            groupBox1.Controls.Add(RoomFloorNumberEditBox);
            groupBox1.Location = new Point(194, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 437);
            groupBox1.TabIndex = 93;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(122, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 25);
            pictureBox1.TabIndex = 104;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Assaf Font", 15.7499981F);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(57, 214);
            label2.Name = "label2";
            label2.Size = new Size(88, 36);
            label2.TabIndex = 103;
            label2.Text = "Room Price";
            // 
            // labellll
            // 
            labellll.AutoSize = true;
            labellll.BackColor = Color.Transparent;
            labellll.Font = new Font("Assaf Font", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labellll.ForeColor = SystemColors.WindowFrame;
            labellll.Location = new Point(58, 160);
            labellll.Name = "labellll";
            labellll.Size = new Size(87, 36);
            labellll.TabIndex = 102;
            labellll.Text = "Room Type";
            // 
            // labelllll
            // 
            labelllll.AutoSize = true;
            labelllll.BackColor = Color.Transparent;
            labelllll.Font = new Font("Assaf Font", 15.7499981F);
            labelllll.ForeColor = SystemColors.WindowFrame;
            labelllll.Location = new Point(57, 269);
            labelllll.Name = "labelllll";
            labelllll.Size = new Size(99, 36);
            labelllll.TabIndex = 101;
            labelllll.Text = "Floor Number";
            // 
            // SaveButton
            // 
            SaveButton.BackgroundImage = (Image)resources.GetObject("SaveButton.BackgroundImage");
            SaveButton.BackgroundImageLayout = ImageLayout.Stretch;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Assaf Font", 21.75F);
            SaveButton.ForeColor = SystemColors.ButtonHighlight;
            SaveButton.Location = new Point(131, 346);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(153, 56);
            SaveButton.TabIndex = 100;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // RoomPriceEditBox
            // 
            RoomPriceEditBox.Location = new Point(189, 222);
            RoomPriceEditBox.Name = "RoomPriceEditBox";
            RoomPriceEditBox.Size = new Size(170, 23);
            RoomPriceEditBox.TabIndex = 99;
            // 
            // RoomTypeEditBox
            // 
            RoomTypeEditBox.FormattingEnabled = true;
            RoomTypeEditBox.Items.AddRange(new object[] { "Single", "Double", "Suite" });
            RoomTypeEditBox.Location = new Point(189, 168);
            RoomTypeEditBox.Name = "RoomTypeEditBox";
            RoomTypeEditBox.Size = new Size(170, 23);
            RoomTypeEditBox.TabIndex = 98;
            // 
            // RoomFormLabel
            // 
            RoomFormLabel.AutoSize = true;
            RoomFormLabel.BackColor = Color.Transparent;
            RoomFormLabel.BorderStyle = BorderStyle.Fixed3D;
            RoomFormLabel.Font = new Font("Athletic Outfit", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomFormLabel.ForeColor = SystemColors.InfoText;
            RoomFormLabel.Location = new Point(91, 30);
            RoomFormLabel.Name = "RoomFormLabel";
            RoomFormLabel.Size = new Size(236, 63);
            RoomFormLabel.TabIndex = 97;
            RoomFormLabel.Text = "Rooms Edit";
            // 
            // RoomFloorNumberEditBox
            // 
            RoomFloorNumberEditBox.Location = new Point(189, 277);
            RoomFloorNumberEditBox.Name = "RoomFloorNumberEditBox";
            RoomFloorNumberEditBox.Size = new Size(170, 23);
            RoomFloorNumberEditBox.TabIndex = 96;
            // 
            // RoomsEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 573);
            Controls.Add(groupBox1);
            Controls.Add(BackButton_Edit);
            Name = "RoomsEdit";
            Text = "RoomsEdit";
            Load += RoomsEdit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BackButton_Edit;
        private GroupBox groupBox1;
        private Label label2;
        private Label labellll;
        private Label labelllll;
        private Button SaveButton;
        private TextBox RoomPriceEditBox;
        private ComboBox RoomTypeEditBox;
        private Label RoomFormLabel;
        private TextBox RoomFloorNumberEditBox;
        private PictureBox pictureBox1;
    }
}