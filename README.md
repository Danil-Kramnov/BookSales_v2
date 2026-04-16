Setup

1. Update connection string in DBConnection.cs with your Oracle credentials
2. Run Booksales_CreateDrop.sql in SQL Developer to create tables and sample data
3. Open BookSales_v2.sln in Visual Studio and press F5

User Flow:

Two roles: Customer and Admin (hardcoded, no DB entry).

Customers menu:

Open Account: anyone can register, credentials saved to DB
Update Account Details: enter email/password to load and edit your account
Close Account: button inside Update Account Details, soft delete (status change from Active to Closed)

Catalogue menu (Admin only, enter password admin to access)

Add Book: fill in details to add a new book to DB
Update Book Details: search for a book, edit details, save to DB
Discontinue Book: button inside Update Book Details, soft delete (status chnge from Available to Discontinued)

Orders menu (Customer only, enter email/password to access)

Place Order: search available books, add to cart, checkout
Return Book: view your orders, return a book within 14 days

Display Analysis menu (Admin only, enter password admin to access)

Yearly Revenue: bar chart of total revenue per month for selected year
Genre Analysis: bar chart of books sold per genre for selected year


Test Credentials:

Customer: jane@email.com/pass
Admin: admin/admin (not implemented)

Done and working:

Open Account (Customers menu)
Update Account Details + Close Account button (Customers menu)

Not Done:

Catalogue, Orders, Display Analysis: UI is in place but not connected to db