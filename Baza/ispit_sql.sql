USE [master]
GO
/****** Object:  Database [ispit_sql_cd_dvd]    Script Date: 22.3.2019. 17:55:40 ******/
CREATE DATABASE [ispit_sql_cd_dvd]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ispit_sql_cd_dvd', FILENAME = N'D:\Code\AlgebraCSharp2019-1\Baza\ispit_sql_cd_dvd.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ispit_sql_cd_dvd_log', FILENAME = N'D:\Code\AlgebraCSharp2019-1\Baza\ispit_sql_cd_dvd_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ispit_sql_cd_dvd].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET ARITHABORT OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET  MULTI_USER 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET QUERY_STORE = OFF
GO
USE [ispit_sql_cd_dvd]
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
USE [ispit_sql_cd_dvd]
GO
/****** Object:  Table [dbo].[posudba]    Script Date: 22.3.2019. 17:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posudba](
	[id_prijatelja] [int] NOT NULL,
	[id_medija] [int] NOT NULL,
	[datum_posudbe] [date] NOT NULL,
	[datum_povratka] [date] NULL,
 CONSTRAINT [PK_posudba] PRIMARY KEY CLUSTERED 
(
	[id_prijatelja] ASC,
	[id_medija] ASC,
	[datum_posudbe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prijatelji]    Script Date: 22.3.2019. 17:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prijatelji](
	[id_prijatelja] [int] NOT NULL,
	[ime] [nvarchar](50) NOT NULL,
	[prezime] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_prijatelji] PRIMARY KEY CLUSTERED 
(
	[id_prijatelja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zbirka_cd_i_dvd]    Script Date: 22.3.2019. 17:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zbirka_cd_i_dvd](
	[id_medija] [int] NOT NULL,
	[naziv_medija] [nvarchar](50) NOT NULL,
	[vrsta_medija] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_zbirka_cd_i_dvd] PRIMARY KEY CLUSTERED 
(
	[id_medija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[posudba] ([id_prijatelja], [id_medija], [datum_posudbe], [datum_povratka]) VALUES (1, 1, CAST(N'2019-03-15' AS Date), CAST(N'2019-04-15' AS Date))
INSERT [dbo].[posudba] ([id_prijatelja], [id_medija], [datum_posudbe], [datum_povratka]) VALUES (2, 2, CAST(N'2019-03-01' AS Date), NULL)
INSERT [dbo].[posudba] ([id_prijatelja], [id_medija], [datum_posudbe], [datum_povratka]) VALUES (3, 3, CAST(N'2019-03-20' AS Date), NULL)
INSERT [dbo].[prijatelji] ([id_prijatelja], [ime], [prezime]) VALUES (1, N'Pero', N'Maric')
INSERT [dbo].[prijatelji] ([id_prijatelja], [ime], [prezime]) VALUES (2, N'Mario', N'Peric')
INSERT [dbo].[prijatelji] ([id_prijatelja], [ime], [prezime]) VALUES (3, N'Fata', N'Izbosne')
INSERT [dbo].[zbirka_cd_i_dvd] ([id_medija], [naziv_medija], [vrsta_medija]) VALUES (1, N'Wojko W', N'CD')
INSERT [dbo].[zbirka_cd_i_dvd] ([id_medija], [naziv_medija], [vrsta_medija]) VALUES (2, N'Čudesna Ženka', N'DVD')
INSERT [dbo].[zbirka_cd_i_dvd] ([id_medija], [naziv_medija], [vrsta_medija]) VALUES (3, N'Podvodni Čovjek', N'DVD')
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD  CONSTRAINT [FK_posudba_prijatelji] FOREIGN KEY([id_prijatelja])
REFERENCES [dbo].[prijatelji] ([id_prijatelja])
GO
ALTER TABLE [dbo].[posudba] CHECK CONSTRAINT [FK_posudba_prijatelji]
GO
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD  CONSTRAINT [FK_posudba_zbirka_cd_i_dvd] FOREIGN KEY([id_medija])
REFERENCES [dbo].[zbirka_cd_i_dvd] ([id_medija])
GO
ALTER TABLE [dbo].[posudba] CHECK CONSTRAINT [FK_posudba_zbirka_cd_i_dvd]
GO
USE [master]
GO
ALTER DATABASE [ispit_sql_cd_dvd] SET  READ_WRITE 
GO
