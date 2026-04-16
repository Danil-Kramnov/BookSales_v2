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
using Oracle.ManagedDataAccess.Client;

namespace BookSalesSys
{
    public partial class frmUpdateAccountDetails : Form
    {
        frmMainMenu Parent;

        private int _accountID;

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
            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                string sql = @"UPDATE Accounts SET Forename=:fn, Surname=:sn, DOB=:dob, Email=:email, Password=:pwd, 
                                                   Phone=:phone, Street=:street, Town=:town, County=:county, Eircode=:eircode
                                               WHERE AccountID=:id";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":fn", txtForename.Text);
                cmd.Parameters.Add(":sn", txtSurname.Text);
                cmd.Parameters.Add(":dob", dtpDOB.Value.Date);
                cmd.Parameters.Add(":email", txtEmail.Text);
                cmd.Parameters.Add(":pwd", txtPassword.Text);
                cmd.Parameters.Add(":phone", txtPhone.Text);
                cmd.Parameters.Add(":street", txtStreet.Text);
                cmd.Parameters.Add(":town", txtTown.Text);
                cmd.Parameters.Add(":county", txtCounty.Text);
                cmd.Parameters.Add(":eircode", txtEircode.Text);
                cmd.Parameters.Add(":id", _accountID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                    MessageBox.Show("Account with this email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation Message
            MessageBox.Show("Account Updated", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void chbLoginHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLoginHidePassword.CheckState == CheckState.Checked)
            {
                txtLoginPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtLoginPassword.UseSystemPasswordChar= false;
            }
        }

        private void btnLoadAccountDetails_Click(object sender, EventArgs e)
        {
            try
            {
                // code taken from here: https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/retrieving-data-using-a-datareader
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                string sql = "SELECT * FROM Accounts WHERE Email=:email AND Password=:pwd AND Status='A'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":email", txtLoginEmail.Text);
                cmd.Parameters.Add(":pwd", txtLoginPassword.Text);
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read()) {
                    _accountID = Convert.ToInt32(dr["AccountID"]);
                    txtForename.Text = dr["Forename"].ToString();
                    txtSurname.Text = dr["Surname"].ToString();
                    dtpDOB.Value = Convert.ToDateTime(dr["DOB"]);
                    txtEmail.Text = dr["Email"].ToString();
                    txtPassword.Text = dr["Password"].ToString();
                    txtPhone.Text = dr["Phone"].ToString();
                    txtStreet.Text = dr["Street"].ToString();
                    txtTown.Text = dr["Town"].ToString();
                    txtCounty.Text = dr["County"].ToString();
                    txtEircode.Text = dr["Eircode"].ToString();
                    captureOriginalValues();
                    grpUpdateAccountDetails.Visible = true;
                }
                else
                {
                    MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close your account?", "Confirm", 
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    OracleConnection conn = DBConnection.GetConnection();
                    conn.Open();
                    string sql = "UPDATE Accounts SET Status='C' WHERE AccountID=:id";
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":id", _accountID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Account Closed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpUpdateAccountDetails.Visible = false;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
