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
using Microsoft.VisualBasic;

namespace BookSalesSys
{
    public partial class frmPlaceOrder : Form
    {
        frmMainMenu Parent;
        
        public frmPlaceOrder()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public frmPlaceOrder(frmMainMenu parent)
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


        private void closeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmCloseAccount nextForm = new frmCloseAccount();
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

        private void btnSearchBarOrder_Click(object sender, EventArgs e)
        {
            // Check if search string not empty
            if (string.IsNullOrWhiteSpace(txtSearchBarOrder.Text))
            {
                MessageBox.Show("Please enter a title (or part of) to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grpPlaceOrderSelectBook.Visible = true;
            dgvPlaceOrderSelectBook.Rows.Clear();
            dgvPlaceOrderSelectBook.Rows.Add("Running Grave", "Rober Galbraith", "€18");
            dgvPlaceOrderSelectBook.Rows.Add("The Graveyard Book", "Neil Gaiman", "€12");
            dgvPlaceOrderSelectBook.Rows.Add("Grave Intentions", "Harith Athreya", "€23");
        }

        private void dgvPlaceOrderSelectBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pops up window to ask about how many of this book you want to order for each click (taken from https://stackoverflow.com/questions/16463599/popup-window-in-winform-c-sharp)
            string prompt = Interaction.InputBox("How many books you want to order?", "Quantity", "1", 0,0);
            
            if(int.TryParse(prompt,out int numericPrompt) && numericPrompt > 0)
            {
                int rowIndex = e.RowIndex;

                string author = dgvPlaceOrderSelectBook.Rows[rowIndex].Cells[0].Value.ToString();
                string title = dgvPlaceOrderSelectBook.Rows[rowIndex].Cells[1].Value.ToString();
                string price = dgvPlaceOrderSelectBook.Rows[rowIndex].Cells[2].Value.ToString();


                dgvPlaceOrderCart.Rows.Add(author, title, price, prompt, "X");

                if (dgvPlaceOrderCart.Rows.Count > 0)
                {
                    grpPlaceOrderCart.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter the positive whole number", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnPlaceOrderCheckout_Click(object sender, EventArgs e)
        {
            grpPlaceOrderCheckout.Visible=true;
            dgvPlaceOrderCheckout.Rows.Clear();
            dgvPlaceOrderTotalPrice.Rows.Clear();


            string author;
            string title;
            decimal price;
            int qty;
            decimal bookPrice;
            decimal totalPrice = 0;

            //Add new rows for each click (referencing this source https://learn.microsoft.com/en-us/dotnet/api/system.string.substring?view=net-9.0)
            for (int i = 0; dgvPlaceOrderCart.Rows.Count > i; i++)
            {
                title = dgvPlaceOrderCart.Rows[i].Cells[0].Value.ToString();
                author = dgvPlaceOrderCart.Rows[i].Cells[1].Value.ToString();
                price = decimal.Parse(dgvPlaceOrderCart.Rows[i].Cells[2].Value.ToString().Substring(1));
                qty = int.Parse(dgvPlaceOrderCart.Rows[i].Cells[3].Value.ToString());
                bookPrice = qty * price;
                totalPrice += bookPrice;


                dgvPlaceOrderCheckout.Rows.Add(author, title, "€" + price, qty);
            }


            dgvPlaceOrderTotalPrice.Rows.Add("€" + totalPrice);

        }

        private void btnPlaceOrderBuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your order", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grpPlaceOrderCart.Visible=false;
            grpPlaceOrderCheckout.Visible=false;
            dgvPlaceOrderCart.Rows.Clear();
            dgvPlaceOrderCheckout.Rows.Clear();
            dgvPlaceOrderTotalPrice.Rows.Clear();
        }

        private void dgvPlaceOrderCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // On cell click with X remove books from the cart
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            string title;
            string author;
            decimal price;


            if (colIndex == 4)
            {
                //dgvPlaceOrderCart.Rows.RemoveAt(rowIndex);

                string prompt = Interaction.InputBox("How many books you want to remove?", "Quantity", "1", 0, 0);

                if (!int.TryParse(prompt, out int numericPrompt) || numericPrompt < 0)
                {
                    MessageBox.Show("Please enter the positive whole number", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    

                    int.TryParse(dgvPlaceOrderCart.Rows[rowIndex].Cells[3].Value.ToString(), out int qty);

                    qty -= numericPrompt;

                    if (qty <= 0)
                    {
                        dgvPlaceOrderCart.Rows.RemoveAt(rowIndex);
                    }
                    else
                    {
                        title = dgvPlaceOrderCart.Rows[rowIndex].Cells[0].Value.ToString();
                        author = dgvPlaceOrderCart.Rows[rowIndex].Cells[1].Value.ToString();
                        price = decimal.Parse(dgvPlaceOrderCart.Rows[rowIndex].Cells[2].Value.ToString().Substring(1));

                        dgvPlaceOrderCart.Rows[rowIndex].SetValues(title, author, "€" + price, qty);
                    }

                    
                }
            }
        }
    }
}
