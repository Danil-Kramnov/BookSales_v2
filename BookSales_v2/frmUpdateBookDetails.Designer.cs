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
            this.catalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdateBookDetails = new System.Windows.Forms.GroupBox();
            this.btnDiscontinueBook = new System.Windows.Forms.Button();
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
            this.dgvBookListUpdate = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAdminLogin = new System.Windows.Forms.GroupBox();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.chbAdminHidePassword = new System.Windows.Forms.CheckBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminLogin = new System.Windows.Forms.TextBox();
            this.grpSearchBook = new System.Windows.Forms.GroupBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.mnuUpdateBookDetails.SuspendLayout();
            this.grpUpdateBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookListUpdate)).BeginInit();
            this.grpAdminLogin.SuspendLayout();
            this.grpSearchBook.SuspendLayout();
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
            this.mnuUpdateBookDetails.Size = new System.Drawing.Size(665, 24);
            this.mnuUpdateBookDetails.TabIndex = 6;
            this.mnuUpdateBookDetails.Text = "Update Book Details Menu";
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
            this.grpUpdateBookDetails.Controls.Add(this.btnDiscontinueBook);
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
            this.grpUpdateBookDetails.Location = new System.Drawing.Point(86, 363);
            this.grpUpdateBookDetails.Name = "grpUpdateBookDetails";
            this.grpUpdateBookDetails.Size = new System.Drawing.Size(419, 227);
            this.grpUpdateBookDetails.TabIndex = 8;
            this.grpUpdateBookDetails.TabStop = false;
            this.grpUpdateBookDetails.Text = "Book Details";
            this.grpUpdateBookDetails.Visible = false;
            // 
            // btnDiscontinueBook
            // 
            this.btnDiscontinueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscontinueBook.Location = new System.Drawing.Point(239, 192);
            this.btnDiscontinueBook.Name = "btnDiscontinueBook";
            this.btnDiscontinueBook.Size = new System.Drawing.Size(156, 29);
            this.btnDiscontinueBook.TabIndex = 20;
            this.btnDiscontinueBook.Text = "Discontinue";
            this.btnDiscontinueBook.UseVisualStyleBackColor = true;
            this.btnDiscontinueBook.Click += new System.EventHandler(this.btnDiscontinueBook_Click);
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
            this.btnUpdateBookDetails.Location = new System.Drawing.Point(64, 192);
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
            this.txtBookTitle.ReadOnly = true;
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
            this.dgvBookListUpdate.Location = new System.Drawing.Point(26, 242);
            this.dgvBookListUpdate.Name = "dgvBookListUpdate";
            this.dgvBookListUpdate.ReadOnly = true;
            this.dgvBookListUpdate.Size = new System.Drawing.Size(608, 115);
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
            this.grpAdminLogin.Location = new System.Drawing.Point(86, 25);
            this.grpAdminLogin.Name = "grpAdminLogin";
            this.grpAdminLogin.Size = new System.Drawing.Size(419, 138);
            this.grpAdminLogin.TabIndex = 20;
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
            // grpSearchBook
            // 
            this.grpSearchBook.Controls.Add(this.btnSearchBook);
            this.grpSearchBook.Controls.Add(this.lblSearchBook);
            this.grpSearchBook.Controls.Add(this.txtSearchBook);
            this.grpSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchBook.Location = new System.Drawing.Point(86, 169);
            this.grpSearchBook.Name = "grpSearchBook";
            this.grpSearchBook.Size = new System.Drawing.Size(419, 67);
            this.grpSearchBook.TabIndex = 21;
            this.grpSearchBook.TabStop = false;
            this.grpSearchBook.Visible = false;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.Location = new System.Drawing.Point(326, 25);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(79, 28);
            this.btnSearchBook.TabIndex = 9;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBook.Location = new System.Drawing.Point(19, 28);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(101, 20);
            this.lblSearchBook.TabIndex = 8;
            this.lblSearchBook.Text = "Search Book";
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(131, 25);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(175, 26);
            this.txtSearchBook.TabIndex = 7;
            // 
            // frmUpdateBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 665);
            this.Controls.Add(this.grpSearchBook);
            this.Controls.Add(this.grpAdminLogin);
            this.Controls.Add(this.dgvBookListUpdate);
            this.Controls.Add(this.grpUpdateBookDetails);
            this.Controls.Add(this.mnuUpdateBookDetails);
            this.Name = "frmUpdateBookDetails";
            this.Text = "Book Sales System - [Catalogue - Update Book Details]";
            this.mnuUpdateBookDetails.ResumeLayout(false);
            this.mnuUpdateBookDetails.PerformLayout();
            this.grpUpdateBookDetails.ResumeLayout(false);
            this.grpUpdateBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookListUpdate)).EndInit();
            this.grpAdminLogin.ResumeLayout(false);
            this.grpAdminLogin.PerformLayout();
            this.grpSearchBook.ResumeLayout(false);
            this.grpSearchBook.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem catalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookDetailsToolStripMenuItem;
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
        private System.Windows.Forms.Button btnDiscontinueBook;
        private System.Windows.Forms.GroupBox grpAdminLogin;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.CheckBox chbAdminHidePassword;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label lblAdminLogin;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminLogin;
        private System.Windows.Forms.GroupBox grpSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.TextBox txtSearchBook;
    }
}