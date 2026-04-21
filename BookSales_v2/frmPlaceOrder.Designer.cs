namespace BookSalesSys
{
    partial class frmPlaceOrder
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
            this.mnuPlaceOrder = new System.Windows.Forms.MenuStrip();
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
            this.dgvPlaceOrderSelectBook = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPlaceOrderCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPlaceOrderCart = new System.Windows.Forms.GroupBox();
            this.btnPlaceOrderBuy = new System.Windows.Forms.Button();
            this.grpPlaceOrderSelectBook = new System.Windows.Forms.GroupBox();
            this.grpCustomerLogin = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.chbOrderHidePassword = new System.Windows.Forms.CheckBox();
            this.btnLoadCustomer = new System.Windows.Forms.Button();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.txtOrderPassword = new System.Windows.Forms.TextBox();
            this.txtOrderEmail = new System.Windows.Forms.TextBox();
            this.grpOrderSearch = new System.Windows.Forms.GroupBox();
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.lblOrderSearch = new System.Windows.Forms.Label();
            this.txtOrderSearch = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.mnuPlaceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderSelectBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderCart)).BeginInit();
            this.grpPlaceOrderCart.SuspendLayout();
            this.grpPlaceOrderSelectBook.SuspendLayout();
            this.grpCustomerLogin.SuspendLayout();
            this.grpOrderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPlaceOrder
            // 
            this.mnuPlaceOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.mnuBackClick,
            this.customersToolStripMenuItem,
            this.catalogueToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuPlaceOrder.Location = new System.Drawing.Point(0, 0);
            this.mnuPlaceOrder.Name = "mnuPlaceOrder";
            this.mnuPlaceOrder.Size = new System.Drawing.Size(941, 24);
            this.mnuPlaceOrder.TabIndex = 6;
            this.mnuPlaceOrder.Text = "Place Order Menu";
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
            this.genreAnalysisToolStripMenuItem.Click += new System.EventHandler(this.genreAnalysisToolStripMenuItem_Click);
            // 
            // dgvPlaceOrderSelectBook
            // 
            this.dgvPlaceOrderSelectBook.AllowUserToAddRows = false;
            this.dgvPlaceOrderSelectBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaceOrderSelectBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Author,
            this.Price,
            this.StockAmount});
            this.dgvPlaceOrderSelectBook.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgvPlaceOrderSelectBook.Location = new System.Drawing.Point(6, 37);
            this.dgvPlaceOrderSelectBook.Name = "dgvPlaceOrderSelectBook";
            this.dgvPlaceOrderSelectBook.ReadOnly = true;
            this.dgvPlaceOrderSelectBook.Size = new System.Drawing.Size(399, 115);
            this.dgvPlaceOrderSelectBook.TabIndex = 23;
            this.dgvPlaceOrderSelectBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaceOrderSelectBook_CellContentClick);
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
            this.Price.Width = 50;
            // 
            // StockAmount
            // 
            this.StockAmount.HeaderText = "Stock";
            this.StockAmount.Name = "StockAmount";
            this.StockAmount.ReadOnly = true;
            this.StockAmount.Visible = false;
            // 
            // dgvPlaceOrderCart
            // 
            this.dgvPlaceOrderCart.AllowUserToAddRows = false;
            this.dgvPlaceOrderCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaceOrderCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.Qty,
            this.Remove});
            this.dgvPlaceOrderCart.Location = new System.Drawing.Point(6, 37);
            this.dgvPlaceOrderCart.Name = "dgvPlaceOrderCart";
            this.dgvPlaceOrderCart.ReadOnly = true;
            this.dgvPlaceOrderCart.Size = new System.Drawing.Size(450, 161);
            this.dgvPlaceOrderCart.TabIndex = 26;
            this.dgvPlaceOrderCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaceOrderCart_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Book Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Author";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 50;
            // 
            // Remove
            // 
            this.Remove.HeaderText = " ";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            // 
            // grpPlaceOrderCart
            // 
            this.grpPlaceOrderCart.Controls.Add(this.lblTotalPrice);
            this.grpPlaceOrderCart.Controls.Add(this.btnPlaceOrderBuy);
            this.grpPlaceOrderCart.Controls.Add(this.dgvPlaceOrderCart);
            this.grpPlaceOrderCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlaceOrderCart.Location = new System.Drawing.Point(12, 294);
            this.grpPlaceOrderCart.Name = "grpPlaceOrderCart";
            this.grpPlaceOrderCart.Size = new System.Drawing.Size(465, 299);
            this.grpPlaceOrderCart.TabIndex = 27;
            this.grpPlaceOrderCart.TabStop = false;
            this.grpPlaceOrderCart.Text = "Cart";
            this.grpPlaceOrderCart.Visible = false;
            // 
            // btnPlaceOrderBuy
            // 
            this.btnPlaceOrderBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrderBuy.Location = new System.Drawing.Point(347, 204);
            this.btnPlaceOrderBuy.Name = "btnPlaceOrderBuy";
            this.btnPlaceOrderBuy.Size = new System.Drawing.Size(109, 76);
            this.btnPlaceOrderBuy.TabIndex = 27;
            this.btnPlaceOrderBuy.Text = "Buy";
            this.btnPlaceOrderBuy.UseVisualStyleBackColor = true;
            this.btnPlaceOrderBuy.Click += new System.EventHandler(this.btnPlaceOrderBuy_Click);
            // 
            // grpPlaceOrderSelectBook
            // 
            this.grpPlaceOrderSelectBook.Controls.Add(this.dgvPlaceOrderSelectBook);
            this.grpPlaceOrderSelectBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlaceOrderSelectBook.Location = new System.Drawing.Point(12, 100);
            this.grpPlaceOrderSelectBook.Name = "grpPlaceOrderSelectBook";
            this.grpPlaceOrderSelectBook.Size = new System.Drawing.Size(465, 178);
            this.grpPlaceOrderSelectBook.TabIndex = 28;
            this.grpPlaceOrderSelectBook.TabStop = false;
            this.grpPlaceOrderSelectBook.Text = "Select Book to Add to Cart";
            this.grpPlaceOrderSelectBook.Visible = false;
            // 
            // grpCustomerLogin
            // 
            this.grpCustomerLogin.Controls.Add(this.btnLogout);
            this.grpCustomerLogin.Controls.Add(this.chbOrderHidePassword);
            this.grpCustomerLogin.Controls.Add(this.btnLoadCustomer);
            this.grpCustomerLogin.Controls.Add(this.lblLoginPassword);
            this.grpCustomerLogin.Controls.Add(this.lblLoginEmail);
            this.grpCustomerLogin.Controls.Add(this.txtOrderPassword);
            this.grpCustomerLogin.Controls.Add(this.txtOrderEmail);
            this.grpCustomerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerLogin.Location = new System.Drawing.Point(500, 100);
            this.grpCustomerLogin.Name = "grpCustomerLogin";
            this.grpCustomerLogin.Size = new System.Drawing.Size(413, 156);
            this.grpCustomerLogin.TabIndex = 30;
            this.grpCustomerLogin.TabStop = false;
            this.grpCustomerLogin.Text = "Customer Login";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(204, 101);
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
            this.chbOrderHidePassword.Location = new System.Drawing.Point(289, 72);
            this.chbOrderHidePassword.Name = "chbOrderHidePassword";
            this.chbOrderHidePassword.Size = new System.Drawing.Size(118, 20);
            this.chbOrderHidePassword.TabIndex = 10;
            this.chbOrderHidePassword.Text = "Hide Password";
            this.chbOrderHidePassword.UseVisualStyleBackColor = true;
            // 
            // btnLoadCustomer
            // 
            this.btnLoadCustomer.Location = new System.Drawing.Point(100, 101);
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
            this.lblLoginPassword.Location = new System.Drawing.Point(12, 71);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(78, 20);
            this.lblLoginPassword.TabIndex = 8;
            this.lblLoginPassword.Text = "Password";
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmail.Location = new System.Drawing.Point(12, 39);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(48, 20);
            this.lblLoginEmail.TabIndex = 8;
            this.lblLoginEmail.Text = "Email";
            // 
            // txtOrderPassword
            // 
            this.txtOrderPassword.Location = new System.Drawing.Point(100, 69);
            this.txtOrderPassword.Name = "txtOrderPassword";
            this.txtOrderPassword.Size = new System.Drawing.Size(183, 26);
            this.txtOrderPassword.TabIndex = 8;
            // 
            // txtOrderEmail
            // 
            this.txtOrderEmail.Location = new System.Drawing.Point(100, 37);
            this.txtOrderEmail.Name = "txtOrderEmail";
            this.txtOrderEmail.Size = new System.Drawing.Size(275, 26);
            this.txtOrderEmail.TabIndex = 7;
            // 
            // grpOrderSearch
            // 
            this.grpOrderSearch.Controls.Add(this.btnOrderSearch);
            this.grpOrderSearch.Controls.Add(this.lblOrderSearch);
            this.grpOrderSearch.Controls.Add(this.txtOrderSearch);
            this.grpOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderSearch.Location = new System.Drawing.Point(12, 27);
            this.grpOrderSearch.Name = "grpOrderSearch";
            this.grpOrderSearch.Size = new System.Drawing.Size(465, 67);
            this.grpOrderSearch.TabIndex = 31;
            this.grpOrderSearch.TabStop = false;
            this.grpOrderSearch.Visible = false;
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSearch.Location = new System.Drawing.Point(377, 25);
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
            // txtOrderSearch
            // 
            this.txtOrderSearch.Location = new System.Drawing.Point(131, 25);
            this.txtOrderSearch.Name = "txtOrderSearch";
            this.txtOrderSearch.Size = new System.Drawing.Size(240, 26);
            this.txtOrderSearch.TabIndex = 7;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(19, 232);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(83, 20);
            this.lblTotalPrice.TabIndex = 28;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 672);
            this.Controls.Add(this.grpOrderSearch);
            this.Controls.Add(this.grpCustomerLogin);
            this.Controls.Add(this.grpPlaceOrderSelectBook);
            this.Controls.Add(this.grpPlaceOrderCart);
            this.Controls.Add(this.mnuPlaceOrder);
            this.Name = "frmPlaceOrder";
            this.Text = "Book Sales System - [Orders - Place Order]";
            this.mnuPlaceOrder.ResumeLayout(false);
            this.mnuPlaceOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderSelectBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderCart)).EndInit();
            this.grpPlaceOrderCart.ResumeLayout(false);
            this.grpPlaceOrderCart.PerformLayout();
            this.grpPlaceOrderSelectBook.ResumeLayout(false);
            this.grpCustomerLogin.ResumeLayout(false);
            this.grpCustomerLogin.PerformLayout();
            this.grpOrderSearch.ResumeLayout(false);
            this.grpOrderSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPlaceOrder;
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
        private System.Windows.Forms.DataGridView dgvPlaceOrderSelectBook;
        private System.Windows.Forms.DataGridView dgvPlaceOrderCart;
        private System.Windows.Forms.GroupBox grpPlaceOrderCart;
        private System.Windows.Forms.GroupBox grpPlaceOrderSelectBook;
        private System.Windows.Forms.Button btnPlaceOrderBuy;
        private System.Windows.Forms.GroupBox grpCustomerLogin;
        private System.Windows.Forms.CheckBox chbOrderHidePassword;
        private System.Windows.Forms.Button btnLoadCustomer;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.TextBox txtOrderPassword;
        private System.Windows.Forms.TextBox txtOrderEmail;
        private System.Windows.Forms.GroupBox grpOrderSearch;
        private System.Windows.Forms.Button btnOrderSearch;
        private System.Windows.Forms.Label lblOrderSearch;
        private System.Windows.Forms.TextBox txtOrderSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remove;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}