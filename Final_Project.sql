
CREATE DATABASE DB_Library_Management_Project2;

USE DB_Library_Management_Project2;


CREATE TABLE LIBRARY_BRANCH (
	BranchID INT PRIMARY KEY NOT NULL IDENTITY,
	BranchName VARCHAR(50) NOT NULL,
	Address VARCHAR(50) NOT NULL
);

CREATE TABLE PUBLISHER (
	PublisherName VARCHAR(50) PRIMARY KEY NOT NULL,
	PubAddress VARCHAR(50) NOT NULL,
	Phone VARCHAR(20) NOT NULL
);

CREATE TABLE BOOKS (
	BookID INT PRIMARY KEY NOT NULL IDENTITY(10,1),
	Title VARCHAR(50) NOT NULL,
	PublisherName VARCHAR(50) CONSTRAINT fk_PublisherName FOREIGN KEY REFERENCES PUBLISHER(PublisherName) ON UPDATE CASCADE ON DELETE CASCADE	
);

CREATE TABLE BOOK_AUTHORS (
	BookID INT NOT NULL CONSTRAINT fk_Book_Authors FOREIGN KEY REFERENCES BOOKS(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	AuthorName VARCHAR(50) NOT NULL
);
 SELECT * FROM BOOK_COPIES
CREATE TABLE BOOK_COPIES (
	BookID INT NOT NULL CONSTRAINT fk_Book_Copies FOREIGN KEY REFERENCES BOOKS(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchID INT NOT NULL CONSTRAINT fk_BranchID FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
	Number_OF_Copies INT NOT NULL
);

CREATE TABLE BORROWER (
	CardNo INT PRIMARY KEY NOT NULL IDENTITY(100,1),
	Name VARCHAR(50) NOT NULL,
	Address VARCHAR(50) NOT NULL,
	Phone VARCHAR(20)
); 

CREATE TABLE BOOK_LOANS (
	BookID INT NOT NULL CONSTRAINT fk_Book_Loans FOREIGN KEY REFERENCES BOOKS(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchID INT NOT NULL CONSTRAINT fk_Branch_ID FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
	CardNo INT NOT NULL CONSTRAINT fk_CardNo FOREIGN KEY REFERENCES BORROWER(CardNo) ON UPDATE CASCADE ON DELETE CASCADE,
	DateOut DATE NOT NULL,
	DateDue DATE NOT NULL
);

INSERT INTO LIBRARY_BRANCH
	(BranchName, Address)
	VALUES
	('Sharpstown', '321 Ace Pk' ),
	('Central', '473 New Ln'),
	('Belmont', '210 Fun Dr'),
	('Hollywood', '330 Hal Blvd')
;
SELECT * FROM LIBRARY_BRANCH;

INSERT INTO PUBLISHER
	(PublisherName, PubAddress, Phone)
	VALUES
	('Defender', '111 Grant Rd', '503-231-7834'),
	('Abrams', '224 Ann Dr', '503-574-7788'),
	('Sterling', '853 Head Ave', '503-988-2323'),
	('Chronicle', '901 City Dr', '503-305-221'),
	('Dover', '826 Fort Rd', '971-810-3223')
;
SELECT * FROM PUBLISHER
INSERT INTO BOOKS
	(Title, PublisherName)
	VALUES
	('The War of the Worlds', 'Chronicle'),
	('Odd John', 'Abrams'),
	('When Worlds Collide', 'Dover'),
	('Brave New World', 'Sterling'),
	('The Shinar Directive', 'Defender'),
	('The Unseen Realm', 'Defender'),
	('Falling Free', 'Chronicle'),
	('Mission of Gravity', 'Abrams'),
	('Earth Abides', 'Dover'),
	('Foundation', 'Sterling'),
	('Reversing Hermon', 'Defender'),
	('The Great Inception', 'Defender'),
	('Ring Around The Sun', 'Chronicle'),
	('Starship Troopers', 'Abrams'),
	('Venus', 'Dover'),
	('Alas, Babylon', 'Sterling'),
	('The Facade', 'Defender'),
	('The Portent', 'Defender'),
	('It', 'Chronicle'),
	('The Shining', 'Abrams'),
	('The Lost Tribe', 'Dover'),
	('Lord of the Flies', 'Sterling'),
	('The Sheeriyth Imperative', 'Defender'),
	('Corrupting the Image', 'Defender'),
	('A Clockwork Orange', 'Chronicle'),
	('Less Than Zero', 'Abrams'),
	('Rats Saw God', 'Dover'),
	( 'King Dork', 'Sterling'),
	('The Rotters Club', 'Chronicle'),
	('Goodbye Columbus', 'Abrams'),
	('The Kite Runner', 'Sterling'),
	('Absolute Beginners', 'Dover'),
	('Twelve', 'Sterling'),
	('Catcher In The Rye', 'Chronicle'),
	('Black Swan Green', 'Abrams'),
	('Great Expectations', 'Dover'),
	('Jane Eyre', 'Sterling'),
	('The Outsiders', 'Chronicle'),
	('The Virgin Suicides', 'Abrams'),
	('The Secret History', 'Dover'),
	('Skippy Dies', 'Sterling'),
	('The Rachel Papers', 'Defender')
;
SELECT * FROM BOOK_AUTHORS
INSERT INTO BOOK_AUTHORS
	(BookID, AuthorName)
	VALUES
	(10, 'H.G. Wells'),
	(11, 'Olaf Stapledon'),
	(12, 'Edwin Balmer'),
	(13, 'Aldous Huxley'),
	(14, 'Michael Lake'),
	(15, 'Michael Heiser'),
	(16, 'Lois McMaster Bujoid'),
	(17, 'Hal Clement'),
	(18, 'George R. Stewart'),
	(19, 'Isaac Asimov'),
	(20, 'Michael Heiser'),
	(21, 'Derek Gilbert'),
	(22, 'Clifford D. Simak'),
	(23, 'Robert Heinlein'),
	(24, 'Theodore Sturgeon'),
	(25, 'Pat Frank'),
	(26, 'Michael Heiser'),
	(27, 'Michael Heiser'),
	(28,'Steven King'),
	(29, 'Steven King'),
	(30, 'Mark W. Lee'),
	(31, 'William Golding'),
	(32, 'Michael Lake'),
	(33, 'Douglas Hamp'),
	(34, 'Anthony Burgess'),
	(35, 'Bret Easton Ellis'),
	(36, 'Rob Thomas'),
	(37, 'Frank Portman'),
	(38, 'Jonathon Coe'),
	(39, 'Philip Roth'),
	(40, 'Khalid Hosseini'),
	(41, 'Colin MacInnes'),
	(42, 'Mick McDonell'),
	(43, 'JD Salinger'),
	(44, 'David Mitchell'),
	(45, 'Charles Dickens'),
	(46, 'Charlotte Bronte'),
	(47, 'SE Hinton'),
	(48, 'Jeffery Eugenides'),
	(49, 'Donna Tartt'),
	(50, 'Paul Murray'),
	(51, 'Martin Amis')
;

INSERT INTO BORROWER
	(Name, Address, Phone)
	VALUES
	('Kayla', 'Goober', '503-757-7588')
	('James', '572 Billings Ct', '503-445-5544'),
	('Hank', '865 N Bend Dr', '791-223-0011'),
	('Ben', '334 4th Ave', '971-555-1010'),
	('Ashley', '120 Grant St', '503-686-7979'),
	('Martin', '150 SE Juniper Rd', '503-213-2211'),
	('Debbie', '635 SE Alder Ct', '971-261-3010'),
	('Amir', '1920 16th Ave', '503-283-4039'),
	('Sharron', '928 Foster', '503-102-3838')
;

INSERT INTO BOOK_COPIES
	(BookID, BranchID, Number_OF_Copies)
	VALUES
	(10, 1, 6),
	(11, 1, 4),
	(12, 1, 5),
	(13, 1, 6),
	(14, 1, 4),
	(15, 1, 5),
	(16, 1, 4),
	(17, 1, 3),
	(18, 1, 7),
	(19, 2, 5),
	(20, 2, 5),
	(21, 2, 6),
	(22, 2, 4),
	(23, 2, 7),
	(24, 2, 8),
	(25, 2, 5),
	(26, 2, 4),
	(27, 2, 7),
	(28, 2, 6),
	(29, 2, 5),
	(30, 1, 9),
	(31, 3, 4),
	(32, 3, 7),
	(33, 3, 5),
	(34, 3, 6),
	(35, 3, 4),
	(36, 3, 6),
	(37, 3, 5),
	(38, 3, 4),
	(39, 3, 5),
	(40, 3, 4),
	(41, 4, 6),
	(42, 4, 7),
	(43, 4, 4),
	(44, 4, 8),
	(45, 4, 6),
	(46, 4, 4),
	(47, 4, 9),
	(48, 4, 6),
	(49, 4, 6),
	(50, 4, 4),
	(51, 4, 7)
;

INSERT INTO BOOK_LOANS
	(BookID, BranchID, CardNo, DateOut, DateDue)
	VALUES
	(10, 1, 100, '2019/2/12', '2019/2/20'),
	(11, 1, 100, '2019/2/1', '2019/2/11'),
	(12, 1, 100, '2019/3/4', '2019/3/17'),
	(13, 1, 100, '2019/1/23', '2019/1/29'),
	(14, 1, 100, '2019/2/3', '2019/2/28'),
	(15, 1, 101, '2019/4/10', '2019/4/27'),
	(16, 1, 101, '2019/3/22', '2019/3/26'),
	(17, 1, 101, '2019/3/12', '2019/3/20'),
	(18, 1, 101, '2019/1/10', '2019/1/19'),
	(19, 2, 101, '2019/1/1', '2019/1/12'),
	(20, 2, 102, '2019/9/29', '2019/10/7'),
	(21, 2, 102, '2018/12/13', '2019/1/3'),
	(22, 2, 102, '2019/2/5', '2019/2/13'),
	(23, 2, 102, '2019/3/3', '2019/3/11'),
	(24, 2, 102, '2018/8/24', '2018/8/30'),
	(25, 2, 103, '2018/12/1', '2018/12/11'),
	(26, 2, 103, '2019/1/3', '2019/1/24'),
	(27, 2, 103, '2018/12/21', '2018/12/29'),
	(28, 2, 103, '2019/3/15', '2019/3/22'),
	(29, 3, 103, '2019/4/20', '2019/4/27'),
	(30, 3, 104, '2019/3/18', '2019/3/24'),
	(31, 3, 104, '2019/1/1', '2019/1/8'),
	(32, 3, 104, '2019/2/16', '2019/2/21'),
	(33, 3, 104, '2019/3/2', '2019/3/10'),
	(34, 3, 104, '2019/3/7', '2019/3/15'),
	(35, 3, 105, '2019/2/13', '2019/2/22'),
	(36, 3, 105, '2018/11/23', '2018/11/30'),
	(37, 3, 105, '2019/1/24', '2019/1/30'),
	(38, 3, 105, '2019/2/19', '2019/2/26'),
	(39, 4, 105, '2019/4/11', '2019/4/17'),
	(40, 4, 105, '2019/4/2', '2019/4/10'),
	(41, 4, 106, '2018/10/21', '2018/10/30'),
	(42, 4, 106, '2019/4/18', '2019/4/25'),
	(43, 4, 106, '2019/1/22', '2019/1/30'),
	(44, 4, 106, '2018/12/1', '2018/12/10'),
	(45, 4, 106, '2018/11/14', '2018/11/30'),
	(46, 4, 107, '2019/2/20', '2019/2/28'),
	(47, 4, 107, '2019/4/2', '2019/4/12'),
	(48, 4, 107, '2018/12/22', '2018/12/31'),
	(49, 1, 107, '2019/2/23', '2019/2/27'),
	(50, 2, 107, '2019/3/20', '2019/3/28'),
	(51, 3, 107, '2019/4/10', '2019/3/20'),
	(10, 1, 100, '2018/3/3', '2018/3/11'),
	(11, 1, 100, '2017/1/11', '2017/2/22'),
	(12, 2, 100, '2017/2/13', '2017/2/18'),
	(13, 2, 101, '2016/3/9', '2016/4/8'),
	(14, 3, 101, '2016/5/5', '2016/5/10'),
	(15, 3, 101, '2017/3/9', '2017/3/12'),
	(16, 4, 102, '2015/4/12', '2015/4/18')
;



 /* 1. How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"?*/

	CREATE PROCEDURE NoOfCopies
	AS BEGIN
	SELECT Number_OF_Copies
	FROM BOOKS 
	INNER JOIN BOOK_COPIES ON Books.BookID=BOOK_COPIES.BookID 
	INNER JOIN LIBRARY_BRANCH ON LIBRARY_BRANCH.BranchID=BOOK_COPIES.BranchID
	WHERE Title='The Lost Tribe' AND BranchName='Sharpstown'
	END

	EXEC NoOfCopies;

 /* 2. How many copies of the book titled "The Lost Tribe" are owned by each library branch?*/
 
	CREATE PROCEDURE BranchNameAndNumberOfCopies 
	As BEGIN 
	SELECT BranchName, Number_OF_Copies
	FROM BOOKS 
	INNER JOIN BOOK_COPIES ON Books.BookID=BOOK_COPIES.BookID 
	INNER JOIN LIBRARY_BRANCH on LIBRARY_BRANCH.BranchID=BOOK_COPIES.BranchID
	WHERE Title='The Lost Tribe'
	END

	Exec BranchNameAndNumberOfCopies;

 /* 3. Retrieve the names of all borrowers who do not have any books checked out.*/
 
	CREATE PROCEDURE BorrowerName
	AS
	BEGIN 

	SELECT BORROWER.Name, 
	FROM BORROWER WHERE NOT EXISTS ( SELECT *  FROM BOOK_LOANS 
	WHERE BORROWER.CardNo = BOOK_LOANS.CardNo )
	END;

	EXEC BorrowerName;

 /* 4. For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today,
  retrieve the book title, the borrower's name, and the borrower's address.*/
	

	CREATE PROC GetTitleNameAndAddress22
	AS BEGIN
	SELECT  BOOKS.Title, BORROWER.Name, BORROWER.Address
	FROM LIBRARY_BRANCH
	INNER JOIN BOOK_LOANS ON LIBRARY_BRANCH.BranchID = BOOK_LOANS.BranchID
	INNER JOIN BORROWER ON BORROWER.CardNo = BOOK_LOANS.CardNo
	INNER JOIN BOOKS ON BOOKS.BookID = BOOK_LOANS.BookID
	WHERE BOOK_LOANS.DateDue = '2019/2/20' and LIBRARY_BRANCH. BranchName='Sharpstown' 
	END;

	EXEC  GetTitleNameAndAddress22;
 
 /* 5. For each library branch, retrieve the branch name and the total number of books loaned out from that branch.*/
		 
	CREATE PROCEDURE TotalNumberOfBooksLoaned
	AS BEGIN
	SELECT BranchName, COUNT(*) AS TotalNumberofbooks
	FROM BOOK_LOANS 
	INNER JOIN  LIBRARY_BRANCH ON BOOK_LOANS.BranchId = LIBRARY_BRANCH.BranchId
	GROUP BY BranchName 
	END;

	EXEC  TotalNumberOfBooksLoaned;
 
 /* 6. Retrieve the names, addresses, and the number of books checked out for all borrowers who have more than five books checked out.*/

	

	CREATE PROCEDURE NumberOfBooksBorrows
	AS BEGIN
	SELECT  BORROWER.Name, BORROWER.Address,COUNT(*) AS Numberofbooks
	FROM BORROWER 
	INNER JOIN  BOOK_LOANS ON BORROWER.CardNo = BOOK_LOANS.CardNo
	GROUP BY BORROWER.Name, BORROWER.Address
	HAVING COUNT(*) > 5 
	END;

	EXEC NumberOfBooksBorrows;
 
 /* 7. For each book authored (or co-authored) by "Stephen King", retrieve the title and the number of copies
  owned by the library branch whose name is "Central".*/
	
	CREATE PROCEDURE TitleWithNumberOfCopies1
	AS BEGIN
	SELECT  BOOKS.Title, BOOK_COPIES.Number_OF_Copies, LIBRARY_BRANCH.BranchName
	FROM BOOK_AUTHORS
	INNER JOIN BOOKS ON BOOK_AUTHORS.BookID = BOOKS.BookID
	INNER JOIN BOOK_COPIES ON BOOK_COPIES.BookID = BOOKS.BookID
	INNER JOIN LIBRARY_BRANCH ON LIBRARY_BRANCH.BranchID = BOOK_COPIES.BranchID
	WHERE BOOK_AUTHORS.AuthorName = 'Stephen King' AND LIBRARY_BRANCH.BranchName =  'Central'
	END;

	EXEC TitleWithNumberOfCopies1;
