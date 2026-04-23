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
    public partial class frmYearlyRevenueAnalysis : Form
    {
        new frmMainMenu Parent;
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
            this.CenterToScreen();
            DBConnection.ApplyStyling(this);
        }
        public frmYearlyRevenueAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Parent = parent;
            DBConnection.ApplyStyling(this);
        }

        private void openAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmOpenAccount nextForm = new frmOpenAccount(Parent);
            nextForm.Show();
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

        private void genreAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmYearlyGenreAnalysis nextForm = new frmYearlyGenreAnalysis(Parent);
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

        

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminLogin.Text != "admin" || txtAdminPassword.Text != "admin")
            {
                MessageBox.Show("Invalid admin credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // populate year dropdown from Orders table
            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                string sql = "SELECT DISTINCT EXTRACT(YEAR FROM DateOrdered) AS Year " +
                             "FROM Orders ORDER BY Year";
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();
                cmbSelectYearRevenueAnalysis.Items.Clear();
                while (dr.Read())
                {
                    cmbSelectYearRevenueAnalysis.Items.Add(dr["Year"].ToString());
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

        private void cmbSelectYearRevenueAnalysis_SelectedIndexChanged(object sender, EventArgs e)
        {

            int year = int.Parse(cmbSelectYearRevenueAnalysis.Text);

            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                // sum TotalPrice grouped by month for selected year
                string sql = @"SELECT TO_CHAR(DateOrdered,'MM') AS Month, SUM(TotalPrice) AS Total
                               FROM Orders
                               WHERE EXTRACT(YEAR FROM DateOrdered) = :year
                               GROUP BY TO_CHAR(DateOrdered,'MM')
                               ORDER BY Month";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add("year", year);
                OracleDataReader dr = cmd.ExecuteReader();

                // initialise arrays for all 12 months (reference from using_chart_objects.pdf)
                string[] months = {"Jan","Feb","Mar","Apr","May","Jun", "Jul","Aug","Sep","Oct","Nov","Dec"};
                decimal[] amounts = new decimal[12]; // all zero by default

                while (dr.Read())
                {
                    int m = int.Parse(dr["Month"].ToString()) - 1; // convert "01" to index 0
                    amounts[m] = Convert.ToDecimal(dr["Total"]);
                }
                dr.Close();
                conn.Close();

                if (amounts.All(a => a == 0))
                {
                    MessageBox.Show("No data found for " + year, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // bind data to chart (reference from using_chart_objects.pdf)
                // AddXY adds a data point to the chart with X (category) and Y (value)
                // #VALY is a keyword that displays the Y value as a label on each bar
                // reference: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datavisualization.charting.datapoint

                chtRevenueAnalysis.Series["Revenue"].Points.Clear();
                chtRevenueAnalysis.Series["Revenue"].Points.DataBindXY(months, amounts);
                chtRevenueAnalysis.Series["Revenue"].Label = "#VALY";
                chtRevenueAnalysis.ChartAreas[0].AxisX.Interval = 1;
                chtRevenueAnalysis.Visible = true;
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
            cmbSelectYearRevenueAnalysis.Visible = false;
            chtRevenueAnalysis.Visible = false;
            cmbSelectYearRevenueAnalysis.Items.Clear();
            grpSelectYearAnalysis.Visible = false;
        }
    }
}
