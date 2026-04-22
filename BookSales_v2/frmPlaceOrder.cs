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
using Microsoft.VisualBasic;
using Oracle.ManagedDataAccess.Client;

namespace BookSalesSys
{
    public partial class frmPlaceOrder : Form
    {
        frmMainMenu Parent;

        private int _customerID;
       
        public frmPlaceOrder()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgvPlaceOrderSelectBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlaceOrderCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DBConnection.ApplyStyling(this);
        }
        public frmPlaceOrder(frmMainMenu parent)
        {
            InitializeComponent();
            this.CenterToScreen();
            dgvPlaceOrderSelectBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlaceOrderCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Parent = parent;
            DBConnection.ApplyStyling(this);

        }

        public frmPlaceOrder(frmMainMenu parent, string email, string password)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Parent = parent;
            txtOrderEmail.Text = email;
            txtOrderPassword.Text = password;
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


        private void dgvPlaceOrderSelectBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Pops up window to ask about how many of this book you want to order
            // (taken from https://stackoverflow.com/questions/16463599/popup-window-in-winform-c-sharp)
            string prompt = Interaction.InputBox("How many books you want to order?", "Quantity", "1", -1, -1);

            if (int.TryParse(prompt, out int numericPrompt) && numericPrompt > 0)
            {
                int rowIndex = e.RowIndex;
                string title = dgvPlaceOrderSelectBook.Rows[rowIndex].Cells[0].Value.ToString();
                string author = dgvPlaceOrderSelectBook.Rows[rowIndex].Cells[1].Value.ToString();
                string price = dgvPlaceOrderSelectBook.Rows[rowIndex].Cells[2].Value.ToString();

                // validate quantity against stock
                int stock = int.Parse(dgvPlaceOrderSelectBook.Rows[rowIndex].Cells[3].Value.ToString());
                if (numericPrompt > stock)
                {
                    MessageBox.Show("Insufficient stock. Only " + stock + " available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // check if book already in cart
                bool found = false;
                for (int i = 0; i < dgvPlaceOrderCart.Rows.Count; i++)
                {
                    if (dgvPlaceOrderCart.Rows[i].Cells[0].Value.ToString() == title)
                    {
                        // book already in cart
                        int existingQty = int.Parse(dgvPlaceOrderCart.Rows[i].Cells[3].Value.ToString());
                        int newQty = existingQty + numericPrompt;
                        if (newQty > stock)
                        {
                            MessageBox.Show("Insufficient stock. Only " + stock + " available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        dgvPlaceOrderCart.Rows[i].SetValues(title, author, price, newQty, "X");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    dgvPlaceOrderCart.Rows.Add(title, author, price, numericPrompt, "X");
                }
                grpPlaceOrderCart.Visible = true;
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Please enter a positive whole number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPlaceOrderBuy_Click(object sender, EventArgs e)
        {
            // transaction basics: https://medium.com/bytehide/transactions-in-dotnet-b469826575a0
            OracleConnection conn = DBConnection.GetConnection();
            OracleTransaction transaction = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // get next OrderID and insert into Orders
                string getID = "SELECT orders_seq.NEXTVAL FROM dual"; // needed OrderID before inserting OrderedBooks rows: https://docs.oracle.com/en/database/oracle/oracle-database/19/sqlrf/Selecting-from-the-DUAL-Table.html
                OracleCommand idCmd = new OracleCommand(getID, conn);
                int orderID = Convert.ToInt32(idCmd.ExecuteScalar()); // needed one value from the query: https://learn.microsoft.com/en-us/dotnet/api/system.data.oracleclient.oraclecommand.executescalar?view=netframework-4.8.1

                if (dgvPlaceOrderCart.Rows.Count == 0)
                {
                    MessageBox.Show("Cart is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal totalPrice = decimal.Parse(lblTotalPrice.Text.Substring(9));

                string orderSql = @"INSERT INTO Orders (OrderID, AccountID, TotalPrice, DateOrdered)
                                    VALUES(:orderID, :accountID, :totalPrice, SYSDATE)";
                OracleCommand orderCmd = new OracleCommand(orderSql, conn);
                orderCmd.Parameters.Add("orderID", orderID);
                orderCmd.Parameters.Add("accountID", _customerID);
                orderCmd.Parameters.Add("totalPrice", totalPrice);
                orderCmd.ExecuteNonQuery();

                // for each cart item insert OrderedBooks + reduce stock
                for (int i = 0; i < dgvPlaceOrderCart.Rows.Count; i++)
                {
                    string title = dgvPlaceOrderCart.Rows[i].Cells[0].Value.ToString();
                    decimal price = decimal.Parse(dgvPlaceOrderCart.Rows[i].Cells[2].Value.ToString().Substring(1));
                    int qty = int.Parse(dgvPlaceOrderCart.Rows[i].Cells[3].Value.ToString());

                    string obSql = @"INSERT INTO OrderedBooks (OrderID, BookTitle, QtyOrdered, OrderPrice)
                                     VALUES(:orderID, :title, :qty, :price)";
                    OracleCommand orderedbooksCmd = new OracleCommand(obSql, conn);
                    orderedbooksCmd.Parameters.Add("orderID", orderID);
                    orderedbooksCmd.Parameters.Add("title", title);
                    orderedbooksCmd.Parameters.Add("qty", qty);
                    orderedbooksCmd.Parameters.Add("price", price * qty);
                    orderedbooksCmd.ExecuteNonQuery();

                    // reduce stock
                    string stockSql = @"UPDATE Books SET StockAmount = StockAmount - :qty
                                        WHERE BookTitle = :title";
                    OracleCommand stockCmd = new OracleCommand(stockSql, conn);
                    stockCmd.Parameters.Add("qty", qty);
                    stockCmd.Parameters.Add("title", title);
                    stockCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Thank you for your order!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // reset UI
                grpPlaceOrderCart.Visible = false;

                dgvPlaceOrderCart.Rows.Clear();

                LoadBooks("");
            }
            catch (Exception ex)
            {
                transaction?.Rollback(); // fix null reference exception: https://stackoverflow.com/questions/4660142/what-is-a-nullreferenceexception-and-how-do-i-fix-it
                MessageBox.Show("Order failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvPlaceOrderCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // On cell click with X remove books from the cart
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            string title;
            string author;
            decimal price;


            if (colIndex == 4)
            {
                string prompt = Interaction.InputBox("How many books you want to remove?", "Quantity", "1", -1, -1);
                int.TryParse(dgvPlaceOrderCart.Rows[rowIndex].Cells[3].Value.ToString(), out int qty);

                if (!int.TryParse(prompt, out int numericPrompt) || numericPrompt <= 0 || numericPrompt > qty)
                {
                    MessageBox.Show("Please enter a number between 1 and " + qty, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    qty -= numericPrompt;

                    if (qty <= 0)
                    {
                        dgvPlaceOrderCart.Rows.RemoveAt(rowIndex);
                        if (dgvPlaceOrderCart.Rows.Count == 0)
                            grpPlaceOrderCart.Visible = false;
                    }
                    else
                    {
                        title = dgvPlaceOrderCart.Rows[rowIndex].Cells[0].Value.ToString();
                        author = dgvPlaceOrderCart.Rows[rowIndex].Cells[1].Value.ToString();
                        price = decimal.Parse(dgvPlaceOrderCart.Rows[rowIndex].Cells[2].Value.ToString().Substring(1));
                        dgvPlaceOrderCart.Rows[rowIndex].SetValues(title, author, "€" + price, qty);
                    }
                    UpdateTotal();
                }
            }
        }

        

        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderEmail.Text) || string.IsNullOrWhiteSpace(txtOrderPassword.Text))
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
                cmd.Parameters.Add("email", txtOrderEmail.Text);
                cmd.Parameters.Add("pwd", txtOrderPassword.Text);
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
                    LoadBooks("");
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
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooks(string search)
        {
            try
            {
                OracleConnection conn = DBConnection.GetConnection();
                conn.Open();
                // retrieve active books matching search
                string sql = @"SELECT BookTitle, Author, Price, StockAmount 
                               FROM Books WHERE UPPER(BookTitle) LIKE '%' || UPPER(:search) || '%'
                               AND BookStatus='A'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add("search", search);
                OracleDataReader dr = cmd.ExecuteReader();
                grpPlaceOrderSelectBook.Visible = true;
                dgvPlaceOrderSelectBook.Rows.Clear();
                while (dr.Read())
                {
                    dgvPlaceOrderSelectBook.Rows.Add(dr["BookTitle"].ToString(),
                                                     dr["Author"].ToString(),
                                                     "€" + dr["Price"].ToString(),
                                                     dr["StockAmount"].ToString());
                }
                    
                dr.Close();
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _customerID = 0;
            grpOrderSearch.Visible = false;
            grpPlaceOrderSelectBook.Visible = false;
            grpPlaceOrderCart.Visible = false;

            txtOrderEmail.Clear();
            txtOrderPassword.Clear();
            dgvPlaceOrderCart.Rows.Clear();

            lblWelcome.Text = "";

            lblTotalPrice.Text = "Total: €0.00";
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderSearch.Text))
            {
                LoadBooks("");
                return;
            }
            LoadBooks(txtOrderSearch.Text);
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgvPlaceOrderCart.Rows.Count; i++)
            {
                decimal price = decimal.Parse(dgvPlaceOrderCart.Rows[i].Cells[2].Value.ToString().Substring(1));
                int qty = int.Parse(dgvPlaceOrderCart.Rows[i].Cells[3].Value.ToString());
                total += price * qty;
            }
            lblTotalPrice.Text = "Total: €" + total;
        }

    }
}
