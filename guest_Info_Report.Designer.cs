namespace UHotel9
{
    partial class guest_Info_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guest_Info_Report));
            GuestDataGrid = new DataGridView();
            GuestInfoReportButton = new Button();
            GuestSearchTextBox = new TextBox();
            GuestSearch = new Button();
            BackButton_Edit = new Button();
            ((System.ComponentModel.ISupportInitialize)GuestDataGrid).BeginInit();
            SuspendLayout();
            // 
            // GuestDataGrid
            // 
            GuestDataGrid.BackgroundColor = SystemColors.ControlLight;
            GuestDataGrid.BorderStyle = BorderStyle.None;
            GuestDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GuestDataGrid.Location = new Point(113, 93);
            GuestDataGrid.Name = "GuestDataGrid";
            GuestDataGrid.Size = new Size(791, 455);
            GuestDataGrid.TabIndex = 0;
            GuestDataGrid.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // GuestInfoReportButton
            // 
            GuestInfoReportButton.BackgroundImage = (Image)resources.GetObject("GuestInfoReportButton.BackgroundImage");
            GuestInfoReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            GuestInfoReportButton.FlatStyle = FlatStyle.Popup;
            GuestInfoReportButton.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuestInfoReportButton.ForeColor = Color.White;
            GuestInfoReportButton.Location = new Point(393, 597);
            GuestInfoReportButton.Name = "GuestInfoReportButton";
            GuestInfoReportButton.Size = new Size(212, 61);
            GuestInfoReportButton.TabIndex = 1;
            GuestInfoReportButton.Text = "Guest Information";
            GuestInfoReportButton.UseVisualStyleBackColor = true;
            GuestInfoReportButton.Click += button1_Click;
            // 
            // GuestSearchTextBox
            // 
            GuestSearchTextBox.ForeColor = SystemColors.WindowFrame;
            GuestSearchTextBox.Location = new Point(751, 613);
            GuestSearchTextBox.Name = "GuestSearchTextBox";
            GuestSearchTextBox.Size = new Size(153, 23);
            GuestSearchTextBox.TabIndex = 6;
            GuestSearchTextBox.Text = "Guest ID";
            // 
            // GuestSearch
            // 
            GuestSearch.BackColor = SystemColors.MenuText;
            GuestSearch.BackgroundImage = (Image)resources.GetObject("GuestSearch.BackgroundImage");
            GuestSearch.BackgroundImageLayout = ImageLayout.Stretch;
            GuestSearch.FlatStyle = FlatStyle.Flat;
            GuestSearch.Font = new Font("Assaf Font", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuestSearch.ForeColor = SystemColors.ControlLightLight;
            GuestSearch.Location = new Point(673, 601);
            GuestSearch.Name = "GuestSearch";
            GuestSearch.Size = new Size(72, 45);
            GuestSearch.TabIndex = 2;
            GuestSearch.Text = "Search";
            GuestSearch.UseVisualStyleBackColor = false;
            GuestSearch.Click += GuestSearch_Click;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(37, 28);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(38, 33);
            BackButton_Edit.TabIndex = 92;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // guest_Info_Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1030, 708);
            Controls.Add(BackButton_Edit);
            Controls.Add(GuestSearchTextBox);
            Controls.Add(GuestSearch);
            Controls.Add(GuestInfoReportButton);
            Controls.Add(GuestDataGrid);
            Name = "guest_Info_Report";
            Text = "guest_Info_Report";
            ((System.ComponentModel.ISupportInitialize)GuestDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GuestDataGrid;
        private Button GuestInfoReportButton;
        private TextBox GuestSearchTextBox;
        private Button GuestSearch;
        private Button BackButton_Edit;
    }
}