using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSalesSys
{
    public partial class frmUpdateAccountDetails : Form
    {
        frmMainMenu Parent;

        // Variable to hold original values
        private string originalForename;
        private string originalSurname;
        private string originalEmail;
        private string originalPassword;
        private string originalPhone;
        private string originalStreet;
        private string originalTown;
        private string originalCounty;
        private string originalEircode;

        public frmUpdateAccountDetails()
        {
            InitializeComponent();
            this.CenterToScreen();
            dtpDOB.Value = dtpDOB.Value.AddYears(-18);
            captureOriginalValues();

        }

        public frmUpdateAccountDetails(frmMainMenu parent)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Parent = parent;

            dtpDOB.Value = dtpDOB.Value.AddYears(-18);
            captureOriginalValues();
        }

        private void captureOriginalValues()
        {
            originalForename = txtForename.Text;
            originalSurname = txtSurname.Text;
            originalEmail = txtEmail.Text;
            originalPassword = txtPassword.Text;
            originalPhone = txtPhone.Text;
            originalStreet = txtStreet.Text;
            originalTown = txtTown.Text;
            originalCounty = txtCounty.Text;
            originalEircode = txtEircode.Text;
        }


        private void openAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmOpenAccount nextForm = new frmOpenAccount();
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
            frmCloseAccount addBook = new frmCloseAccount();
            addBook.Show();
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

        private void mnuBackClick_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnUpdateAccountDetails_Click(object sender, EventArgs e)
        {
            // Check if any details have changed
            if (txtForename.Text == originalForename &&
                txtSurname.Text == originalSurname &&
                txtEmail.Text == originalEmail &&
                txtPassword.Text == originalPassword &&
                txtPhone.Text == originalPhone &&
                txtStreet.Text == originalStreet &&
                txtTown.Text == originalTown &&
                txtCounty.Text == originalCounty &&
                txtEircode.Text == originalEircode)
            {
                MessageBox.Show("You are trying to save the same details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Forename Validation
            if (txtForename.Text.Length > 30 || !Regex.IsMatch(txtForename.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Forename must be up to 30 characters and contain only letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Surname Validation
            if (txtSurname.Text.Length > 30 || !Regex.IsMatch(txtSurname.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Surname must be up to 30 characters and contain only letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Email Validation
            if (txtEmail.Text.Length > 30)
            {
                MessageBox.Show("Email must be up to 30 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Password Validation
            if (txtPassword.Text.Length > 30)
            {
                MessageBox.Show("Password must be up to 30 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Phone Validation
            if (txtPhone.Text.Length > 10 || !Regex.IsMatch(txtPhone.Text, @"^\d+$"))
            {
                MessageBox.Show("Phone must be up to 10 digits and contain only digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Street Validation
            if (txtStreet.Text.Length > 50)
            {
                MessageBox.Show("Street must be up to 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Town Validation
            if (txtTown.Text.Length > 20)
            {
                MessageBox.Show("Town must be up to 20 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // County Validation
            if (txtCounty.Text.Length > 20)
            {
                MessageBox.Show("County must be up to 20 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Eircode Validation
            if (txtEircode.Text.Length > 7 || !Regex.IsMatch(txtEircode.Text, "^[a-zA-Z0-9]*$"))
            {
                MessageBox.Show("Eircode must be up to 7 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Save Data

            // Confirmation Message
            MessageBox.Show("Account Updated", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
