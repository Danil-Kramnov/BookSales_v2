namespace BookSalesSys
{
    partial class frmReturnBook
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
            this.mnuReturnBook = new System.Windows.Forms.MenuStrip();
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
            this.lblAccountIdOrder = new System.Windows.Forms.Label();
            this.txtAccountIdOrder = new System.Windows.Forms.TextBox();
            this.btnSearchBarReturnBook = new System.Windows.Forms.Button();
            this.lblSearchBarReturn = new System.Windows.Forms.Label();
            this.txtSearchBarReturn = new System.Windows.Forms.TextBox();
            this.grpReturnBookSelectBook = new System.Windows.Forms.GroupBox();
            this.dgvReturnBookSelectBook = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuReturnBook.SuspendLayout();
            this.grpReturnBookSelectBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBookSelectBook)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuReturnBook
            // 
            this.mnuReturnBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.mnuBackClick,
            this.customersToolStripMenuItem,
            this.catalogueToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuReturnBook.Location = new System.Drawing.Point(0, 0);
            this.mnuReturnBook.Name = "mnuReturnBook";
            this.mnuReturnBook.Size = new System.Drawing.Size(800, 24);
            this.mnuReturnBook.TabIndex = 6;
            this.mnuReturnBook.Text = "Return Book Menu";
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
            this.genreAnalysisToolStripMenuItem.Click += new System.EventHandler(this.genreAnalysisToolStripMenuItem_Click);
            // 
            // lblAccountIdOrder
            // 
            this.lblAccountIdOrder.AutoSize = true;
            this.lblAccountIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountIdOrder.Location = new System.Drawing.Point(546, 35);
            this.lblAccountIdOrder.Name = "lblAccountIdOrder";
            this.lblAccountIdOrder.Size = new System.Drawing.Size(89, 20);
            this.lblAccountIdOrder.TabIndex = 27;
            this.lblAccountIdOrder.Text = "Account ID";
            // 
            // txtAccountIdOrder
            // 
            this.txtAccountIdOrder.Enabled = false;
            this.txtAccountIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountIdOrder.Location = new System.Drawing.Point(641, 32);
            this.txtAccountIdOrder.Name = "txtAccountIdOrder";
            this.txtAccountIdOrder.ReadOnly = true;
            this.txtAccountIdOrder.Size = new System.Drawing.Size(146, 26);
            this.txtAccountIdOrder.TabIndex = 26;
            this.txtAccountIdOrder.Text = "001";
            // 
            // btnSearchBarReturnBook
            // 
            this.btnSearchBarReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBarReturnBook.Location = new System.Drawing.Point(272, 87);
            this.btnSearchBarReturnBook.Name = "btnSearchBarReturnBook";
            this.btnSearchBarReturnBook.Size = new System.Drawing.Size(75, 26);
            this.btnSearchBarReturnBook.TabIndex = 30;
            this.btnSearchBarReturnBook.Text = "Search";
            this.btnSearchBarReturnBook.UseVisualStyleBackColor = true;
            this.btnSearchBarReturnBook.Click += new System.EventHandler(this.btnSearchBarReturnBook_Click);
            // 
            // lblSearchBarReturn
            // 
            this.lblSearchBarReturn.AutoSize = true;
            this.lblSearchBarReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBarReturn.Location = new System.Drawing.Point(12, 90);
            this.lblSearchBarReturn.Name = "lblSearchBarReturn";
            this.lblSearchBarReturn.Size = new System.Drawing.Size(81, 20);
            this.lblSearchBarReturn.TabIndex = 29;
            this.lblSearchBarReturn.Text = "Enter Title";
            // 
            // txtSearchBarReturn
            // 
            this.txtSearchBarReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBarReturn.Location = new System.Drawing.Point(107, 87);
            this.txtSearchBarReturn.Name = "txtSearchBarReturn";
            this.txtSearchBarReturn.Size = new System.Drawing.Size(146, 26);
            this.txtSearchBarReturn.TabIndex = 28;
            // 
            // grpReturnBookSelectBook
            // 
            this.grpReturnBookSelectBook.Controls.Add(this.dgvReturnBookSelectBook);
            this.grpReturnBookSelectBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReturnBookSelectBook.Location = new System.Drawing.Point(160, 156);
            this.grpReturnBookSelectBook.Name = "grpReturnBookSelectBook";
            this.grpReturnBookSelectBook.Size = new System.Drawing.Size(498, 200);
            this.grpReturnBookSelectBook.TabIndex = 31;
            this.grpReturnBookSelectBook.TabStop = false;
            this.grpReturnBookSelectBook.Text = "Select Book";
            this.grpReturnBookSelectBook.Visible = false;
            // 
            // dgvReturnBookSelectBook
            // 
            this.dgvReturnBookSelectBook.AllowUserToAddRows = false;
            this.dgvReturnBookSelectBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBookSelectBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Author,
            this.Price,
            this.Qty});
            this.dgvReturnBookSelectBook.Location = new System.Drawing.Point(26, 37);
            this.dgvReturnBookSelectBook.Name = "dgvReturnBookSelectBook";
            this.dgvReturnBookSelectBook.ReadOnly = true;
            this.dgvReturnBookSelectBook.Size = new System.Drawing.Size(448, 115);
            this.dgvReturnBookSelectBook.TabIndex = 23;
            this.dgvReturnBookSelectBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnBookSelectBook_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Book Title";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpReturnBookSelectBook);
            this.Controls.Add(this.btnSearchBarReturnBook);
            this.Controls.Add(this.lblSearchBarReturn);
            this.Controls.Add(this.txtSearchBarReturn);
            this.Controls.Add(this.lblAccountIdOrder);
            this.Controls.Add(this.txtAccountIdOrder);
            this.Controls.Add(this.mnuReturnBook);
            this.Name = "frmReturnBook";
            this.Text = "Book Sales System - [Orders - Return Book]";
            this.mnuReturnBook.ResumeLayout(false);
            this.mnuReturnBook.PerformLayout();
            this.grpReturnBookSelectBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBookSelectBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuReturnBook;
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
        private System.Windows.Forms.Label lblAccountIdOrder;
        private System.Windows.Forms.TextBox txtAccountIdOrder;
        private System.Windows.Forms.Button btnSearchBarReturnBook;
        private System.Windows.Forms.Label lblSearchBarReturn;
        private System.Windows.Forms.TextBox txtSearchBarReturn;
        private System.Windows.Forms.GroupBox grpReturnBookSelectBook;
        private System.Windows.Forms.DataGridView dgvReturnBookSelectBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}