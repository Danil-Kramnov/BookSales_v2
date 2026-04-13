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
    public partial class frmYearlyGenreAnalysis : Form
    {
        frmMainMenu Parent { get; set; }
        public frmYearlyGenreAnalysis()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public frmYearlyGenreAnalysis(frmMainMenu parent)
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

        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbSelectYearGenreAnalysis_SelectedIndexChanged(object sender, EventArgs e)
        {
            chtGenreAnalysis.Visible = true;
            chtGenreAnalysis.Series["Quantity"].Points.Clear();
            chtGenreAnalysis.Series["Quantity"].Points.AddXY("Detective", 97);
            chtGenreAnalysis.Series["Quantity"].Points.AddXY("Sci-fi", 51);
            chtGenreAnalysis.Series["Quantity"].Points.AddXY("History", 65);
            chtGenreAnalysis.Series["Quantity"].Points.AddXY("Fantasy", 33);
            chtGenreAnalysis.Series["Quantity"].Points.AddXY("Romance", 60);
            chtGenreAnalysis.Series["Quantity"].Points.AddXY("Poems", 28);
            chtGenreAnalysis.Series["Quantity"].Points.AddXY("Biography", 69);
            chtGenreAnalysis.Series["Quantity"].Points.AddXY("Non-fiction", 62);
        }
    }
}
