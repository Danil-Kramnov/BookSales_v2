using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BookSalesSys
{
    public partial class frmAddBook : Form
    {
        new frmMainMenu Parent { get; set; }
        
        public frmAddBook()
        {
            InitializeComponent();
            this.CenterToScreen();
            DBConnection.ApplyStyling(this);
            dgvAddedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
        public frmAddBook(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
            this.CenterToScreen();
            
            dgvAddedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DBConnection.ApplyStyling(this);


        }

        private void openAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmOpenAccount frm = new frmOpenAccount(Parent);
            frm.Show();
        }

        private void updateAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmUpdateAccountDetails frm = new frmUpdateAccountDetails(Parent);
            frm.Show();
        }


        private void updateBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmUpdateBookDetails frm = new frmUpdateBookDetails(Parent);
            frm.Show();
        }


        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmPlaceOrder frm = new frmPlaceOrder(Parent);
            frm.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmReturnBook frm = new frmReturnBook(Parent);
            frm.Show();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmYearlyRevenueAnalysis frm = new frmYearlyRevenueAnalysis(Parent);
            frm.Show();
        }

        private void genreAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmYearlyGenreAnalysis frm = new frmYearlyGenreAnalysis(Parent);
            frm.Show();
        }

        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Validation

            // All fields must be entered
            if (string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtBookTitle.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStockAmount.Text) ||
                cmbGenre.SelectedIndex == -1)
            {
                MessageBox.Show("All fields must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Book Title Validation
            if (txtBookTitle.Text.Length > 50)
            {
                MessageBox.Show("Book title must be up to 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Author Validation
            if (txtAuthor.Text.Length > 50)
            {
                MessageBox.Show("Author name must be up to 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Price Validation
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Price must be a positive value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Stock Amount Validation
            if (!int.TryParse(txtStockAmount.Text, out int stockAmount) || stockAmount < 0)
            {
                MessageBox.Show("Stock amount must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save Data
            
            string genreCode = cmbGenre.Text.Substring(0, 2);

            // set status Available, save to Books table
            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                string sql = @"INSERT INTO Books (BookID, BookTitle, Author, GenreCode, Price, StockAmount, BookStatus)
                                           VALUES(books_seq.NEXTVAL, :title, :author, :genre, :price, :stock, 'A')";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add("title", txtBookTitle.Text);
                cmd.Parameters.Add("author", txtAuthor.Text);
                cmd.Parameters.Add("genre", genreCode);
                cmd.Parameters.Add("price", price);
                cmd.Parameters.Add("stock", stockAmount);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    MessageBox.Show("A book with this title already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            // confirmation message
            MessageBox.Show("Book Added", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBooks();
            
            // show added book in grid
            dgvAddedBooks.Visible = true;

            // reset UI
            txtAuthor.Clear();
            txtBookTitle.Clear();
            txtPrice.Clear();
            txtStockAmount.Clear();
            cmbGenre.SelectedIndex = -1;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminLogin.Text != "admin" || txtAdminPassword.Text != "admin")
            {
                MessageBox.Show("Invalid admin password.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // load genres from Genres table
            OracleConnection conn = DBConnection.GetConnection();
            conn.Open();
            string sql = "SELECT GenreCode, Description FROM Genres";
            OracleCommand cmd = new OracleCommand(sql, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            cmbGenre.Items.Clear();
            while (dr.Read())
            {
                cmbGenre.Items.Add(dr["GenreCode"].ToString() + " - " + dr["Description"].ToString());
            }
            dr.Close();
            conn.Close();
            grpAddBook.Visible = true;
            btnAdminLogin.Visible = false;
            LoadBooks();
        }

        private void chbAdminHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdminHidePassword.CheckState == CheckState.Checked)
            {
                txtAdminPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtAdminPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            grpAddBook.Visible = false;
            txtAdminLogin.Clear();
            txtAdminPassword.Clear();
            dgvAddedBooks.Visible = false;
            btnAdminLogin.Visible = true;
        }

        private void LoadBooks()
        {
            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                string sql = "SELECT BookID, BookTitle, Author, Price, StockAmount, GenreCode FROM Books WHERE BookStatus='A'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();
                dgvAddedBooks.Rows.Clear();
                dgvAddedBooks.Visible = true;
                while (dr.Read())
                {
                    dgvAddedBooks.Rows.Add(dr["BookID"].ToString(),
                                           dr["BookTitle"].ToString(),
                                           dr["Author"].ToString(),
                                           dr["Price"].ToString(),
                                           dr["StockAmount"].ToString(),
                                           dr["GenreCode"].ToString());
                }
                    
                dr.Close();
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
