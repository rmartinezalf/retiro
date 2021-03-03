USE [master]
GO

/****** Object:  Database [cuentas]    Script Date: 2/03/2021 12:56:21 p. m. ******/
IF OBJECT_ID('cuentas','P') IS NOT NULL
BEGIN
   DROP DATABASE [cuentas]
END
GO

/****** Object:  Database [cuentas]    Script Date: 2/03/2021 12:56:21 p. m. ******/
CREATE DATABASE [cuentas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cuentas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER02\MSSQL\DATA\Cuentas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cuentas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER02\MSSQL\DATA\Cuentas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [cuentas] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cuentas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [cuentas] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [cuentas] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [cuentas] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [cuentas] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [cuentas] SET ARITHABORT OFF 
GO

ALTER DATABASE [cuentas] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [cuentas] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [cuentas] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [cuentas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [cuentas] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [cuentas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [cuentas] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [cuentas] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [cuentas] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [cuentas] SET  DISABLE_BROKER 
GO

ALTER DATABASE [cuentas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [cuentas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [cuentas] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [cuentas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [cuentas] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [cuentas] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [cuentas] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [cuentas] SET RECOVERY FULL 
GO

ALTER DATABASE [cuentas] SET  MULTI_USER 
GO

ALTER DATABASE [cuentas] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [cuentas] SET DB_CHAINING OFF 
GO

ALTER DATABASE [cuentas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [cuentas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [cuentas] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [cuentas] SET QUERY_STORE = OFF
GO

USE [cuentas]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [cuentas] SET  READ_WRITE 
GO

