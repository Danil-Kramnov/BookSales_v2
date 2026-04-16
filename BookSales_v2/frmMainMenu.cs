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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmOpenAccount nextForm = new frmOpenAccount(this);
            nextForm.Show();
        }

        private void updateAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmUpdateAccountDetails nextForm = new frmUpdateAccountDetails(this);
            nextForm.Show();
        }



        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmAddBook nextForm = new frmAddBook(this);
            nextForm.Show();
        }

        private void updateBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmUpdateBookDetails nextForm = new frmUpdateBookDetails(this);
            nextForm.Show();
        }

        private void discontinueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmDiscontinueBook nextForm = new frmDiscontinueBook(this);
            nextForm.Show();
        }

        private void placeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmPlaceOrder nextForm = new frmPlaceOrder(this);
            nextForm.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmReturnBook nextForm = new frmReturnBook(this);
            nextForm.Show();
        }

        private void produceYearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmYearlyRevenueAnalysis nextForm = new frmYearlyRevenueAnalysis(this);
            nextForm.Show();
        }

        private void produceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmYearlyGenreAnalysis nextForm = new frmYearlyGenreAnalysis(this);
            nextForm.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (DBConnection.IsConnected)
            {
                DBConnection.IsConnected = false;
                lblStatus.Text = "Offline";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                btnConnect.Text = "Connect";
            }
            else
            {
                if (DBConnection.TestConnection())
                {
                    lblStatus.Text = "Online";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Offline";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            

        }
    }
}
