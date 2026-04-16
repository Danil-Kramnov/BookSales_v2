using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BookSalesSys
{
    public partial class frmReturnBook : Form
    {
        frmMainMenu Parent { get; set; }
        public frmReturnBook()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public frmReturnBook(frmMainMenu parent)
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

        private void btnSearchBarReturnBook_Click(object sender, EventArgs e)
        {
            // Check if search string not empty
            if (string.IsNullOrWhiteSpace(txtSearchBarReturn.Text))
            {
                MessageBox.Show("Please enter a title (or part of) to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grpReturnBookSelectBook.Visible = true;
            dgvReturnBookSelectBook.Rows.Clear();
            dgvReturnBookSelectBook.Rows.Add("Running Grave", "Rober Galbraith", "€18", "2");
            dgvReturnBookSelectBook.Rows.Add("The Graveyard Book", "Neil Gaiman", "€12", "4");
            dgvReturnBookSelectBook.Rows.Add("Grave Intentions", "Harith Athreya", "€23", "2");
        }


        private void dgvReturnBookSelectBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            string title = dgvReturnBookSelectBook.Rows[rowIndex].Cells[0].Value.ToString();
            string author = dgvReturnBookSelectBook.Rows[rowIndex].Cells[1].Value.ToString();
            decimal price = decimal.Parse(dgvReturnBookSelectBook.Rows[rowIndex].Cells[2].Value.ToString().Substring(1));

            // Ask how many books you want to return
            // Pops up window to ask about how many of this book you want to return for each click (taken from https://stackoverflow.com/questions/16463599/popup-window-in-winform-c-sharp)

            string prompt = Interaction.InputBox("How many books you want to return?", "Quantity", "1", 0, 0);
            //Remove rows for each click (referencing this source https://learn.microsoft.com/en-us/dotnet/api/system.string.substring?view=net-9.0)
            int.TryParse(dgvReturnBookSelectBook.Rows[rowIndex].Cells[3].Value.ToString(), out int qty);
            if (!int.TryParse(prompt, out int result) || result < 0 || result > qty)
            {
                MessageBox.Show("Please enter the positive whole number in range 0-" + qty + " of ordered books", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                qty -= result;
                dgvReturnBookSelectBook.Rows[rowIndex].SetValues(title, author, "€" + price, qty);
                if (qty == 0)
                {
                    dgvReturnBookSelectBook.Rows.RemoveAt(rowIndex);
                }
            }
        }
    }
}
