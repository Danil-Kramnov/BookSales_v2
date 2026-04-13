namespace BookSalesSys
{
    partial class frmDiscontinueBook
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
            this.mnuDiscontinueBook = new System.Windows.Forms.MenuStrip();
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
            this.btnSearchBarDiscontinue = new System.Windows.Forms.Button();
            this.lblSearchBarDiscontinue = new System.Windows.Forms.Label();
            this.txtSearchBarDiscontinue = new System.Windows.Forms.TextBox();
            this.dgvBookListDiscontinue = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDiscontinueBook = new System.Windows.Forms.GroupBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnDiscontinueBook = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.mnuDiscontinueBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookListDiscontinue)).BeginInit();
            this.grpDiscontinueBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuDiscontinueBook
            // 
            this.mnuDiscontinueBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.mnuBackClick,
            this.customersToolStripMenuItem,
            this.catalogueToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuDiscontinueBook.Location = new System.Drawing.Point(0, 0);
            this.mnuDiscontinueBook.Name = "mnuDiscontinueBook";
            this.mnuDiscontinueBook.Size = new System.Drawing.Size(709, 24);
            this.mnuDiscontinueBook.TabIndex = 8;
            this.mnuDiscontinueBook.Text = "Discontinue Book Menu";
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
            this.updateBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateBookDetailsToolStripMenuItem_Click);
            // 
            // discontinueBookToolStripMenuItem
            // 
            this.discontinueBookToolStripMenuItem.Name = "discontinueBookToolStripMenuItem";
            this.discontinueBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.discontinueBookToolStripMenuItem.Text = "Discontinue Book";
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
            // btnSearchBarDiscontinue
            // 
            this.btnSearchBarDiscontinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBarDiscontinue.Location = new System.Drawing.Point(430, 46);
            this.btnSearchBarDiscontinue.Name = "btnSearchBarDiscontinue";
            this.btnSearchBarDiscontinue.Size = new System.Drawing.Size(75, 26);
            this.btnSearchBarDiscontinue.TabIndex = 23;
            this.btnSearchBarDiscontinue.Text = "Search";
            this.btnSearchBarDiscontinue.UseVisualStyleBackColor = true;
            this.btnSearchBarDiscontinue.Click += new System.EventHandler(this.btnSearchBarDiscontinue_Click);
            // 
            // lblSearchBarDiscontinue
            // 
            this.lblSearchBarDiscontinue.AutoSize = true;
            this.lblSearchBarDiscontinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBarDiscontinue.Location = new System.Drawing.Point(170, 49);
            this.lblSearchBarDiscontinue.Name = "lblSearchBarDiscontinue";
            this.lblSearchBarDiscontinue.Size = new System.Drawing.Size(81, 20);
            this.lblSearchBarDiscontinue.TabIndex = 22;
            this.lblSearchBarDiscontinue.Text = "Enter Title";
            // 
            // txtSearchBarDiscontinue
            // 
            this.txtSearchBarDiscontinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBarDiscontinue.Location = new System.Drawing.Point(265, 46);
            this.txtSearchBarDiscontinue.Name = "txtSearchBarDiscontinue";
            this.txtSearchBarDiscontinue.Size = new System.Drawing.Size(146, 26);
            this.txtSearchBarDiscontinue.TabIndex = 21;
            // 
            // dgvBookListDiscontinue
            // 
            this.dgvBookListDiscontinue.AllowUserToAddRows = false;
            this.dgvBookListDiscontinue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookListDiscontinue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Author,
            this.Genre,
            this.Price,
            this.StockAmount});
            this.dgvBookListDiscontinue.Location = new System.Drawing.Point(70, 102);
            this.dgvBookListDiscontinue.Name = "dgvBookListDiscontinue";
            this.dgvBookListDiscontinue.ReadOnly = true;
            this.dgvBookListDiscontinue.Size = new System.Drawing.Size(546, 115);
            this.dgvBookListDiscontinue.TabIndex = 25;
            this.dgvBookListDiscontinue.Visible = false;
            this.dgvBookListDiscontinue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookListDiscontinue_CellClick);
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
            // grpDiscontinueBook
            // 
            this.grpDiscontinueBook.Controls.Add(this.cmbGenre);
            this.grpDiscontinueBook.Controls.Add(this.txtStockAmount);
            this.grpDiscontinueBook.Controls.Add(this.lblStockAmount);
            this.grpDiscontinueBook.Controls.Add(this.lblGenre);
            this.grpDiscontinueBook.Controls.Add(this.btnDiscontinueBook);
            this.grpDiscontinueBook.Controls.Add(this.txtPrice);
            this.grpDiscontinueBook.Controls.Add(this.txtAuthor);
            this.grpDiscontinueBook.Controls.Add(this.txtBookTitle);
            this.grpDiscontinueBook.Controls.Add(this.lblPrice);
            this.grpDiscontinueBook.Controls.Add(this.lblAuthor);
            this.grpDiscontinueBook.Controls.Add(this.lblBookTitle);
            this.grpDiscontinueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDiscontinueBook.Location = new System.Drawing.Point(112, 259);
            this.grpDiscontinueBook.Name = "grpDiscontinueBook";
            this.grpDiscontinueBook.Size = new System.Drawing.Size(451, 227);
            this.grpDiscontinueBook.TabIndex = 24;
            this.grpDiscontinueBook.TabStop = false;
            this.grpDiscontinueBook.Text = "Book Details";
            this.grpDiscontinueBook.Visible = false;
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
            // btnDiscontinueBook
            // 
            this.btnDiscontinueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscontinueBook.Location = new System.Drawing.Point(134, 192);
            this.btnDiscontinueBook.Name = "btnDiscontinueBook";
            this.btnDiscontinueBook.Size = new System.Drawing.Size(165, 29);
            this.btnDiscontinueBook.TabIndex = 14;
            this.btnDiscontinueBook.Text = "Discontinue Book";
            this.btnDiscontinueBook.UseVisualStyleBackColor = true;
            this.btnDiscontinueBook.Click += new System.EventHandler(this.btnUpdateBookDetails_Click_1);
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
            // frmDiscontinueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 543);
            this.Controls.Add(this.dgvBookListDiscontinue);
            this.Controls.Add(this.grpDiscontinueBook);
            this.Controls.Add(this.btnSearchBarDiscontinue);
            this.Controls.Add(this.lblSearchBarDiscontinue);
            this.Controls.Add(this.txtSearchBarDiscontinue);
            this.Controls.Add(this.mnuDiscontinueBook);
            this.Name = "frmDiscontinueBook";
            this.Text = "Book Sales System - [Catalogue - Discontinue Book]";
            this.mnuDiscontinueBook.ResumeLayout(false);
            this.mnuDiscontinueBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookListDiscontinue)).EndInit();
            this.grpDiscontinueBook.ResumeLayout(false);
            this.grpDiscontinueBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDiscontinueBook;
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
        private System.Windows.Forms.Button btnSearchBarDiscontinue;
        private System.Windows.Forms.Label lblSearchBarDiscontinue;
        private System.Windows.Forms.TextBox txtSearchBarDiscontinue;
        private System.Windows.Forms.DataGridView dgvBookListDiscontinue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAmount;
        private System.Windows.Forms.GroupBox grpDiscontinueBook;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnDiscontinueBook;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookTitle;
    }
}