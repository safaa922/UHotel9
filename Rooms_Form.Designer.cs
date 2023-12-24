using System.Drawing.Drawing2D;

namespace UHotel9
{
    partial class Rooms_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms_Form));
            BackButton_Edit = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            SaveButton = new Button();
            RoomPriceBox = new TextBox();
            label2 = new Label();
            RoomTypeBox = new ComboBox();
            RoomFormLabel = new Label();
            RoomFloorNumberBox = new TextBox();
            labellll = new Label();
            labelllll = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(41, 21);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(35, 33);
            BackButton_Edit.TabIndex = 92;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(RoomPriceBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(RoomTypeBox);
            groupBox1.Controls.Add(RoomFormLabel);
            groupBox1.Controls.Add(RoomFloorNumberBox);
            groupBox1.Controls.Add(labellll);
            groupBox1.Controls.Add(labelllll);
            groupBox1.Location = new Point(160, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 440);
            groupBox1.TabIndex = 93;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(133, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 25);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // SaveButton
            // 
            SaveButton.BackgroundImage = (Image)resources.GetObject("SaveButton.BackgroundImage");
            SaveButton.BackgroundImageLayout = ImageLayout.Stretch;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Assaf Font", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = SystemColors.ButtonHighlight;
            SaveButton.Location = new Point(148, 338);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(153, 54);
            SaveButton.TabIndex = 23;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // RoomPriceBox
            // 
            RoomPriceBox.Location = new Point(203, 224);
            RoomPriceBox.Name = "RoomPriceBox";
            RoomPriceBox.Size = new Size(170, 23);
            RoomPriceBox.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Assaf Font", 15.7499981F);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(87, 216);
            label2.Name = "label2";
            label2.Size = new Size(88, 36);
            label2.TabIndex = 21;
            label2.Text = "Room Price";
            // 
            // RoomTypeBox
            // 
            RoomTypeBox.FormattingEnabled = true;
            RoomTypeBox.Items.AddRange(new object[] { "Single", "Double", "Suite" });
            RoomTypeBox.Location = new Point(203, 170);
            RoomTypeBox.Name = "RoomTypeBox";
            RoomTypeBox.Size = new Size(170, 23);
            RoomTypeBox.TabIndex = 20;
            // 
            // RoomFormLabel
            // 
            RoomFormLabel.AutoSize = true;
            RoomFormLabel.BackColor = Color.Transparent;
            RoomFormLabel.BorderStyle = BorderStyle.Fixed3D;
            RoomFormLabel.FlatStyle = FlatStyle.Flat;
            RoomFormLabel.Font = new Font("Athletic Outfit", 33.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomFormLabel.ForeColor = SystemColors.ActiveCaptionText;
            RoomFormLabel.Location = new Point(105, 36);
            RoomFormLabel.Name = "RoomFormLabel";
            RoomFormLabel.Size = new Size(234, 59);
            RoomFormLabel.TabIndex = 19;
            RoomFormLabel.Text = "Rooms Form";
            // 
            // RoomFloorNumberBox
            // 
            RoomFloorNumberBox.Location = new Point(203, 279);
            RoomFloorNumberBox.Name = "RoomFloorNumberBox";
            RoomFloorNumberBox.Size = new Size(170, 23);
            RoomFloorNumberBox.TabIndex = 18;
            // 
            // labellll
            // 
            labellll.AutoSize = true;
            labellll.BackColor = Color.Transparent;
            labellll.Font = new Font("Assaf Font", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labellll.ForeColor = SystemColors.WindowFrame;
            labellll.Location = new Point(88, 162);
            labellll.Name = "labellll";
            labellll.Size = new Size(87, 36);
            labellll.TabIndex = 17;
            labellll.Text = "Room Type";
            // 
            // labelllll
            // 
            labelllll.AutoSize = true;
            labelllll.BackColor = Color.Transparent;
            labelllll.Font = new Font("Assaf Font", 15.7499981F);
            labelllll.ForeColor = SystemColors.WindowFrame;
            labelllll.Location = new Point(87, 271);
            labelllll.Name = "labelllll";
            labelllll.Size = new Size(99, 36);
            labelllll.TabIndex = 16;
            labelllll.Text = "Floor Number";
            // 
            // Rooms_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(756, 631);
            Controls.Add(groupBox1);
            Controls.Add(BackButton_Edit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Rooms_Form";
            Text = "Rooms_Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Button AddRoomBox { get; private set; }
        private Button BackButton_Edit;
        private GroupBox groupBox1;
        private Button SaveButton;
        private TextBox RoomPriceBox;
        private Label label2;
        private ComboBox RoomTypeBox;
        private Label RoomFormLabel;
        private TextBox RoomFloorNumberBox;
        private Label labellll;
        private Label labelllll;
        private PictureBox pictureBox1;
    }
   

    
        public class AddRoomBox : Button
        {
            public AddRoomBox()
            {
                FlatStyle = FlatStyle.Flat;
                FlatAppearance.BorderSize = 0;
                BackColor = Color.DodgerBlue;
                ForeColor = Color.White;
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold);
                Padding = new Padding(10);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);
                int borderRadius = 20; // Adjust the value to change the roundness of the edges

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
                    path.AddArc(bounds.X + bounds.Width - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
                    path.AddArc(bounds.X + bounds.Width - borderRadius, bounds.Y + bounds.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                    path.AddArc(bounds.X, bounds.Y + bounds.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                    e.Graphics.FillPath(new SolidBrush(BackColor), path);
                }
            }
        }
    }
