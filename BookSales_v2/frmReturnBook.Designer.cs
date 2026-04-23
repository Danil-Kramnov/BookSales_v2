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
            this.grpReturnBookSelectBook = new System.Windows.Forms.GroupBox();
            this.dgvReturnBookSelectBook = new System.Windows.Forms.DataGridView();
            this.grpCustomerLogin = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.chbOrderHidePassword = new System.Windows.Forms.CheckBox();
            this.btnLoadCustomer = new System.Windows.Forms.Button();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.txtReturnPassword = new System.Windows.Forms.TextBox();
            this.txtReturnEmail = new System.Windows.Forms.TextBox();
            this.grpOrderSearch = new System.Windows.Forms.GroupBox();
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.lblOrderSearch = new System.Windows.Forms.Label();
            this.txtReturnSearch = new System.Windows.Forms.TextBox();
            this.grpReturnCart = new System.Windows.Forms.GroupBox();
            this.lblRefundTotal = new System.Windows.Forms.Label();
            this.btnRefund = new System.Windows.Forms.Button();
            this.dgvReturnCart = new System.Windows.Forms.DataGridView();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyRetuned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderIDCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuReturnBook.SuspendLayout();
            this.grpReturnBookSelectBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBookSelectBook)).BeginInit();
            this.grpCustomerLogin.SuspendLayout();
            this.grpOrderSearch.SuspendLayout();
            this.grpReturnCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnCart)).BeginInit();
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
            this.mnuReturnBook.Size = new System.Drawing.Size(942, 24);
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
            // grpReturnBookSelectBook
            // 
            this.grpReturnBookSelectBook.Controls.Add(this.dgvReturnBookSelectBook);
            this.grpReturnBookSelectBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReturnBookSelectBook.Location = new System.Drawing.Point(12, 101);
            this.grpReturnBookSelectBook.Name = "grpReturnBookSelectBook";
            this.grpReturnBookSelectBook.Size = new System.Drawing.Size(458, 222);
            this.grpReturnBookSelectBook.TabIndex = 31;
            this.grpReturnBookSelectBook.TabStop = false;
            this.grpReturnBookSelectBook.Text = "Select Book to Return";
            this.grpReturnBookSelectBook.Visible = false;
            // 
            // dgvReturnBookSelectBook
            // 
            this.dgvReturnBookSelectBook.AllowUserToAddRows = false;
            this.dgvReturnBookSelectBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBookSelectBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.QtyOrdered,
            this.OrderPrice,
            this.OrderDate,
            this.OrderID});
            this.dgvReturnBookSelectBook.Location = new System.Drawing.Point(6, 38);
            this.dgvReturnBookSelectBook.Name = "dgvReturnBookSelectBook";
            this.dgvReturnBookSelectBook.ReadOnly = true;
            this.dgvReturnBookSelectBook.Size = new System.Drawing.Size(448, 179);
            this.dgvReturnBookSelectBook.TabIndex = 23;
            this.dgvReturnBookSelectBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnBookSelectBook_CellClick);
            // 
            // grpCustomerLogin
            // 
            this.grpCustomerLogin.Controls.Add(this.btnLogout);
            this.grpCustomerLogin.Controls.Add(this.chbOrderHidePassword);
            this.grpCustomerLogin.Controls.Add(this.btnLoadCustomer);
            this.grpCustomerLogin.Controls.Add(this.lblLoginPassword);
            this.grpCustomerLogin.Controls.Add(this.lblLoginEmail);
            this.grpCustomerLogin.Controls.Add(this.txtReturnPassword);
            this.grpCustomerLogin.Controls.Add(this.txtReturnEmail);
            this.grpCustomerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerLogin.Location = new System.Drawing.Point(476, 101);
            this.grpCustomerLogin.Name = "grpCustomerLogin";
            this.grpCustomerLogin.Size = new System.Drawing.Size(458, 156);
            this.grpCustomerLogin.TabIndex = 32;
            this.grpCustomerLogin.TabStop = false;
            this.grpCustomerLogin.Text = "Customer Login";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(238, 99);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 28);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // chbOrderHidePassword
            // 
            this.chbOrderHidePassword.AutoSize = true;
            this.chbOrderHidePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOrderHidePassword.Location = new System.Drawing.Point(323, 70);
            this.chbOrderHidePassword.Name = "chbOrderHidePassword";
            this.chbOrderHidePassword.Size = new System.Drawing.Size(118, 20);
            this.chbOrderHidePassword.TabIndex = 10;
            this.chbOrderHidePassword.Text = "Hide Password";
            this.chbOrderHidePassword.UseVisualStyleBackColor = true;
            // 
            // btnLoadCustomer
            // 
            this.btnLoadCustomer.Location = new System.Drawing.Point(134, 99);
            this.btnLoadCustomer.Name = "btnLoadCustomer";
            this.btnLoadCustomer.Size = new System.Drawing.Size(79, 28);
            this.btnLoadCustomer.TabIndex = 9;
            this.btnLoadCustomer.Text = "Login";
            this.btnLoadCustomer.UseVisualStyleBackColor = true;
            this.btnLoadCustomer.Click += new System.EventHandler(this.btnLoadCustomer_Click);
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.Location = new System.Drawing.Point(22, 70);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(78, 20);
            this.lblLoginPassword.TabIndex = 8;
            this.lblLoginPassword.Text = "Password";
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmail.Location = new System.Drawing.Point(22, 38);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(48, 20);
            this.lblLoginEmail.TabIndex = 8;
            this.lblLoginEmail.Text = "Email";
            // 
            // txtReturnPassword
            // 
            this.txtReturnPassword.Location = new System.Drawing.Point(134, 67);
            this.txtReturnPassword.Name = "txtReturnPassword";
            this.txtReturnPassword.Size = new System.Drawing.Size(183, 26);
            this.txtReturnPassword.TabIndex = 8;
            // 
            // txtReturnEmail
            // 
            this.txtReturnEmail.Location = new System.Drawing.Point(134, 35);
            this.txtReturnEmail.Name = "txtReturnEmail";
            this.txtReturnEmail.Size = new System.Drawing.Size(275, 26);
            this.txtReturnEmail.TabIndex = 7;
            // 
            // grpOrderSearch
            // 
            this.grpOrderSearch.Controls.Add(this.btnOrderSearch);
            this.grpOrderSearch.Controls.Add(this.lblOrderSearch);
            this.grpOrderSearch.Controls.Add(this.txtReturnSearch);
            this.grpOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderSearch.Location = new System.Drawing.Point(12, 27);
            this.grpOrderSearch.Name = "grpOrderSearch";
            this.grpOrderSearch.Size = new System.Drawing.Size(419, 67);
            this.grpOrderSearch.TabIndex = 33;
            this.grpOrderSearch.TabStop = false;
            this.grpOrderSearch.Visible = false;
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSearch.Location = new System.Drawing.Point(326, 25);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(79, 28);
            this.btnOrderSearch.TabIndex = 9;
            this.btnOrderSearch.Text = "Search";
            this.btnOrderSearch.UseVisualStyleBackColor = true;
            this.btnOrderSearch.Click += new System.EventHandler(this.btnOrderSearch_Click);
            // 
            // lblOrderSearch
            // 
            this.lblOrderSearch.AutoSize = true;
            this.lblOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSearch.Location = new System.Drawing.Point(19, 28);
            this.lblOrderSearch.Name = "lblOrderSearch";
            this.lblOrderSearch.Size = new System.Drawing.Size(101, 20);
            this.lblOrderSearch.TabIndex = 8;
            this.lblOrderSearch.Text = "Search Book";
            // 
            // txtReturnSearch
            // 
            this.txtReturnSearch.Location = new System.Drawing.Point(131, 25);
            this.txtReturnSearch.Name = "txtReturnSearch";
            this.txtReturnSearch.Size = new System.Drawing.Size(175, 26);
            this.txtReturnSearch.TabIndex = 7;
            // 
            // grpReturnCart
            // 
            this.grpReturnCart.Controls.Add(this.lblRefundTotal);
            this.grpReturnCart.Controls.Add(this.btnRefund);
            this.grpReturnCart.Controls.Add(this.dgvReturnCart);
            this.grpReturnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReturnCart.Location = new System.Drawing.Point(12, 329);
            this.grpReturnCart.Name = "grpReturnCart";
            this.grpReturnCart.Size = new System.Drawing.Size(458, 275);
            this.grpReturnCart.TabIndex = 34;
            this.grpReturnCart.TabStop = false;
            this.grpReturnCart.Text = "Return Cart";
            this.grpReturnCart.Visible = false;
            // 
            // lblRefundTotal
            // 
            this.lblRefundTotal.AutoSize = true;
            this.lblRefundTotal.Location = new System.Drawing.Point(19, 220);
            this.lblRefundTotal.Name = "lblRefundTotal";
            this.lblRefundTotal.Size = new System.Drawing.Size(101, 20);
            this.lblRefundTotal.TabIndex = 30;
            this.lblRefundTotal.Text = "Total Refund";
            // 
            // btnRefund
            // 
            this.btnRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.Location = new System.Drawing.Point(347, 192);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(109, 76);
            this.btnRefund.TabIndex = 27;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // dgvReturnCart
            // 
            this.dgvReturnCart.AllowUserToAddRows = false;
            this.dgvReturnCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookTitle,
            this.QtyRetuned,
            this.RefundAmount,
            this.OrderIDCart});
            this.dgvReturnCart.Location = new System.Drawing.Point(6, 25);
            this.dgvReturnCart.Name = "dgvReturnCart";
            this.dgvReturnCart.ReadOnly = true;
            this.dgvReturnCart.Size = new System.Drawing.Size(450, 161);
            this.dgvReturnCart.TabIndex = 26;
            this.dgvReturnCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnCart_CellClick);
            // 
            // BookTitle
            // 
            this.BookTitle.HeaderText = "Book Title";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // QtyRetuned
            // 
            this.QtyRetuned.HeaderText = "Qty Retuned";
            this.QtyRetuned.Name = "QtyRetuned";
            this.QtyRetuned.ReadOnly = true;
            this.QtyRetuned.Width = 50;
            // 
            // RefundAmount
            // 
            this.RefundAmount.HeaderText = "Refund Amount";
            this.RefundAmount.Name = "RefundAmount";
            this.RefundAmount.ReadOnly = true;
            // 
            // OrderIDCart
            // 
            this.OrderIDCart.HeaderText = "Order ID";
            this.OrderIDCart.Name = "OrderIDCart";
            this.OrderIDCart.ReadOnly = true;
            this.OrderIDCart.Width = 50;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(784, 51);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(91, 24);
            this.lblWelcome.TabIndex = 35;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "Book Title";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // QtyOrdered
            // 
            this.QtyOrdered.HeaderText = "QtyOrdered";
            this.QtyOrdered.Name = "QtyOrdered";
            this.QtyOrdered.ReadOnly = true;
            // 
            // OrderPrice
            // 
            this.OrderPrice.HeaderText = "OrderPrice";
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 611);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.grpReturnCart);
            this.Controls.Add(this.grpOrderSearch);
            this.Controls.Add(this.grpCustomerLogin);
            this.Controls.Add(this.grpReturnBookSelectBook);
            this.Controls.Add(this.mnuReturnBook);
            this.Name = "frmReturnBook";
            this.Text = "Book Sales System - [Orders - Return Book]";
            this.mnuReturnBook.ResumeLayout(false);
            this.mnuReturnBook.PerformLayout();
            this.grpReturnBookSelectBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBookSelectBook)).EndInit();
            this.grpCustomerLogin.ResumeLayout(false);
            this.grpCustomerLogin.PerformLayout();
            this.grpOrderSearch.ResumeLayout(false);
            this.grpOrderSearch.PerformLayout();
            this.grpReturnCart.ResumeLayout(false);
            this.grpReturnCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnCart)).EndInit();
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
        private System.Windows.Forms.GroupBox grpReturnBookSelectBook;
        private System.Windows.Forms.DataGridView dgvReturnBookSelectBook;
        private System.Windows.Forms.GroupBox grpCustomerLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.CheckBox chbOrderHidePassword;
        private System.Windows.Forms.Button btnLoadCustomer;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.TextBox txtReturnPassword;
        private System.Windows.Forms.TextBox txtReturnEmail;
        private System.Windows.Forms.GroupBox grpOrderSearch;
        private System.Windows.Forms.Button btnOrderSearch;
        private System.Windows.Forms.Label lblOrderSearch;
        private System.Windows.Forms.TextBox txtReturnSearch;
        private System.Windows.Forms.GroupBox grpReturnCart;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.DataGridView dgvReturnCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyRetuned;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIDCart;
        private System.Windows.Forms.Label lblRefundTotal;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
    }
}