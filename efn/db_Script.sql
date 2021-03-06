USE [master]
GO
/****** Object:  Database [efn_test]    Script Date: 4/21/2020 1:11:30 PM ******/
CREATE DATABASE [efn_test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'efn_test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\efn_test.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'efn_test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\efn_test_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [efn_test] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [efn_test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [efn_test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [efn_test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [efn_test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [efn_test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [efn_test] SET ARITHABORT OFF 
GO
ALTER DATABASE [efn_test] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [efn_test] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [efn_test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [efn_test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [efn_test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [efn_test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [efn_test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [efn_test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [efn_test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [efn_test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [efn_test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [efn_test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [efn_test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [efn_test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [efn_test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [efn_test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [efn_test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [efn_test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [efn_test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [efn_test] SET  MULTI_USER 
GO
ALTER DATABASE [efn_test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [efn_test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [efn_test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [efn_test] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [efn_test]
GO
/****** Object:  Table [dbo].[BuyingTransactions]    Script Date: 4/21/2020 1:11:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyingTransactions](
	[PurchasedTransactionId] [numeric](18, 0) NOT NULL,
	[UserId] [numeric](18, 0) NULL,
	[PurchasedRatePerGram] [decimal](18, 0) NULL,
	[PurchasedDate] [date] NULL,
	[PurchasedQuantity] [decimal](18, 0) NULL,
	[PurchasedPrice] [decimal](18, 0) NULL,
	[PurchasedTax] [decimal](18, 0) NULL,
	[PurchasedTotalPrice] [decimal](18, 0) NULL,
	[ProductId] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[PurchasedTransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 4/21/2020 1:11:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[PricePerGram] [decimal](18, 0) NULL,
	[CreateDate] [date] NULL,
	[UpdateDate] [date] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/21/2020 1:11:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[UsersTotalProductQuantity] [numeric](18, 0) NULL,
	[CreateDate] [date] NULL,
	[UpdateDate] [date] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [efn_test] SET  READ_WRITE 
GO
