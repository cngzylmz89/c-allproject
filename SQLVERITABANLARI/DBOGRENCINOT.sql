USE [master]
GO
/****** Object:  Database [DbOgrenciNot]    Script Date: 5.06.2025 12:00:23 ******/
CREATE DATABASE [DbOgrenciNot]
 
GO
USE [DbOgrenciNot]
GO
/****** Object:  Table [dbo].[TBLDERSLER]    Script Date: 5.06.2025 12:00:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBLDERSLER](
	[DERSID] [int] NULL,
	[DERSAD] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBLOGRENCILER]    Script Date: 5.06.2025 12:00:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBLOGRENCILER](
	[OGRID] [int] NULL,
	[OGRAD] [varchar](20) NULL,
	[OGRSOYAD] [varchar](20) NULL,
	[OGRCINSIYET] [varchar](5) NULL,
	[OGRKULUP] [varchar](20) NULL,
	[OGRSEHIR] [varchar](13) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [DbOgrenciNot] SET  READ_WRITE 
GO
