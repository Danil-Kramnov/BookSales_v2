using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BookSalesSys
{
    public partial class frmOpenAccount : Form
    {
        frmMainMenu Parent { get; set; }

        public frmOpenAccount()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public frmOpenAccount(frmMainMenu parent)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Parent = parent;

            dtpDOB.Value = dtpDOB.Value.AddYears(-18);

            SetPlaceholder(txtForename, "e.g. John");
            SetPlaceholder(txtSurname, "e.g. Doe");
            SetPlaceholder(txtEmail, "e.g. john@email.com");
            SetPlaceholder(txtPassword, "e.g. pass1");
            SetPlaceholder(txtPhone, "e.g. 0871234567");
            SetPlaceholder(txtStreet, "e.g. Test Street");
            SetPlaceholder(txtTown, "e.g. Tralee");
            SetPlaceholder(txtCounty, "e.g. Kerry");
            SetPlaceholder(txtEircode, "e.g. V92AB12");
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

        // Placeholder for fields entry
        private void SetPlaceholder(TextBox txt, string hint)
        {
            txt.Text = hint;
            txt.ForeColor = Color.Gray;
            txt.GotFocus += (s, e) => {
                if (txt.Text == hint) { txt.Text = ""; txt.ForeColor = Color.Black; }
            };
            txt.LostFocus += (s, e) => {
                if (txt.Text == "") { txt.Text = hint; txt.ForeColor = Color.Gray; }
            };
        }


        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            // Validate Data

            // All Fields must be entered
            if (string.IsNullOrWhiteSpace(txtForename.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtStreet.Text) ||
                string.IsNullOrWhiteSpace(txtTown.Text) ||
                string.IsNullOrWhiteSpace(txtCounty.Text) ||
                string.IsNullOrWhiteSpace(txtEircode.Text))
            {
                MessageBox.Show("All fields must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // age validation
            if ((DateTime.Today - dtpDOB.Value.Date).TotalDays < 365 * 18)
            {
                MessageBox.Show("You must be over 18 to open an account.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save Data
            try
            {
                // code taken from: https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.parameters?view=netframework-4.8.1
                // and here: https://csharpforums.net/threads/sql-command-parameters.8459/
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                string sql = @"INSERT INTO Accounts (AccountID,Forename,Surname,DOB,Email,Password,Phone,Street,Town,County,Eircode,Status)
                               VALUES (accounts_seq.NEXTVAL,:fn,:sn,:dob,:email,:pwd,:phone,:street,:towm,:county,:eircode,'A')";
                OracleCommand cmd = new OracleCommand(sql,conn);
                cmd.Parameters.Add(":fn", txtForename.Text);
                cmd.Parameters.Add(":sn", txtSurname.Text);
                cmd.Parameters.Add(":dob", dtpDOB.Value);
                cmd.Parameters.Add(":email", txtEmail.Text);
                cmd.Parameters.Add(":pwd", txtPassword.Text);
                cmd.Parameters.Add(":phone", txtPhone.Text);
                cmd.Parameters.Add(":street", txtStreet.Text);
                cmd.Parameters.Add(":town", txtTown.Text);
                cmd.Parameters.Add(":county", txtCounty.Text);
                cmd.Parameters.Add(":eircode", txtEircode.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (OracleException ex) 
            {
                if (ex.Number == 1)
                {
                    MessageBox.Show("Account with this email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Database error." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return;

            }


            // Confirmation Message
            MessageBox.Show("Account Created", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset UI
            txtForename.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtEircode.Clear();

        }


    }
}
