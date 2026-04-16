using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BookSalesSys
{
    public partial class frmDiscontinueBook : Form
    {
        frmMainMenu Parent { get; set; }
        public frmDiscontinueBook()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public frmDiscontinueBook(frmMainMenu parent)
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

        private void updateBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmUpdateBookDetails nextForm = new frmUpdateBookDetails();
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

        //Back Button returns back to the Main Menu
        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchBarDiscontinue_Click(object sender, EventArgs e)
        {
            // Check if search string not empty
            if (string.IsNullOrWhiteSpace(txtSearchBarDiscontinue.Text))
            {
                MessageBox.Show("Please enter a title (or part of) to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvBookListDiscontinue.Visible = true;
            dgvBookListDiscontinue.Rows.Clear();
            dgvBookListDiscontinue.Rows.Add("Running Grave", "Robert Galbraith", "[DT] Detective", "€18", "97");
            dgvBookListDiscontinue.Rows.Add("The Graveyard Book", "Neil Gaiman", "[SC] Science Fiction", "€12", "101");
            dgvBookListDiscontinue.Rows.Add("Grave Intentions", "Harith Athreya", "[HR] History", "€23", "202");
        }

        private void dgvBookListDiscontinue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpDiscontinueBook.Visible = true;

            int rowIndex = e.RowIndex;

            string title = dgvBookListDiscontinue.Rows[rowIndex].Cells[0].Value.ToString();
            string author = dgvBookListDiscontinue.Rows[rowIndex].Cells[1].Value.ToString();
            string genre = dgvBookListDiscontinue.Rows[rowIndex].Cells[2].Value.ToString();
            string price = dgvBookListDiscontinue.Rows[rowIndex].Cells[3].Value.ToString();
            string stockAmount = dgvBookListDiscontinue.Rows[rowIndex].Cells[4].Value.ToString();

            txtBookTitle.Text = title;
            txtAuthor.Text = author;
            cmbGenre.Text = genre;
            txtPrice.Text = price;
            txtStockAmount.Text = stockAmount;
        }

        private void btnUpdateBookDetails_Click_1(object sender, EventArgs e)
        {
            // Confirmation Message (taken from https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult)
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to discontinue this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Check if the user clicked "Yes"
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Book Discontinued", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
