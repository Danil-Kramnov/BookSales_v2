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
        new frmMainMenu Parent { get; set; }
        private int _customerID;
        public frmReturnBook()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgvReturnBookSelectBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReturnCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DBConnection.ApplyStyling(this);
        }
        public frmReturnBook(frmMainMenu parent)
        {
            InitializeComponent();
            this.CenterToScreen();
            dgvReturnBookSelectBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReturnCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                string sql = @"SELECT AccountID, Forename FROM Accounts 
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
                    string forename = dr["Forename"].ToString();
                    lblWelcome.Visible = true;
                    lblWelcome.Text = "Hello, " + forename + "!";
                    dr.Close();
                    conn.Close();
                    grpOrderSearch.Visible = true;
                    grpReturnBookSelectBook.Visible = true;
                    btnLoadCustomer.Visible = false;
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

        }

        private void dgvReturnBookSelectBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int rowIndex = e.RowIndex;
            string title = dgvReturnBookSelectBook.Rows[rowIndex].Cells[0].Value.ToString();
            int qty = int.Parse(dgvReturnBookSelectBook.Rows[rowIndex].Cells[1].Value.ToString());
            decimal price = decimal.Parse(dgvReturnBookSelectBook.Rows[rowIndex].Cells[2].Value.ToString().Substring(1));
            int orderID = int.Parse(dgvReturnBookSelectBook.Rows[rowIndex].Cells[4].Value.ToString());

            // ask how many to return
            // (taken from https://stackoverflow.com/questions/16463599/popup-window-in-winform-c-sharp)
            string prompt = Interaction.InputBox("How many books do you want to return?", "Quantity", "1", -1, -1);

            if (!int.TryParse(prompt, out int result) || result <= 0 || result > qty)
            {
                MessageBox.Show("Please enter a number between 1 and " + qty, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal refundAmount = result * (price / qty);

            // check if already in return cart
            bool found = false;
            for (int i = 0; i < dgvReturnCart.Rows.Count; i++)
            {
                if (dgvReturnCart.Rows[i].Cells[0].Value.ToString() == title && 
                    int.Parse(dgvReturnCart.Rows[i].Cells[3].Value.ToString()) == orderID)
                {
                    int existingQty = int.Parse(dgvReturnCart.Rows[i].Cells[1].Value.ToString());
                    int newQty = existingQty + result;
                    if (newQty > qty)
                    {
                        MessageBox.Show("Cannot return more than ordered quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    decimal newRefund = newQty * (price / qty);
                    dgvReturnCart.Rows[i].SetValues(title, newQty, "€" + newRefund, orderID, "X");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                dgvReturnCart.Rows.Add(title, result, "€" + refundAmount, orderID, "X");
            }
            grpReturnCart.Visible = true;
            UpdateRefundTotal();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _customerID = 0;
            grpOrderSearch.Visible = false;
            grpReturnBookSelectBook.Visible = false;
            grpReturnCart.Visible = false;
            txtReturnEmail.Clear();
            txtReturnPassword.Clear();
            dgvReturnBookSelectBook.Rows.Clear();
            dgvReturnCart.Rows.Clear();
            lblWelcome.Text = "";
            btnLoadCustomer.Visible = true;
        }

        private void LoadOrders(string searchTerm)
        {
            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                // retrieve books ordered within 14 days
                string sql = @"SELECT orderedbooks.BookTitle, orderedbooks.QtyOrdered, 
                                        orderedbooks.OrderPrice, orders.DateOrdered, orders.OrderID
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
                                                     Convert.ToDateTime(dr["DateOrdered"]).ToString("dd-MMM-yy"),
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

        private void UpdateRefundTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgvReturnCart.Rows.Count; i++)
            {
                decimal refund = decimal.Parse(dgvReturnCart.Rows[i].Cells[2].Value.ToString().Substring(1));
                total += refund;
            }
            lblRefundTotal.Text = "Total Refund: €" + total;
        }

        private void dgvReturnCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 4)
            {
                dgvReturnCart.Rows.RemoveAt(e.RowIndex);
                if (dgvReturnCart.Rows.Count == 0)
                {
                    grpReturnCart.Visible = false;
                }
                else
                    UpdateRefundTotal();
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (dgvReturnCart.Rows.Count == 0)
            {
                MessageBox.Show("No books in return cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();

                for (int i = 0; i < dgvReturnCart.Rows.Count; i++)
                {
                    string title = dgvReturnCart.Rows[i].Cells[0].Value.ToString();
                    int qtyReturned = int.Parse(dgvReturnCart.Rows[i].Cells[1].Value.ToString());
                    decimal refund = decimal.Parse(dgvReturnCart.Rows[i].Cells[2].Value.ToString().Substring(1));
                    int orderID = int.Parse(dgvReturnCart.Rows[i].Cells[3].Value.ToString());

                    // insert into ReturnedBooks
                    string retSql = @"INSERT INTO ReturnedBooks(ReturnID, OrderID, BookTitle, QtyReturned, RefundAmount, ReturnedDate)
                                      VALUES(returns_seq.NEXTVAL, :orderID, :title, :qty, :refundAmount, SYSDATE)";
                    OracleCommand retCmd = new OracleCommand(retSql, conn);
                    retCmd.Parameters.Add("orderID", orderID);
                    retCmd.Parameters.Add("title", title);
                    retCmd.Parameters.Add("qty", qtyReturned);
                    retCmd.Parameters.Add("refundAmount", refund);
                    retCmd.ExecuteNonQuery();

                    // restore stock
                    string stockSql = "UPDATE Books SET StockAmount = StockAmount + :qty " +
                                      "WHERE BookTitle = :title";
                    OracleCommand stockCmd = new OracleCommand(stockSql, conn);
                    stockCmd.Parameters.Add("qty", qtyReturned);
                    stockCmd.Parameters.Add("title", title);
                    stockCmd.ExecuteNonQuery();

                    // check current qty from grid to decide delete or update
                    int currentQty = 0;
                    foreach (DataGridViewRow row in dgvReturnBookSelectBook.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == title &&
                            int.Parse(row.Cells[4].Value.ToString()) == orderID)
                        {
                            currentQty = int.Parse(row.Cells[1].Value.ToString());
                            break;
                        }
                    }

                    if (qtyReturned >= currentQty)
                    {
                        // all books returned
                        string deleteObSql = "DELETE FROM OrderedBooks WHERE OrderID=:orderID AND BookTitle=:title";
                        OracleCommand deleteObCmd = new OracleCommand(deleteObSql, conn);
                        deleteObCmd.Parameters.Add("orderID", orderID);
                        deleteObCmd.Parameters.Add("title", title);
                        deleteObCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // partial return
                        string obSql = @"UPDATE OrderedBooks SET QtyOrdered=QtyOrdered-:qty, OrderPrice=OrderPrice-:refundAmount
                                         WHERE OrderID=:orderID AND BookTitle=:title";
                        OracleCommand obCmd = new OracleCommand(obSql, conn);
                        obCmd.Parameters.Add("qty", qtyReturned);
                        obCmd.Parameters.Add("refundAmount", refund);
                        obCmd.Parameters.Add("orderID", orderID);
                        obCmd.Parameters.Add("title", title);
                        obCmd.ExecuteNonQuery();
                    }

                    // reduce order total
                    string orderSql = "UPDATE Orders SET TotalPrice = TotalPrice - :refundAmount " +
                                      "WHERE OrderID = :orderID";
                    OracleCommand orderCmd = new OracleCommand(orderSql, conn);
                    orderCmd.Parameters.Add("refundAmount", refund);
                    orderCmd.Parameters.Add("orderID", orderID);
                    orderCmd.ExecuteNonQuery();
                }

                conn.Close();
                MessageBox.Show("Books Returned Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // reset UI
                grpReturnCart.Visible = false;
                dgvReturnCart.Rows.Clear();
                LoadOrders("");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbOrderHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOrderHidePassword.CheckState == CheckState.Checked)
            {
                txtReturnPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtReturnPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
