USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[Barcode_Of_Reader_Card]    Script Date: 11/19/2014 11:01:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Barcode_Of_Reader_Card](
	[MaDocGia] [char](13) NOT NULL,
	[BarcodeName] [char](13) NOT NULL,
	[BarcodePath] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 11/19/2014 11:01:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaSoDocGia] [char](13) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [char](13) NULL,
	[TinhTP] [nvarchar](50) NULL,
	[QuocGia] [nvarchar](50) NULL,
	[KhoaLopDonVi] [nvarchar](100) NULL,
	[Nhom] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[NgayTheHetHan] [date] NULL,
	[TrangThaiThe] [nvarchar](20) NULL,
	[CMND] [char](13) NULL,
	[SoMaVach] [char](13) NULL,
	[MaSoThe] [char](13) NULL,
	[TenDangNhap] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[GhiChu] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSoDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 11/19/2014 11:01:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[SoDangKyCaBiet] [int] NOT NULL,
	[NhanDe] [nvarchar](50) NULL,
	[NhaXuatBan] [nvarchar](50) NULL,
	[TacGia] [nvarchar](50) NULL,
	[Gia] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoDangKyCaBiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinMuonSach]    Script Date: 11/19/2014 11:01:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongTinMuonSach](
	[MaDocGia] [char](13) NOT NULL,
	[SoDangKyCaBiet] [int] NOT NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC,
	[SoDangKyCaBiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[YKienDocGia]    Script Date: 11/19/2014 11:01:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YKienDocGia](
	[ID] [int] NOT NULL,
	[TieuDe] [nvarchar](50) NULL,
	[NoiDung] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DocGia] ([MaSoDocGia], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [TinhTP], [QuocGia], [KhoaLopDonVi], [Nhom], [Email], [NgayTheHetHan], [TrangThaiThe], [CMND], [SoMaVach], [MaSoThe], [TenDangNhap], [MatKhau], [GhiChu]) VALUES (N'1112148      ', N'Hưng', N'Nam', CAST(0x3E390B00 AS Date), N'asdasgas', N'1564897312   ', N'hồ chí minh', N'việt nam', N'sinh', N'Sinh viên', N'abc@yahoo.com', CAST(0x3F390B00 AS Date), N'Được mượn', N'124151241    ', N'1112148      ', N'1112148      ', N'nam', N'123', N'hay mượn đồ không trả')
INSERT [dbo].[DocGia] ([MaSoDocGia], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [TinhTP], [QuocGia], [KhoaLopDonVi], [Nhom], [Email], [NgayTheHetHan], [TrangThaiThe], [CMND], [SoMaVach], [MaSoThe], [TenDangNhap], [MatKhau], [GhiChu]) VALUES (N'1112149      ', N'Mai trung kiên điên', N'Nam', CAST(0x3B390B00 AS Date), N'abcasd', N'0123456789   ', N'hà nội', N'việt nam', N'công nghệ thông tin', N'Sinh viên', N'graywolf1411@gmail.com', CAST(0x41390B00 AS Date), N'Được mượn', N'024867522    ', N'1112149      ', N'1112149      ', N'kien', N'123', N'hay chôm sách')
INSERT [dbo].[Sach] ([SoDangKyCaBiet], [NhanDe], [NhaXuatBan], [TacGia], [Gia]) VALUES (1, N'hồ chí minh một tấm gương vĩ đại', N'văn học nghệ thuật', N'trần anh', 80000.0000)
INSERT [dbo].[Sach] ([SoDangKyCaBiet], [NhanDe], [NhaXuatBan], [TacGia], [Gia]) VALUES (2, N'Lịch sử việt nam', N'giáo dục', N'ngô trung quốc', 72000.0000)
INSERT [dbo].[ThongTinMuonSach] ([MaDocGia], [SoDangKyCaBiet], [NgayMuon], [NgayTra]) VALUES (N'1112148      ', 1, CAST(0x3E390B00 AS Date), CAST(0x49390B00 AS Date))
INSERT [dbo].[ThongTinMuonSach] ([MaDocGia], [SoDangKyCaBiet], [NgayMuon], [NgayTra]) VALUES (N'1112149      ', 2, CAST(0x44390B00 AS Date), CAST(0x4C390B00 AS Date))
INSERT [dbo].[YKienDocGia] ([ID], [TieuDe], [NoiDung]) VALUES (1, N'thiếu sách', N'cần mua thêm sách sinh học')
INSERT [dbo].[YKienDocGia] ([ID], [TieuDe], [NoiDung]) VALUES (2, N'dư sách', N'cần bán sách lỗi thời')
ALTER TABLE [dbo].[Barcode_Of_Reader_Card]  WITH CHECK ADD  CONSTRAINT [fk_Barcode_Of_Reader_Card_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaSoDocGia])
GO
ALTER TABLE [dbo].[Barcode_Of_Reader_Card] CHECK CONSTRAINT [fk_Barcode_Of_Reader_Card_DocGia]
GO
ALTER TABLE [dbo].[ThongTinMuonSach]  WITH CHECK ADD  CONSTRAINT [fk_ThongTinMuonSach_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaSoDocGia])
GO
ALTER TABLE [dbo].[ThongTinMuonSach] CHECK CONSTRAINT [fk_ThongTinMuonSach_DocGia]
GO
ALTER TABLE [dbo].[ThongTinMuonSach]  WITH CHECK ADD  CONSTRAINT [fk_ThongTinMuonSach_Sach] FOREIGN KEY([SoDangKyCaBiet])
REFERENCES [dbo].[Sach] ([SoDangKyCaBiet])
GO
ALTER TABLE [dbo].[ThongTinMuonSach] CHECK CONSTRAINT [fk_ThongTinMuonSach_Sach]
GO
