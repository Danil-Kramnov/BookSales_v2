namespace BookSalesSys
{
    partial class frmMainMenu
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discontinueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produceYearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.adminToolStripMenuItem1});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(793, 24);
            this.mnuMainMenu.TabIndex = 3;
            this.mnuMainMenu.Text = "Main Menu Strip";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.updateAccountDetailsToolStripMenuItem,
            this.closeAccountToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.createAccountToolStripMenuItem.Text = "Open Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // updateAccountDetailsToolStripMenuItem
            // 
            this.updateAccountDetailsToolStripMenuItem.Name = "updateAccountDetailsToolStripMenuItem";
            this.updateAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.updateAccountDetailsToolStripMenuItem.Text = "Update Account Details";
            this.updateAccountDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateAccountDetailsToolStripMenuItem_Click);
            // 
            // closeAccountToolStripMenuItem
            // 
            this.closeAccountToolStripMenuItem.Name = "closeAccountToolStripMenuItem";
            this.closeAccountToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.closeAccountToolStripMenuItem.Text = "Close Account";
            this.closeAccountToolStripMenuItem.Click += new System.EventHandler(this.closeAccountToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.updateBookDetailsToolStripMenuItem,
            this.discontinueBookToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.salesToolStripMenuItem.Text = "Catalogue";
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
            // discontinueBookToolStripMenuItem
            // 
            this.discontinueBookToolStripMenuItem.Name = "discontinueBookToolStripMenuItem";
            this.discontinueBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.discontinueBookToolStripMenuItem.Text = "Discontinue Book";
            this.discontinueBookToolStripMenuItem.Click += new System.EventHandler(this.discontinueBookToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeSaleToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.adminToolStripMenuItem.Text = "Orders";
            // 
            // placeSaleToolStripMenuItem
            // 
            this.placeSaleToolStripMenuItem.Name = "placeSaleToolStripMenuItem";
            this.placeSaleToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.placeSaleToolStripMenuItem.Text = "Place Order";
            this.placeSaleToolStripMenuItem.Click += new System.EventHandler(this.placeSaleToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem1
            // 
            this.adminToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produceYearlyRevenueAnalysisToolStripMenuItem,
            this.produceToolStripMenuItem});
            this.adminToolStripMenuItem1.Name = "adminToolStripMenuItem1";
            this.adminToolStripMenuItem1.Size = new System.Drawing.Size(103, 20);
            this.adminToolStripMenuItem1.Text = "Display Analysis";
            // 
            // produceYearlyRevenueAnalysisToolStripMenuItem
            // 
            this.produceYearlyRevenueAnalysisToolStripMenuItem.Name = "produceYearlyRevenueAnalysisToolStripMenuItem";
            this.produceYearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.produceYearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue";
            this.produceYearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.produceYearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // produceToolStripMenuItem
            // 
            this.produceToolStripMenuItem.Name = "produceToolStripMenuItem";
            this.produceToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.produceToolStripMenuItem.Text = "Genre Analysis";
            this.produceToolStripMenuItem.Click += new System.EventHandler(this.produceToolStripMenuItem_Click);
            // 
            // picMainMenu
            // 
            this.picMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMainMenu.Image = global::BookSales_v2.Properties.Resources.Books;
            this.picMainMenu.Location = new System.Drawing.Point(12, 27);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(776, 411);
            this.picMainMenu.TabIndex = 2;
            this.picMainMenu.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(674, 39);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(107, 41);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(615, 52);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "label1";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.picMainMenu);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "Book Sales System - [Main Menu]";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discontinueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produceYearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produceToolStripMenuItem;
        private System.Windows.Forms.PictureBox picMainMenu;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
    }
}

