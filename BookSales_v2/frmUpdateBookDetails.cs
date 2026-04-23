using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BookSalesSys
{
    public partial class frmUpdateBookDetails : Form
    {
        new frmMainMenu Parent;

        private string _originalTitle;

        public frmUpdateBookDetails()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgvBookListUpdate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DBConnection.ApplyStyling(this);
        }
        public frmUpdateBookDetails(frmMainMenu parent)
        {
            InitializeComponent();
            this.CenterToScreen();
            dgvBookListUpdate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Parent = parent;
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
            frmUpdateAccountDetails nextForm = new frmUpdateAccountDetails(Parent);
            nextForm.Show();
        }


        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmAddBook nextForm = new frmAddBook(Parent);
            nextForm.Show();
        }


        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmPlaceOrder nextForm = new frmPlaceOrder(Parent);
            nextForm.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmReturnBook nextForm = new frmReturnBook(Parent);
            nextForm.Show();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmYearlyRevenueAnalysis nextForm = new frmYearlyRevenueAnalysis(Parent);
            nextForm.Show();
        }

        private void genreAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmYearlyGenreAnalysis nextForm = new frmYearlyGenreAnalysis(Parent);
            nextForm.Show();
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

        
        

        // Variables to hold original values
        private string originalTitle;
        private string originalAuthor;
        private string originalPrice;
        private string originalStockAmount;
        private string originalGenre;

        
        private void captureOriginalValues()
        {
            originalTitle = txtBookTitle.Text;
            originalAuthor = txtAuthor.Text;
            originalPrice = txtPrice.Text;
            originalStockAmount = txtStockAmount.Text;
            originalGenre = cmbGenre.Text;
        }

        private void btnUpdateBookDetails_Click(object sender, EventArgs e)
        {
            // Validation

            // Check if any details have changed
            if (txtAuthor.Text == originalAuthor &&
                txtBookTitle.Text == originalTitle &&
                txtPrice.Text == originalPrice &&
                txtStockAmount.Text == originalStockAmount &&
                cmbGenre.Text == originalGenre)
            {
                MessageBox.Show("You are trying to save the same details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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

            // stock amount validation

            if (!int.TryParse(txtStockAmount.Text, out int stockAmount) || stockAmount < 0)
            {
                MessageBox.Show("Stock Amount must be a positive value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save Data



            // save updated book details to Books table
            string genreCode = cmbGenre.Text.Substring(0, 2);

            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                string sql = @"UPDATE Books SET Author=:author, GenreCode=:genre,Price=:price, StockAmount=:stock
                                            WHERE BookTitle=:title";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add("author", txtAuthor.Text);
                cmd.Parameters.Add("genre", genreCode);
                cmd.Parameters.Add("price", price);
                cmd.Parameters.Add("stock", stockAmount);
                cmd.Parameters.Add("title", _originalTitle);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // update the row in the grid to show changes
            dgvBookListUpdate.Rows[dgvBookListUpdate.CurrentCell.RowIndex].SetValues(txtBookTitle.Text,
                                                                                     txtAuthor.Text,
                                                                                     genreCode,
                                                                                     txtPrice.Text,
                                                                                     txtStockAmount.Text);

            // Confirmation Message
            MessageBox.Show("Book Updated", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminLogin.Text != "admin" || txtAdminPassword.Text != "admin")
            {
                MessageBox.Show("Invalid admin credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            grpSearchBook.Visible = true;
            LoadBooks("");
        }

        // load all books on admin login
        private void LoadBooks(string search)
        {
            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                // retrieve active books matching search
                string sql = @"SELECT BookTitle, Author, GenreCode, Price, StockAmount 
                               FROM Books WHERE UPPER(BookTitle) LIKE '%' || UPPER(:search) || '%' 
                               AND BookStatus='A'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add("search", search);
                OracleDataReader dr = cmd.ExecuteReader();
                dgvBookListUpdate.Rows.Clear();
                dgvBookListUpdate.Visible = true;
                while (dr.Read())
                {
                    dgvBookListUpdate.Rows.Add(dr["BookTitle"].ToString(),
                                               dr["Author"].ToString(),
                                               dr["GenreCode"].ToString(),
                                               dr["Price"].ToString(),
                                               dr["StockAmount"].ToString());
                }
                    
                if (dgvBookListUpdate.Rows.Count == 0)
                {
                    MessageBox.Show("No books found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dr.Close();
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBook.Text))
            {
                MessageBox.Show("Please enter a title (or part of) to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadBooks(txtSearchBook.Text);
        }

        private void dgvBookListUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            grpUpdateBookDetails.Visible = true;

            int rowIndex = e.RowIndex;
            txtBookTitle.Text = dgvBookListUpdate.Rows[rowIndex].Cells[0].Value.ToString();
            txtAuthor.Text = dgvBookListUpdate.Rows[rowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvBookListUpdate.Rows[rowIndex].Cells[3].Value.ToString();
            txtStockAmount.Text = dgvBookListUpdate.Rows[rowIndex].Cells[4].Value.ToString();

            // load genres from db and set current genre
            OracleConnection conn = DBConnection.GetConnection();
            conn.Open();
            string sql = "SELECT GenreCode, Description FROM Genres";
            OracleCommand cmd = new OracleCommand(sql, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            cmbGenre.Items.Clear();
            string currentGenre = dgvBookListUpdate.Rows[rowIndex].Cells[2].Value.ToString();
            while (dr.Read())
            {
                string item = dr["GenreCode"].ToString() + " - " + dr["Description"].ToString();
                cmbGenre.Items.Add(item);
                if (dr["GenreCode"].ToString() == currentGenre)
                {
                    cmbGenre.SelectedItem = item;
                }
            }
            dr.Close();
            conn.Close();

            _originalTitle = txtBookTitle.Text;
            captureOriginalValues();
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            grpSearchBook.Visible = false;
            grpUpdateBookDetails.Visible = false;
            txtAdminLogin.Clear();
            txtAdminPassword.Clear();
            dgvBookListUpdate.Rows.Clear();
        }

        private void btnDiscontinueBook_Click(object sender, EventArgs e)
        {
            // set BookStatus to Discontinued (soft delete)
            DialogResult result = MessageBox.Show("Are you sure you want to discontinue this book?", "Confirm", 
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    OracleConnection conn = DBConnection.GetConnection();
                    conn.Open();
                    string sql = "UPDATE Books SET BookStatus='D' WHERE BookTitle=:title";
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add("title", _originalTitle);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Book Discontinued.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvBookListUpdate.Rows.RemoveAt(dgvBookListUpdate.CurrentCell.RowIndex);
                    grpUpdateBookDetails.Visible = false;
                    LoadBooks("");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
