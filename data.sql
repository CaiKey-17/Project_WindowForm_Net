USE [master]
GO
/****** Object:  Database [Net]    Script Date: 5/10/2024 3:27:23 PM ******/
CREATE DATABASE [Net]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Net', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Net.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Net_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Net_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Net] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Net].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Net] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Net] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Net] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Net] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Net] SET ARITHABORT OFF 
GO
ALTER DATABASE [Net] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Net] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Net] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Net] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Net] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Net] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Net] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Net] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Net] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Net] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Net] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Net] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Net] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Net] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Net] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Net] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Net] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Net] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Net] SET  MULTI_USER 
GO
ALTER DATABASE [Net] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Net] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Net] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Net] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Net] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Net] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Net] SET QUERY_STORE = ON
GO
ALTER DATABASE [Net] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Net]
GO
/****** Object:  Table [dbo].[calam]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calam](
	[ca] [int] NOT NULL,
	[giobatdau] [varchar](10) NULL,
	[gioketthuc] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[ten] [nvarchar](10) NOT NULL,
	[ma] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[sdt] [varchar](10) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[email] [varchar](50) NULL,
	[ngaydangki] [date] NULL,
	[id] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[sdt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kho]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kho](
	[ten] [nvarchar](50) NOT NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
	[hansudung] [date] NULL,
	[ghichu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lich]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lich](
	[ngay] [date] NOT NULL,
	[ca] [int] NOT NULL,
	[id] [varchar](10) NOT NULL,
	[diemdanh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ngay] ASC,
	[ca] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[luong]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[luong](
	[ma] [varchar](10) NOT NULL,
	[tien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[maytinh]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[maytinh](
	[ma] [varchar](10) NOT NULL,
	[soluong] [int] NULL,
	[mausac] [nvarchar](20) NULL,
	[tinhtrang] [nvarchar](100) NULL,
	[cauhinh] [nvarchar](100) NULL,
	[ghichu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[id] [varchar](10) NOT NULL,
	[ten] [nvarchar](100) NULL,
	[gioitinh] [nvarchar](10) NULL,
	[quequan] [nvarchar](50) NULL,
	[ngayvaolam] [date] NULL,
	[trangthai] [int] NULL,
	[chucvu] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sudung]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sudung](
	[taikhoan] [varchar](10) NOT NULL,
	[ma] [varchar](10) NOT NULL,
	[thoigian] [datetime] NOT NULL,
	[trangthai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC,
	[ma] ASC,
	[thoigian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoanC]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoanC](
	[taikhoan] [varchar](10) NOT NULL,
	[matkhau] [varchar](10) NULL,
	[hansudung] [int] NULL,
	[sdt] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoanNV]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoanNV](
	[taikhoan] [varchar](20) NOT NULL,
	[matkhau] [varchar](20) NULL,
	[id] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thanhtoanMA]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thanhtoanMA](
	[HDMA] [varchar](10) NULL,
	[soluong] [int] NULL,
	[tongtien] [float] NULL,
	[ngay] [datetime] NULL,
	[trangthai] [nvarchar](100) NULL,
	[taikhoan] [varchar](10) NULL,
	[ten] [nvarchar](50) NULL,
	[ghichu] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thanhtoanTK]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thanhtoanTK](
	[HDTK] [varchar](10) NOT NULL,
	[sogio] [int] NULL,
	[tongtien] [float] NULL,
	[ngay] [datetime] NULL,
	[trangthai] [nvarchar](100) NULL,
	[taikhoan] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[HDTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thietbi]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thietbi](
	[tenthietbi] [nvarchar](50) NOT NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
	[tinhtrang] [nvarchar](100) NULL,
	[ghichu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[tenthietbi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[calam] ([ca], [giobatdau], [gioketthuc]) VALUES (1, N'7:00', N'12:00')
INSERT [dbo].[calam] ([ca], [giobatdau], [gioketthuc]) VALUES (2, N'12:01', N'17:00')
INSERT [dbo].[calam] ([ca], [giobatdau], [gioketthuc]) VALUES (3, N'17:01', N'23:00')
GO
INSERT [dbo].[chucvu] ([ten], [ma]) VALUES (N'Phục vụ', N'2')
INSERT [dbo].[chucvu] ([ten], [ma]) VALUES (N'Quản lý', N'4')
INSERT [dbo].[chucvu] ([ten], [ma]) VALUES (N'Thủ kho', N'3')
INSERT [dbo].[chucvu] ([ten], [ma]) VALUES (N'Thu ngân', N'1')
GO
INSERT [dbo].[khachhang] ([sdt], [ten], [email], [ngaydangki], [id]) VALUES (N'000', N'sa', N'a@gmail,com', CAST(N'2024-05-10' AS Date), N'NV2')
INSERT [dbo].[khachhang] ([sdt], [ten], [email], [ngaydangki], [id]) VALUES (N'111', N'A', N'a@gmail.com', CAST(N'2024-05-10' AS Date), N'NV2')
INSERT [dbo].[khachhang] ([sdt], [ten], [email], [ngaydangki], [id]) VALUES (N'112', N'che', N'', CAST(N'2024-05-10' AS Date), N'NV2')
INSERT [dbo].[khachhang] ([sdt], [ten], [email], [ngaydangki], [id]) VALUES (N'115', N'acd', N'', CAST(N'2024-05-10' AS Date), N'NV2')
INSERT [dbo].[khachhang] ([sdt], [ten], [email], [ngaydangki], [id]) VALUES (N'116', N'ob', N'', CAST(N'2024-05-10' AS Date), N'NV2')
GO
INSERT [dbo].[kho] ([ten], [soluong], [dongia], [hansudung], [ghichu]) VALUES (N'Bò cụng', 100, 15000, CAST(N'2024-05-09' AS Date), N'')
INSERT [dbo].[kho] ([ten], [soluong], [dongia], [hansudung], [ghichu]) VALUES (N'Mì cay', 100, 25000, CAST(N'2024-05-09' AS Date), N'')
INSERT [dbo].[kho] ([ten], [soluong], [dongia], [hansudung], [ghichu]) VALUES (N'Mì hảo hảo', 89, 7000, CAST(N'2024-05-09' AS Date), N'Mới')
INSERT [dbo].[kho] ([ten], [soluong], [dongia], [hansudung], [ghichu]) VALUES (N'Nước suối', 96, 10000, CAST(N'2024-05-09' AS Date), N'')
INSERT [dbo].[kho] ([ten], [soluong], [dongia], [hansudung], [ghichu]) VALUES (N'Pepsi', 100, 12000, CAST(N'2024-05-09' AS Date), N'')
INSERT [dbo].[kho] ([ten], [soluong], [dongia], [hansudung], [ghichu]) VALUES (N'Snack', 99, 11000, CAST(N'2024-05-09' AS Date), N'')
INSERT [dbo].[kho] ([ten], [soluong], [dongia], [hansudung], [ghichu]) VALUES (N'Sting', 91, 13000, CAST(N'2024-05-09' AS Date), N'')
GO
INSERT [dbo].[luong] ([ma], [tien]) VALUES (N'1', 7000000)
INSERT [dbo].[luong] ([ma], [tien]) VALUES (N'2', 6000000)
INSERT [dbo].[luong] ([ma], [tien]) VALUES (N'3', 5000000)
INSERT [dbo].[luong] ([ma], [tien]) VALUES (N'4', 100000000)
GO
INSERT [dbo].[maytinh] ([ma], [soluong], [mausac], [tinhtrang], [cauhinh], [ghichu]) VALUES (N'MT1', 10, N'Trắng', N'Mới', N'RTX 3050 Ti', N'Hi')
GO
INSERT [dbo].[nhanvien] ([id], [ten], [gioitinh], [quequan], [ngayvaolam], [trangthai], [chucvu]) VALUES (N'NV1', N'Nguyễn Cao Kỳ', N'Nữ', N'Hà Nội', CAST(N'1999-01-02' AS Date), 1, N'Quản lý')
INSERT [dbo].[nhanvien] ([id], [ten], [gioitinh], [quequan], [ngayvaolam], [trangthai], [chucvu]) VALUES (N'NV2', N'An', N'Nam', N'', CAST(N'2024-05-10' AS Date), 1, N'Thu ngân')
INSERT [dbo].[nhanvien] ([id], [ten], [gioitinh], [quequan], [ngayvaolam], [trangthai], [chucvu]) VALUES (N'NV3', N'Vĩnh', N'Nam', N'', CAST(N'2024-05-10' AS Date), 1, N'Phục vụ')
INSERT [dbo].[nhanvien] ([id], [ten], [gioitinh], [quequan], [ngayvaolam], [trangthai], [chucvu]) VALUES (N'NV4', N'Luân', N'Nam', N'', CAST(N'2024-05-10' AS Date), 1, N'Thủ kho')
INSERT [dbo].[nhanvien] ([id], [ten], [gioitinh], [quequan], [ngayvaolam], [trangthai], [chucvu]) VALUES (N'NV5', N'Luân No', N'Nam', N'', CAST(N'2024-05-10' AS Date), 1, N'Thủ kho')
INSERT [dbo].[nhanvien] ([id], [ten], [gioitinh], [quequan], [ngayvaolam], [trangthai], [chucvu]) VALUES (N'NV6', N'An An', N'Nam', N'', CAST(N'2024-05-10' AS Date), 0, N'Phục vụ')
GO
INSERT [dbo].[sudung] ([taikhoan], [ma], [thoigian], [trangthai]) VALUES (N'000', N'MT1', CAST(N'2024-05-10T09:39:47.943' AS DateTime), 0)
INSERT [dbo].[sudung] ([taikhoan], [ma], [thoigian], [trangthai]) VALUES (N'000', N'MT1', CAST(N'2024-05-10T09:46:27.473' AS DateTime), 0)
INSERT [dbo].[sudung] ([taikhoan], [ma], [thoigian], [trangthai]) VALUES (N'111', N'MT1', CAST(N'2024-05-10T09:37:06.307' AS DateTime), 0)
GO
INSERT [dbo].[taikhoanC] ([taikhoan], [matkhau], [hansudung], [sdt]) VALUES (N'000', N'123', 416, N'000')
INSERT [dbo].[taikhoanC] ([taikhoan], [matkhau], [hansudung], [sdt]) VALUES (N'111', N'123', 119, N'111')
INSERT [dbo].[taikhoanC] ([taikhoan], [matkhau], [hansudung], [sdt]) VALUES (N'112', N'1', 0, N'112')
INSERT [dbo].[taikhoanC] ([taikhoan], [matkhau], [hansudung], [sdt]) VALUES (N'115', N'1', 120, N'115')
INSERT [dbo].[taikhoanC] ([taikhoan], [matkhau], [hansudung], [sdt]) VALUES (N'116', N'1', 0, N'116')
GO
INSERT [dbo].[taikhoanNV] ([taikhoan], [matkhau], [id]) VALUES (N'NV1', N'123', N'NV1')
INSERT [dbo].[taikhoanNV] ([taikhoan], [matkhau], [id]) VALUES (N'NV2', N'123', N'NV2')
INSERT [dbo].[taikhoanNV] ([taikhoan], [matkhau], [id]) VALUES (N'NV3', N'123', N'NV3')
INSERT [dbo].[taikhoanNV] ([taikhoan], [matkhau], [id]) VALUES (N'NV4', N'123', N'NV4')
INSERT [dbo].[taikhoanNV] ([taikhoan], [matkhau], [id]) VALUES (N'NV5', N'123', N'NV5')
INSERT [dbo].[taikhoanNV] ([taikhoan], [matkhau], [id]) VALUES (N'NV6', N'123', N'NV6')
GO
INSERT [dbo].[thanhtoanMA] ([HDMA], [soluong], [tongtien], [ngay], [trangthai], [taikhoan], [ten], [ghichu]) VALUES (N'HD1', 3, 21000, CAST(N'2024-05-10T09:40:46.680' AS DateTime), N'Hoàn tất', N'000', N'Mì hảo hảo', NULL)
INSERT [dbo].[thanhtoanMA] ([HDMA], [soluong], [tongtien], [ngay], [trangthai], [taikhoan], [ten], [ghichu]) VALUES (N'HD2', 3, 30000, CAST(N'2024-05-10T09:40:58.247' AS DateTime), N'Hoàn tất', N'000', N'Nước suối', NULL)
GO
INSERT [dbo].[thanhtoanTK] ([HDTK], [sogio], [tongtien], [ngay], [trangthai], [taikhoan]) VALUES (N'HD1', 2, 20000, CAST(N'2024-05-10T09:31:14.110' AS DateTime), N'Đã thanh toán', N'115')
INSERT [dbo].[thanhtoanTK] ([HDTK], [sogio], [tongtien], [ngay], [trangthai], [taikhoan]) VALUES (N'HD2', 2, 20000, CAST(N'2024-05-10T09:32:29.933' AS DateTime), N'Đã thanh toán', N'111')
INSERT [dbo].[thanhtoanTK] ([HDTK], [sogio], [tongtien], [ngay], [trangthai], [taikhoan]) VALUES (N'HD3', 3, 30000, CAST(N'2024-05-10T09:34:13.400' AS DateTime), N'Đã thanh toán', N'000')
INSERT [dbo].[thanhtoanTK] ([HDTK], [sogio], [tongtien], [ngay], [trangthai], [taikhoan]) VALUES (N'HD4', 3, 30000, CAST(N'2024-05-10T09:38:12.327' AS DateTime), N'Chưa thanh toán', N'111')
INSERT [dbo].[thanhtoanTK] ([HDTK], [sogio], [tongtien], [ngay], [trangthai], [taikhoan]) VALUES (N'HD5', 4, 40000, CAST(N'2024-05-10T09:40:32.647' AS DateTime), N'Đã thanh toán', N'000')
GO
INSERT [dbo].[thietbi] ([tenthietbi], [soluong], [dongia], [tinhtrang], [ghichu]) VALUES (N'Chuột', 100, 1300000, N'Mới', N'')
INSERT [dbo].[thietbi] ([tenthietbi], [soluong], [dongia], [tinhtrang], [ghichu]) VALUES (N'Chuột cơ', 3, 1300, N'', NULL)
INSERT [dbo].[thietbi] ([tenthietbi], [soluong], [dongia], [tinhtrang], [ghichu]) VALUES (N'Máy lạnh', 30, 10000000, N'Mới', N'')
INSERT [dbo].[thietbi] ([tenthietbi], [soluong], [dongia], [tinhtrang], [ghichu]) VALUES (N'Quạt điện', 5, 3000000, N'Cũ', N'')
GO
ALTER TABLE [dbo].[chucvu]  WITH CHECK ADD FOREIGN KEY([ma])
REFERENCES [dbo].[luong] ([ma])
GO
ALTER TABLE [dbo].[khachhang]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[nhanvien] ([id])
GO
ALTER TABLE [dbo].[lich]  WITH CHECK ADD FOREIGN KEY([ca])
REFERENCES [dbo].[calam] ([ca])
GO
ALTER TABLE [dbo].[lich]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[nhanvien] ([id])
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD FOREIGN KEY([chucvu])
REFERENCES [dbo].[chucvu] ([ten])
GO
ALTER TABLE [dbo].[sudung]  WITH CHECK ADD FOREIGN KEY([ma])
REFERENCES [dbo].[maytinh] ([ma])
GO
ALTER TABLE [dbo].[sudung]  WITH CHECK ADD FOREIGN KEY([taikhoan])
REFERENCES [dbo].[taikhoanC] ([taikhoan])
GO
ALTER TABLE [dbo].[taikhoanC]  WITH CHECK ADD FOREIGN KEY([sdt])
REFERENCES [dbo].[khachhang] ([sdt])
GO
ALTER TABLE [dbo].[taikhoanNV]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[nhanvien] ([id])
GO
ALTER TABLE [dbo].[thanhtoanMA]  WITH CHECK ADD FOREIGN KEY([taikhoan])
REFERENCES [dbo].[taikhoanC] ([taikhoan])
GO
ALTER TABLE [dbo].[thanhtoanMA]  WITH CHECK ADD FOREIGN KEY([ten])
REFERENCES [dbo].[kho] ([ten])
GO
ALTER TABLE [dbo].[thanhtoanTK]  WITH CHECK ADD FOREIGN KEY([taikhoan])
REFERENCES [dbo].[taikhoanC] ([taikhoan])
GO
ALTER TABLE [dbo].[lich]  WITH CHECK ADD CHECK  (([diemdanh]=(1) OR [diemdanh]=(0)))
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD CHECK  (([trangthai]=(1) OR [trangthai]=(0)))
GO
ALTER TABLE [dbo].[sudung]  WITH CHECK ADD CHECK  (([trangthai]=(1) OR [trangthai]=(0)))
GO
/****** Object:  StoredProcedure [dbo].[datMon]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[datMon] @taikhoan varchar(10)
AS
BEGIN
	

	declare @id varchar(10),@tam varchar(10)
	select TOP 1 @tam = hdma from thanhtoanMA 

	if @tam IS NULL
		begin
			set @id = 'HD1'
			UPDATE thanhtoanMA
			set trangthai = N'Đang đặt',HDMA = @id
			where taikhoan = @taikhoan and trangthai = N'Chưa đặt'

			
		end
	else
		begin
			declare @temp varchar(10),@stt int
			select TOP 1 @temp = HDMA from thanhtoanMA order by HDMA desc
			set @temp = right(@temp,1)
			set @stt = cast(right(@temp,1)as int) + 1
			set @id = 'HD' + cast(@stt as varchar(3))

			UPDATE thanhtoanMA
			set trangthai = N'Đang đặt',HDMA = @id
			where taikhoan = @taikhoan and trangthai = N'Chưa đặt'

		
		end
	
END
GO
/****** Object:  StoredProcedure [dbo].[diemdanh]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[diemdanh] @id varchar(10),@ca int,@ngay date
as
begin
	update lich
	set diemdanh = 1
	where id = @id and ca = @ca and ngay = @ngay
end
GO
/****** Object:  StoredProcedure [dbo].[hoanTat]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hoanTat] @HD varchar(10), @taikhoan varchar(10)
as
begin
			UPDATE thanhtoanMA
			set trangthai = N'Hoàn tất'
			where taikhoan = @taikhoan and trangthai = N'Đang đặt' and HDMA = @HD
end
GO
/****** Object:  StoredProcedure [dbo].[naptien]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[naptien] @sdt varchar(10),@giothue int
as
begin
	declare @HDDK varchar(10)
	if (select count(*) from thanhtoanTK)=0
		begin
			set @HDDK = 'HD1'
		end
	else
		begin
			declare @temp varchar(10),@stt int
			select TOP 1 @temp = HDTK from thanhtoanTK order by HDTK desc
			set @temp = right(@temp,1)
			set @stt = cast(right(@temp,1)as int) + 1
			set @HDDK = 'HD' + cast(@stt as varchar(3))
		end
	declare @tong float
	set @tong = @giothue * 10000
	insert into thanhtoanTK values(@HDDK,@giothue,@tong,getdate(),N'Chưa thanh toán',@sdt)
end
GO
/****** Object:  StoredProcedure [dbo].[suaNV]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaNV]  @id varchar(10),@ten nvarchar(50), @gioitinh nvarchar(5), @que nvarchar(50)
as
begin
	update nhanvien
	set ten = @ten
	where id = @id

	update nhanvien
	set gioitinh = @gioitinh
	where id = @id

	update nhanvien
	set quequan = @que
	where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[themKH]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themKH] @sdt varchar(10),@ten nvarchar(50),@email varchar(50),@id varchar(10)
as
begin
	insert into khachhang values(@sdt,@ten,@email,getdate(),@id)
	insert into taikhoanC values(@sdt,'1',0,@sdt)
end
GO
/****** Object:  StoredProcedure [dbo].[themLich]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[themLich] @id varchar(10),@ca int,@ngay date
as
begin
	insert into lich values(@ngay,@ca,@id,0)
end
GO
/****** Object:  StoredProcedure [dbo].[themMonAn]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themMonAn] @taikhoan varchar(10), @ten nvarchar(50),@soluong int,@ghichu nvarchar(100)
as
begin	
	declare @thanhtien float,@dongia float
	select @dongia = dongia from kho where ten = @ten
	set @thanhtien = @soluong * @dongia
	insert into thanhtoanMA(soluong,tongtien,ngay,trangthai,taikhoan,ten,ghichu) values(@soluong,@thanhtien,getdate(),N'Chưa đặt',@taikhoan,@ten,@ghichu)
	
	Update kho
	set soluong = soluong - @soluong
	where ten = @ten
end
GO
/****** Object:  StoredProcedure [dbo].[themNV]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themNV] @ten nvarchar(50), @gioitinh nvarchar(5), @que nvarchar(50), @chucvu nvarchar(50)
as
begin
	declare @ID varchar(10)
	if (select count(*) from nhanvien)=0
		begin
			set @ID = 'NV1'
		end
	else
		begin
			declare @temp varchar(10),@stt int
			select TOP 1 @temp = id from nhanvien order by id desc
			set @temp = right(@temp,1)
			set @stt = cast(right(@temp,1)as int) + 1
			set @ID = 'NV' + cast(@stt as varchar(3))
		end
	insert into nhanvien values(@ID,@ten,@gioitinh,@que,getdate(),1,@chucvu)
	insert into taikhoanNV values(@ID,123,@ID)
	
end
GO
/****** Object:  StoredProcedure [dbo].[xacnhanDK]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xacnhanDK] @HDDK varchar(10)
as
begin
	declare @thoigian int,@sdt varchar(10)
	select @thoigian = sogio,@sdt = taikhoan from thanhtoanTK where HDTK = @HDDK 
	set @thoigian = @thoigian * 60
	update thanhtoanTK
	set trangthai = N'Đã thanh toán'
	where HDTK = @HDDK 

	update taikhoanC
	set hansudung = hansudung + @thoigian
	where sdt = @sdt 
end
GO
/****** Object:  StoredProcedure [dbo].[xoaMonAn]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaMonAn]  @taikhoan varchar(10), @ten nvarchar(50)
as
begin 
	declare @soluong int
	select @soluong = soluong from thanhtoanMA where taikhoan = @taikhoan and ten = @ten and trangthai = N'Chưa đặt'

	update kho
	set soluong = soluong + @soluong
	where ten = @ten

	delete from thanhtoanMA
	where taikhoan = @taikhoan and ten = @ten and trangthai = N'Chưa đặt'
end
GO
/****** Object:  StoredProcedure [dbo].[xoaMonAn1]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaMonAn1]  @taikhoan varchar(10), @ten nvarchar(50), @hdma varchar(10)
as
begin 
	declare @soluong int
	select @soluong = soluong from thanhtoanMA where taikhoan = @taikhoan and ten = @ten and HDMA = @hdma and trangthai = N'Đang đặt'

	update kho
	set soluong = soluong + @soluong
	where ten = @ten

	delete from thanhtoanMA
	where taikhoan = @taikhoan and ten = @ten and HDMA = @hdma and trangthai = N'Đang đặt'
end
GO
/****** Object:  StoredProcedure [dbo].[xoaNV]    Script Date: 5/10/2024 3:27:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaNV] @id varchar(10)
as
begin
	update nhanvien
	set trangthai =0
	where id = @id
end
GO
USE [master]
GO
ALTER DATABASE [Net] SET  READ_WRITE 
GO
