
/****** Object:  Database [QuanLyThuVien]    Script Date: 12/2/2014 1:54:57 AM ******/
CREATE DATABASE [QuanLyThuVien]

GO

USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/2/2014 1:54:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[acc] [nvarchar](100) NOT NULL,
	[pass] [nvarchar](100) NOT NULL,
	[email] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[acc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Barcode_Of_Reader_Card]    Script Date: 12/2/2014 1:54:57 AM ******/
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
/****** Object:  Table [dbo].[DanhMucAdmin]    Script Date: 12/2/2014 1:54:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucAdmin](
	[id] [nvarchar](255) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[link] [nvarchar](255) NULL,
	[oder] [int] NOT NULL,
	[parent] [nvarchar](255) NULL,
	[icon] [nvarchar](255) NULL,
	[type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 12/2/2014 1:54:57 AM ******/
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
/****** Object:  Table [dbo].[Sach]    Script Date: 12/2/2014 1:54:57 AM ******/
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
/****** Object:  Table [dbo].[ThongTinMuonSach]    Script Date: 12/2/2014 1:54:57 AM ******/
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
/****** Object:  Table [dbo].[YKienDocGia]    Script Date: 12/2/2014 1:54:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YKienDocGia](
	[ID] [int] NOT NULL,
	[NgayGui] [date] NULL,
	[TieuDe] [nvarchar](50) NOT NULL,
	[NoiDung] [nvarchar](100) NOT NULL,
	[KyDanh] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Account] ([acc], [pass], [email]) VALUES (N'Admin', N'Admin', NULL)
INSERT [dbo].[DanhMucAdmin] ([id], [name], [link], [oder], [parent], [icon], [type]) VALUES (N'chinh-sua-doc-gia', N'Chỉnh sửa độc giả', N'/Admin/QuanLyDocGia/ChinhSuaDocGia', 2, NULL, N'images/icons/mainnav/ui.png', 1)
INSERT [dbo].[DanhMucAdmin] ([id], [name], [link], [oder], [parent], [icon], [type]) VALUES (N'phat-sinh-ma-vach', N'Phát sinh mã vạch', N'/Admin/QuanLyDocGia/PhatSinhBarCode', 6, NULL, N'images/icons/mainnav/forms.png', 1)
INSERT [dbo].[DanhMucAdmin] ([id], [name], [link], [oder], [parent], [icon], [type]) VALUES (N'quan-ly-hinh-doc-gia', N'Quản lý hình độc giả', N'/Admin/QuanLyDocGia/QLYHinh', 5, NULL, N'images/icons/mainnav/ui.png', 1)
INSERT [dbo].[DanhMucAdmin] ([id], [name], [link], [oder], [parent], [icon], [type]) VALUES (N'quan-ly-y-kien-gop-y', N'Quản lý ý kiến góp ý', N'/Admin/QuanLyDocGia/QLYKienGopY', 4, NULL, N'images/icons/mainnav/ui.png', 1)
INSERT [dbo].[DanhMucAdmin] ([id], [name], [link], [oder], [parent], [icon], [type]) VALUES (N'them-moi-doc-gia', N'Thêm mới độc giả', N'/Admin/QuanLyDocGia/ThemDocGia', 1, NULL, N'images/icons/mainnav/forms.png', 1)
INSERT [dbo].[DanhMucAdmin] ([id], [name], [link], [oder], [parent], [icon], [type]) VALUES (N'thong-ke-doc-gia', N'Thống kê độc giả', N'/Admin/QuanLyDocGia/TKe', 3, NULL, N'images/icons/mainnav/statistics.png', 1)
INSERT [dbo].[DocGia] ([MaSoDocGia], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [TinhTP], [QuocGia], [KhoaLopDonVi], [Nhom], [Email], [NgayTheHetHan], [TrangThaiThe], [CMND], [SoMaVach], [MaSoThe], [TenDangNhap], [MatKhau], [GhiChu]) VALUES (N'1112094      ', N'Hoan', N'Nữ', CAST(0x461B0B00 AS Date), N'abcd', N'0123456789   ', N'Hà Nội', N'Việt Nam', N'công nghệ thông tin', N'Sinh viên', N'hoan@gmail.com', CAST(0x3F390B00 AS Date), N'Được mượn', N'45345537     ', N'1112094      ', N'1112094      ', N'1112094', N'', N'')
INSERT [dbo].[DocGia] ([MaSoDocGia], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [TinhTP], [QuocGia], [KhoaLopDonVi], [Nhom], [Email], [NgayTheHetHan], [TrangThaiThe], [CMND], [SoMaVach], [MaSoThe], [TenDangNhap], [MatKhau], [GhiChu]) VALUES (N'1112148      ', N'Hưng', N'Nam', CAST(0x481B0B00 AS Date), N'asdasgas', N'1564897312   ', N'Hồ Chí Minh', N'Việt Nam', N'sinh', N'Sinh viên', N'abc@yahoo.com', CAST(0x3F390B00 AS Date), N'Được mượn', N'124151241    ', N'1112148      ', N'1112148      ', N'nam', N'123', N'hay mượn đồ không trả')
INSERT [dbo].[DocGia] ([MaSoDocGia], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [TinhTP], [QuocGia], [KhoaLopDonVi], [Nhom], [Email], [NgayTheHetHan], [TrangThaiThe], [CMND], [SoMaVach], [MaSoThe], [TenDangNhap], [MatKhau], [GhiChu]) VALUES (N'1112149      ', N'Kiên', N'Nam', CAST(0x451B0B00 AS Date), N'abcasd', N'0123456789   ', N'Hồ Chí Minh', N'Việt Nam', N'công nghệ thông tin', N'Sinh viên', N'graywolf1411@gmail.com', CAST(0x41390B00 AS Date), N'Được mượn', N'024867522    ', N'1112149      ', N'1112149      ', N'kien', N'', N'hay chôm sách')
INSERT [dbo].[DocGia] ([MaSoDocGia], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [TinhTP], [QuocGia], [KhoaLopDonVi], [Nhom], [Email], [NgayTheHetHan], [TrangThaiThe], [CMND], [SoMaVach], [MaSoThe], [TenDangNhap], [MatKhau], [GhiChu]) VALUES (N'1112152      ', N'Lân', N'Nam', CAST(0x451B0B00 AS Date), N'abcdf', N'0123456798   ', N'Đà Nẵng', N'Việt Nam', N'Mỹ thuật', N'Sinh viên', N'lan@yahoo.com', CAST(0x45390B00 AS Date), N'Được mượn', N'012345489    ', N'1112152      ', N'1112152      ', N'lan', N'123', N'hay nói dối')
INSERT [dbo].[Sach] ([SoDangKyCaBiet], [NhanDe], [NhaXuatBan], [TacGia], [Gia]) VALUES (1, N'Hồ chí minh một tấm gương vĩ đại', N'Văn học nghệ thuật', N'Trần Anh', 80000.0000)
INSERT [dbo].[Sach] ([SoDangKyCaBiet], [NhanDe], [NhaXuatBan], [TacGia], [Gia]) VALUES (2, N'Lịch sử việt nam', N'Giáo Dục', N'Ngô Trung Quốc', 72000.0000)
INSERT [dbo].[Sach] ([SoDangKyCaBiet], [NhanDe], [NhaXuatBan], [TacGia], [Gia]) VALUES (3, N'Chúa tể của Nhẫn', N'Nước ngoài', N'unknown', 150000.0000)
INSERT [dbo].[Sach] ([SoDangKyCaBiet], [NhanDe], [NhaXuatBan], [TacGia], [Gia]) VALUES (4, N'Harry Potter', N'Nước ngoài', N'JK', 200000.0000)
INSERT [dbo].[Sach] ([SoDangKyCaBiet], [NhanDe], [NhaXuatBan], [TacGia], [Gia]) VALUES (5, N'Cô gái đến từ hôm qua', N'Văn học nghệ thuật', N'Nguyễn Nhật Ánh', 25000.0000)
INSERT [dbo].[Sach] ([SoDangKyCaBiet], [NhanDe], [NhaXuatBan], [TacGia], [Gia]) VALUES (6, N'Bàn có 5 chỗ ngồi', N'Văn học nghệ thuật', N'Nguyễn Nhật Ánh', 25000.0000)
INSERT [dbo].[ThongTinMuonSach] ([MaDocGia], [SoDangKyCaBiet], [NgayMuon], [NgayTra]) VALUES (N'1112094      ', 4, CAST(0x3F390B00 AS Date), CAST(0x49390B00 AS Date))
INSERT [dbo].[ThongTinMuonSach] ([MaDocGia], [SoDangKyCaBiet], [NgayMuon], [NgayTra]) VALUES (N'1112148      ', 1, CAST(0x3E390B00 AS Date), CAST(0x49390B00 AS Date))
INSERT [dbo].[ThongTinMuonSach] ([MaDocGia], [SoDangKyCaBiet], [NgayMuon], [NgayTra]) VALUES (N'1112149      ', 2, CAST(0x44390B00 AS Date), CAST(0x4C390B00 AS Date))
INSERT [dbo].[ThongTinMuonSach] ([MaDocGia], [SoDangKyCaBiet], [NgayMuon], [NgayTra]) VALUES (N'1112152      ', 6, CAST(0x3C390B00 AS Date), NULL)
INSERT [dbo].[YKienDocGia] ([ID], [NgayGui], [TieuDe], [NoiDung], [KyDanh]) VALUES (1, CAST(0x3E390B00 AS Date), N'Thiếu sách', N'Thư viện cần mua thêm sách sinh học, vật lý, hóa học', N'Một bạn nữ giấu tên')
INSERT [dbo].[YKienDocGia] ([ID], [NgayGui], [TieuDe], [NoiDung], [KyDanh]) VALUES (2, CAST(0x3F390B00 AS Date), N'Phong cách quản lý sách', N'Thư viện quản lý sách chưa hợp lý, vị trí đặt sách khó lui tới lấy', N'Một bạn nam giấu họ')
INSERT [dbo].[YKienDocGia] ([ID], [NgayGui], [TieuDe], [NoiDung], [KyDanh]) VALUES (3, CAST(0x40390B00 AS Date), N'Vấn đề mượn sách', N'Thư viện nên gia tăng thời hạn cho mượn sách, thời hạn 7 ngày là quá ít', N'Một người lạ giấu mặt')
ALTER TABLE [dbo].[DanhMucAdmin] ADD  DEFAULT ((1)) FOR [oder]
GO
ALTER TABLE [dbo].[DanhMucAdmin] ADD  DEFAULT ((1)) FOR [type]
GO
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
USE [master]
GO
ALTER DATABASE [QuanLyThuVien] SET  READ_WRITE 
GO
