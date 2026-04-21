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
using Oracle.ManagedDataAccess.Client;

namespace BookSalesSys
{
    public partial class frmReturnBook : Form
    {
        frmMainMenu Parent { get; set; }
        private int _customerID;
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



        

        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReturnEmail.Text) || string.IsNullOrWhiteSpace(txtReturnPassword.Text))
            {
                MessageBox.Show("Please enter email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                string sql = @"SELECT AccountID FROM Accounts 
                               WHERE Email=:email 
                               AND Password=:pwd 
                               AND Status='A'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add("email", txtReturnEmail.Text);
                cmd.Parameters.Add("pwd", txtReturnPassword.Text);
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    _customerID = Convert.ToInt32(dr["AccountID"]);
                    dr.Close();
                    conn.Close();
                    grpOrderSearch.Visible = true;
                    grpReturnBookSelectBook.Visible = true;
                    LoadOrders("");
                }
                else
                {
                    dr.Close();
                    conn.Close();
                    MessageBox.Show("Account not found or already closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReturnSearch.Text))
            {
                LoadOrders("");
                return;
            }
            LoadOrders(txtReturnSearch.Text);

            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                // retrieve books ordered within 14 days matching search
                string sql = @"SELECT orderedbooks.BookTitle, orderedbooks.QtyOrdered, orderedbooks.OrderPrice, orders.OrderID
                               FROM Orders orders
                               JOIN OrderedBooks orderedbooks ON orders.OrderID = orderedbooks.OrderID
                               WHERE orders.AccountID = :accountID
                               AND UPPER(orderedbooks.BookTitle) LIKE '%' || UPPER(:search) || '%'
                               AND orders.DateOrdered >= SYSDATE - 14";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add("accountID", _customerID);
                cmd.Parameters.Add("search", txtReturnSearch.Text);
                OracleDataReader dr = cmd.ExecuteReader();
                dgvReturnBookSelectBook.Rows.Clear();
                while (dr.Read())
                    dgvReturnBookSelectBook.Rows.Add(dr["BookTitle"].ToString(),
                                                     dr["QtyOrdered"].ToString(),
                                                     "€" + dr["OrderPrice"].ToString(),
                                                     dr["OrderID"].ToString());
                if (dgvReturnBookSelectBook.Rows.Count == 0)
                {
                    MessageBox.Show("No returns/refunds after 14 days.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                dr.Close();
                conn.Close();
                grpReturnBookSelectBook.Visible = true;
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReturnBookSelectBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int rowIndex = e.RowIndex;
            string title = dgvReturnBookSelectBook.Rows[rowIndex].Cells[0].Value.ToString();
            int qty = int.Parse(dgvReturnBookSelectBook.Rows[rowIndex].Cells[1].Value.ToString());
            decimal price = decimal.Parse(dgvReturnBookSelectBook.Rows[rowIndex].Cells[2].Value.ToString().Substring(1));
            int orderID = int.Parse(dgvReturnBookSelectBook.Rows[rowIndex].Cells[3].Value.ToString());

            // ask how many to return
            // (taken from https://stackoverflow.com/questions/16463599/popup-window-in-winform-c-sharp)
            string prompt = Interaction.InputBox("How many books do you want to return?", "Quantity", "1", 0, 0);

            if (!int.TryParse(prompt, out int result) || result <= 0 || result > qty)
            {
                MessageBox.Show("Please enter a number between 1 and " + qty, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal refundAmount = result * (price / qty);

            // save return, update stock and order total
            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();

                // insert into ReturnedBooks
                string retSql = @"INSERT INTO ReturnedBooks (OrderID, BookTitle, QtyReturned, RefundAmount)
                                  VALUES(:orderID, :title, :qty, :refundAmount)";
                OracleCommand retCmd = new OracleCommand(retSql, conn);
                retCmd.Parameters.Add("orderID", orderID);
                retCmd.Parameters.Add("title", title);
                retCmd.Parameters.Add("qty", result);
                retCmd.Parameters.Add("refundAmount", refundAmount);
                retCmd.ExecuteNonQuery();

                // restore stock
                string stockSql = "UPDATE Books SET StockAmount = StockAmount + :qty " +
                                  "WHERE BookTitle = :title";
                OracleCommand stockCmd = new OracleCommand(stockSql, conn);
                stockCmd.Parameters.Add("qty", result);
                stockCmd.Parameters.Add("title", title);
                stockCmd.ExecuteNonQuery();

                // reduce order total
                string orderSql = "UPDATE Orders SET TotalPrice = TotalPrice - :refundAmount " +
                                  "WHERE OrderID = :orderID";
                OracleCommand orderCmd = new OracleCommand(orderSql, conn);
                orderCmd.Parameters.Add("refundAmount", refundAmount);
                orderCmd.Parameters.Add("orderID", orderID);
                orderCmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Book Returned. Refund: €" + refundAmount, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // update grid row
                qty -= result;
                if (qty == 0)
                {
                    dgvReturnBookSelectBook.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    dgvReturnBookSelectBook.Rows[rowIndex].SetValues(title, qty, "€" + (price - refundAmount), orderID);
                }    
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _customerID = 0;
            grpReturnBookSelectBook.Visible = false;
            txtReturnEmail.Clear();
            txtReturnPassword.Clear();
            dgvReturnBookSelectBook.Rows.Clear();
        }

        private void LoadOrders(string searchTerm)
        {
            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                // retrieve books ordered within 14 days
                string sql = @"SELECT orderedbooks.BookTitle, orderedbooks.QtyOrdered, orderedbooks.OrderPrice, orders.OrderID
                               FROM Orders orders
                               JOIN OrderedBooks orderedbooks ON orders.OrderID = orderedbooks.OrderID
                               WHERE orders.AccountID = :accountID
                               AND UPPER(orderedbooks.BookTitle) LIKE '%' || UPPER(:search) || '%'
                               AND orders.DateOrdered >= SYSDATE - 14";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add("accountID", _customerID);
                cmd.Parameters.Add("search", searchTerm);
                OracleDataReader dr = cmd.ExecuteReader();
                dgvReturnBookSelectBook.Rows.Clear();
                grpReturnBookSelectBook.Visible = true;
                while (dr.Read())
                {
                    dgvReturnBookSelectBook.Rows.Add(dr["BookTitle"].ToString(),
                                                     dr["QtyOrdered"].ToString(),
                                                     "€" + dr["OrderPrice"].ToString(),
                                                     dr["OrderID"].ToString());
                }
                if (dgvReturnBookSelectBook.Rows.Count == 0)
                {
                    MessageBox.Show("No returns/refunds after 14 days.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                dr.Close();
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
