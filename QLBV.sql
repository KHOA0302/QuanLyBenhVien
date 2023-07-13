USE [QLBV]
GO
/****** Object:  User [1]    Script Date: 12/07/2023 9:33:53 SA ******/
CREATE USER [1] FOR LOGIN [ADMIN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [4]    Script Date: 12/07/2023 9:33:53 SA ******/
CREATE USER [4] FOR LOGIN [LT] WITH DEFAULT_SCHEMA=[4]
GO
/****** Object:  User [5]    Script Date: 12/07/2023 9:33:53 SA ******/
CREATE USER [5] FOR LOGIN [VHH] WITH DEFAULT_SCHEMA=[5]
GO
/****** Object:  User [System.Data.DataRowView]    Script Date: 12/07/2023 9:33:53 SA ******/
CREATE USER [System.Data.DataRowView] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[System.Data.DataRowView]
GO
/****** Object:  DatabaseRole [ADMIN]    Script Date: 12/07/2023 9:33:53 SA ******/
CREATE ROLE [ADMIN]
GO
/****** Object:  DatabaseRole [BACSI]    Script Date: 12/07/2023 9:33:53 SA ******/
CREATE ROLE [BACSI]
GO
/****** Object:  DatabaseRole [YTA]    Script Date: 12/07/2023 9:33:53 SA ******/
CREATE ROLE [YTA]
GO
ALTER ROLE [ADMIN] ADD MEMBER [1]
GO
ALTER ROLE [db_owner] ADD MEMBER [1]
GO
ALTER ROLE [BACSI] ADD MEMBER [4]
GO
ALTER ROLE [db_datareader] ADD MEMBER [4]
GO
ALTER ROLE [YTA] ADD MEMBER [5]
GO
ALTER ROLE [db_datareader] ADD MEMBER [5]
GO
ALTER ROLE [BACSI] ADD MEMBER [System.Data.DataRowView]
GO
ALTER ROLE [db_datareader] ADD MEMBER [System.Data.DataRowView]
GO
ALTER ROLE [db_owner] ADD MEMBER [ADMIN]
GO
ALTER ROLE [db_datareader] ADD MEMBER [BACSI]
GO
ALTER ROLE [db_datareader] ADD MEMBER [YTA]
GO
/****** Object:  Schema [4]    Script Date: 12/07/2023 9:33:53 SA ******/
CREATE SCHEMA [4]
GO
/****** Object:  Schema [5]    Script Date: 12/07/2023 9:33:53 SA ******/
CREATE SCHEMA [5]
GO
/****** Object:  Schema [System.Data.DataRowView]    Script Date: 12/07/2023 9:33:53 SA ******/
CREATE SCHEMA [System.Data.DataRowView]
GO
/****** Object:  UserDefinedFunction [dbo].[TangMaBN]    Script Date: 12/07/2023 9:33:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TangMaBN]()
RETURNS INT
AS
BEGIN
	DECLARE @MA INT
	SELECT @MA = COUNT(*) + 1 FROM BENHNHAN
	RETURN @MA
END
GO
/****** Object:  UserDefinedFunction [dbo].[TangMaNV]    Script Date: 12/07/2023 9:33:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TangMaNV]()
RETURNS INT
AS
BEGIN
	DECLARE @MA INT
	SELECT @MA = COUNT(*) + 1 FROM NHANVIEN
	RETURN @MA
END

GO
/****** Object:  UserDefinedFunction [dbo].[TinhTienSuDungVatTu]    Script Date: 12/07/2023 9:33:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TinhTienSuDungVatTu](@MAVT nvarchar(10) , @SL int)
RETURNS float
AS
BEGIN
	DECLARE @TONGTIEN float
	SELECT @TONGTIEN = (@SL*DONGIA) FROM VATTU
	WHERE MAVT = @MAVT
	RETURN @TONGTIEN
END
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/07/2023 9:33:53 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] NOT NULL,
	[TEN] [nvarchar](100) NOT NULL,
	[CHUCDANH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_BacSi]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_BacSi]
AS
SELECT MANV, CONCAT(MANV, '-', TEN, '-', CHUCDANH) AS TEN
FROM NHANVIEN
WHERE CHUCDANH = N'Bác Sĩ'
GO
/****** Object:  Table [dbo].[BENHNHAN]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENHNHAN](
	[MABN] [int] NOT NULL,
	[TEN] [nvarchar](100) NOT NULL,
	[NGAYSINH] [datetime] NOT NULL,
	[MABS] [int] NOT NULL,
 CONSTRAINT [PK_BENHNHAN] PRIMARY KEY CLUSTERED 
(
	[MABN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_BenhNhan]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_BenhNhan]
AS
	SELECT MABN, CONCAT(MABN, ' - ', TEN) AS TEN FROM BENHNHAN
GO
/****** Object:  Table [dbo].[DIEUTRI]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEUTRI](
	[MASCT] [int] NOT NULL,
	[MABS] [int] NOT NULL,
	[MABN] [int] NOT NULL,
	[NGAY] [datetime] NOT NULL,
	[THOIGIAN] [time](0) NOT NULL,
	[KETQUA] [text] NOT NULL,
 CONSTRAINT [PK_DIEUTRI] PRIMARY KEY CLUSTERED 
(
	[MASCT] ASC,
	[MABS] ASC,
	[MABN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIUONG]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIUONG](
	[SOGIUONG] [int] NOT NULL,
	[SOPHONG] [int] NOT NULL,
	[MAKHU] [nvarchar](10) NOT NULL,
	[MABN] [int] NULL,
 CONSTRAINT [PK_GIUONG] PRIMARY KEY CLUSTERED 
(
	[SOGIUONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHUCHUATRI]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUCHUATRI](
	[MAKHU] [nvarchar](10) NOT NULL,
	[TENKHU] [nvarchar](50) NOT NULL,
	[MANV] [int] NOT NULL,
 CONSTRAINT [PK_KHUCHUATRI] PRIMARY KEY CLUSTERED 
(
	[MAKHU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LAMVIEC]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAMVIEC](
	[MAKHU] [nvarchar](10) NOT NULL,
	[MANV] [int] NOT NULL,
	[SOGIOLAM] [float] NOT NULL,
 CONSTRAINT [PK_LAMVIEC] PRIMARY KEY CLUSTERED 
(
	[MAKHU] ASC,
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUCHUATRI]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUCHUATRI](
	[SO] [int] NOT NULL,
	[TEN] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SUCHUATRI] PRIMARY KEY CLUSTERED 
(
	[SO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUDUNG]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUDUNG](
	[MABN] [int] NOT NULL,
	[MAVT] [nvarchar](10) NOT NULL,
	[LAN] [int] NOT NULL,
	[NGAY] [datetime] NOT NULL,
	[THOIGIAN] [time](0) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[TONGTIEN] [float] NOT NULL,
 CONSTRAINT [PK_SUDUNG] PRIMARY KEY CLUSTERED 
(
	[MABN] ASC,
	[MAVT] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VATTU]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VATTU](
	[MAVT] [nvarchar](10) NOT NULL,
	[TENVT] [nvarchar](50) NOT NULL,
	[DACTA] [text] NOT NULL,
	[DONGIA] [float] NOT NULL,
 CONSTRAINT [PK_VATTU] PRIMARY KEY CLUSTERED 
(
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[BENHNHAN] ([MABN], [TEN], [NGAYSINH], [MABS]) VALUES (1, N'Hồ Thái', CAST(N'1999-05-11T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[BENHNHAN] ([MABN], [TEN], [NGAYSINH], [MABS]) VALUES (2, N'Văn Ty', CAST(N'2002-05-22T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[BENHNHAN] ([MABN], [TEN], [NGAYSINH], [MABS]) VALUES (3, N'Tiến Nam', CAST(N'2002-03-12T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[BENHNHAN] ([MABN], [TEN], [NGAYSINH], [MABS]) VALUES (4, N'Ngọc Tú', CAST(N'2001-02-09T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[BENHNHAN] ([MABN], [TEN], [NGAYSINH], [MABS]) VALUES (5, N'Chí Khanh', CAST(N'1993-11-05T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[BENHNHAN] ([MABN], [TEN], [NGAYSINH], [MABS]) VALUES (6, N'Hồ Hoàng', CAST(N'2000-06-23T00:00:00.000' AS DateTime), 8)
INSERT [dbo].[BENHNHAN] ([MABN], [TEN], [NGAYSINH], [MABS]) VALUES (7, N'Chí Cường', CAST(N'2005-07-12T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[DIEUTRI] ([MASCT], [MABS], [MABN], [NGAY], [THOIGIAN], [KETQUA]) VALUES (1, 4, 1, CAST(N'2023-06-29T00:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time), N'Tái Khám')
INSERT [dbo].[DIEUTRI] ([MASCT], [MABS], [MABN], [NGAY], [THOIGIAN], [KETQUA]) VALUES (2, 4, 2, CAST(N'2023-07-02T00:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time), N'Tái Khám')
INSERT [dbo].[DIEUTRI] ([MASCT], [MABS], [MABN], [NGAY], [THOIGIAN], [KETQUA]) VALUES (3, 4, 3, CAST(N'2023-07-08T00:00:00.000' AS DateTime), CAST(N'11:00:00' AS Time), N'Tái Khám')
INSERT [dbo].[DIEUTRI] ([MASCT], [MABS], [MABN], [NGAY], [THOIGIAN], [KETQUA]) VALUES (3, 8, 6, CAST(N'2023-07-05T00:00:00.000' AS DateTime), CAST(N'11:00:00' AS Time), N'Chua chu?n doán')
INSERT [dbo].[DIEUTRI] ([MASCT], [MABS], [MABN], [NGAY], [THOIGIAN], [KETQUA]) VALUES (4, 4, 4, CAST(N'2023-07-09T00:00:00.000' AS DateTime), CAST(N'17:00:00' AS Time), N'Không Có Covid-19')
INSERT [dbo].[DIEUTRI] ([MASCT], [MABS], [MABN], [NGAY], [THOIGIAN], [KETQUA]) VALUES (5, 4, 5, CAST(N'2023-07-18T00:00:00.000' AS DateTime), CAST(N'07:30:00' AS Time), N'Hoàn Thành')
GO
INSERT [dbo].[GIUONG] ([SOGIUONG], [SOPHONG], [MAKHU], [MABN]) VALUES (1, 1, N'K01', 1)
INSERT [dbo].[GIUONG] ([SOGIUONG], [SOPHONG], [MAKHU], [MABN]) VALUES (2, 1, N'K01', 5)
INSERT [dbo].[GIUONG] ([SOGIUONG], [SOPHONG], [MAKHU], [MABN]) VALUES (3, 2, N'K01', 4)
INSERT [dbo].[GIUONG] ([SOGIUONG], [SOPHONG], [MAKHU], [MABN]) VALUES (4, 2, N'K01', 2)
INSERT [dbo].[GIUONG] ([SOGIUONG], [SOPHONG], [MAKHU], [MABN]) VALUES (5, 1, N'K02', NULL)
INSERT [dbo].[GIUONG] ([SOGIUONG], [SOPHONG], [MAKHU], [MABN]) VALUES (6, 1, N'K02', NULL)
INSERT [dbo].[GIUONG] ([SOGIUONG], [SOPHONG], [MAKHU], [MABN]) VALUES (7, 2, N'K02', NULL)
INSERT [dbo].[GIUONG] ([SOGIUONG], [SOPHONG], [MAKHU], [MABN]) VALUES (8, 2, N'K02', NULL)
INSERT [dbo].[GIUONG] ([SOGIUONG], [SOPHONG], [MAKHU], [MABN]) VALUES (9, 1, N'K03', NULL)
INSERT [dbo].[GIUONG] ([SOGIUONG], [SOPHONG], [MAKHU], [MABN]) VALUES (10, 1, N'K03', NULL)
GO
INSERT [dbo].[KHUCHUATRI] ([MAKHU], [TENKHU], [MANV]) VALUES (N'K01', N'Khu A1', 5)
INSERT [dbo].[KHUCHUATRI] ([MAKHU], [TENKHU], [MANV]) VALUES (N'K02', N'Khu A2', 6)
INSERT [dbo].[KHUCHUATRI] ([MAKHU], [TENKHU], [MANV]) VALUES (N'K03', N'Khu B1', 7)
GO
INSERT [dbo].[LAMVIEC] ([MAKHU], [MANV], [SOGIOLAM]) VALUES (N'K01', 4, 8)
INSERT [dbo].[LAMVIEC] ([MAKHU], [MANV], [SOGIOLAM]) VALUES (N'K01', 5, 10)
INSERT [dbo].[LAMVIEC] ([MAKHU], [MANV], [SOGIOLAM]) VALUES (N'K02', 4, 10)
INSERT [dbo].[LAMVIEC] ([MAKHU], [MANV], [SOGIOLAM]) VALUES (N'K02', 6, 8)
INSERT [dbo].[LAMVIEC] ([MAKHU], [MANV], [SOGIOLAM]) VALUES (N'K03', 4, 8)
INSERT [dbo].[LAMVIEC] ([MAKHU], [MANV], [SOGIOLAM]) VALUES (N'K03', 7, 10)
INSERT [dbo].[LAMVIEC] ([MAKHU], [MANV], [SOGIOLAM]) VALUES (N'K03', 8, 7)
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [CHUCDANH]) VALUES (1, N'Nguyễn Tiến Ngọc', N'Viện Trưởng')
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [CHUCDANH]) VALUES (2, N'Lê Xuân Trường', N'Viện Trưởng')
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [CHUCDANH]) VALUES (3, N'Trần Ngọc Đăng Khoa', N'Viện Trưởng')
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [CHUCDANH]) VALUES (4, N'Lương Trang', N'Bác Sĩ')
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [CHUCDANH]) VALUES (5, N'Võ Hoài Hân', N'Y Tá')
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [CHUCDANH]) VALUES (6, N'Thu Hoài', N'Y Tá')
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [CHUCDANH]) VALUES (7, N'Nguyễn Hoài Thương', N'Y Tá')
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [CHUCDANH]) VALUES (8, N'Trương Hoàng', N'Bác Sĩ')
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [CHUCDANH]) VALUES (9, N'Lê Vân', N'Y Tá')
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [CHUCDANH]) VALUES (10, N'Lê Vinh', N'Y Tá')
GO
INSERT [dbo].[SUCHUATRI] ([SO], [TEN]) VALUES (1, N'Viêm Gan B')
INSERT [dbo].[SUCHUATRI] ([SO], [TEN]) VALUES (2, N'Viêm Gan A')
INSERT [dbo].[SUCHUATRI] ([SO], [TEN]) VALUES (3, N'Xét nghiệm máu')
INSERT [dbo].[SUCHUATRI] ([SO], [TEN]) VALUES (4, N'Covid-19')
INSERT [dbo].[SUCHUATRI] ([SO], [TEN]) VALUES (5, N'Bó Bột Cánh Tay')
INSERT [dbo].[SUCHUATRI] ([SO], [TEN]) VALUES (6, N'Xét nghiệm ADN')
GO
INSERT [dbo].[SUDUNG] ([MABN], [MAVT], [LAN], [NGAY], [THOIGIAN], [SOLUONG], [TONGTIEN]) VALUES (1, N'VT01', 1, CAST(N'2023-06-26T00:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time), 2, 3000000)
INSERT [dbo].[SUDUNG] ([MABN], [MAVT], [LAN], [NGAY], [THOIGIAN], [SOLUONG], [TONGTIEN]) VALUES (1, N'VT01', 2, CAST(N'2023-06-27T00:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time), 3, 4500000)
INSERT [dbo].[SUDUNG] ([MABN], [MAVT], [LAN], [NGAY], [THOIGIAN], [SOLUONG], [TONGTIEN]) VALUES (2, N'VT02', 1, CAST(N'2023-07-02T00:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time), 2, 470000)
INSERT [dbo].[SUDUNG] ([MABN], [MAVT], [LAN], [NGAY], [THOIGIAN], [SOLUONG], [TONGTIEN]) VALUES (3, N'VT03', 1, CAST(N'2023-07-08T00:00:00.000' AS DateTime), CAST(N'11:00:00' AS Time), 3, 1425000)
INSERT [dbo].[SUDUNG] ([MABN], [MAVT], [LAN], [NGAY], [THOIGIAN], [SOLUONG], [TONGTIEN]) VALUES (4, N'VT04', 1, CAST(N'2023-07-09T00:00:00.000' AS DateTime), CAST(N'17:00:00' AS Time), 1, 35000)
INSERT [dbo].[SUDUNG] ([MABN], [MAVT], [LAN], [NGAY], [THOIGIAN], [SOLUONG], [TONGTIEN]) VALUES (5, N'VT03', 1, CAST(N'2023-07-12T00:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time), 1, 475000)
INSERT [dbo].[SUDUNG] ([MABN], [MAVT], [LAN], [NGAY], [THOIGIAN], [SOLUONG], [TONGTIEN]) VALUES (5, N'VT05', 1, CAST(N'2023-07-18T00:00:00.000' AS DateTime), CAST(N'07:30:00' AS Time), 2, 30000)
INSERT [dbo].[SUDUNG] ([MABN], [MAVT], [LAN], [NGAY], [THOIGIAN], [SOLUONG], [TONGTIEN]) VALUES (6, N'VT05', 1, CAST(N'2023-07-05T00:00:00.000' AS DateTime), CAST(N'10:00:00' AS Time), 7, 105000)
INSERT [dbo].[SUDUNG] ([MABN], [MAVT], [LAN], [NGAY], [THOIGIAN], [SOLUONG], [TONGTIEN]) VALUES (6, N'VT06', 1, CAST(N'2023-07-11T00:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time), 5, 250000)
GO
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DACTA], [DONGIA]) VALUES (N'VT01', N'Peginterferon alfa 2a', N'M?c b?nh nh?', 1500000)
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DACTA], [DONGIA]) VALUES (N'VT02', N'Havax', N'B?nh nhân >1 tu?i', 235000)
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DACTA], [DONGIA]) VALUES (N'VT03', N'Kentamax plus', N'B?nh nhân >10 tu?i', 475000)
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DACTA], [DONGIA]) VALUES (N'VT04', N'Covid-19 Antigen Rapid Test Kit', N'L?y nu?c b?t', 35000)
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DACTA], [DONGIA]) VALUES (N'VT05', N'Bột Bó Thạch Cao', N'C? Ð?nh Xuong Gãy', 15000)
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DACTA], [DONGIA]) VALUES (N'VT06', N'Thuốc Kháng Sinh', N'Dùng cho b?nh nhân trên 5 tu?i', 50000)
GO
ALTER TABLE [dbo].[DIEUTRI]  WITH CHECK ADD  CONSTRAINT [FK_DIEUTRI_BENHNHAN] FOREIGN KEY([MABN])
REFERENCES [dbo].[BENHNHAN] ([MABN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DIEUTRI] CHECK CONSTRAINT [FK_DIEUTRI_BENHNHAN]
GO
ALTER TABLE [dbo].[DIEUTRI]  WITH CHECK ADD  CONSTRAINT [FK_DIEUTRI_NHANVIEN] FOREIGN KEY([MABS])
REFERENCES [dbo].[NHANVIEN] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DIEUTRI] CHECK CONSTRAINT [FK_DIEUTRI_NHANVIEN]
GO
ALTER TABLE [dbo].[DIEUTRI]  WITH CHECK ADD  CONSTRAINT [FK_DIEUTRI_SUCHUATRI] FOREIGN KEY([MASCT])
REFERENCES [dbo].[SUCHUATRI] ([SO])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DIEUTRI] CHECK CONSTRAINT [FK_DIEUTRI_SUCHUATRI]
GO
ALTER TABLE [dbo].[GIUONG]  WITH CHECK ADD  CONSTRAINT [FK_GIUONG_BENHNHAN] FOREIGN KEY([MABN])
REFERENCES [dbo].[BENHNHAN] ([MABN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GIUONG] CHECK CONSTRAINT [FK_GIUONG_BENHNHAN]
GO
ALTER TABLE [dbo].[GIUONG]  WITH CHECK ADD  CONSTRAINT [FK_GIUONG_KHUCHUATRI] FOREIGN KEY([MAKHU])
REFERENCES [dbo].[KHUCHUATRI] ([MAKHU])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GIUONG] CHECK CONSTRAINT [FK_GIUONG_KHUCHUATRI]
GO
ALTER TABLE [dbo].[LAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_LAMVIEC_KHUCHUATRI] FOREIGN KEY([MAKHU])
REFERENCES [dbo].[KHUCHUATRI] ([MAKHU])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LAMVIEC] CHECK CONSTRAINT [FK_LAMVIEC_KHUCHUATRI]
GO
ALTER TABLE [dbo].[LAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_LAMVIEC_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LAMVIEC] CHECK CONSTRAINT [FK_LAMVIEC_NHANVIEN]
GO
ALTER TABLE [dbo].[SUDUNG]  WITH CHECK ADD  CONSTRAINT [FK_SUDUNG_BENHNHAN] FOREIGN KEY([MABN])
REFERENCES [dbo].[BENHNHAN] ([MABN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SUDUNG] CHECK CONSTRAINT [FK_SUDUNG_BENHNHAN]
GO
ALTER TABLE [dbo].[SUDUNG]  WITH CHECK ADD  CONSTRAINT [FK_SUDUNG_VATTU] FOREIGN KEY([MAVT])
REFERENCES [dbo].[VATTU] ([MAVT])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SUDUNG] CHECK CONSTRAINT [FK_SUDUNG_VATTU]
GO
/****** Object:  StoredProcedure [dbo].[SP_BackUp]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BackUp](
	@filepath nvarchar(max))
AS
BEGIN
	BACKUP DATABASE [QLBV]
	TO DISK = @filepath;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BenhNhanChuaNamGiuong]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BenhNhanChuaNamGiuong]
AS
BEGIN
	SELECT MABN, CONCAT(MABN, ' - ', TEN) AS TEN 
	FROM BENHNHAN
	WHERE MABN NOT IN (SELECT MABN FROM GIUONG)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DieuTri]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DieuTri] @MABN NVARCHAR(10)
AS 
BEGIN
	SELECT MANV, BS.TEN, SCT.TEN, NGAY, THOIGIAN, KETQUA FROM
	(SELECT * FROM DIEUTRI WHERE MABN = @MABN) DT,
	(SELECT MANV, TEN FROM NHANVIEN WHERE CHUCDANH = N'Bác Sĩ') BS,
	SUCHUATRI SCT
	WHERE DT.MABS = BS.MANV AND DT.MASCT = SCT.SO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_MABN]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Kiem_Tra_MABN]
@MABN int
AS
BEGIN	
	IF EXISTS(SELECT * FROM BENHNHAN BN  WHERE BN.MABN = @MABN)
		RETURN 1	
	RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_MANV]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Kiem_Tra_MANV]
@MANV int
AS
BEGIN	
	IF EXISTS(SELECT * FROM NHANVIEN NV  WHERE NV.MANV = @MANV)
		RETURN 1	
	RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_MASCT]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Kiem_Tra_MASCT]
@MA int
AS
BEGIN	
	IF EXISTS(SELECT * FROM SUCHUATRI SCT WHERE SCT.SO = @MA)
		RETURN 1	
	RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_MAVT]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Kiem_Tra_MAVT]
@MAVT nvarchar(10)
AS
BEGIN	
	IF EXISTS(SELECT * FROM VATTU VT  WHERE VT.MAVT = @MAVT)
		RETURN 1	
	RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_MKCT]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Kiem_Tra_MKCT]
@MAKHU nvarchar(10)
AS
BEGIN	
	IF EXISTS(SELECT * FROM KHUCHUATRI KHU  WHERE KHU.MAKHU = @MAKHU)
		RETURN 1	
	RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Kiem_Tra_SG]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Kiem_Tra_SG]
@SO int
AS
BEGIN	
	IF EXISTS(SELECT * FROM GIUONG G WHERE G.SOGIUONG = @SO)
		RETURN 1	
	RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_Thong_Tin_NV_Tu_Login]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Lay_Thong_Tin_NV_Tu_Login]
@TENLOGIN NVARCHAR( 100)
AS
DECLARE @UID INT
DECLARE @MANV NVARCHAR(100)
SELECT @UID= uid , @MANV= NAME FROM sys.sysusers 
  WHERE sid = SUSER_SID(@TENLOGIN)

SELECT MANV = @MANV, 
       HOTEN = (SELECT TEN FROM dbo.NHANVIEN WHERE MANV=@MANV ), 
       TENNHOM = NAME
  FROM sys.sysusers
    WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)
GO
/****** Object:  StoredProcedure [dbo].[SP_NhanVienChuaTaoTaiKhoan]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_NhanVienChuaTaoTaiKhoan]
AS
	SELECT MANV, CONCAT(MANV, ' - ', TEN, ' - ', CHUCDANH) as HOTEN
	FROM NHANVIEN 
	WHERE CHUCDANH <> N'Viện Trưởng'
	AND NOT EXISTS( SELECT SUSER_SNAME(sid) 
				FROM sys.sysusers 
				WHERE name = CAST(MANV AS NVARCHAR))
GO
/****** Object:  StoredProcedure [dbo].[SP_NhanVienKhongLaYTaTruong]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_NhanVienKhongLaYTaTruong]
AS
BEGIN
	SELECT MANV, CONCAT(MANV, ' - ', TEN, ' - ', CHUCDANH) AS TEN 
	FROM NHANVIEN
	WHERE MANV NOT IN (SELECT MANV FROM KHUCHUATRI) AND CHUCDANH = N'Y Tá'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SoGioLamNhanVien]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SoGioLamNhanVien]
AS
BEGIN
	SELECT LV.MANV,TEN, CHUCDANH, SUM(SOGIOLAM) AS SOGIOLAM FROM
	(SELECT * FROM NHANVIEN WHERE CHUCDANH <> N'Viện Trưởng') NV, LAMVIEC LV
	WHERE LV.MANV = NV.MANV
	GROUP BY LV.MANV,TEN, CHUCDANH
	ORDER BY LV.MANV, CHUCDANH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SuDungVatTu]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SuDungVatTu] @MABN INT
AS 
BEGIN
	SELECT NGAY, THOIGIAN, TENVT, LAN, SOLUONG, DONGIA, TONGTIEN FROM
	(SELECT * FROM SUDUNG WHERE MABN = @MABN) SD,
	VATTU VT
	WHERE SD.MAVT = VT.MAVT
	ORDER BY NGAY
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Tao_Tai_Khoan]    Script Date: 12/07/2023 9:33:54 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Tao_Tai_Khoan]
    @LGNAME VARCHAR(50),  @PASS VARCHAR(50),
    @USERNAME VARCHAR(50),  @ROLE VARCHAR(50)     
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS, 'QLBV'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
  BEGIN
     RAISERROR ('Login name bị trùng', 16,1)
	 RETURN
  END 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RAISERROR ('Nhân viên đã có login name', 16,2)
       RETURN
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE = 'ADMIN'
  BEGIN
      EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
      --EXEC sp_addsrvrolemember @LGNAME, 'DBCREATOR'
	  --EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  END
GO
