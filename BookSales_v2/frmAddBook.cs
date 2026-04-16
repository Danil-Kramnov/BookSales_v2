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

namespace BookSalesSys
{
    public partial class frmAddBook : Form
    {
        frmMainMenu Parent { get; set; }
        
        public frmAddBook()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public frmAddBook(frmMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
            this.CenterToScreen();

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
            frmUpdateAccountDetails frm = new frmUpdateAccountDetails();
            frm.Show();
        }


        private void updateBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmUpdateBookDetails frm = new frmUpdateBookDetails();
            frm.Show();
        }

        private void discontinueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmDiscontinueBook frm = new frmDiscontinueBook();
            frm.Show();
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmPlaceOrder frm = new frmPlaceOrder();
            frm.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmReturnBook frm = new frmReturnBook();
            frm.Show();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmYearlyRevenueAnalysis frm = new frmYearlyRevenueAnalysis();
            frm.Show();
        }

        private void genreAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmYearlyGenreAnalysis frm = new frmYearlyGenreAnalysis();
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

            // Stock Amount Validation
            if (!int.TryParse(txtStockAmount.Text, out int stockAmount) || stockAmount <= 0)
            {
                MessageBox.Show("Stock amount must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save Data

            // Confirmation Message
            MessageBox.Show("Book Added", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset UI
            txtAuthor.Clear();
            txtBookTitle.Clear();
            txtPrice.Clear();
            txtStockAmount.Clear();
            cmbGenre.SelectedIndex = -1;
        }
    }
}
