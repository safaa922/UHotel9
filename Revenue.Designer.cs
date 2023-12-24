namespace UHotel9
{
    partial class Revenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revenue));
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            optionToolStripMenuItem = new ToolStripMenuItem();
            showRevenueToolStripMenuItem = new ToolStripMenuItem();
            totalRevenueToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            revenueDataGridView = new DataGridView();
            BackButton_Edit = new Button();
            menuStrip2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)revenueDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(967, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { optionToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(5, 2, 0, 2);
            menuStrip2.Size = new Size(967, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // optionToolStripMenuItem
            // 
            optionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showRevenueToolStripMenuItem, totalRevenueToolStripMenuItem });
            optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            optionToolStripMenuItem.Size = new Size(54, 20);
            optionToolStripMenuItem.Text = "option";
            // 
            // showRevenueToolStripMenuItem
            // 
            showRevenueToolStripMenuItem.Name = "showRevenueToolStripMenuItem";
            showRevenueToolStripMenuItem.Size = new Size(148, 22);
            showRevenueToolStripMenuItem.Text = "Show revenue";
            showRevenueToolStripMenuItem.Click += showRevenueToolStripMenuItem_Click;
            // 
            // totalRevenueToolStripMenuItem
            // 
            totalRevenueToolStripMenuItem.Name = "totalRevenueToolStripMenuItem";
            totalRevenueToolStripMenuItem.Size = new Size(148, 22);
            totalRevenueToolStripMenuItem.Text = "Total Revenue";
            totalRevenueToolStripMenuItem.Click += totalRevenueToolStripMenuItem_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(revenueDataGridView);
            panel1.Location = new Point(22, 76);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 406);
            panel1.TabIndex = 2;
            // 
            // revenueDataGridView
            // 
            revenueDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            revenueDataGridView.Location = new Point(10, 34);
            revenueDataGridView.Margin = new Padding(3, 2, 3, 2);
            revenueDataGridView.Name = "revenueDataGridView";
            revenueDataGridView.RowHeadersWidth = 51;
            revenueDataGridView.Size = new Size(874, 411);
            revenueDataGridView.TabIndex = 0;
            revenueDataGridView.CellContentClick += revenueDataGridView_CellContentClick;
            // 
            // BackButton_Edit
            // 
            BackButton_Edit.BackColor = Color.Transparent;
            BackButton_Edit.BackgroundImage = (Image)resources.GetObject("BackButton_Edit.BackgroundImage");
            BackButton_Edit.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton_Edit.Font = new Font("Assaf Font", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_Edit.Location = new Point(22, 545);
            BackButton_Edit.Name = "BackButton_Edit";
            BackButton_Edit.Size = new Size(35, 33);
            BackButton_Edit.TabIndex = 92;
            BackButton_Edit.UseVisualStyleBackColor = false;
            BackButton_Edit.Click += BackButton_Edit_Click;
            // 
            // Revenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(967, 602);
            Controls.Add(BackButton_Edit);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Revenue";
            Text = "Revenue";
            Load += Revenue_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)revenueDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem showRevenueToolStripMenuItem;
        private Panel panel1;
        private DataGridView revenueDataGridView;
        private ToolStripMenuItem totalRevenueToolStripMenuItem;
        private Button BackButton_Edit;
    }
}