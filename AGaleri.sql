USE [master]
GO
/****** Object:  Database [AGaleri]    Script Date: 26.04.2023 15:21:15 ******/
CREATE DATABASE [AGaleri]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AGaleri', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\AGaleri.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AGaleri_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\AGaleri_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AGaleri] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AGaleri].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AGaleri] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AGaleri] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AGaleri] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AGaleri] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AGaleri] SET ARITHABORT OFF 
GO
ALTER DATABASE [AGaleri] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AGaleri] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AGaleri] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AGaleri] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AGaleri] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AGaleri] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AGaleri] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AGaleri] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AGaleri] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AGaleri] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AGaleri] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AGaleri] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AGaleri] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AGaleri] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AGaleri] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AGaleri] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AGaleri] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AGaleri] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AGaleri] SET  MULTI_USER 
GO
ALTER DATABASE [AGaleri] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AGaleri] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AGaleri] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AGaleri] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AGaleri] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AGaleri] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AGaleri] SET QUERY_STORE = OFF
GO
USE [AGaleri]
GO
/****** Object:  Table [dbo].[Araclar]    Script Date: 26.04.2023 15:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Araclar](
	[AracNo] [int] IDENTITY(1,1) NOT NULL,
	[Fiyat] [int] NULL,
	[Adet] [int] NULL,
	[Marka] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Yıl] [int] NULL,
	[SubeNo] [int] NULL,
	[MüsteriNo] [int] NULL,
 CONSTRAINT [PK_Araclar] PRIMARY KEY CLUSTERED 
(
	[AracNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 26.04.2023 15:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[KullaniciNo] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [varchar](50) NULL,
	[KullaniciSifre] [varchar](50) NULL,
	[Telefon] [int] NULL,
	[Adres] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[SubeNo] [int] NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 26.04.2023 15:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[MusteriNo] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](50) NULL,
	[Telefon] [int] NULL,
	[DTarih] [datetime] NULL,
	[Bakiye] [int] NULL,
	[Adres] [varchar](50) NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[MusteriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subeler]    Script Date: 26.04.2023 15:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subeler](
	[SubeNo] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[CalisanSayisi] [int] NULL,
	[Ciro] [int] NULL,
 CONSTRAINT [PK_Subeler] PRIMARY KEY CLUSTERED 
(
	[SubeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Araclar] ON 

INSERT [dbo].[Araclar] ([AracNo], [Fiyat], [Adet], [Marka], [Model], [Yıl], [SubeNo], [MüsteriNo]) VALUES (1, 200000, 35, N'BMW', N'hgf', 2021, 1, 1)
INSERT [dbo].[Araclar] ([AracNo], [Fiyat], [Adet], [Marka], [Model], [Yıl], [SubeNo], [MüsteriNo]) VALUES (2, 5600000, 40, N'Peugeot', N'301', 2023, 5, 2)
INSERT [dbo].[Araclar] ([AracNo], [Fiyat], [Adet], [Marka], [Model], [Yıl], [SubeNo], [MüsteriNo]) VALUES (3, 850000, 10, N'Fiat', N'Egea', 2014, 3, 4)
INSERT [dbo].[Araclar] ([AracNo], [Fiyat], [Adet], [Marka], [Model], [Yıl], [SubeNo], [MüsteriNo]) VALUES (4, 740000, 5, N'Opel', N'Astra', 2015, 4, 6)
INSERT [dbo].[Araclar] ([AracNo], [Fiyat], [Adet], [Marka], [Model], [Yıl], [SubeNo], [MüsteriNo]) VALUES (7, 5600000, 34, N'togg', N'SUV', 2023, 2, 4)
INSERT [dbo].[Araclar] ([AracNo], [Fiyat], [Adet], [Marka], [Model], [Yıl], [SubeNo], [MüsteriNo]) VALUES (8, 300000, 15, N'Ford', N'Focus', 2019, 6, 2)
SET IDENTITY_INSERT [dbo].[Araclar] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAd], [KullaniciSifre], [Telefon], [Adres], [Mail], [SubeNo]) VALUES (3, N'admin', N'123', 57832, N'beyğolu', N'aleyna@hotmail.com', 1)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAd], [KullaniciSifre], [Telefon], [Adres], [Mail], [SubeNo]) VALUES (4, N'aleyna', N'3423', 3343543, N'şile', N'aa@hotmail.com', 4)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAd], [KullaniciSifre], [Telefon], [Adres], [Mail], [SubeNo]) VALUES (5, N'mustafa', N'678', 556238, N'üsküdar', NULL, 5)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAd], [KullaniciSifre], [Telefon], [Adres], [Mail], [SubeNo]) VALUES (6, N'altan', N'987', 213453, N'sarıyer', N'altan@hotmal.com', 3)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAd], [KullaniciSifre], [Telefon], [Adres], [Mail], [SubeNo]) VALUES (7, N'mihran', N'1234', 32423, N'ümraniye', NULL, 4)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAd], [KullaniciSifre], [Telefon], [Adres], [Mail], [SubeNo]) VALUES (8, N'leylim', N'123', 34215, NULL, NULL, 1)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAd], [KullaniciSifre], [Telefon], [Adres], [Mail], [SubeNo]) VALUES (9, N'füsun', N'123', 21425, NULL, NULL, 2)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAd], [KullaniciSifre], [Telefon], [Adres], [Mail], [SubeNo]) VALUES (10, N'feyyaz', N'1234', 324123, NULL, NULL, 5)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAd], [KullaniciSifre], [Telefon], [Adres], [Mail], [SubeNo]) VALUES (12, N'adm', N'123', 1314, N'şişli', N'aa@gmail.com', 1)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAd], [KullaniciSifre], [Telefon], [Adres], [Mail], [SubeNo]) VALUES (13, N'admin5', N'123', 23423, N'şile', N'aley@hotmail.com', 2)
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([MusteriNo], [AdSoyad], [Telefon], [DTarih], [Bakiye], [Adres]) VALUES (1, N'aleyna arı', 677764783, CAST(N'1980-10-20T00:00:00.000' AS DateTime), 20000000, N'Şişli')
INSERT [dbo].[Musteri] ([MusteriNo], [AdSoyad], [Telefon], [DTarih], [Bakiye], [Adres]) VALUES (2, N'mustafa', 56653282, CAST(N'1990-01-09T00:00:00.000' AS DateTime), 450000, N'Beyoğlu')
INSERT [dbo].[Musteri] ([MusteriNo], [AdSoyad], [Telefon], [DTarih], [Bakiye], [Adres]) VALUES (3, N'elif', 87772327, CAST(N'1983-12-04T00:00:00.000' AS DateTime), 3200000, N'Şile')
INSERT [dbo].[Musteri] ([MusteriNo], [AdSoyad], [Telefon], [DTarih], [Bakiye], [Adres]) VALUES (4, N'aslı', 4554498, CAST(N'1959-04-04T00:00:00.000' AS DateTime), 6500000, N'Sarıyer')
INSERT [dbo].[Musteri] ([MusteriNo], [AdSoyad], [Telefon], [DTarih], [Bakiye], [Adres]) VALUES (6, N'güner', 4324, CAST(N'1949-06-21T00:00:00.000' AS DateTime), 7800000, N'Beykoz')
SET IDENTITY_INSERT [dbo].[Musteri] OFF
GO
SET IDENTITY_INSERT [dbo].[Subeler] ON 

INSERT [dbo].[Subeler] ([SubeNo], [Ad], [CalisanSayisi], [Ciro]) VALUES (1, N'Beyoğlu', 7, 30000000)
INSERT [dbo].[Subeler] ([SubeNo], [Ad], [CalisanSayisi], [Ciro]) VALUES (2, N'Şişli', 10, 4370000)
INSERT [dbo].[Subeler] ([SubeNo], [Ad], [CalisanSayisi], [Ciro]) VALUES (3, N'Sarıyer', 9, 9000000)
INSERT [dbo].[Subeler] ([SubeNo], [Ad], [CalisanSayisi], [Ciro]) VALUES (4, N'Ümraniye', 12, 5600000)
INSERT [dbo].[Subeler] ([SubeNo], [Ad], [CalisanSayisi], [Ciro]) VALUES (5, N'Üsküdar', 6, 2300000)
INSERT [dbo].[Subeler] ([SubeNo], [Ad], [CalisanSayisi], [Ciro]) VALUES (6, N'beykoz', 15, 32524)
SET IDENTITY_INSERT [dbo].[Subeler] OFF
GO
ALTER TABLE [dbo].[Araclar]  WITH CHECK ADD  CONSTRAINT [FK_Araclar_Musteri] FOREIGN KEY([MüsteriNo])
REFERENCES [dbo].[Musteri] ([MusteriNo])
GO
ALTER TABLE [dbo].[Araclar] CHECK CONSTRAINT [FK_Araclar_Musteri]
GO
ALTER TABLE [dbo].[Araclar]  WITH CHECK ADD  CONSTRAINT [FK_Araclar_Subeler] FOREIGN KEY([SubeNo])
REFERENCES [dbo].[Subeler] ([SubeNo])
GO
ALTER TABLE [dbo].[Araclar] CHECK CONSTRAINT [FK_Araclar_Subeler]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Subeler] FOREIGN KEY([SubeNo])
REFERENCES [dbo].[Subeler] ([SubeNo])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Subeler]
GO
/****** Object:  StoredProcedure [dbo].[S1]    Script Date: 26.04.2023 15:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[S1]
as begin
select Ad, Marka, Model, Fiyat,Adet from Subeler s join Araclar a on s.SubeNo=a.SubeNo 
end
GO
/****** Object:  StoredProcedure [dbo].[S2]    Script Date: 26.04.2023 15:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[S2]
as begin
select AdSoyad,Bakiye from Musteri order by Bakiye asc
end
GO
/****** Object:  StoredProcedure [dbo].[S3]    Script Date: 26.04.2023 15:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[S3] 
as begin 
select avg(Ciro) as 'Şubelerin Ciro Ortalaması' from Subeler
end
GO
/****** Object:  StoredProcedure [dbo].[S4]    Script Date: 26.04.2023 15:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[S4]
as begin
select MusteriNo,AdSoyad, Marka, Model, Fiyat from Araclar a join Musteri m on a.MüsteriNo= m.MusteriNo order by AdSoyad asc
end
GO
/****** Object:  StoredProcedure [dbo].[S5]    Script Date: 26.04.2023 15:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[S5]
as begin
select SubeNo,Ad,AdSoyad, MusteriNo, Bakiye from Subeler join Musteri on Subeler.Ad = Musteri.Adres order by SubeNo asc
end
GO
USE [master]
GO
ALTER DATABASE [AGaleri] SET  READ_WRITE 
GO
