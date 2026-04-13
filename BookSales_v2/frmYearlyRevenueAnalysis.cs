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
    public partial class frmYearlyRevenueAnalysis : Form
    {
        frmMainMenu Parent;
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public frmYearlyRevenueAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Parent = parent;

        }

        private void openAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmOpenAccount nextForm = new frmOpenAccount();
            nextForm.Show();
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

        private void cmbSelectYearRevenueAnalysis_SelectedIndexChanged(object sender, EventArgs e)
        {

            chtRevenueAnalysis.Visible = true;
            chtRevenueAnalysis.Series["Revenue"].Points.Clear();
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("January", 58000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("February", 48000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("March", 63000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("April", 55000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("May", 62000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("June", 61000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("July", 60000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("August", 57000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("September", 68000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("October", 59000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("November", 65000);
            chtRevenueAnalysis.Series["Revenue"].Points.AddXY("December", 70000);
        }
    }
}
