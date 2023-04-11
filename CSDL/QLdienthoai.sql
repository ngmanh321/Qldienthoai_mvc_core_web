CREATE DATABASE [QLdienthoai]
go
USE [QLdienthoai]
GO
/****** Object:  Table [dbo].[Chitietdonhang]    Script Date: 4/8/2023 3:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitietdonhang](
	[Madon] [int] NOT NULL,
	[Masp] [int] NOT NULL,
	[Soluong] [int] NULL,
	[Dongia] [decimal](18, 0) NULL,
	[Tenkhach] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
	[TenTK] [nvarchar](50) NULL,
	[Tensp] [nvarchar](50) NULL,
 CONSTRAINT [PK_Chitietdonhang_1] PRIMARY KEY CLUSTERED 
(
	[Madon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donhang]    Script Date: 4/8/2023 3:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donhang](
	[Madon] [int] NULL,
	[Masp] [int] NULL,
	[Soluong] [int] NULL,
	[Dongia] [decimal](18, 0) NULL,
	[TenKhach] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
	[Tentk] [nvarchar](50) NULL,
	[Tensp] [nvarchar](50) NULL,
	[Ngaydat] [datetime] NULL,
	[Trangthai] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hangsanxuat]    Script Date: 4/8/2023 3:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hangsanxuat](
	[Mahang] [int] IDENTITY(1,1) NOT NULL,
	[Tenhang] [nchar](10) NULL,
 CONSTRAINT [PK_Hangsanxuat] PRIMARY KEY CLUSTERED 
(
	[Mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hedieuhanh]    Script Date: 4/8/2023 3:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hedieuhanh](
	[Mahdh] [int] IDENTITY(1,1) NOT NULL,
	[Tenhdh] [nchar](10) NULL,
 CONSTRAINT [PK_Hedieuhanh] PRIMARY KEY CLUSTERED 
(
	[Mahdh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manhinh]    Script Date: 4/8/2023 3:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manhinh](
	[Mamanhinh] [nvarchar](50) NOT NULL,
	[Tenmanhinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_Manhinh] PRIMARY KEY CLUSTERED 
(
	[Mamanhinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nguoidung]    Script Date: 4/8/2023 3:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nguoidung](
	[TenTK] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[LoaiTK] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nguoidung] PRIMARY KEY CLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sanpham]    Script Date: 4/8/2023 3:39:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sanpham](
	[Masp] [int] IDENTITY(1,1) NOT NULL,
	[Tensp] [nvarchar](50) NULL,
	[Giatien] [decimal](18, 0) NULL,
	[Soluong] [int] NULL,
	[Mota] [ntext] NULL,
	[Thesim] [int] NULL,
	[Bonhotrong] [int] NULL,
	[Ram] [int] NULL,
	[Anhbia] [nvarchar](10) NULL,
	[Mahang] [int] NULL,
	[Mahdh] [int] NULL,
	[Camera] [nvarchar](50) NULL,
	[Pin] [nvarchar](50) NULL,
	[Chip] [nvarchar](50) NULL,
	[Mamanhinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sanpham] PRIMARY KEY CLUSTERED 
(
	[Masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Chitietdonhang] ([Madon], [Masp], [Soluong], [Dongia], [Tenkhach], [Diachi], [Sdt], [TenTK], [Tensp]) VALUES (168980, 57, 1, CAST(100000 AS Decimal(18, 0)), N'Minh Lan', N'HN_NTL_HTM', N'1234567', N'ngmanh321', N'MayMoi')
GO
INSERT [dbo].[Donhang] ([Madon], [Masp], [Soluong], [Dongia], [TenKhach], [Diachi], [Sdt], [Tentk], [Tensp], [Ngaydat], [Trangthai]) VALUES (603639, 2, 1, CAST(2000000 AS Decimal(18, 0)), N'Minh', N'HN_NTL', N'1234556', N'ngmanh321', N'Apple Iphone 3', NULL, N'Hoan Thanh')
GO
INSERT [dbo].[Donhang] ([Madon], [Masp], [Soluong], [Dongia], [TenKhach], [Diachi], [Sdt], [Tentk], [Tensp], [Ngaydat], [Trangthai]) VALUES (955171, 5, 1, CAST(2000000 AS Decimal(18, 0)), N'Lan Nguyen', N'HN_NTL_HTM', N'12345678', N'ngmanh321', N'Apple Iphone 4', NULL, N'Loi (Huy) Don')
GO
SET IDENTITY_INSERT [dbo].[Hangsanxuat] ON 
GO
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang]) VALUES (1, N'Sam Sung  ')
GO
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang]) VALUES (2, N'Apple     ')
GO
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang]) VALUES (3, N'Xiaomi    ')
GO
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang]) VALUES (4, N'Vsmart    ')
GO
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang]) VALUES (7, N'WinPhone  ')
GO
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang]) VALUES (8, N'MobiStart ')
GO
SET IDENTITY_INSERT [dbo].[Hangsanxuat] OFF
GO
SET IDENTITY_INSERT [dbo].[Hedieuhanh] ON 
GO
INSERT [dbo].[Hedieuhanh] ([Mahdh], [Tenhdh]) VALUES (1, N'Android   ')
GO
INSERT [dbo].[Hedieuhanh] ([Mahdh], [Tenhdh]) VALUES (2, N'IOS       ')
GO
INSERT [dbo].[Hedieuhanh] ([Mahdh], [Tenhdh]) VALUES (3, N'VOS       ')
GO
INSERT [dbo].[Hedieuhanh] ([Mahdh], [Tenhdh]) VALUES (4, N'WinsPhone ')
GO
INSERT [dbo].[Hedieuhanh] ([Mahdh], [Tenhdh]) VALUES (6, N'MacOS     ')
GO
SET IDENTITY_INSERT [dbo].[Hedieuhanh] OFF
GO
INSERT [dbo].[Manhinh] ([Mamanhinh], [Tenmanhinh]) VALUES (N'AMO', N'AMOLED ')
GO
INSERT [dbo].[Manhinh] ([Mamanhinh], [Tenmanhinh]) VALUES (N'CB', N'ClearBlack.')
GO
INSERT [dbo].[Manhinh] ([Mamanhinh], [Tenmanhinh]) VALUES (N'IPS', N'IPS Quantum')
GO
INSERT [dbo].[Manhinh] ([Mamanhinh], [Tenmanhinh]) VALUES (N'LED', N'LED-backlit IPS LCD')
GO
INSERT [dbo].[Manhinh] ([Mamanhinh], [Tenmanhinh]) VALUES (N'SLCD', N'Super LCD')
GO
INSERT [dbo].[Nguoidung] ([TenTK], [MatKhau], [LoaiTK]) VALUES (N'admin', N'ngthu321', N'0')
GO
INSERT [dbo].[Nguoidung] ([TenTK], [MatKhau], [LoaiTK]) VALUES (N'admin2', N'ngthu321', N'0')
GO
INSERT [dbo].[Nguoidung] ([TenTK], [MatKhau], [LoaiTK]) VALUES (N'ngmanh321', N'ngthu321', N'1')
GO
INSERT [dbo].[Nguoidung] ([TenTK], [MatKhau], [LoaiTK]) VALUES (N'ngmanh999', N'ngthu321', N'1')
GO
INSERT [dbo].[Nguoidung] ([TenTK], [MatKhau], [LoaiTK]) VALUES (N'ngthu999', N'ngthu321', N'1')
GO
SET IDENTITY_INSERT [dbo].[Sanpham] ON 
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (2, N'Apple Iphone 3', CAST(2000000 AS Decimal(18, 0)), 6, N'Apple Iphone 3', 1, 8, 8, N'ip3.jpg', 2, 2, N'20MP', N'5000mAh', N'Snapdragon 732', N'AMO')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (5, N'Apple Iphone 4', CAST(2000000 AS Decimal(18, 0)), 9, N'Apple Iphone 4', 1, 8, 1, N'ip4.jpg', 2, 2, N'25MP', N'5000mAh', N'Snapdragon 665 ', N'CB')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (6, N'Apple Iphone 5', CAST(2000000 AS Decimal(18, 0)), 10, N'Apple Iphone 5', 1, 8, 1, N'ip5.jpg', 2, 2, N'20MP', N'5000mAh', N'Snapdragon 665 ', N'IPS')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (7, N'Apple Iphone 6', CAST(2000000 AS Decimal(18, 0)), 2, N'Apple Iphone 6', 1, 8, 1, N'ip6.jpg', 2, 2, N'50MP', N'5000mAh', N'Snapdragon 665 ', N'LED')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (8, N'SamSung GalaxyS1', CAST(1000000 AS Decimal(18, 0)), 1, N'SamSung GalaxyS1', 2, 8, 2, N'ss1.jpg', 1, 1, N'60MP', N'5000mAh', N'Snapdragon 665 ', N'SLCD')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (9, N'SamSung GalaxyS2', CAST(1000000 AS Decimal(18, 0)), 1, N'SamSung GalaxyS2', 1, 8, 1, N'ss2.jpg', 1, 1, N'40MP', N'5000mAh', N'Snapdragon 665 ', N'AMO')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (10, N'SamSung GalaxyS3', CAST(2000000 AS Decimal(18, 0)), 1, N'SamSung GalaxyS3', 1, 8, 2, N'ss3.jpg', 1, 1, N'60MP', N'5000mAh', N'Snapdragon 665 ', N'SLCD')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (11, N'SamSung GalaxyS4', CAST(2000000 AS Decimal(18, 0)), 2, N'SamSung GalaxyS4', 2, 8, 2, N'ss4.jpg', 1, 1, N'20MP', N'5000mAh', N'Snapdragon 665 ', N'IPS')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (13, N'Xiaomi mi4', CAST(200000 AS Decimal(18, 0)), 10, N'Xiaomi mi4', 2, 8, 4, N'mi4.jpg', 3, 1, N'20MP', N'5000mAh', N'Snapdragon 665 ', N'AMO')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (14, N'Xiaomi mi5', CAST(2000000 AS Decimal(18, 0)), 10, N'Xiaomi mi5', 2, 16, 6, N'mi5.jpg', 3, 1, N'20MP', N'5000mAh', N'Snapdragon 665 ', N'AMO')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (15, N'Xiaomi mi6', CAST(20000 AS Decimal(18, 0)), 10, N'Xiaomi mi6', 2, 8, 6, N'mi6.jpg', 3, 1, N'20MP', N'5000mAh', N'Snapdragon 665 ', N'IPS')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (16, N'Xiaomi mi7', CAST(200000 AS Decimal(18, 0)), 10, N'Mi7', 2, 8, 2, N'mi7.jpg', 3, 1, N'20MP', N'5000mAh', N'Snapdragon 665 ', N'SLCD')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (25, N'Vsmart1', CAST(3000000 AS Decimal(18, 0)), 8, N'VS1', 2, 16, 4, N'vs1.jpg', 4, 3, N'20MP', N'5000mAh', N'Snapdragon 665 ', N'LED')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (26, N'Vsmart2', CAST(3600000 AS Decimal(18, 0)), 16, N'VS2', 2, 64, 4, N'vs2.jpg', 4, 3, N'20MP', N'5000mAh', N'Snapdragon 665 ', N'IPS')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (32, N'WinPhone1', CAST(30000000 AS Decimal(18, 0)), 2, N'WinPhone', 2, 64, 3, N'wp1.jpg', 7, 4, N'64MP', N'4500mAh', N'SNAPD 732G', N'IPS')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (33, N'Xiaomi mi1', CAST(200000 AS Decimal(18, 0)), 4, N'XiaoMi 1', 2, 64, 5, N'mi1.jpg', 3, 1, N'64MP', N'4000mAh', N'HeloTeck555', N'LED')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (34, N'Xiaomi mi2', CAST(4100000 AS Decimal(18, 0)), 5, N'Xiaomi mi2', 2, 16, 3, N'mi2.jpg', 3, 1, N'16MP', N'4500mAh', N'Snapdragon 888', N'IPS')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (35, N'Xiaomi mi3', CAST(8000000 AS Decimal(18, 0)), 31, N'Xiaomi mi3', 2, 8, 4, N'mi3.jpg', 3, 1, N'64MP', N'50000mAh', N'Snapdragon 888', N'AMO')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (36, N'Xiaomi mi8', CAST(6500000 AS Decimal(18, 0)), 2, N'Xiaomi mi8', 1, 256, 8, N'mi8.jpg', 3, 1, N'128', N'5500mAh', N'HELLOTECK', N'AMO')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (38, N'MobiiStart1', CAST(3000000 AS Decimal(18, 0)), 6, N'Mbs1', 2, 8, 2, N'mb1.jpg', 8, 1, N'64', N'4200mAh', N'SNAP420', N'CB')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (39, N'MobiiStart2', CAST(2000000 AS Decimal(18, 0)), 3, N'MBs2', 3, 16, 4, N'mb2.jpg', 8, 1, N'32', N'3000mAh', N'SNAP420', N'IPS')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (40, N'MobiiStart3', CAST(2000000 AS Decimal(18, 0)), 3, N'MBs3', 1, 16, 4, N'mb3.jpg', 8, 1, N'32', N'3000mAh', N'SNAP420', N'CB')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (41, N'MobiiStar4t', CAST(2000000 AS Decimal(18, 0)), 3, N'MBs4', 1, 16, 4, N'mb4.jpg', 8, 1, N'32', N'3000mAh', N'SNAP420', N'AMO')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (50, N'MiMax2', CAST(2000000 AS Decimal(18, 0)), 2, N'MiMax2', 2, 64, 3, N'mb4.jpg', 1, 1, N'64MP', N'3000mAh', N'SNAP665', N'AMO')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (55, N'WinPhone1', CAST(30000000 AS Decimal(18, 0)), 2, N'WinPhone', 2, 2, 2, N'wp1.jpg', 4, 1, N'64MP', N'4500mAh', N'SNAP665', N'AMO')
GO
INSERT [dbo].[Sanpham] ([Masp], [Tensp], [Giatien], [Soluong], [Mota], [Thesim], [Bonhotrong], [Ram], [Anhbia], [Mahang], [Mahdh], [Camera], [Pin], [Chip], [Mamanhinh]) VALUES (57, N'MayMoi', CAST(100000 AS Decimal(18, 0)), 0, N'1', 2, 64, 2, N'mac.jpg', 1, 1, N'64MP', N'4000mAh', N'Snapdragon 732', N'AMO')
GO
SET IDENTITY_INSERT [dbo].[Sanpham] OFF
GO
ALTER TABLE [dbo].[Chitietdonhang]  WITH CHECK ADD  CONSTRAINT [FK_Chitietdonhang_Nguoidung] FOREIGN KEY([TenTK])
REFERENCES [dbo].[Nguoidung] ([TenTK])
GO
ALTER TABLE [dbo].[Chitietdonhang] CHECK CONSTRAINT [FK_Chitietdonhang_Nguoidung]
GO
ALTER TABLE [dbo].[Chitietdonhang]  WITH CHECK ADD  CONSTRAINT [FK_Chitietdonhang_Sanpham] FOREIGN KEY([Masp])
REFERENCES [dbo].[Sanpham] ([Masp])
GO
ALTER TABLE [dbo].[Chitietdonhang] CHECK CONSTRAINT [FK_Chitietdonhang_Sanpham]
GO
ALTER TABLE [dbo].[Sanpham]  WITH CHECK ADD  CONSTRAINT [FK_Sanpham_Hangsanxuat] FOREIGN KEY([Mahang])
REFERENCES [dbo].[Hangsanxuat] ([Mahang])
GO
ALTER TABLE [dbo].[Sanpham] CHECK CONSTRAINT [FK_Sanpham_Hangsanxuat]
GO
ALTER TABLE [dbo].[Sanpham]  WITH CHECK ADD  CONSTRAINT [FK_Sanpham_Hedieuhanh] FOREIGN KEY([Mahdh])
REFERENCES [dbo].[Hedieuhanh] ([Mahdh])
GO
ALTER TABLE [dbo].[Sanpham] CHECK CONSTRAINT [FK_Sanpham_Hedieuhanh]
GO
ALTER TABLE [dbo].[Sanpham]  WITH CHECK ADD  CONSTRAINT [FK_Sanpham_Manhinh] FOREIGN KEY([Mamanhinh])
REFERENCES [dbo].[Manhinh] ([Mamanhinh])
GO
ALTER TABLE [dbo].[Sanpham] CHECK CONSTRAINT [FK_Sanpham_Manhinh]
GO
