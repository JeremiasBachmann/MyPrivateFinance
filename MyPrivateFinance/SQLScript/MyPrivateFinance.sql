USE [master]
GO

/****** Object:  Database [MyPrivateFinance]    Script Date: 26.05.2021 15:20:04 ******/
CREATE DATABASE [MyPrivateFinance]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyPrivateFinance', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyPrivateFinance.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyPrivateFinance_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyPrivateFinance_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyPrivateFinance].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MyPrivateFinance] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET ARITHABORT OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MyPrivateFinance] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MyPrivateFinance] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MyPrivateFinance] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MyPrivateFinance] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET RECOVERY FULL 
GO

ALTER DATABASE [MyPrivateFinance] SET  MULTI_USER 
GO

ALTER DATABASE [MyPrivateFinance] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MyPrivateFinance] SET DB_CHAINING OFF 
GO

ALTER DATABASE [MyPrivateFinance] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [MyPrivateFinance] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [MyPrivateFinance] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [MyPrivateFinance] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [MyPrivateFinance] SET QUERY_STORE = OFF
GO

ALTER DATABASE [MyPrivateFinance] SET  READ_WRITE 
GO

