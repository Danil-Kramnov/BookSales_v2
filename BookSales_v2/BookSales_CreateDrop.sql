-- Book Sales
-- Author: Danil Kramnov (t-00257323)

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

-- code taken from: https://docs.oracle.com/en/database/oracle/oracle-database/19/sqlrf/CREATE-SEQUENCE.html
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
(GenreCode CHAR(2),
 Description VARCHAR2(20) NOT NULL,
 CONSTRAINT pk_Genres PRIMARY KEY (GenreCode));

PROMPT
PROMPT CREATING Table Accounts
PROMPT
CREATE TABLE Accounts
(AccountID INT,
 Forename VARCHAR2(30) NOT NULL,
 Surname VARCHAR2(30) NOT NULL,
 DOB DATE NOT NULL,
 Email VARCHAR2(30) NOT NULL,
 Password VARCHAR2(30) NOT NULL,
 Phone VARCHAR2(10) NOT NULL,
 Street VARCHAR2(50) NOT NULL,
 Town VARCHAR2(20) NOT NULL,
 County VARCHAR2(20) NOT NULL,
 Eircode VARCHAR2(7) NOT NULL,
 Status CHAR(1) DEFAULT 'A' NOT NULL,
 CONSTRAINT pk_Accounts PRIMARY KEY (AccountID),
 CONSTRAINT uq_Accounts_Email UNIQUE (Email));

PROMPT
PROMPT CREATING Table Books
PROMPT
CREATE TABLE Books
(BookTitle VARCHAR2(50),
 Author VARCHAR2(50) NOT NULL,
 GenreCode CHAR(2) NOT NULL,
 Price DECIMAL(10,2) NOT NULL,
 StockAmount INT NOT NULL,
 BookStatus CHAR(1) DEFAULT 'A' NOT NULL,
 CONSTRAINT pk_Books PRIMARY KEY (BookTitle),
 CONSTRAINT fk_Books_Genres FOREIGN KEY (GenreCode) REFERENCES Genres,
 CONSTRAINT ck_Books_Price CHECK (Price > 0),
 CONSTRAINT ck_Books_Stock CHECK (StockAmount >= 0));

PROMPT
PROMPT CREATING Table Orders
PROMPT
CREATE TABLE Orders
(OrderID INT,
 AccountID INT NOT NULL,
 TotalPrice DECIMAL(10,2) NOT NULL,
 DateOrdered DATE NOT NULL,
 CONSTRAINT pk_Orders PRIMARY KEY (OrderID),
 CONSTRAINT fk_Orders_Accounts FOREIGN KEY (AccountID) REFERENCES Accounts,
 CONSTRAINT ck_Orders_Price CHECK (TotalPrice >= 0));

PROMPT
PROMPT CREATING Table OrderedBooks
PROMPT
CREATE TABLE OrderedBooks
(OrderID INT,
 BookTitle VARCHAR2(50),
 QtyOrdered INT NOT NULL,
 OrderPrice DECIMAL(10,2) NOT NULL,
 CONSTRAINT pk_OrderedBooks PRIMARY KEY (OrderID, BookTitle),
 CONSTRAINT fk_OrderedBooks_Orders FOREIGN KEY (OrderID) REFERENCES Orders,
 CONSTRAINT fk_OrderedBooks_Books FOREIGN KEY (BookTitle) REFERENCES Books,
 CONSTRAINT ck_OrderedBooks_Qty CHECK (QtyOrdered > 0),
 CONSTRAINT ck_OrderedBooks_Price CHECK (OrderPrice >= 0));

PROMPT
PROMPT CREATING Table ReturnedBooks
PROMPT
CREATE TABLE ReturnedBooks
(ReturnID INT,
 OrderID INT NOT NULL,
 BookTitle VARCHAR2(50) NOT NULL,
 QtyReturned INT NOT NULL,
 RefundAmount DECIMAL(10,2) NOT NULL,
 ReturnedDate DATE NOT NULL,
 CONSTRAINT pk_ReturnedBooks PRIMARY KEY (ReturnID),
 CONSTRAINT fk_ReturnedBooks_Orders FOREIGN KEY (OrderID) REFERENCES Orders,
 CONSTRAINT fk_ReturnedBooks_Books FOREIGN KEY (BookTitle) REFERENCES Books,
 CONSTRAINT ck_ReturnedBooks_Qty CHECK (QtyReturned > 0),
 CONSTRAINT ck_ReturnedBooks_Refund CHECK (RefundAmount >= 0));

PROMPT
PROMPT CREATING Sequences
PROMPT
CREATE SEQUENCE accounts_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE orders_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE returns_seq START WITH 1 INCREMENT BY 1;

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
PROMPT POPULATING Table Accounts
PROMPT
INSERT INTO Accounts VALUES(accounts_seq.NEXTVAL,'Jane','Doe',
  TO_DATE('07-11-2006','DD-MM-YYYY'),'jane@email.com','pass',
  '0871234567','Ocean Drive 123','Tralee','Kerry','V12NX34','A');
INSERT INTO Accounts VALUES(accounts_seq.NEXTVAL,'John','Smith',
  TO_DATE('15-03-1990','DD-MM-YYYY'),'john@email.com','Pass1234!',
  '0851234567','Main Street 45','Cork','Cork','T12AB34','A');
INSERT INTO Accounts VALUES(accounts_seq.NEXTVAL,'Mary','Murphy',
  TO_DATE('22-07-1985','DD-MM-YYYY'),'mary@email.com','Pass1234!',
  '0861234567','Church Road 12','Dublin','Dublin','D01CD56','A');
INSERT INTO Accounts VALUES(accounts_seq.NEXTVAL,'Patrick','Ryan',
  TO_DATE('10-05-1995','DD-MM-YYYY'),'patrick@email.com','Pass1234!',
  '0871112233','High Street 78','Galway','Galway','H91EF78','A');
INSERT INTO Accounts VALUES(accounts_seq.NEXTVAL,'Siobhan','O Brien',
  TO_DATE('30-09-1998','DD-MM-YYYY'),'siobhan@email.com','Pass1234!',
  '0831234567','Lake View 5','Limerick','Limerick','V94GH90','A');
INSERT INTO Accounts VALUES(accounts_seq.NEXTVAL,'Liam','Kelly',
  TO_DATE('14-02-1988','DD-MM-YYYY'),'liam@email.com','Pass1234!',
  '0891234567','Park Avenue 33','Waterford','Waterford','X91IJ12','A');
INSERT INTO Accounts VALUES(accounts_seq.NEXTVAL,'Aoife','Walsh',
  TO_DATE('05-11-1992','DD-MM-YYYY'),'aoife@email.com','Pass1234!',
  '0851112233','River Road 19','Kilkenny','Kilkenny','R95KL34','A');
INSERT INTO Accounts VALUES(accounts_seq.NEXTVAL,'Sean','Byrne',
  TO_DATE('28-06-1997','DD-MM-YYYY'),'sean@email.com','Pass1234!',
  '0871223344','Castle Street 7','Sligo','Sligo','F91MN56','A');

PROMPT
PROMPT POPULATING Table Books
PROMPT
INSERT INTO Books VALUES('Running Grave','R. Galbraith','DE',18,97,'A');
INSERT INTO Books VALUES('American Gods','N. Gaiman','FA',12,101,'A');
INSERT INTO Books VALUES('Sapiens','Y. N. Harari','HI',14,55,'A');
INSERT INTO Books VALUES('Project Hail Mary','A. Weir','SF',16,43,'A');
INSERT INTO Books VALUES('Normal People','S. Rooney','RO',11,62,'A');
INSERT INTO Books VALUES('Gone Girl','G. Flynn','DE',13,78,'A');
INSERT INTO Books VALUES('Dune','F. Herbert','SF',15,89,'A');
INSERT INTO Books VALUES('Yellow Face','R.F. Kuang','BI',14,45,'A');
INSERT INTO Books VALUES('Stormlight Archive','B. Sanderson','FA',12,67,'A');
INSERT INTO Books VALUES('Atomic Habits','J. Clear','NF',16,92,'A');

PROMPT
PROMPT POPULATING Table Orders and OrderedBooks
PROMPT
INSERT INTO Orders VALUES(orders_seq.NEXTVAL,1,30,SYSDATE);
INSERT INTO OrderedBooks VALUES(1,'Running Grave',1,18);
INSERT INTO OrderedBooks VALUES(1,'American Gods',1,12);

INSERT INTO Orders VALUES(orders_seq.NEXTVAL,1,14,SYSDATE-5);
INSERT INTO OrderedBooks VALUES(2,'Sapiens',1,14);

INSERT INTO Orders VALUES(orders_seq.NEXTVAL,1,16,SYSDATE-10);
INSERT INTO OrderedBooks VALUES(3,'Project Hail Mary',1,16);

INSERT INTO Orders VALUES(orders_seq.NEXTVAL,1,22,SYSDATE-13);
INSERT INTO OrderedBooks VALUES(4,'Normal People',2,22);

INSERT INTO Orders VALUES(orders_seq.NEXTVAL,2,28,SYSDATE-2);
INSERT INTO OrderedBooks VALUES(5,'Gone Girl',1,13);
INSERT INTO OrderedBooks VALUES(5,'Dune',1,15);

INSERT INTO Orders VALUES(orders_seq.NEXTVAL,3,28,SYSDATE-7);
INSERT INTO OrderedBooks VALUES(6,'Educated',2,28);

INSERT INTO Orders VALUES(orders_seq.NEXTVAL,4,40,SYSDATE-3);
INSERT INTO OrderedBooks VALUES(7,'The Midnight Library',2,24);
INSERT INTO OrderedBooks VALUES(7,'Atomic Habits',1,16);

INSERT INTO Orders VALUES(orders_seq.NEXTVAL,5,31,SYSDATE-15);
INSERT INTO OrderedBooks VALUES(8,'Running Grave',1,18);
INSERT INTO OrderedBooks VALUES(8,'Sapiens',1,13);

INSERT INTO Orders VALUES(orders_seq.NEXTVAL,6,23,SYSDATE-20);
INSERT INTO OrderedBooks VALUES(9,'American Gods',1,12);
INSERT INTO OrderedBooks VALUES(9,'Normal People',1,11);

INSERT INTO Orders VALUES(orders_seq.NEXTVAL,7,15,SYSDATE-30);
INSERT INTO OrderedBooks VALUES(10,'Dune',1,15);

COMMIT;

PROMPT
PROMPT Database Setup Complete
PROMPT