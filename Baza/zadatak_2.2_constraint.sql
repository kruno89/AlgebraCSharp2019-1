USE [master]
GO
/****** Object:  Database [constraint_zadatak_2_2]    Script Date: 20.3.2019. 13:55:18 ******/
CREATE DATABASE [constraint_zadatak_2_2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'constraint_zadatak_2_2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\constraint_zadatak_2_2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'constraint_zadatak_2_2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\constraint_zadatak_2_2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [constraint_zadatak_2_2] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [constraint_zadatak_2_2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [constraint_zadatak_2_2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET ARITHABORT OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET  MULTI_USER 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [constraint_zadatak_2_2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [constraint_zadatak_2_2] SET QUERY_STORE = OFF
GO
USE [constraint_zadatak_2_2]
GO
/****** Object:  Table [dbo].[odjeli]    Script Date: 20.3.2019. 13:55:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odjeli](
	[id] [int] NOT NULL,
	[naziv] [nchar](50) NOT NULL,
 CONSTRAINT [PK_odjeli] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[radnici]    Script Date: 20.3.2019. 13:55:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[radnici](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ime] [nchar](50) NOT NULL,
	[prezime] [nchar](50) NOT NULL,
 CONSTRAINT [PK_radnici] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[šefovi]    Script Date: 20.3.2019. 13:55:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[šefovi](
	[id] [int] NOT NULL,
	[odjel] [nchar](50) NOT NULL,
 CONSTRAINT [PK_šefovi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[odjeli] ([id], [naziv]) VALUES (1, N'Odjel za opće poslove                             ')
INSERT [dbo].[odjeli] ([id], [naziv]) VALUES (2, N'Odjel za financije i računovodstvo                ')
INSERT [dbo].[odjeli] ([id], [naziv]) VALUES (3, N'Odjel za kupovinu                                 ')
INSERT [dbo].[odjeli] ([id], [naziv]) VALUES (4, N'Odjel za prodaju                                  ')
INSERT [dbo].[odjeli] ([id], [naziv]) VALUES (5, N'Odjel za energetsku obnovu                        ')
SET IDENTITY_INSERT [dbo].[radnici] ON 

INSERT [dbo].[radnici] ([id], [ime], [prezime]) VALUES (1, N'Armin                                             ', N'Pasal                                             ')
INSERT [dbo].[radnici] ([id], [ime], [prezime]) VALUES (2, N'Ana                                               ', N'Pozga                                             ')
INSERT [dbo].[radnici] ([id], [ime], [prezime]) VALUES (3, N'Gabrijel                                          ', N'Jurko                                             ')
INSERT [dbo].[radnici] ([id], [ime], [prezime]) VALUES (4, N'Saša                                              ', N'Tepp                                              ')
INSERT [dbo].[radnici] ([id], [ime], [prezime]) VALUES (5, N'David                                             ', N'Balli                                             ')
SET IDENTITY_INSERT [dbo].[radnici] OFF
INSERT [dbo].[šefovi] ([id], [odjel]) VALUES (1, N'3                                                 ')
INSERT [dbo].[šefovi] ([id], [odjel]) VALUES (2, N'4                                                 ')
INSERT [dbo].[šefovi] ([id], [odjel]) VALUES (3, N'5                                                 ')
INSERT [dbo].[šefovi] ([id], [odjel]) VALUES (4, N'1                                                 ')
INSERT [dbo].[šefovi] ([id], [odjel]) VALUES (5, N'2                                                 ')
ALTER TABLE [dbo].[odjeli]  WITH CHECK ADD  CONSTRAINT [FK_odjeli_radnici] FOREIGN KEY([id])
REFERENCES [dbo].[radnici] ([id])
GO
ALTER TABLE [dbo].[odjeli] CHECK CONSTRAINT [FK_odjeli_radnici]
GO
ALTER TABLE [dbo].[šefovi]  WITH CHECK ADD  CONSTRAINT [FK_šefovi_odjeli] FOREIGN KEY([id])
REFERENCES [dbo].[odjeli] ([id])
GO
ALTER TABLE [dbo].[šefovi] CHECK CONSTRAINT [FK_šefovi_odjeli]
GO
ALTER TABLE [dbo].[radnici]  WITH CHECK ADD  CONSTRAINT [chk_id] CHECK  (([id]>=(1) AND [id]<=(1000)))
GO
ALTER TABLE [dbo].[radnici] CHECK CONSTRAINT [chk_id]
GO
USE [master]
GO
ALTER DATABASE [constraint_zadatak_2_2] SET  READ_WRITE 
GO
