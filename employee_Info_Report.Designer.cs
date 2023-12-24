namespace UHotel9
{
    partial class employee_Info_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_Info_Report));
            dataGridViewEmployee = new DataGridView();
            ShowEmployeeInfo = new Button();
            EmployeeSearch = new Button();
            EmployeeSearchTextBox = new TextBox();
            BackButton_Edit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewEmployee.BorderStyle = BorderStyle.None;
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Location = new Point(67, 106);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.Size = new Size(963, 406);
            dataGridViewEmployee.TabIndex = 0;
            dataGridViewEmployee.CellContentClick += dataGridViewEmployee_CellContentClick_1;
            // 
            // ShowEmployeeInfo
            // 
            ShowEmployeeInfo.BackgroundImage = (Image)resources.GetObject("ShowEmployeeInfo.BackgroundImage");
            ShowEmployeeInfo.BackgroundImageLayout = ImageLayout.Stretch;
            ShowEmployeeInfo.FlatStyle = FlatStyle.Popup;
            ShowEmployeeInfo.Font = new Font("Assaf Font", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowEmployeeInfo.ForeColor = Color.GhostWhite;
            ShowEmployeeInfo.Location = new Point(448, 581);
            ShowEmployeeInfo.Name = "ShowEmployeeInfo";
            ShowEmployeeInfo.Size = new Size(215, 57);
            ShowEmployeeInfo.TabIndex = 2;
            ShowEmployeeInfo.Text = "Show Employee Info";
            ShowEmployeeInfo.UseVisualStyleBackColor = true;
            ShowEmployeeInfo.Click += ShowEmployeeInfo_Click;
            // 
            // EmployeeSearch
            // 
            EmployeeSearch.BackgroundImage = (Image)resources.GetObject("EmployeeSearch.BackgroundImage");
            EmployeeSearch.BackgroundImageLayout = ImageLayout.Stretch;
            EmployeeSearch.FlatStyle = FlatStyle.Popup;
            EmployeeSearch.ForeColor = SystemColors.ButtonHighlight;
            EmployeeSearch.Location = new Point(721, 591);
            EmployeeSearch.Name = "EmployeeSearch";
            EmployeeSearch.Size = new Size(82, 37);
            EmployeeSearch.TabIndex = 3;
            EmployeeSearch.Text = "Search";
            EmployeeSearch.UseVisualStyleBackColor = true;
            EmployeeSearch.Click += EmployeeSearch_Click;
            // 
            // EmployeeSearchTextBox
            // 
            EmployeeSearchTextBox.BackColor = Color.FloralWhite;
            EmployeeSearchTextBox.ForeColor = SystemColors.WindowFrame;
            EmployeeSearchTextBox.Location = new Point(809, 599);
            EmployeeSearchTextBox.Name = "EmployeeSearchTextBox";
            EmployeeSearchTextBox.Size = new Size(150, 23);
            EmployeeSearchTextBox.TabIndex = 4;
            EmployeeSearchTextBox.Text = "Employee ID";
            EmployeeSearchTextBox.TextChanged += EmployeeSearchTextBox_TextChanged;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(23, 25);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(32, 33);
            BackButton_Edit.TabIndex = 91;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // employee_Info_Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1116, 698);
            Controls.Add(BackButton_Edit);
            Controls.Add(EmployeeSearchTextBox);
            Controls.Add(EmployeeSearch);
            Controls.Add(ShowEmployeeInfo);
            Controls.Add(dataGridViewEmployee);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "employee_Info_Report";
            Text = "employee_Info_Report";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmployee;
        private Button ShowEmployeeInfo;
        private Button EmployeeSearch;
        private TextBox EmployeeSearchTextBox;
        private Button BackButton_Edit;
    }
}