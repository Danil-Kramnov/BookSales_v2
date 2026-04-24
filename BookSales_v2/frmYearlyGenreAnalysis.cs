using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BookSalesSys
{
    public partial class frmYearlyGenreAnalysis : Form
    {
        new frmMainMenu Parent;
        public frmYearlyGenreAnalysis()
        {
            InitializeComponent();
            this.CenterToScreen();
            DBConnection.ApplyStyling(this);
        }
        public frmYearlyGenreAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Parent = parent;
            DBConnection.ApplyStyling(this);
        }

        private void openAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmOpenAccount frm = new frmOpenAccount(Parent);
            frm.Show();
        }

        private void updateAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmUpdateAccountDetails nextForm = new frmUpdateAccountDetails(Parent);
            nextForm.Show();
        }



        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmAddBook nextForm = new frmAddBook(Parent);
            nextForm.Show();
        }

        private void updateBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmUpdateBookDetails nextForm = new frmUpdateBookDetails(Parent);
            nextForm.Show();
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmPlaceOrder nextForm = new frmPlaceOrder(Parent);
            nextForm.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmReturnBook nextForm = new frmReturnBook(Parent);
            nextForm.Show();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmYearlyRevenueAnalysis nextForm = new frmYearlyRevenueAnalysis(Parent);
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

        

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminLogin.Text != "admin" || txtAdminPassword.Text != "admin")
            {
                MessageBox.Show("Invalid admin credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                string sql = "SELECT DISTINCT EXTRACT(YEAR FROM DateOrdered) AS Year " +
                             "FROM Orders ORDER BY Year";
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();
                cmbSelectYearGenreAnalysis.Items.Clear();
                btnAdminLogin.Visible = false;
                while (dr.Read())
                {
                    cmbSelectYearGenreAnalysis.Items.Add(dr["Year"].ToString());
                }
                dr.Close();
                conn.Close();
                grpSelectYearAnalysis.Visible = true;
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            txtAdminLogin.Clear();
            txtAdminPassword.Clear();
            grpSelectYearAnalysis.Visible = false;
            chtGenreAnalysis.Visible = false;
            btnAdminLogin.Visible = true;
            cmbSelectYearGenreAnalysis.Items.Clear();
        }

        private void cmbSelectYearGenreAnalysis_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int year = int.Parse(cmbSelectYearGenreAnalysis.Text);

            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                // sum QtyOrdered grouped by genre for selected year (reference from using_chart_objects.pdf)
                string sql = @"SELECT genres.Description, SUM(orderedbooks.QtyOrdered) AS Total
                               FROM Orders orders
                               JOIN OrderedBooks orderedbooks ON orders.OrderID = orderedbooks.OrderID
                               JOIN Books books ON orderedbooks.BookID = books.BookID
                               JOIN Genres genres ON books.GenreCode = genres.GenreCode
                               WHERE EXTRACT(YEAR FROM orders.DateOrdered) = :year
                               GROUP BY genres.Description";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add("year", year);
                OracleDataReader dr = cmd.ExecuteReader();

                chtGenreAnalysis.Series["Quantity"].Points.Clear();
                bool hasData = false;

                while (dr.Read())
                {
                    string genre = dr["Description"].ToString();
                    double total = Convert.ToDouble(dr["Total"]);
                    chtGenreAnalysis.Series["Quantity"].Points.AddXY(genre, total);
                    hasData = true;
                }
                dr.Close();
                conn.Close();

                if (!hasData)
                {
                    MessageBox.Show("No data found for " + year, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // chart settings (reference from using_chart_objects.pdf)
                chtGenreAnalysis.Series["Quantity"].Label = "#VALY";
                chtGenreAnalysis.ChartAreas[0].AxisX.Interval = 1;
                chtGenreAnalysis.Visible = true;
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbAdminHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdminHidePassword.CheckState == CheckState.Checked)
            {
                txtAdminPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtAdminPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
