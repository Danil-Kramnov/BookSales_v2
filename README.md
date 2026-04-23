# BookSalesSys

## Setup
1. Update connection string in `DBConnection.cs` with your Oracle credentials
2. Run `BookSales_CreateDrop.sql` in SQL Developer to create tables and sample data
3. Open `BookSales_v2.sln` in Visual Studio and press F5

## User Flow
Two roles: **Customer** and **Admin** (hardcoded, no DB entry).

**Customers menu**
- Open Account: anyone can register, credentials saved to DB. Automatically navigates to Place Order after registration
- Update Account Details: enter email/password to load and edit your account
- Close Account: button inside Update Account Details, soft delete (status change from Active to Closed)

**Catalogue menu** *(Admin only, enter login and password `admin` to access)*
- Add Book: fill in details to add a new book to DB, existing books displayed in grid
- Update Book Details: search for a book, edit details, save to DB
- Discontinue Book: button inside Update Book Details, soft delete (status change from Available to Discontinued)

**Orders menu** *(Customer only, enter email/password to access)*
- Place Order: search available books, add to cart, buy
- Return Book: view your recent orders (within 14 days), add books to return cart, refund

**Display Analysis menu** *(Admin only, enter login and password `admin` to access)*
- Yearly Revenue: bar chart of total revenue per month for selected year
- Genre Analysis: bar chart of books sold per genre for selected year

## Test Credentials
- Customer: `jane@email.com` / `pass`
- Other customers: `john@email.com`, `mary@email.com`, `patrick@email.com` / `Pass1234!`
- Admin: `admin` / `admin`