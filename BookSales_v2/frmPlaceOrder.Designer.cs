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
            this.btnSearchBarPlaceOrder = new System.Windows.Forms.Button();
            this.lblSearchBarOrder = new System.Windows.Forms.Label();
            this.txtSearchBarOrder = new System.Windows.Forms.TextBox();
            this.lblAccountIdOrder = new System.Windows.Forms.Label();
            this.txtAccountIdOrder = new System.Windows.Forms.TextBox();
            this.dgvPlaceOrderCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPlaceOrderCart = new System.Windows.Forms.GroupBox();
            this.btnPlaceOrderCheckout = new System.Windows.Forms.Button();
            this.grpPlaceOrderSelectBook = new System.Windows.Forms.GroupBox();
            this.grpPlaceOrderCheckout = new System.Windows.Forms.GroupBox();
            this.dgvPlaceOrderTotalPrice = new System.Windows.Forms.DataGridView();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPlaceOrderCheckout = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlaceOrderBuy = new System.Windows.Forms.Button();
            this.mnuPlaceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderSelectBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderCart)).BeginInit();
            this.grpPlaceOrderCart.SuspendLayout();
            this.grpPlaceOrderSelectBook.SuspendLayout();
            this.grpPlaceOrderCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderCheckout)).BeginInit();
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
            this.mnuPlaceOrder.Size = new System.Drawing.Size(1171, 24);
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
            this.Price});
            this.dgvPlaceOrderSelectBook.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgvPlaceOrderSelectBook.Location = new System.Drawing.Point(6, 37);
            this.dgvPlaceOrderSelectBook.Name = "dgvPlaceOrderSelectBook";
            this.dgvPlaceOrderSelectBook.ReadOnly = true;
            this.dgvPlaceOrderSelectBook.Size = new System.Drawing.Size(293, 115);
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
            // btnSearchBarPlaceOrder
            // 
            this.btnSearchBarPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBarPlaceOrder.Location = new System.Drawing.Point(272, 67);
            this.btnSearchBarPlaceOrder.Name = "btnSearchBarPlaceOrder";
            this.btnSearchBarPlaceOrder.Size = new System.Drawing.Size(75, 26);
            this.btnSearchBarPlaceOrder.TabIndex = 22;
            this.btnSearchBarPlaceOrder.Text = "Search";
            this.btnSearchBarPlaceOrder.UseVisualStyleBackColor = true;
            this.btnSearchBarPlaceOrder.Click += new System.EventHandler(this.btnSearchBarOrder_Click);
            // 
            // lblSearchBarOrder
            // 
            this.lblSearchBarOrder.AutoSize = true;
            this.lblSearchBarOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBarOrder.Location = new System.Drawing.Point(12, 70);
            this.lblSearchBarOrder.Name = "lblSearchBarOrder";
            this.lblSearchBarOrder.Size = new System.Drawing.Size(81, 20);
            this.lblSearchBarOrder.TabIndex = 21;
            this.lblSearchBarOrder.Text = "Enter Title";
            // 
            // txtSearchBarOrder
            // 
            this.txtSearchBarOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBarOrder.Location = new System.Drawing.Point(107, 67);
            this.txtSearchBarOrder.Name = "txtSearchBarOrder";
            this.txtSearchBarOrder.Size = new System.Drawing.Size(146, 26);
            this.txtSearchBarOrder.TabIndex = 20;
            // 
            // lblAccountIdOrder
            // 
            this.lblAccountIdOrder.AutoSize = true;
            this.lblAccountIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountIdOrder.Location = new System.Drawing.Point(496, 30);
            this.lblAccountIdOrder.Name = "lblAccountIdOrder";
            this.lblAccountIdOrder.Size = new System.Drawing.Size(89, 20);
            this.lblAccountIdOrder.TabIndex = 25;
            this.lblAccountIdOrder.Text = "Account ID";
            // 
            // txtAccountIdOrder
            // 
            this.txtAccountIdOrder.Enabled = false;
            this.txtAccountIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountIdOrder.Location = new System.Drawing.Point(591, 27);
            this.txtAccountIdOrder.Name = "txtAccountIdOrder";
            this.txtAccountIdOrder.ReadOnly = true;
            this.txtAccountIdOrder.Size = new System.Drawing.Size(146, 26);
            this.txtAccountIdOrder.TabIndex = 24;
            this.txtAccountIdOrder.Text = "001";
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
            this.dgvPlaceOrderCart.Size = new System.Drawing.Size(450, 115);
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
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            // 
            // grpPlaceOrderCart
            // 
            this.grpPlaceOrderCart.Controls.Add(this.btnPlaceOrderCheckout);
            this.grpPlaceOrderCart.Controls.Add(this.dgvPlaceOrderCart);
            this.grpPlaceOrderCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlaceOrderCart.Location = new System.Drawing.Point(323, 128);
            this.grpPlaceOrderCart.Name = "grpPlaceOrderCart";
            this.grpPlaceOrderCart.Size = new System.Drawing.Size(465, 217);
            this.grpPlaceOrderCart.TabIndex = 27;
            this.grpPlaceOrderCart.TabStop = false;
            this.grpPlaceOrderCart.Text = "Cart";
            this.grpPlaceOrderCart.Visible = false;
            // 
            // btnPlaceOrderCheckout
            // 
            this.btnPlaceOrderCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrderCheckout.Location = new System.Drawing.Point(177, 158);
            this.btnPlaceOrderCheckout.Name = "btnPlaceOrderCheckout";
            this.btnPlaceOrderCheckout.Size = new System.Drawing.Size(122, 26);
            this.btnPlaceOrderCheckout.TabIndex = 25;
            this.btnPlaceOrderCheckout.Text = "Go Checkout";
            this.btnPlaceOrderCheckout.UseVisualStyleBackColor = true;
            this.btnPlaceOrderCheckout.Click += new System.EventHandler(this.btnPlaceOrderCheckout_Click);
            // 
            // grpPlaceOrderSelectBook
            // 
            this.grpPlaceOrderSelectBook.Controls.Add(this.dgvPlaceOrderSelectBook);
            this.grpPlaceOrderSelectBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlaceOrderSelectBook.Location = new System.Drawing.Point(12, 128);
            this.grpPlaceOrderSelectBook.Name = "grpPlaceOrderSelectBook";
            this.grpPlaceOrderSelectBook.Size = new System.Drawing.Size(305, 217);
            this.grpPlaceOrderSelectBook.TabIndex = 28;
            this.grpPlaceOrderSelectBook.TabStop = false;
            this.grpPlaceOrderSelectBook.Text = "Select Book";
            this.grpPlaceOrderSelectBook.Visible = false;
            // 
            // grpPlaceOrderCheckout
            // 
            this.grpPlaceOrderCheckout.Controls.Add(this.dgvPlaceOrderTotalPrice);
            this.grpPlaceOrderCheckout.Controls.Add(this.dgvPlaceOrderCheckout);
            this.grpPlaceOrderCheckout.Controls.Add(this.btnPlaceOrderBuy);
            this.grpPlaceOrderCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlaceOrderCheckout.Location = new System.Drawing.Point(794, 128);
            this.grpPlaceOrderCheckout.Name = "grpPlaceOrderCheckout";
            this.grpPlaceOrderCheckout.Size = new System.Drawing.Size(366, 217);
            this.grpPlaceOrderCheckout.TabIndex = 29;
            this.grpPlaceOrderCheckout.TabStop = false;
            this.grpPlaceOrderCheckout.Text = "Checkout";
            this.grpPlaceOrderCheckout.Visible = false;
            // 
            // dgvPlaceOrderTotalPrice
            // 
            this.dgvPlaceOrderTotalPrice.AllowUserToAddRows = false;
            this.dgvPlaceOrderTotalPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaceOrderTotalPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalPrice});
            this.dgvPlaceOrderTotalPrice.Location = new System.Drawing.Point(6, 125);
            this.dgvPlaceOrderTotalPrice.Name = "dgvPlaceOrderTotalPrice";
            this.dgvPlaceOrderTotalPrice.ReadOnly = true;
            this.dgvPlaceOrderTotalPrice.Size = new System.Drawing.Size(113, 86);
            this.dgvPlaceOrderTotalPrice.TabIndex = 29;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 50;
            // 
            // dgvPlaceOrderCheckout
            // 
            this.dgvPlaceOrderCheckout.AllowUserToAddRows = false;
            this.dgvPlaceOrderCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaceOrderCheckout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7});
            this.dgvPlaceOrderCheckout.Location = new System.Drawing.Point(6, 37);
            this.dgvPlaceOrderCheckout.Name = "dgvPlaceOrderCheckout";
            this.dgvPlaceOrderCheckout.ReadOnly = true;
            this.dgvPlaceOrderCheckout.Size = new System.Drawing.Size(345, 82);
            this.dgvPlaceOrderCheckout.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Book Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Author";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // btnPlaceOrderBuy
            // 
            this.btnPlaceOrderBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrderBuy.Location = new System.Drawing.Point(268, 133);
            this.btnPlaceOrderBuy.Name = "btnPlaceOrderBuy";
            this.btnPlaceOrderBuy.Size = new System.Drawing.Size(83, 51);
            this.btnPlaceOrderBuy.TabIndex = 27;
            this.btnPlaceOrderBuy.Text = "Buy";
            this.btnPlaceOrderBuy.UseVisualStyleBackColor = true;
            this.btnPlaceOrderBuy.Click += new System.EventHandler(this.btnPlaceOrderBuy_Click);
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 364);
            this.Controls.Add(this.grpPlaceOrderCheckout);
            this.Controls.Add(this.grpPlaceOrderSelectBook);
            this.Controls.Add(this.grpPlaceOrderCart);
            this.Controls.Add(this.lblAccountIdOrder);
            this.Controls.Add(this.txtAccountIdOrder);
            this.Controls.Add(this.btnSearchBarPlaceOrder);
            this.Controls.Add(this.lblSearchBarOrder);
            this.Controls.Add(this.txtSearchBarOrder);
            this.Controls.Add(this.mnuPlaceOrder);
            this.Name = "frmPlaceOrder";
            this.Text = "Book Sales System - [Orders - Place Order]";
            this.mnuPlaceOrder.ResumeLayout(false);
            this.mnuPlaceOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderSelectBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderCart)).EndInit();
            this.grpPlaceOrderCart.ResumeLayout(false);
            this.grpPlaceOrderSelectBook.ResumeLayout(false);
            this.grpPlaceOrderCheckout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaceOrderCheckout)).EndInit();
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
        private System.Windows.Forms.Button btnSearchBarPlaceOrder;
        private System.Windows.Forms.Label lblSearchBarOrder;
        private System.Windows.Forms.TextBox txtSearchBarOrder;
        private System.Windows.Forms.Label lblAccountIdOrder;
        private System.Windows.Forms.TextBox txtAccountIdOrder;
        private System.Windows.Forms.DataGridView dgvPlaceOrderCart;
        private System.Windows.Forms.GroupBox grpPlaceOrderCart;
        private System.Windows.Forms.GroupBox grpPlaceOrderSelectBook;
        private System.Windows.Forms.Button btnPlaceOrderCheckout;
        private System.Windows.Forms.GroupBox grpPlaceOrderCheckout;
        private System.Windows.Forms.Button btnPlaceOrderBuy;
        private System.Windows.Forms.DataGridView dgvPlaceOrderCheckout;
        private System.Windows.Forms.DataGridView dgvPlaceOrderTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remove;
    }
}