namespace UHotel9
{
    partial class Accountant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountant));
            revenue = new Label();
            revenueButton = new Button();
            revenueBox = new DateTimePicker();
            pictureBox1 = new PictureBox();
            BackButton_Edit = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // revenue
            // 
            revenue.AutoSize = true;
            revenue.BackColor = Color.Transparent;
            revenue.Font = new Font("adoody", 11.25F);
            revenue.ForeColor = Color.FromArgb(192, 192, 255);
            revenue.Location = new Point(96, 312);
            revenue.Name = "revenue";
            revenue.Size = new Size(66, 21);
            revenue.TabIndex = 0;
            revenue.Text = "Revenue";
          //  revenue.Click += label1_Click;
            // 
            // revenueButton
            // 
            revenueButton.BackgroundImage = (Image)resources.GetObject("revenueButton.BackgroundImage");
            revenueButton.BackgroundImageLayout = ImageLayout.Stretch;
            revenueButton.FlatStyle = FlatStyle.Popup;
            revenueButton.Font = new Font("Segoe UI", 11.25F);
            revenueButton.ForeColor = SystemColors.ButtonHighlight;
            revenueButton.Location = new Point(316, 333);
            revenueButton.Margin = new Padding(3, 2, 3, 2);
            revenueButton.Name = "revenueButton";
            revenueButton.Size = new Size(100, 42);
            revenueButton.TabIndex = 3;
            revenueButton.Text = "Revenue";
            revenueButton.UseVisualStyleBackColor = true;
            revenueButton.Click += revenueButton_Click;
            // 
            // revenueBox
            // 
            revenueBox.CalendarFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            revenueBox.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            revenueBox.Location = new Point(96, 342);
            revenueBox.Margin = new Padding(3, 2, 3, 2);
            revenueBox.Name = "revenueBox";
            revenueBox.Size = new Size(203, 22);
            revenueBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(501, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 570);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.FlatStyle = FlatStyle.Popup;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(27, 36);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(34, 32);
            BackButton_Edit.TabIndex = 91;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Mishaland", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(96, 176);
            label1.Name = "label1";
            label1.Size = new Size(233, 52);
            label1.TabIndex = 92;
            label1.Text = "Welcome Back !";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(96, 251);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(320, 21);
            pictureBox2.TabIndex = 93;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Accountant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1034, 566);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(BackButton_Edit);
            Controls.Add(pictureBox1);
            Controls.Add(revenueBox);
            Controls.Add(revenueButton);
            Controls.Add(revenue);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Accountant";
            Text = "Accountant";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label revenue;
        private Button revenueButton;
        private DateTimePicker revenueBox;
        private PictureBox pictureBox1;
        private Button BackButton_Edit;
        private Label label1;
        private PictureBox pictureBox2;
    }
}