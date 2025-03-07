USE [master]
GO
/****** Object:  Database [LibraryManagment]    Script Date: 2/21/2025 9:40:18 PM ******/
CREATE DATABASE [LibraryManagment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryDB', FILENAME = N'C:\Users\NB\Desktop\MSSQL16.MSSQLSERVER\MSSQL\DATA\LibraryManagment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibraryDB_log', FILENAME = N'C:\Users\NB\Desktop\MSSQL16.MSSQLSERVER\MSSQL\DATA\LibraryManagment_0.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LibraryManagment] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryManagment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryManagment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryManagment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryManagment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryManagment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryManagment] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryManagment] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibraryManagment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryManagment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryManagment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryManagment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryManagment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryManagment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryManagment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryManagment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryManagment] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LibraryManagment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryManagment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryManagment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryManagment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryManagment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryManagment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryManagment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryManagment] SET RECOVERY FULL 
GO
ALTER DATABASE [LibraryManagment] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryManagment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryManagment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryManagment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryManagment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LibraryManagment] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LibraryManagment] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LibraryManagment', N'ON'
GO
ALTER DATABASE [LibraryManagment] SET QUERY_STORE = ON
GO
ALTER DATABASE [LibraryManagment] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LibraryManagment]
GO
/****** Object:  User [test]    Script Date: 2/21/2025 9:40:18 PM ******/
CREATE USER [test] FOR LOGIN [test] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Saranda]    Script Date: 2/21/2025 9:40:18 PM ******/
CREATE USER [Saranda] FOR LOGIN [Saranda] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Elvira]    Script Date: 2/21/2025 9:40:18 PM ******/
CREATE USER [Elvira] FOR LOGIN [Elvira] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Elmedina]    Script Date: 2/21/2025 9:40:18 PM ******/
CREATE USER [Elmedina] FOR LOGIN [Elmedina] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Eliona]    Script Date: 2/21/2025 9:40:18 PM ******/
CREATE USER [Eliona] FOR LOGIN [Eliona] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [LibrarianRole]    Script Date: 2/21/2025 9:40:18 PM ******/
CREATE ROLE [LibrarianRole]
GO
/****** Object:  DatabaseRole [AdministratorRole]    Script Date: 2/21/2025 9:40:18 PM ******/
CREATE ROLE [AdministratorRole]
GO
ALTER ROLE [db_owner] ADD MEMBER [test]
GO
ALTER ROLE [db_owner] ADD MEMBER [Saranda]
GO
ALTER ROLE [db_owner] ADD MEMBER [Elvira]
GO
ALTER ROLE [db_owner] ADD MEMBER [Elmedina]
GO
ALTER ROLE [db_owner] ADD MEMBER [Eliona]
GO
/****** Object:  UserDefinedFunction [dbo].[AverageLoansPerClient]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Funksioni për të marrë huazimet mesatare për klient
CREATE FUNCTION [dbo].[AverageLoansPerClient]() 
RETURNS DECIMAL(10,2) 
AS
BEGIN
    DECLARE @avg_loans DECIMAL(10,2);

    SELECT @avg_loans = CAST(COUNT(Loan_ID) AS DECIMAL(10,2)) / COUNT(DISTINCT Client_ID)
    FROM Loan;

    RETURN ISNULL(@avg_loans, 0.00);
END;
GO
/****** Object:  UserDefinedFunction [dbo].[CalculatePenalty]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CalculatePenalty](@loan_id INT) 
RETURNS DECIMAL(10,2) 
AS
BEGIN
    DECLARE @due_date DATE;
    DECLARE @return_date DATE;
    DECLARE @days_late INT;
    DECLARE @penalty DECIMAL(10,2);

    -- Marrim datat nga tabela Loans
    SELECT @due_date = Return_Date, @return_date = Actual_Return_Date
    FROM Loans
    WHERE Loan_ID = @loan_id;

    -- Nëse libri është kthyer me vonesë, llogarit dënimin
    IF @return_date > @due_date
    BEGIN
        SET @days_late = DATEDIFF(DAY, @due_date, @return_date);
        SET @penalty = @days_late * 1.50; -- Supozojmë që dënimi është 1.50 për çdo ditë vonesë
    END
    ELSE
    BEGIN
        SET @penalty = 0.00;
    END

    RETURN @penalty;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetClientBalance]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Funksioni për të marrë balancin e pagesave për klientët
CREATE FUNCTION [dbo].[GetClientBalance](@client_id INT) 
RETURNS DECIMAL(10,2) 
AS
BEGIN
    DECLARE @total_payments DECIMAL(10,2);

    SELECT @total_payments = SUM(Amount)
    FROM Payment
    WHERE Client_ID = @client_id;

    RETURN ISNULL(@total_payments, 0.00);
END;
GO
/****** Object:  UserDefinedFunction [dbo].[MostActiveClient]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Funksioni për të gjetur klientin me më shumë huazime
CREATE FUNCTION [dbo].[MostActiveClient]() 
RETURNS INT 
AS
BEGIN
    DECLARE @top_client INT;

    SELECT TOP 1 @top_client = Client_ID
    FROM Loan
    GROUP BY Client_ID
    ORDER BY COUNT(Loan_ID) DESC;

    RETURN @top_client;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[MostBorrowedBook]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Funksioni për të gjetur librin më të huazuar
CREATE FUNCTION [dbo].[MostBorrowedBook]() 
RETURNS INT 
AS
BEGIN
    DECLARE @top_book INT;

    SELECT TOP 1 @top_book = Material_ID
    FROM Loan
    GROUP BY Material_ID
    ORDER BY COUNT(Loan_ID) DESC;

    RETURN @top_book;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[TotalLateFees]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TotalLateFees]() 
RETURNS DECIMAL(10,2) 
AS
BEGIN
    DECLARE @total_fee DECIMAL(10,2);

    -- Llogarit shumën e të gjitha tarifave të vonesave
    SELECT @total_fee = SUM(Penalty_Fee)
    FROM Loan
    WHERE Penalty_Fee > 0;

    RETURN ISNULL(@total_fee, 0.00);
END;
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Client_ID] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](100) NOT NULL,
	[Last_Name] [nvarchar](100) NOT NULL,
	[Date_of_Birth] [date] NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](255) NOT NULL,
	[Membership_Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Client_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[Payment_ID] [int] IDENTITY(1,1) NOT NULL,
	[Client_ID] [int] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[Payment_Date] [date] NOT NULL,
	[Payment_Type] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Payment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Total_Payments_Details]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Total_Payments_Details] AS
SELECT 
    c.Client_ID,
    c.First_Name,
    c.Last_Name,
    p.Payment_ID,
    p.Amount,
    p.Payment_Date,
    p.Payment_Type
FROM Clients c
LEFT JOIN Payments p ON c.Client_ID = p.Client_ID;
GO
/****** Object:  Table [dbo].[Bibliographic_Materials]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bibliographic_Materials](
	[Material_ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[Author] [nvarchar](255) NOT NULL,
	[Co_Authors] [nvarchar](255) NULL,
	[Publisher] [nvarchar](255) NOT NULL,
	[Publication_Date] [date] NOT NULL,
	[ISBN] [varchar](20) NULL,
	[DOI] [varchar](50) NULL,
	[Material_Type] [nvarchar](50) NOT NULL,
	[Abstract] [text] NULL,
	[Available_Copies] [int] NOT NULL,
	[Date_Added] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Material_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loans]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loans](
	[Loan_ID] [int] IDENTITY(1,1) NOT NULL,
	[Client_ID] [int] NOT NULL,
	[Material_ID] [int] NOT NULL,
	[Loan_Date] [date] NOT NULL,
	[Return_Date] [date] NOT NULL,
	[Actual_Return_Date] [date] NULL,
	[Penalty_Fee] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Loan_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Overdue_Loans]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Overdue_Loans] AS
SELECT
    l.Loan_ID,
    c.First_Name,
    c.Last_Name,
    bm.Title,
    l.Loan_Date,
    l.Return_Date,
    l.Actual_Return_Date,
	DATEDIFF(DAY, l.Return_Date, l.Actual_Return_Date) AS Days_Overdue,
    l.Penalty_Fee
FROM
    Loans l
JOIN 
    Clients c ON l.Client_ID = c.Client_ID
JOIN 
    Bibliographic_Materials bm ON l.Material_ID = bm.Material_ID
WHERE l.Actual_Return_Date > l.Return_Date;
GO
/****** Object:  View [dbo].[Active_Clients]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Active_Clients] AS
SELECT Client_ID, First_Name, Last_Name, Email, Phone, Address
FROM Clients
WHERE Membership_Active = 1;
GO
/****** Object:  View [dbo].[Materials_By_Type]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Materials_By_Type] AS
SELECT Material_Type, COUNT(Material_ID) AS Total_Materials
FROM Bibliographic_Materials
GROUP BY Material_Type;
GO
/****** Object:  View [dbo].[Available_Books]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Available_Books] AS
SELECT Material_ID, Title, Author, Publisher, Available_Copies
FROM Bibliographic_Materials
WHERE Material_Type = 'Book' AND Available_Copies > 0;
GO
/****** Object:  View [dbo].[Client_Loan_History]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Client_Loan_History] AS
SELECT 
    L.Loan_ID,
    C.Client_ID,
    C.First_Name,
    C.Last_Name,
    BM.Title AS Material_Title,
    L.Loan_Date,
    L.Return_Date,
    L.Actual_Return_Date,
    CASE 
        WHEN L.Actual_Return_Date IS NULL THEN 'Not Returned'
        WHEN L.Actual_Return_Date > L.Return_Date THEN 'Returned Late'
        ELSE 'Returned On Time'
    END AS Loan_Status
FROM Loans L
JOIN Clients C ON L.Client_ID = C.Client_ID
JOIN Bibliographic_Materials BM ON L.Material_ID = BM.Material_ID;
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bibliographic_Materials] ON 

INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (1, N'Introduction to Algorithms', N'Thomas H. Cormen', N'Charles E. Leiserson', N'Dukagjini', CAST(N'2025-02-17' AS Date), N'9780262033848', N'10.5555/9780262033848', N'Ebook', N'A comprehensive guide to algorithms.', 5, CAST(N'2025-02-12' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (2, N'Artificial Intelligence: A Modern Approach', N'Stuart Russell', N'Peter Norvig', N'Pearson', CAST(N'2020-04-01' AS Date), N'9780134610993', N'10.5555/9780134610993', N'Book', N'An in-depth introduction to AI.', 0, CAST(N'2025-02-12' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (3, N'Machine Learning Yearning', N'Andrew Ng', NULL, N'Self-Published', CAST(N'2018-05-01' AS Date), NULL, N'10.5555/self-publishedML', N'Ebook', N'Guidelines for machine learning projects.', 6, CAST(N'2025-02-12' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (4, N'Deep Learning', N'Ian Goodfellow', N'Yoshua Bengio, Aaron Courville', N'MIT Press', CAST(N'2016-11-18' AS Date), N'9780262035613', N'10.5555/9780262035613', N'Audio Book', N'A comprehensive textbook on deep learning.', 2, CAST(N'2025-02-12' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (5, N'Database System Concepts', N'Abraham Silberschatz', N'Henry F. Korth, S. Sudarshan', N'McGraw-Hill', CAST(N'2020-01-01' AS Date), N'9781260084504', N'10.5555/9781260084504', N'Book', N'A fundamental database textbook.', 6, CAST(N'2025-02-12' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (6, N'The Pragmatic Programmer', N'Andrew Hunt', N'David Thomas', N'Addison-Wesley', CAST(N'1999-10-20' AS Date), N'9780201616224', N'10.5555/9780201616224', N'Ebook', N'Software development best practices.', 3, CAST(N'2025-02-12' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (7, N'Python Crash Course', N'Eric Matthes', NULL, N'No Starch Press', CAST(N'2019-05-03' AS Date), N'9781593279288', N'10.5555/9781593279288', N'Online Course', N'A hands-on, project-based guide to Python.', 5, CAST(N'2025-02-12' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (8, N'Quantum Computing for Everyone', N'Chris Bernhardt', NULL, N'MIT Press', CAST(N'2019-03-29' AS Date), N'9780262039253', N'10.5555/9780262039253', N'Ebook', N'An accessible introduction to quantum computing.', 4, CAST(N'2025-02-12' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (9, N'Computer Networks', N'Andrew S. Tanenbaum', N'David J. Wetherall', N'Pearson', CAST(N'2010-01-01' AS Date), N'9780132126953', N'10.5555/9780132126953', N'Book', N'A classic computer networking book.', 3, CAST(N'2025-02-12' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (10, N'Design Patterns', N'Erich Gamma', N'Richard Helm, Ralph Johnson, John Vlissides', N'Addison-Wesley', CAST(N'1994-10-21' AS Date), N'9780201633610', N'10.5555/9780201633610', N'Audio Book', N'A foundational text on software design patterns.', 2, CAST(N'2025-02-12' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (11, N'Clean Code', N'Robert C. Martin', NULL, N'Prentice Hall', CAST(N'2008-08-01' AS Date), N'9780132350884', N'10.5555/9780132350884', N'Book', N'A guide to writing clean and maintainable code.', 5, CAST(N'2025-02-15' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (12, N'prilli', N'Ismail Kadare', N'', N'Dukagjini', CAST(N'2025-02-17' AS Date), N'9780262033842', N'10.5555/9780262033841', N'Book', NULL, 3, CAST(N'2025-02-17' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (13, N'prilli', N'db', N'amns', N'jjkn', CAST(N'2025-02-17' AS Date), N'1234567898765432', N'', N'Book', NULL, 6, CAST(N'2025-02-17' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (14, N'esfhb', N'kjsbf', N'jfkjbs', N'shfhb', CAST(N'2025-02-17' AS Date), N'1234567654321', N'42356432', N'Book', NULL, 3, CAST(N'2025-02-17' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (15, N'prill', N'ismail', N'rita', N'dukagjini', CAST(N'2025-02-17' AS Date), N'12345654321', N'454321`', N'Book', NULL, 3, CAST(N'2025-02-17' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (16, N'aaa', N'babab', N'ajaja', N'jashsa', CAST(N'2025-02-18' AS Date), N'234543212345', N'23455432234', N'Book', NULL, 3, CAST(N'2025-02-18' AS Date))
INSERT [dbo].[Bibliographic_Materials] ([Material_ID], [Title], [Author], [Co_Authors], [Publisher], [Publication_Date], [ISBN], [DOI], [Material_Type], [Abstract], [Available_Copies], [Date_Added]) VALUES (17, N'aaaa', N'sss', N'aaaaaaaaaa', N'aaaaaaaaaaaa', CAST(N'2025-02-18' AS Date), N'12345', N'2345', N'Ebook', NULL, 2, CAST(N'2025-02-18' AS Date))
SET IDENTITY_INSERT [dbo].[Bibliographic_Materials] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (1, N'elvira', N'Veseli', CAST(N'2025-02-17' AS Date), N'elvira.veseli12@gmail.com', N'12345654321`', N'asdfghgf', 1)
INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (2, N'Alice', N'Veseli', CAST(N'2025-02-17' AS Date), N'elvira.veseliiii@gmail.com', N'4562345', N'sdfghjg', 1)
INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (3, N'Robert', N'Brown', CAST(N'1978-11-30' AS Date), N'robert.brown@email.com', N'1112223333', N'789 Reading Ave', 1)
INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (4, N'Emily', N'Clark', CAST(N'1995-07-19' AS Date), N'emily.clark@email.com', N'5556667777', N'101 Story Ln', 1)
INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (5, N'David', N'Miller', CAST(N'1982-04-21' AS Date), N'david.miller@email.com', N'8889990000', N'202 Novel St', 1)
INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (6, N'Emma', N'Johnson', CAST(N'1993-02-28' AS Date), N'emma.johnson@email.com', N'1239876543', N'303 Fiction Dr', 1)
INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (7, N'Liam', N'Davis', CAST(N'2000-12-10' AS Date), N'liam.davis@email.com', N'3216549870', N'404 Knowledge Blvd', 1)
INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (8, N'Sophia', N'Martinez', CAST(N'1987-06-05' AS Date), N'sophia.martinez@email.com', N'9871236540', N'505 Research Ct', 1)
INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (9, N'James', N'Wilson', CAST(N'1975-09-25' AS Date), N'james.wilson@email.com', N'4567891230', N'606 Information Pkwy', 1)
INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (10, N'Olivia', N'Taylor', CAST(N'1991-08-12' AS Date), N'olivia.taylor@email.com', N'7894561230', N'707 Library Lane', 1)
INSERT [dbo].[Clients] ([Client_ID], [First_Name], [Last_Name], [Date_of_Birth], [Email], [Phone], [Address], [Membership_Active]) VALUES (11, N'elvira', N'Veseli', CAST(N'2025-02-17' AS Date), N'elvira.veseli12@outlook.com', N'38345678900', N'dbjhbaflahbdc', 1)
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[Loans] ON 

INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (1, 1, 1, CAST(N'2024-11-10' AS Date), CAST(N'2025-03-01' AS Date), CAST(N'2024-11-15' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (2, 2, 2, CAST(N'2024-12-15' AS Date), CAST(N'2025-03-10' AS Date), CAST(N'2024-12-20' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (3, 3, 3, CAST(N'2025-01-20' AS Date), CAST(N'2025-03-15' AS Date), CAST(N'2025-02-20' AS Date), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (4, 4, 4, CAST(N'2025-02-05' AS Date), CAST(N'2025-03-20' AS Date), CAST(N'2025-02-10' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (5, 5, 5, CAST(N'2025-03-01' AS Date), CAST(N'2025-03-25' AS Date), CAST(N'2025-03-05' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (6, 6, 6, CAST(N'2025-04-10' AS Date), CAST(N'2025-03-30' AS Date), CAST(N'2025-04-18' AS Date), CAST(4.75 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (7, 7, 7, CAST(N'2025-05-15' AS Date), CAST(N'2025-04-05' AS Date), CAST(N'2025-05-20' AS Date), CAST(11.25 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (8, 8, 8, CAST(N'2025-06-01' AS Date), CAST(N'2025-04-10' AS Date), CAST(N'2025-06-10' AS Date), CAST(15.25 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (9, 9, 9, CAST(N'2025-07-12' AS Date), CAST(N'2025-04-15' AS Date), CAST(N'2025-07-15' AS Date), CAST(22.75 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (10, 10, 10, CAST(N'2025-08-22' AS Date), CAST(N'2025-04-20' AS Date), CAST(N'2025-08-30' AS Date), CAST(33.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (11, 1, 2, CAST(N'2024-11-15' AS Date), CAST(N'2025-01-15' AS Date), CAST(N'2024-11-20' AS Date), CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (12, 2, 3, CAST(N'2024-12-05' AS Date), CAST(N'2025-02-05' AS Date), CAST(N'2024-12-10' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (13, 3, 4, CAST(N'2025-01-15' AS Date), CAST(N'2025-03-15' AS Date), CAST(N'2025-01-18' AS Date), CAST(1.25 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (14, 4, 5, CAST(N'2025-02-01' AS Date), CAST(N'2025-04-01' AS Date), CAST(N'2025-02-05' AS Date), CAST(3.75 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (15, 5, 6, CAST(N'2025-03-05' AS Date), CAST(N'2025-05-05' AS Date), CAST(N'2025-03-10' AS Date), CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (16, 6, 7, CAST(N'2025-04-10' AS Date), CAST(N'2025-06-10' AS Date), CAST(N'2025-04-15' AS Date), CAST(5.50 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (17, 7, 8, CAST(N'2025-05-01' AS Date), CAST(N'2025-07-01' AS Date), CAST(N'2025-05-10' AS Date), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (18, 8, 9, CAST(N'2025-06-15' AS Date), CAST(N'2025-08-15' AS Date), CAST(N'2025-06-20' AS Date), CAST(6.25 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (19, 9, 10, CAST(N'2025-07-10' AS Date), CAST(N'2025-09-10' AS Date), CAST(N'2025-07-15' AS Date), CAST(7.50 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (20, 10, 1, CAST(N'2025-08-15' AS Date), CAST(N'2025-10-15' AS Date), CAST(N'2025-08-20' AS Date), CAST(8.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (24, 3, 6, CAST(N'2025-02-15' AS Date), CAST(N'2025-04-15' AS Date), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (25, 3, 6, CAST(N'2025-02-15' AS Date), CAST(N'2025-04-15' AS Date), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (26, 1, 2, CAST(N'2025-02-03' AS Date), CAST(N'2025-02-19' AS Date), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (27, 5, 2, CAST(N'2025-02-18' AS Date), CAST(N'2025-02-18' AS Date), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (28, 6, 2, CAST(N'2025-02-18' AS Date), CAST(N'2025-02-18' AS Date), NULL, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (29, 1, 16, CAST(N'2025-02-18' AS Date), CAST(N'2025-02-18' AS Date), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (30, 1, 16, CAST(N'2025-02-18' AS Date), CAST(N'2025-02-18' AS Date), NULL, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Loans] ([Loan_ID], [Client_ID], [Material_ID], [Loan_Date], [Return_Date], [Actual_Return_Date], [Penalty_Fee]) VALUES (31, 5, 5, CAST(N'2025-02-20' AS Date), CAST(N'2025-02-20' AS Date), NULL, CAST(2.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Loans] OFF
GO
SET IDENTITY_INSERT [dbo].[Payments] ON 

INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (1, 1, CAST(2.50 AS Decimal(10, 2)), CAST(N'2025-02-01' AS Date), N'Monthly Subscription')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (2, 2, CAST(5.00 AS Decimal(10, 2)), CAST(N'2025-02-05' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (3, 3, CAST(1.25 AS Decimal(10, 2)), CAST(N'2025-02-10' AS Date), N'Annual Subscription')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (4, 4, CAST(3.75 AS Decimal(10, 2)), CAST(N'2025-02-12' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (5, 5, CAST(2.00 AS Decimal(10, 2)), CAST(N'2025-02-15' AS Date), N'Monthly Subscription')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (6, 6, CAST(4.75 AS Decimal(10, 2)), CAST(N'2025-02-20' AS Date), N'Annual Subscription')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (7, 7, CAST(11.25 AS Decimal(10, 2)), CAST(N'2025-02-22' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (8, 8, CAST(15.25 AS Decimal(10, 2)), CAST(N'2025-02-25' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (9, 9, CAST(22.75 AS Decimal(10, 2)), CAST(N'2025-02-28' AS Date), N'Monthly Subscription')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (10, 10, CAST(33.00 AS Decimal(10, 2)), CAST(N'2025-03-01' AS Date), N'Annual Subscription')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (11, 1, CAST(2.50 AS Decimal(10, 2)), CAST(N'2025-01-10' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (13, 3, CAST(1.25 AS Decimal(10, 2)), CAST(N'2025-01-20' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (14, 4, CAST(3.75 AS Decimal(10, 2)), CAST(N'2025-02-10' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (15, 5, CAST(2.00 AS Decimal(10, 2)), CAST(N'2025-03-05' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (16, 6, CAST(5.50 AS Decimal(10, 2)), CAST(N'2025-04-15' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (17, 7, CAST(4.00 AS Decimal(10, 2)), CAST(N'2025-05-05' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (18, 8, CAST(6.25 AS Decimal(10, 2)), CAST(N'2025-06-01' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (19, 9, CAST(7.50 AS Decimal(10, 2)), CAST(N'2025-07-05' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (20, 10, CAST(8.00 AS Decimal(10, 2)), CAST(N'2025-08-25' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (21, 3, CAST(3.50 AS Decimal(10, 2)), CAST(N'2025-02-21' AS Date), N'Late Return Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (24, 1, CAST(15.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'Monthly Payment')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (25, 1, CAST(12.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'System.Data.DataRowView')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (26, 9, CAST(9.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'System.Data.DataRowView')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (27, 1, CAST(6.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'System.Data.DataRowView')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (28, 1, CAST(4.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'System.Data.DataRowView')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (29, 1, CAST(0.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'System.Data.DataRowView')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (30, 1, CAST(0.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'System.Data.DataRowView')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (31, 1, CAST(0.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'Monthly Payment')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (32, 1, CAST(6.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'System.Data.DataRowView')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (33, 1, CAST(4.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'System.Data.DataRowView')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (34, 1, CAST(3.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'Late Fee')
INSERT [dbo].[Payments] ([Payment_ID], [Client_ID], [Amount], [Payment_Date], [Payment_Type]) VALUES (35, 1, CAST(3.00 AS Decimal(10, 2)), CAST(N'2025-02-18' AS Date), N'Late Fee')
SET IDENTITY_INSERT [dbo].[Payments] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (1, N'admin1', N'AdminPass123', N'Administrator')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (2, N'librarian1', N'LibrarianPass456', N'Librarian')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (3, N'admin2', N'SecurePass789', N'Administrator')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (4, N'librarian2', N'ReadBooks234', N'Librarian')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (5, N'admin3', N'StrongPass321', N'Administrator')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (6, N'librarian3', N'LibraryPass567', N'Librarian')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (7, N'staff1', N'StaffPass789', N'Librarian')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (8, N'staff2', N'StaffPass234', N'Librarian')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (9, N'admin4', N'MasterKey432', N'Administrator')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (10, N'librarian4', N'LibrarianPass123', N'Librarian')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (11, N'Elvira', N'StrongPassword1', N'Administrator')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (12, N'Elmedina', N'StrongPassword1', N'Administrator')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (13, N'Eliona', N'StrongPassword1', N'Librarian')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (14, N'Saranda', N'1234', N'Librarian')
INSERT [dbo].[Users] ([User_ID], [Username], [Password], [Role]) VALUES (15, N'test', N'1234', N'Librarian')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Clients__A9D1053435C88D90]    Script Date: 2/21/2025 9:40:18 PM ******/
ALTER TABLE [dbo].[Clients] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__536C85E437998F71]    Script Date: 2/21/2025 9:40:18 PM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bibliographic_Materials] ADD  DEFAULT (getdate()) FOR [Date_Added]
GO
ALTER TABLE [dbo].[Clients] ADD  DEFAULT ((1)) FOR [Membership_Active]
GO
ALTER TABLE [dbo].[Loans] ADD  DEFAULT (getdate()) FOR [Loan_Date]
GO
ALTER TABLE [dbo].[Loans] ADD  DEFAULT ((0)) FOR [Penalty_Fee]
GO
ALTER TABLE [dbo].[Payments] ADD  DEFAULT (getdate()) FOR [Payment_Date]
GO
ALTER TABLE [dbo].[Loans]  WITH CHECK ADD FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Clients] ([Client_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Loans]  WITH CHECK ADD FOREIGN KEY([Material_ID])
REFERENCES [dbo].[Bibliographic_Materials] ([Material_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Clients] ([Client_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bibliographic_Materials]  WITH CHECK ADD CHECK  (([Available_Copies]>=(0)))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Role]='Librarian' OR [Role]='Administrator'))
GO
/****** Object:  StoredProcedure [dbo].[CalculateLateFee]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedura per llogaritjen e pageses per vonesen
CREATE PROCEDURE [dbo].[CalculateLateFee]
    @Loan_ID INT
AS
BEGIN
    DECLARE @Days_Late INT;
    DECLARE @Fee DECIMAL(10,2);
    
    SELECT @Days_Late = DATEDIFF(DAY, Return_Date, Actual_Return_Date)
    FROM Loans WHERE Loan_ID = @Loan_ID;
    
    IF @Days_Late > 0 
    BEGIN
        SET @Fee = @Days_Late * 1.50; -- 1.50 per dite vonese
        UPDATE Loans SET Penalty_Fee = @Fee WHERE Loan_ID = @Loan_ID;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[GetClientsWithUnpaidFees]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedura per te gjetur klientet me vonesa te papaguara
CREATE PROCEDURE [dbo].[GetClientsWithUnpaidFees]
AS
BEGIN
    SELECT DISTINCT c.Client_ID, c.First_Name, c.Last_Name, SUM(l.Penalty_Fee) AS Total_Fee
    FROM Clients c
    JOIN Loans l ON c.Client_ID = l.Client_ID
    WHERE l.Penalty_Fee > 0
    GROUP BY c.Client_ID, c.First_Name, c.Last_Name;
END
GO
/****** Object:  StoredProcedure [dbo].[GetMaterialByISBN]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedura per te marre materialin sipas ISBN
CREATE PROCEDURE [dbo].[GetMaterialByISBN]
    @ISBN VARCHAR(20)
AS
BEGIN
    SELECT * FROM Materials WHERE ISBN = @ISBN;
END
GO
/****** Object:  StoredProcedure [dbo].[RegisterClient]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedura per regjistrimin e nje klienti te ri
CREATE PROCEDURE [dbo].[RegisterClient]
    @First_Name VARCHAR(50),
    @Last_Name VARCHAR(50),
    @Date_of_Birth DATE,
    @Email VARCHAR(100),
    @Phone VARCHAR(20),
    @Address VARCHAR(255)
AS
BEGIN
    INSERT INTO Clients (First_Name, Last_Name, Date_of_Birth, Email, Phone, Address, Membership_Active)
    VALUES (@First_Name, @Last_Name, @Date_of_Birth, @Email, @Phone, @Address, 1);
END
GO
/****** Object:  StoredProcedure [dbo].[RegisterLoan]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedura per regjistrimin e nje huazimi
CREATE PROCEDURE [dbo].[RegisterLoan]
    @Client_ID INT,
    @Material_ID INT,
    @Loan_Date DATE,
    @Return_Date DATE
AS
BEGIN
    INSERT INTO Loans (Client_ID, Material_ID, Loan_Date, Return_Date, Actual_Return_Date, Penalty_Fee)
    VALUES (@Client_ID, @Material_ID, @Loan_Date, @Return_Date, NULL, 0.00);
    
    UPDATE Materials SET Available_Copies = Available_Copies - 1 WHERE Material_ID = @Material_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateMembershipStatus]    Script Date: 2/21/2025 9:40:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedura per perditesimin e statusit te anetaresise se klientit
CREATE PROCEDURE [dbo].[UpdateMembershipStatus]
    @Client_ID INT,
    @Status INT
AS
BEGIN
    UPDATE Clients SET Membership_Active = @Status WHERE Client_ID = @Client_ID;
END
GO
USE [master]
GO
ALTER DATABASE [LibraryManagment] SET  READ_WRITE 
GO
