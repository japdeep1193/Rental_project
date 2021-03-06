USE [master]
GO
/****** Object:  Database [Rental_Project]    Script Date: 9/02/2021 5:05:41 AM ******/
CREATE DATABASE [Rental_Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Rental_Project_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Rental_Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Rental_Project_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Rental_Project.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Rental_Project] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Rental_Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Rental_Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Rental_Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Rental_Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Rental_Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Rental_Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [Rental_Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Rental_Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Rental_Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Rental_Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Rental_Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Rental_Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Rental_Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Rental_Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Rental_Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Rental_Project] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Rental_Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Rental_Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Rental_Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Rental_Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Rental_Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Rental_Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Rental_Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Rental_Project] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Rental_Project] SET  MULTI_USER 
GO
ALTER DATABASE [Rental_Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Rental_Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Rental_Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Rental_Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Rental_Project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Rental_Project] SET QUERY_STORE = OFF
GO
USE [Rental_Project]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 9/02/2021 5:05:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CusID] [int] NULL,
	[MovID] [int] NULL,
	[BookingDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 9/02/2021 5:05:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[ratting] [varchar](50) NULL,
	[year] [varchar](50) NULL,
	[cost] [varchar](50) NULL,
	[copies] [varchar](50) NULL,
	[plot] [varchar](50) NULL,
	[genre] [varchar](50) NULL,
 CONSTRAINT [PK_Movie_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/02/2021 5:05:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([ID], [CusID], [MovID], [BookingDate], [ReturnDate]) VALUES (1, 1, 1, N'9/02/2021', N'Issued')
SET IDENTITY_INSERT [dbo].[Booking] OFF
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([ID], [title], [ratting], [year], [cost], [copies], [plot], [genre]) VALUES (1, N'toilet ek prem katha', N'4.6', N'2019', N'5', N'8', N'Hollywood', N'Hollywood')
SET IDENTITY_INSERT [dbo].[Movie] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Name], [Phone], [Address]) VALUES (1, N'jazzy', N'649988995', N'Papatoe')
SET IDENTITY_INSERT [dbo].[Users] OFF
USE [master]
GO
ALTER DATABASE [Rental_Project] SET  READ_WRITE 
GO
