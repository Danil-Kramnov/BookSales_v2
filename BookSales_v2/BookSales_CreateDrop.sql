PROMPT
PROMPT DROPPING All Tables
PROMPT
BEGIN
    FOR t IN (SELECT table_name FROM user_tables) LOOP
        BEGIN
            EXECUTE IMMEDIATE 'DROP TABLE "' || t.table_name || '" CASCADE CONSTRAINTS';
        EXCEPTION
            WHEN OTHERS THEN
                DBMS_OUTPUT.PUT_LINE('Failed to drop table ' || t.table_name || ': ' || SQLERRM);
        END;
    END LOOP;
END;
/

//code taken from here: https://docs.oracle.com/en/database/oracle/oracle-database/19/sqlrf/CREATE-SEQUENCE.html
PROMPT
PROMPT DROPPING Sequences
PROMPT
BEGIN
    FOR s IN (SELECT sequence_name FROM user_sequences) LOOP
        BEGIN
            EXECUTE IMMEDIATE 'DROP SEQUENCE "' || s.sequence_name || '"';
        EXCEPTION
            WHEN OTHERS THEN
                DBMS_OUTPUT.PUT_LINE('Failed to drop sequence ' || s.sequence_name || ': ' || SQLERRM);
        END;
    END LOOP;
END;
/

PROMPT
PROMPT CREATING Table Genres
PROMPT
CREATE TABLE Genres
(GenreCode   CHAR(2),
 Description VARCHAR2(20) NOT NULL,
 CONSTRAINT pk_Genres PRIMARY KEY (GenreCode));

PROMPT
PROMPT CREATING Table Accounts
PROMPT
CREATE TABLE Accounts
(AccountID INT,
 Forename  VARCHAR2(30) NOT NULL,
 Surname   VARCHAR2(30) NOT NULL,
 DOB       DATE         NOT NULL,
 Email     VARCHAR2(30) NOT NULL,
 Password  VARCHAR2(30) NOT NULL,
 Phone     VARCHAR2(10) NOT NULL,
 Street    VARCHAR2(50) NOT NULL,
 Town      VARCHAR2(20) NOT NULL,
 County    VARCHAR2(20) NOT NULL,
 Eircode   VARCHAR2(7)  NOT NULL,
 Status    CHAR(1)      DEFAULT 'A' NOT NULL,
 CONSTRAINT pk_Accounts PRIMARY KEY (AccountID),
 CONSTRAINT uq_Accounts_Email UNIQUE (Email));

PROMPT
PROMPT CREATING Table Books
PROMPT
CREATE TABLE Books
(BookTitle   VARCHAR2(50),
 Author      VARCHAR2(50)  NOT NULL,
 GenreCode   CHAR(2)       NOT NULL,
 Price       DECIMAL(10,2) NOT NULL,
 StockAmount INT           NOT NULL,
 BookStatus  CHAR(1)       DEFAULT 'A' NOT NULL,
 CONSTRAINT pk_Books PRIMARY KEY (BookTitle),
 CONSTRAINT fk_Books_Genres FOREIGN KEY (GenreCode) REFERENCES Genres,
 CONSTRAINT ck_Books_Price CHECK (Price > 0),
 CONSTRAINT ck_Books_Stock CHECK (StockAmount >= 0));

PROMPT
PROMPT CREATING Table Orders
PROMPT
CREATE TABLE Orders
(OrderID     INT,
 AccountID   INT           NOT NULL,
 TotalPrice  DECIMAL(10,2) NOT NULL,
 DateOrdered DATE          NOT NULL,
 CONSTRAINT pk_Orders PRIMARY KEY (OrderID),
 CONSTRAINT fk_Orders_Accounts FOREIGN KEY (AccountID) REFERENCES Accounts,
 CONSTRAINT ck_Orders_Price CHECK (TotalPrice >= 0));

PROMPT
PROMPT CREATING Table OrderedBooks
PROMPT
CREATE TABLE OrderedBooks
(OrderID    INT,
 BookTitle  VARCHAR2(50),
 QtyOrdered INT           NOT NULL,
 OrderPrice DECIMAL(10,2) NOT NULL,
 CONSTRAINT pk_OrderedBooks PRIMARY KEY (OrderID, BookTitle),
 CONSTRAINT fk_OrderedBooks_Orders FOREIGN KEY (OrderID) REFERENCES Orders,
 CONSTRAINT fk_OrderedBooks_Books  FOREIGN KEY (BookTitle) REFERENCES Books,
 CONSTRAINT ck_OrderedBooks_Qty    CHECK (QtyOrdered > 0),
 CONSTRAINT ck_OrderedBooks_Price  CHECK (OrderPrice >= 0));

PROMPT
PROMPT CREATING Table ReturnedBooks
PROMPT
CREATE TABLE ReturnedBooks
(OrderID      INT,
 BookTitle    VARCHAR2(50),
 QtyReturned  INT           NOT NULL,
 RefundAmount DECIMAL(10,2) NOT NULL,
 CONSTRAINT pk_ReturnedBooks PRIMARY KEY (OrderID, BookTitle),
 CONSTRAINT fk_ReturnedBooks_Orders FOREIGN KEY (OrderID) REFERENCES Orders,
 CONSTRAINT fk_ReturnedBooks_Books  FOREIGN KEY (BookTitle) REFERENCES Books,
 CONSTRAINT ck_ReturnedBooks_Qty    CHECK (QtyReturned > 0),
 CONSTRAINT ck_ReturnedBooks_Refund CHECK (RefundAmount >= 0));

PROMPT
PROMPT POPULATING Table Genres
PROMPT
INSERT INTO Genres VALUES('DE', 'Detective');
INSERT INTO Genres VALUES('SF', 'Sci-fi');
INSERT INTO Genres VALUES('HI', 'History');
INSERT INTO Genres VALUES('FA', 'Fantasy');
INSERT INTO Genres VALUES('RO', 'Romance');
INSERT INTO Genres VALUES('PO', 'Poems');
INSERT INTO Genres VALUES('BI', 'Biography');
INSERT INTO Genres VALUES('NF', 'Non-fiction');

PROMPT
PROMPT CREATING Sequences
PROMPT
CREATE SEQUENCE accounts_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE orders_seq   START WITH 1 INCREMENT BY 1;

COMMIT;

PROMPT
PROMPT Database Setup Complete
PROMPT