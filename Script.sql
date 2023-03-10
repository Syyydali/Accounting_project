USE [master]
GO
/****** Object:  Database [Accounting_DB]    Script Date: 15/04/1401 10:14:37 ب.ظ ******/
CREATE DATABASE [Accounting_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Accounting_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Accounting_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Accounting_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Accounting_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Accounting_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Accounting_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Accounting_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Accounting_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Accounting_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Accounting_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Accounting_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Accounting_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Accounting_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Accounting_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Accounting_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Accounting_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Accounting_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Accounting_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Accounting_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Accounting_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Accounting_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Accounting_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Accounting_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Accounting_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Accounting_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Accounting_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Accounting_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Accounting_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Accounting_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [Accounting_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Accounting_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Accounting_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Accounting_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Accounting_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Accounting_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Accounting_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Accounting_DB', N'ON'
GO
ALTER DATABASE [Accounting_DB] SET QUERY_STORE = OFF
GO
USE [Accounting_DB]
GO
/****** Object:  Table [dbo].[Accounting]    Script Date: 15/04/1401 10:14:37 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounting](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Description] [nvarchar](800) NULL,
	[DateTitle] [datetime] NOT NULL,
 CONSTRAINT [PK_Accounting] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountingTypes]    Script Date: 15/04/1401 10:14:37 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountingTypes](
	[TypeID] [int] NOT NULL,
	[TypeTitle] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_AccountingTypes] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 15/04/1401 10:14:37 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](350) NOT NULL,
	[Mobile] [nvarchar](150) NOT NULL,
	[Email] [nvarchar](150) NULL,
	[Address] [nvarchar](500) NULL,
	[CustomerImage] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 15/04/1401 10:14:37 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Accounting]  WITH CHECK ADD  CONSTRAINT [FK_Accounting_AccountingTypes] FOREIGN KEY([TypeID])
REFERENCES [dbo].[AccountingTypes] ([TypeID])
GO
ALTER TABLE [dbo].[Accounting] CHECK CONSTRAINT [FK_Accounting_AccountingTypes]
GO
ALTER TABLE [dbo].[Accounting]  WITH CHECK ADD  CONSTRAINT [FK_Accounting_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Accounting] CHECK CONSTRAINT [FK_Accounting_Customers]
GO
USE [master]
GO
ALTER DATABASE [Accounting_DB] SET  READ_WRITE 
GO
