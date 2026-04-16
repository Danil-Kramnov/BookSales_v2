using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSalesSys
{
    public partial class frmUpdateBookDetails : Form
    {
        frmMainMenu Parent;
        public frmUpdateBookDetails()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public frmUpdateBookDetails(frmMainMenu parent)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Parent = parent;
        }

        private void openAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmOpenAccount frm = new frmOpenAccount();
            frm.Show();
        }

        private void updateAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmUpdateAccountDetails nextForm = new frmUpdateAccountDetails();
            nextForm.Show();
        }


        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmAddBook nextForm = new frmAddBook();
            nextForm.Show();
        }

        private void discontinueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmDiscontinueBook nextForm = new frmDiscontinueBook();
            nextForm.Show();
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmPlaceOrder nextForm = new frmPlaceOrder();
            nextForm.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmReturnBook nextForm = new frmReturnBook();
            nextForm.Show();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmYearlyRevenueAnalysis nextForm = new frmYearlyRevenueAnalysis();
            nextForm.Show();
        }

        private void genreAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmYearlyGenreAnalysis nextForm = new frmYearlyGenreAnalysis();
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

        // Adding rows to my data grid (taken from https://stackoverflow.com/questions/15965043/how-to-add-rows-to-datagridview-winforms)
        private void btnSearchBar_Click(object sender, EventArgs e)
        {

            // Check if search string not empty
            if (string.IsNullOrWhiteSpace(txtSearchBarUpdate.Text))
            {
                MessageBox.Show("Please enter a title (or part of) to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvBookListUpdate.Visible = true;
            dgvBookListUpdate.Rows.Clear();
            dgvBookListUpdate.Rows.Add("Running Grave", "Robert Galbraith", "[DT] Detective", "€18", "97");
            dgvBookListUpdate.Rows.Add("The Graveyard Book", "Neil Gaiman", "[SC] Science Fiction", "€12", "101");
            dgvBookListUpdate.Rows.Add("Grave Intentions", "Harith Athreya", "[HR] History", "€23", "202");


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
                string.IsNullOrWhiteSpace(cmbGenre.Text))
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

            if (!decimal.TryParse(txtStockAmount.Text, out decimal stockAmount) || stockAmount <= 0)
            {
                MessageBox.Show("Stock Amount must be a positive value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save Data

            // Confirmation Message
            MessageBox.Show("Book Updated", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvBookListUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpUpdateBookDetails.Visible = true;
            

            int rowIndex = e.RowIndex;

            string title = dgvBookListUpdate.Rows[rowIndex].Cells[0].Value.ToString();
            string author = dgvBookListUpdate.Rows[rowIndex].Cells[1].Value.ToString();
            string genre = dgvBookListUpdate.Rows[rowIndex].Cells[2].Value.ToString();
            string price = dgvBookListUpdate.Rows[rowIndex].Cells[3].Value.ToString();
            string stockAmount = dgvBookListUpdate.Rows[rowIndex].Cells[4].Value.ToString();

            txtBookTitle.Text = title;
            txtAuthor.Text = author;
            cmbGenre.Text = genre;
            txtPrice.Text = price;
            txtStockAmount.Text = stockAmount;

            captureOriginalValues();
        }

    }
}
