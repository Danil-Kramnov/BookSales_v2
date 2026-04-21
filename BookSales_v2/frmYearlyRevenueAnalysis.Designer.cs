namespace BookSalesSys
{
    partial class frmYearlyRevenueAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mnuYearlyRevenueAnalysis = new System.Windows.Forms.MenuStrip();
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
            this.chtRevenueAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSelectYearRevenueAnalysis = new System.Windows.Forms.Label();
            this.cmbSelectYearRevenueAnalysis = new System.Windows.Forms.ComboBox();
            this.grpAdminLogin = new System.Windows.Forms.GroupBox();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.chbAdminHidePassword = new System.Windows.Forms.CheckBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminLogin = new System.Windows.Forms.TextBox();
            this.grpSelectYearAnalysis = new System.Windows.Forms.GroupBox();
            this.mnuYearlyRevenueAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenueAnalysis)).BeginInit();
            this.grpAdminLogin.SuspendLayout();
            this.grpSelectYearAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuYearlyRevenueAnalysis
            // 
            this.mnuYearlyRevenueAnalysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.mnuBackClick,
            this.customersToolStripMenuItem,
            this.catalogueToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuYearlyRevenueAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuYearlyRevenueAnalysis.Name = "mnuYearlyRevenueAnalysis";
            this.mnuYearlyRevenueAnalysis.Size = new System.Drawing.Size(964, 24);
            this.mnuYearlyRevenueAnalysis.TabIndex = 8;
            this.mnuYearlyRevenueAnalysis.Text = "Yearly Revenue Analysis Menu";
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
            // 
            // genreAnalysisToolStripMenuItem
            // 
            this.genreAnalysisToolStripMenuItem.Name = "genreAnalysisToolStripMenuItem";
            this.genreAnalysisToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.genreAnalysisToolStripMenuItem.Text = "Genre Analysis";
            this.genreAnalysisToolStripMenuItem.Click += new System.EventHandler(this.genreAnalysisToolStripMenuItem_Click);
            // 
            // chtRevenueAnalysis
            // 
            chartArea2.Name = "ChartArea1";
            this.chtRevenueAnalysis.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtRevenueAnalysis.Legends.Add(legend2);
            this.chtRevenueAnalysis.Location = new System.Drawing.Point(32, 233);
            this.chtRevenueAnalysis.Name = "chtRevenueAnalysis";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Revenue";
            this.chtRevenueAnalysis.Series.Add(series2);
            this.chtRevenueAnalysis.Size = new System.Drawing.Size(913, 323);
            this.chtRevenueAnalysis.TabIndex = 30;
            this.chtRevenueAnalysis.Text = "Yearly Genre Analysis";
            title2.Name = "YearlyRevenueAnalysis";
            title2.Text = "Yearly Revenue Analysis";
            this.chtRevenueAnalysis.Titles.Add(title2);
            this.chtRevenueAnalysis.Visible = false;
            // 
            // lblSelectYearRevenueAnalysis
            // 
            this.lblSelectYearRevenueAnalysis.AutoSize = true;
            this.lblSelectYearRevenueAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectYearRevenueAnalysis.Location = new System.Drawing.Point(6, 22);
            this.lblSelectYearRevenueAnalysis.Name = "lblSelectYearRevenueAnalysis";
            this.lblSelectYearRevenueAnalysis.Size = new System.Drawing.Size(92, 20);
            this.lblSelectYearRevenueAnalysis.TabIndex = 28;
            this.lblSelectYearRevenueAnalysis.Text = "Select Year";
            this.lblSelectYearRevenueAnalysis.Visible = false;
            // 
            // cmbSelectYearRevenueAnalysis
            // 
            this.cmbSelectYearRevenueAnalysis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectYearRevenueAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectYearRevenueAnalysis.FormattingEnabled = true;
            this.cmbSelectYearRevenueAnalysis.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cmbSelectYearRevenueAnalysis.Location = new System.Drawing.Point(104, 19);
            this.cmbSelectYearRevenueAnalysis.Name = "cmbSelectYearRevenueAnalysis";
            this.cmbSelectYearRevenueAnalysis.Size = new System.Drawing.Size(156, 28);
            this.cmbSelectYearRevenueAnalysis.TabIndex = 31;
            this.cmbSelectYearRevenueAnalysis.Visible = false;
            this.cmbSelectYearRevenueAnalysis.SelectedIndexChanged += new System.EventHandler(this.cmbSelectYearRevenueAnalysis_SelectedIndexChanged);
            // 
            // grpAdminLogin
            // 
            this.grpAdminLogin.Controls.Add(this.btnAdminLogout);
            this.grpAdminLogin.Controls.Add(this.chbAdminHidePassword);
            this.grpAdminLogin.Controls.Add(this.btnAdminLogin);
            this.grpAdminLogin.Controls.Add(this.lblAdminPassword);
            this.grpAdminLogin.Controls.Add(this.lblAdminLogin);
            this.grpAdminLogin.Controls.Add(this.txtAdminPassword);
            this.grpAdminLogin.Controls.Add(this.txtAdminLogin);
            this.grpAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdminLogin.Location = new System.Drawing.Point(12, 27);
            this.grpAdminLogin.Name = "grpAdminLogin";
            this.grpAdminLogin.Size = new System.Drawing.Size(419, 138);
            this.grpAdminLogin.TabIndex = 32;
            this.grpAdminLogin.TabStop = false;
            this.grpAdminLogin.Text = "Admin Login";
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogout.Location = new System.Drawing.Point(235, 99);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(79, 28);
            this.btnAdminLogout.TabIndex = 11;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = true;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // chbAdminHidePassword
            // 
            this.chbAdminHidePassword.AutoSize = true;
            this.chbAdminHidePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAdminHidePassword.Location = new System.Drawing.Point(276, 70);
            this.chbAdminHidePassword.Name = "chbAdminHidePassword";
            this.chbAdminHidePassword.Size = new System.Drawing.Size(118, 20);
            this.chbAdminHidePassword.TabIndex = 10;
            this.chbAdminHidePassword.Text = "Hide Password";
            this.chbAdminHidePassword.UseVisualStyleBackColor = true;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(134, 99);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(79, 28);
            this.btnAdminLogin.TabIndex = 9;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassword.Location = new System.Drawing.Point(22, 68);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(78, 20);
            this.lblAdminPassword.TabIndex = 8;
            this.lblAdminPassword.Text = "Password";
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLogin.Location = new System.Drawing.Point(22, 38);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(48, 20);
            this.lblAdminLogin.TabIndex = 8;
            this.lblAdminLogin.Text = "Login";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(134, 67);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(136, 26);
            this.txtAdminPassword.TabIndex = 8;
            // 
            // txtAdminLogin
            // 
            this.txtAdminLogin.Location = new System.Drawing.Point(134, 35);
            this.txtAdminLogin.Name = "txtAdminLogin";
            this.txtAdminLogin.Size = new System.Drawing.Size(279, 26);
            this.txtAdminLogin.TabIndex = 7;
            // 
            // grpSelectYearAnalysis
            // 
            this.grpSelectYearAnalysis.Controls.Add(this.lblSelectYearRevenueAnalysis);
            this.grpSelectYearAnalysis.Controls.Add(this.cmbSelectYearRevenueAnalysis);
            this.grpSelectYearAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectYearAnalysis.Location = new System.Drawing.Point(32, 172);
            this.grpSelectYearAnalysis.Name = "grpSelectYearAnalysis";
            this.grpSelectYearAnalysis.Size = new System.Drawing.Size(273, 55);
            this.grpSelectYearAnalysis.TabIndex = 33;
            this.grpSelectYearAnalysis.TabStop = false;
            this.grpSelectYearAnalysis.Visible = false;
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 617);
            this.Controls.Add(this.grpSelectYearAnalysis);
            this.Controls.Add(this.grpAdminLogin);
            this.Controls.Add(this.chtRevenueAnalysis);
            this.Controls.Add(this.mnuYearlyRevenueAnalysis);
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "Book Sales System - [Display Analysis - Yearly Revenue]";
            this.mnuYearlyRevenueAnalysis.ResumeLayout(false);
            this.mnuYearlyRevenueAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenueAnalysis)).EndInit();
            this.grpAdminLogin.ResumeLayout(false);
            this.grpAdminLogin.PerformLayout();
            this.grpSelectYearAnalysis.ResumeLayout(false);
            this.grpSelectYearAnalysis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuYearlyRevenueAnalysis;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRevenueAnalysis;
        private System.Windows.Forms.Label lblSelectYearRevenueAnalysis;
        private System.Windows.Forms.ComboBox cmbSelectYearRevenueAnalysis;
        private System.Windows.Forms.GroupBox grpAdminLogin;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.CheckBox chbAdminHidePassword;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label lblAdminLogin;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminLogin;
        private System.Windows.Forms.GroupBox grpSelectYearAnalysis;
    }
}