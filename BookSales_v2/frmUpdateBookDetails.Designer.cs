namespace BookSalesSys
{
    partial class frmUpdateBookDetails
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
            this.mnuUpdateBookDetails = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackClick = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discontinueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdateBookDetails = new System.Windows.Forms.GroupBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnUpdateBookDetails = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtSearchBarUpdate = new System.Windows.Forms.TextBox();
            this.lblSearchBarUpdate = new System.Windows.Forms.Label();
            this.btnSearchBarUpdate = new System.Windows.Forms.Button();
            this.dgvBookListUpdate = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuUpdateBookDetails.SuspendLayout();
            this.grpUpdateBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookListUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuUpdateBookDetails
            // 
            this.mnuUpdateBookDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.mnuBackClick,
            this.customersToolStripMenuItem,
            this.catalogueToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuUpdateBookDetails.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateBookDetails.Name = "mnuUpdateBookDetails";
            this.mnuUpdateBookDetails.Size = new System.Drawing.Size(584, 24);
            this.mnuUpdateBookDetails.TabIndex = 6;
            this.mnuUpdateBookDetails.Text = "Update Book Details Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
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
            this.updateAccountDetailsToolStripMenuItem,
            this.closeAccountToolStripMenuItem});
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
            // closeAccountToolStripMenuItem
            // 
            this.closeAccountToolStripMenuItem.Name = "closeAccountToolStripMenuItem";
            this.closeAccountToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.closeAccountToolStripMenuItem.Text = "Close Account";
            this.closeAccountToolStripMenuItem.Click += new System.EventHandler(this.closeAccountToolStripMenuItem_Click);
            // 
            // catalogueToolStripMenuItem
            // 
            this.catalogueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.updateBookDetailsToolStripMenuItem,
            this.discontinueBookToolStripMenuItem});
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
            // 
            // discontinueBookToolStripMenuItem
            // 
            this.discontinueBookToolStripMenuItem.Name = "discontinueBookToolStripMenuItem";
            this.discontinueBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.discontinueBookToolStripMenuItem.Text = "Discontinue Book";
            this.discontinueBookToolStripMenuItem.Click += new System.EventHandler(this.discontinueBookToolStripMenuItem_Click);
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
            this.genreAnalysisToolStripMenuItem.Click += new System.EventHandler(this.genreAnalysisToolStripMenuItem_Click);
            // 
            // grpUpdateBookDetails
            // 
            this.grpUpdateBookDetails.Controls.Add(this.cmbGenre);
            this.grpUpdateBookDetails.Controls.Add(this.txtStockAmount);
            this.grpUpdateBookDetails.Controls.Add(this.lblStockAmount);
            this.grpUpdateBookDetails.Controls.Add(this.lblGenre);
            this.grpUpdateBookDetails.Controls.Add(this.btnUpdateBookDetails);
            this.grpUpdateBookDetails.Controls.Add(this.txtPrice);
            this.grpUpdateBookDetails.Controls.Add(this.txtAuthor);
            this.grpUpdateBookDetails.Controls.Add(this.txtBookTitle);
            this.grpUpdateBookDetails.Controls.Add(this.lblPrice);
            this.grpUpdateBookDetails.Controls.Add(this.lblAuthor);
            this.grpUpdateBookDetails.Controls.Add(this.lblBookTitle);
            this.grpUpdateBookDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateBookDetails.Location = new System.Drawing.Point(52, 309);
            this.grpUpdateBookDetails.Name = "grpUpdateBookDetails";
            this.grpUpdateBookDetails.Size = new System.Drawing.Size(451, 227);
            this.grpUpdateBookDetails.TabIndex = 8;
            this.grpUpdateBookDetails.TabStop = false;
            this.grpUpdateBookDetails.Text = "Book Details";
            this.grpUpdateBookDetails.Visible = false;
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "[DT] Detective",
            "[SC] Science Fiction",
            "[HR] History",
            "[FS] Fantasy",
            "[RC] Romance",
            "[PO] Poems",
            "[BG] Biography",
            "[NF] Non-fiction"});
            this.cmbGenre.Location = new System.Drawing.Point(134, 92);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(279, 28);
            this.cmbGenre.TabIndex = 19;
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Location = new System.Drawing.Point(134, 158);
            this.txtStockAmount.MaxLength = 30;
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(34, 26);
            this.txtStockAmount.TabIndex = 18;
            this.txtStockAmount.Text = "97";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(22, 162);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(110, 20);
            this.lblStockAmount.TabIndex = 17;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(22, 95);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 16;
            this.lblGenre.Text = "Genre";
            // 
            // btnUpdateBookDetails
            // 
            this.btnUpdateBookDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBookDetails.Location = new System.Drawing.Point(134, 192);
            this.btnUpdateBookDetails.Name = "btnUpdateBookDetails";
            this.btnUpdateBookDetails.Size = new System.Drawing.Size(146, 29);
            this.btnUpdateBookDetails.TabIndex = 14;
            this.btnUpdateBookDetails.Text = "Update Details";
            this.btnUpdateBookDetails.UseVisualStyleBackColor = true;
            this.btnUpdateBookDetails.Click += new System.EventHandler(this.btnUpdateBookDetails_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(134, 124);
            this.txtPrice.MaxLength = 30;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(53, 26);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.Text = "€18";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(134, 60);
            this.txtAuthor.MaxLength = 30;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(279, 26);
            this.txtAuthor.TabIndex = 8;
            this.txtAuthor.Text = "Robert Galbraith";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(134, 34);
            this.txtBookTitle.MaxLength = 30;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(279, 26);
            this.txtBookTitle.TabIndex = 7;
            this.txtBookTitle.Tag = "";
            this.txtBookTitle.Text = "Running Grave";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(22, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(22, 64);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 20);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(22, 40);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(38, 20);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Title";
            // 
            // txtSearchBarUpdate
            // 
            this.txtSearchBarUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBarUpdate.Location = new System.Drawing.Point(213, 65);
            this.txtSearchBarUpdate.Name = "txtSearchBarUpdate";
            this.txtSearchBarUpdate.Size = new System.Drawing.Size(146, 26);
            this.txtSearchBarUpdate.TabIndex = 16;
            // 
            // lblSearchBarUpdate
            // 
            this.lblSearchBarUpdate.AutoSize = true;
            this.lblSearchBarUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBarUpdate.Location = new System.Drawing.Point(118, 68);
            this.lblSearchBarUpdate.Name = "lblSearchBarUpdate";
            this.lblSearchBarUpdate.Size = new System.Drawing.Size(81, 20);
            this.lblSearchBarUpdate.TabIndex = 17;
            this.lblSearchBarUpdate.Text = "Enter Title";
            // 
            // btnSearchBarUpdate
            // 
            this.btnSearchBarUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBarUpdate.Location = new System.Drawing.Point(378, 65);
            this.btnSearchBarUpdate.Name = "btnSearchBarUpdate";
            this.btnSearchBarUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnSearchBarUpdate.TabIndex = 18;
            this.btnSearchBarUpdate.Text = "Search";
            this.btnSearchBarUpdate.UseVisualStyleBackColor = true;
            this.btnSearchBarUpdate.Click += new System.EventHandler(this.btnSearchBar_Click);
            // 
            // dgvBookListUpdate
            // 
            this.dgvBookListUpdate.AllowUserToAddRows = false;
            this.dgvBookListUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookListUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Author,
            this.Genre,
            this.Price,
            this.StockAmount});
            this.dgvBookListUpdate.Location = new System.Drawing.Point(26, 147);
            this.dgvBookListUpdate.Name = "dgvBookListUpdate";
            this.dgvBookListUpdate.ReadOnly = true;
            this.dgvBookListUpdate.Size = new System.Drawing.Size(546, 115);
            this.dgvBookListUpdate.TabIndex = 19;
            this.dgvBookListUpdate.Visible = false;
            this.dgvBookListUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookListUpdate_CellClick);
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
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // StockAmount
            // 
            this.StockAmount.HeaderText = "StockAmount";
            this.StockAmount.Name = "StockAmount";
            this.StockAmount.ReadOnly = true;
            // 
            // frmUpdateBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.dgvBookListUpdate);
            this.Controls.Add(this.btnSearchBarUpdate);
            this.Controls.Add(this.lblSearchBarUpdate);
            this.Controls.Add(this.txtSearchBarUpdate);
            this.Controls.Add(this.grpUpdateBookDetails);
            this.Controls.Add(this.mnuUpdateBookDetails);
            this.Name = "frmUpdateBookDetails";
            this.Text = "Book Sales System - [Catalogue - Update Book Details]";
            this.mnuUpdateBookDetails.ResumeLayout(false);
            this.mnuUpdateBookDetails.PerformLayout();
            this.grpUpdateBookDetails.ResumeLayout(false);
            this.grpUpdateBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookListUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateBookDetails;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBackClick;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discontinueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreAnalysisToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpUpdateBookDetails;
        private System.Windows.Forms.Button btnUpdateBookDetails;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtSearchBarUpdate;
        private System.Windows.Forms.Label lblSearchBarUpdate;
        private System.Windows.Forms.Button btnSearchBarUpdate;
        private System.Windows.Forms.DataGridView dgvBookListUpdate;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAmount;
    }
}