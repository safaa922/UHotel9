namespace UHotel9
{
    partial class Reservation_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation_Data));
            showReservationButton = new Button();
            ReservationReportGridView = new DataGridView();
            BackButton_Edit = new Button();
            ReservationSearchTextBox = new TextBox();
            ReservationSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)ReservationReportGridView).BeginInit();
            SuspendLayout();
            // 
            // showReservationButton
            // 
            showReservationButton.BackgroundImage = (Image)resources.GetObject("showReservationButton.BackgroundImage");
            showReservationButton.BackgroundImageLayout = ImageLayout.Stretch;
            showReservationButton.FlatStyle = FlatStyle.Flat;
            showReservationButton.Font = new Font("Assaf Font", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showReservationButton.ForeColor = SystemColors.ControlLightLight;
            showReservationButton.Location = new Point(389, 521);
            showReservationButton.Name = "showReservationButton";
            showReservationButton.Size = new Size(188, 58);
            showReservationButton.TabIndex = 24;
            showReservationButton.Text = "Show Reservations";
            showReservationButton.UseVisualStyleBackColor = true;
            showReservationButton.Click += sreservation_Click;
            // 
            // ReservationReportGridView
            // 
            ReservationReportGridView.BackgroundColor = SystemColors.ScrollBar;
            ReservationReportGridView.BorderStyle = BorderStyle.None;
            ReservationReportGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReservationReportGridView.Location = new Point(87, 91);
            ReservationReportGridView.Name = "ReservationReportGridView";
            ReservationReportGridView.Size = new Size(781, 391);
            ReservationReportGridView.TabIndex = 25;
            ReservationReportGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(30, 22);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(32, 31);
            BackButton_Edit.TabIndex = 91;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // ReservationSearchTextBox
            // 
            ReservationSearchTextBox.ForeColor = SystemColors.WindowFrame;
            ReservationSearchTextBox.Location = new Point(724, 542);
            ReservationSearchTextBox.Name = "ReservationSearchTextBox";
            ReservationSearchTextBox.Size = new Size(153, 23);
            ReservationSearchTextBox.TabIndex = 98;
            ReservationSearchTextBox.Text = "Room Number";
            // 
            // ReservationSearch
            // 
            ReservationSearch.BackColor = SystemColors.MenuText;
            ReservationSearch.BackgroundImage = (Image)resources.GetObject("ReservationSearch.BackgroundImage");
            ReservationSearch.BackgroundImageLayout = ImageLayout.Stretch;
            ReservationSearch.FlatStyle = FlatStyle.Flat;
            ReservationSearch.Font = new Font("Assaf Font", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReservationSearch.ForeColor = SystemColors.ControlLightLight;
            ReservationSearch.Location = new Point(646, 530);
            ReservationSearch.Name = "ReservationSearch";
            ReservationSearch.Size = new Size(72, 45);
            ReservationSearch.TabIndex = 97;
            ReservationSearch.Text = "Search";
            ReservationSearch.UseVisualStyleBackColor = false;
            ReservationSearch.Click += ReservationSearch_Click;
            // 
            // Reservation_Data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(955, 635);
            Controls.Add(ReservationSearchTextBox);
            Controls.Add(ReservationSearch);
            Controls.Add(BackButton_Edit);
            Controls.Add(ReservationReportGridView);
            Controls.Add(showReservationButton);
            Name = "Reservation_Data";
            Text = "Reservation_Data";
            ((System.ComponentModel.ISupportInitialize)ReservationReportGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button showReservationButton;
        private DataGridView ReservationReportGridView;
        private Button BackButton_Edit;
        private TextBox ReservationSearchTextBox;
        private Button ReservationSearch;
    }
}