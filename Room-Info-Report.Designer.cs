namespace UHotel9
{
    partial class Room_Info_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_Info_Report));
            RoomGridView = new DataGridView();
            ShowRoomInfoButton = new Button();
            BackButton_Edit = new Button();
            RoomSearchTextBox = new TextBox();
            RoomSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)RoomGridView).BeginInit();
            SuspendLayout();
            // 
            // RoomGridView
            // 
            RoomGridView.BackgroundColor = SystemColors.ScrollBar;
            RoomGridView.BorderStyle = BorderStyle.None;
            RoomGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomGridView.Location = new Point(91, 91);
            RoomGridView.Name = "RoomGridView";
            RoomGridView.Size = new Size(790, 397);
            RoomGridView.TabIndex = 0;
            RoomGridView.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // ShowRoomInfoButton
            // 
            ShowRoomInfoButton.BackgroundImage = (Image)resources.GetObject("ShowRoomInfoButton.BackgroundImage");
            ShowRoomInfoButton.BackgroundImageLayout = ImageLayout.Stretch;
            ShowRoomInfoButton.FlatStyle = FlatStyle.Popup;
            ShowRoomInfoButton.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowRoomInfoButton.ForeColor = SystemColors.ControlLightLight;
            ShowRoomInfoButton.Location = new Point(370, 526);
            ShowRoomInfoButton.Name = "ShowRoomInfoButton";
            ShowRoomInfoButton.Size = new Size(214, 55);
            ShowRoomInfoButton.TabIndex = 1;
            ShowRoomInfoButton.Text = "Show Room Info";
            ShowRoomInfoButton.UseVisualStyleBackColor = true;
            ShowRoomInfoButton.Click += ShowRoomInfoButton_Click;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(25, 23);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(35, 33);
            BackButton_Edit.TabIndex = 92;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // RoomSearchTextBox
            // 
            RoomSearchTextBox.ForeColor = SystemColors.WindowFrame;
            RoomSearchTextBox.Location = new Point(728, 545);
            RoomSearchTextBox.Name = "RoomSearchTextBox";
            RoomSearchTextBox.Size = new Size(153, 23);
            RoomSearchTextBox.TabIndex = 94;
            RoomSearchTextBox.Text = "Room Number";
            // 
            // RoomSearch
            // 
            RoomSearch.BackColor = SystemColors.MenuText;
            RoomSearch.BackgroundImage = (Image)resources.GetObject("RoomSearch.BackgroundImage");
            RoomSearch.BackgroundImageLayout = ImageLayout.Stretch;
            RoomSearch.FlatStyle = FlatStyle.Flat;
            RoomSearch.Font = new Font("Assaf Font", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomSearch.ForeColor = SystemColors.ControlLightLight;
            RoomSearch.Location = new Point(650, 533);
            RoomSearch.Name = "RoomSearch";
            RoomSearch.Size = new Size(72, 45);
            RoomSearch.TabIndex = 93;
            RoomSearch.Text = "Search";
            RoomSearch.UseVisualStyleBackColor = false;
            RoomSearch.Click += RoomSearch_Click;
            // 
            // Room_Info_Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(957, 635);
            Controls.Add(RoomSearchTextBox);
            Controls.Add(RoomSearch);
            Controls.Add(BackButton_Edit);
            Controls.Add(ShowRoomInfoButton);
            Controls.Add(RoomGridView);
            Name = "Room_Info_Report";
            Text = "Room_Info_Report";
            ((System.ComponentModel.ISupportInitialize)RoomGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RoomGridView;
        private Button ShowRoomInfoButton;
        private Button BackButton_Edit;
        private TextBox RoomSearchTextBox;
        private Button RoomSearch;
    }
}