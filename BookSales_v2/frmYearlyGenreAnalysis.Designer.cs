namespace BookSalesSys
{
    partial class frmYearlyGenreAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mnuYearlyGenreAnalysis = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelectYearGenreAnalysis = new System.Windows.Forms.Label();
            this.chtGenreAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbSelectYearGenreAnalysis = new System.Windows.Forms.ComboBox();
            this.mnuYearlyGenreAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGenreAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuYearlyGenreAnalysis
            // 
            this.mnuYearlyGenreAnalysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.mnuBackClick,
            this.customersToolStripMenuItem,
            this.catalogueToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuYearlyGenreAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuYearlyGenreAnalysis.Name = "mnuYearlyGenreAnalysis";
            this.mnuYearlyGenreAnalysis.Size = new System.Drawing.Size(998, 24);
            this.mnuYearlyGenreAnalysis.TabIndex = 7;
            this.mnuYearlyGenreAnalysis.Text = "Yearly Genre Analysis Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuBackClick
            // 
            this.mnuBackClick.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBackClick.Name = "mnuBackClick";
            this.mnuBackClick.Size = new System.Drawing.Size(122, 20);
            this.mnuBackClick.Text = "Back to Main Menu";
            this.mnuBackClick.Click += new System.EventHandler(this.mnuBackClick_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAccountToolStripMenuItem,
            this.updateAccountDetailsToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // openAccountToolStripMenuItem
            // 
            this.openAccountToolStripMenuItem.Name = "openAccountToolStripMenuItem";
            this.openAccountToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openAccountToolStripMenuItem.Text = "Open Account";
            this.openAccountToolStripMenuItem.Click += new System.EventHandler(this.openAccountToolStripMenuItem_Click);
            // 
            // updateAccountDetailsToolStripMenuItem
            // 
            this.updateAccountDetailsToolStripMenuItem.Name = "updateAccountDetailsToolStripMenuItem";
            this.updateAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.updateAccountDetailsToolStripMenuItem.Text = "Update Account Details";
            this.updateAccountDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateAccountDetailsToolStripMenuItem_Click);
            // 
            // catalogueToolStripMenuItem
            // 
            this.catalogueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.updateBookDetailsToolStripMenuItem});
            this.catalogueToolStripMenuItem.Name = "catalogueToolStripMenuItem";
            this.catalogueToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.catalogueToolStripMenuItem.Text = "Catalogue";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // updateBookDetailsToolStripMenuItem
            // 
            this.updateBookDetailsToolStripMenuItem.Name = "updateBookDetailsToolStripMenuItem";
            this.updateBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateBookDetailsToolStripMenuItem.Text = "Update Book Details";
            this.updateBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateBookDetailsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.placeOrderToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem,
            this.genreAnalysisToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.adminToolStripMenuItem.Text = "Display Analysis";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue";
            this.yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.yearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // genreAnalysisToolStripMenuItem
            // 
            this.genreAnalysisToolStripMenuItem.Name = "genreAnalysisToolStripMenuItem";
            this.genreAnalysisToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.genreAnalysisToolStripMenuItem.Text = "Genre Analysis";
            // 
            // lblSelectYearGenreAnalysis
            // 
            this.lblSelectYearGenreAnalysis.AutoSize = true;
            this.lblSelectYearGenreAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectYearGenreAnalysis.Location = new System.Drawing.Point(35, 57);
            this.lblSelectYearGenreAnalysis.Name = "lblSelectYearGenreAnalysis";
            this.lblSelectYearGenreAnalysis.Size = new System.Drawing.Size(92, 20);
            this.lblSelectYearGenreAnalysis.TabIndex = 24;
            this.lblSelectYearGenreAnalysis.Text = "Select Year";
            // 
            // chtGenreAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.chtGenreAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtGenreAnalysis.Legends.Add(legend1);
            this.chtGenreAnalysis.Location = new System.Drawing.Point(39, 104);
            this.chtGenreAnalysis.Name = "chtGenreAnalysis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            this.chtGenreAnalysis.Series.Add(series1);
            this.chtGenreAnalysis.Size = new System.Drawing.Size(913, 323);
            this.chtGenreAnalysis.TabIndex = 26;
            this.chtGenreAnalysis.Text = "Yearly Genre Analysis";
            title1.Name = "YearlyGenreAnalysis";
            title1.Text = "Yearly Genre Analysis";
            this.chtGenreAnalysis.Titles.Add(title1);
            this.chtGenreAnalysis.Visible = false;
            // 
            // cmbSelectYearGenreAnalysis
            // 
            this.cmbSelectYearGenreAnalysis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectYearGenreAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectYearGenreAnalysis.FormattingEnabled = true;
            this.cmbSelectYearGenreAnalysis.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cmbSelectYearGenreAnalysis.Location = new System.Drawing.Point(133, 52);
            this.cmbSelectYearGenreAnalysis.Name = "cmbSelectYearGenreAnalysis";
            this.cmbSelectYearGenreAnalysis.Size = new System.Drawing.Size(156, 28);
            this.cmbSelectYearGenreAnalysis.TabIndex = 27;
            this.cmbSelectYearGenreAnalysis.SelectedIndexChanged += new System.EventHandler(this.cmbSelectYearGenreAnalysis_SelectedIndexChanged);
            // 
            // frmYearlyGenreAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.cmbSelectYearGenreAnalysis);
            this.Controls.Add(this.chtGenreAnalysis);
            this.Controls.Add(this.lblSelectYearGenreAnalysis);
            this.Controls.Add(this.mnuYearlyGenreAnalysis);
            this.Name = "frmYearlyGenreAnalysis";
            this.Text = "Book Sales System - [Display Analysis - Genre Analysis]";
            this.mnuYearlyGenreAnalysis.ResumeLayout(false);
            this.mnuYearlyGenreAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGenreAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuYearlyGenreAnalysis;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreAnalysisToolStripMenuItem;
        private System.Windows.Forms.Label lblSelectYearGenreAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGenreAnalysis;
        private System.Windows.Forms.ComboBox cmbSelectYearGenreAnalysis;
    }
}