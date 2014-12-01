using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnBarcode.Barcode;
using System.IO;
using System.Data.Objects;
using BackEnd.Models;
using BackEnd.Areas.Admin.Models;

namespace BackEnd.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class QuanLyDocGiaController : Controller
    {      
        public ActionResult ThemDocGia()
        {
            return View();
        }

        public ActionResult Save(FormCollection f)
        {
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
           
            DocGia d = new DocGia();
            try
            {
                d.MaSoDocGia = (f["SoMaVach"]);
                d.HoTen = f["HoTen"];
                d.GioiTinh = f["GioiTinh"];
                d.NgaySinh = DateTime.Parse(f["NgaySinh"]);
                d.DiaChi = f["DiaChi"];
                d.DienThoai = f["DienThoai"];
                d.TinhTP = f["TinhTP"];
                d.QuocGia = f["QuocGia"];
                d.KhoaLopDonVi = f["KhoaLopDonVi"];
                d.Nhom = f["Nhom"];
                d.Email = f["Email"];
                d.NgayTheHetHan = DateTime.Parse(f["NgayTheHetHan"]);
                d.TrangThaiThe = f["TrangThaiThe"];
                d.CMND = f["CMND"];
                d.SoMaVach = f["SoMaVach"];
                d.MaSoThe = f["MaSoThe"];
                d.TenDangNhap = f["TenDangNhap"];
                d.MatKhau = f["MatKhau"];
                d.GhiChu = f["GhiChu"];
                data.DocGias.Add(d);
                data.SaveChanges();
                return RedirectToAction("ThemDocGiaThanhCong");
            }
            catch (Exception e)
            {
                return RedirectToAction("ThemDocGiaThatBai");
            }                            
        }

        public ActionResult ThemDocGiaThanhCong()
        {
            return View();
        }

        public ActionResult ThemDocGiaThatBai()
        {
            return View();
        }

        public ActionResult ChinhSuaDocGia()
        {
            return View();
        }

        public ActionResult TimDocGia(FormCollection f)
        {           
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            if (f["TuKhoa"].CompareTo("") == 0)
            {
                var result = from p in data.DocGias                          
                             select p;
                return View(result);
            }
            else
            if (int.Parse(f["Tim"]) == 0)
            {
                string temp = f["TuKhoa"];
                var result = from p in data.DocGias
                             where p.MaSoDocGia.Contains(temp)
                             select p;
                return View(result);
            }
            else               
                {
                    string temp = f["TuKhoa"];
                    var result = from p in data.DocGias
                                 where p.HoTen.Contains(temp)
                                 select p;
                    return View(result);
                }
            
        }

        public ActionResult Edit(int id)
        {
            string temp = id.ToString();
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            DocGia result = (from p in data.DocGias
                             where p.MaSoDocGia.CompareTo(temp) == 0
                           select p).First();

            return View(result);
        }

        public ActionResult Details(int id)
        {
            string temp = id.ToString();
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            DocGia result = (from p in data.DocGias
                             where p.MaSoDocGia.CompareTo(temp) == 0
                            select p).First();

            return View(result);
        }

        public ActionResult Update(FormCollection f)
        {
            string temp = f["SoMaVach"];
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            DocGia d = (from p in data.DocGias
                           where p.MaSoDocGia.CompareTo(temp) == 0
                           select p).First();
            try
            {
                d.HoTen = f["HoTen"];
                d.GioiTinh = f["GioiTinh"];
                d.NgaySinh = DateTime.Parse(f["NgaySinh"]);
                d.DiaChi = f["DiaChi"];
                d.DienThoai = f["DienThoai"];
                d.TinhTP = f["TinhTP"];
                d.QuocGia = f["QuocGia"];
                d.KhoaLopDonVi = f["KhoaLopDonVi"];
                d.Nhom = f["Nhom"];
                d.Email = f["Email"];
                d.NgayTheHetHan = DateTime.Parse(f["NgayTheHetHan"]);
                d.TrangThaiThe = f["TrangThaiThe"];
                d.CMND = f["CMND"];
                d.SoMaVach = f["SoMaVach"];
                d.MaSoThe = f["MaSoThe"];
                d.TenDangNhap = f["TenDangNhap"];
                d.MatKhau = f["MatKhau"];
                d.GhiChu = f["GhiChu"];
                data.SaveChanges();
                return RedirectToAction("SuaDocGiaThanhCong");
            }
            catch (Exception e)
            {
                return RedirectToAction("SuaDocGiaThatBai");
            }  
        }

        public ActionResult SuaDocGiaThanhCong()
        {
            return View();
        }

        public ActionResult SuaDocGiaThatBai()
        {
            return View();
        }


        //Xem tất cả ý kiến có trong CSDL
        public ActionResult QLYKienGopY()
        {
            ViewBag.Message = "QL góp ý";
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            var result = from y in data.YKienDocGias
                         select y;
            return View(result);
        }

        //Xóa 1 ý kiến trong CSDL
        public ActionResult remove(int id)
        {
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            YKienDocGia result = (from y in data.YKienDocGias
                                  where y.ID == id
                                  select y).First();
            data.YKienDocGias.Remove(result);
            data.SaveChanges();
            return RedirectToAction("QLYKienGopY");
        }

        //Thống kê đọc giả
        public ActionResult TKe()
        {
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();

            DateTime hientai = DateTime.Now;

            var result = from t in data.ThongTinMuonSaches
                         from dg in data.DocGias
                         from s in data.Saches
                         where (((t.NgayTra == null) && (t.NgayMuon < EntityFunctions.AddDays(DateTime.Now, -7))) || ((t.NgayTra != null) && (t.NgayMuon < EntityFunctions.AddDays(t.NgayTra, -7)))) && (dg.MaSoDocGia == t.MaDocGia) && (s.SoDangKyCaBiet == t.SoDangKyCaBiet)
                         select new MuonSachModel()
                         {
                             madocgia = t.MaDocGia,
                             hoten = dg.HoTen,
                             gioitinh = dg.GioiTinh,
                             donvi = dg.KhoaLopDonVi,
                             nhande = s.NhanDe,
                             tacgia = s.TacGia,
                             ngaymuon = t.NgayMuon,
                             ngaytra = t.NgayTra
                         };
            List<MuonSachModel> muonsach = result.ToList();
            return View(muonsach);
        }

        //removeDGMuonSachQuaHan
        public ActionResult removeDGMuonSachQuaHan(int id)
        {
            string temp = id.ToString();
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            ThongTinMuonSach result = (from tt in data.ThongTinMuonSaches
                                       where tt.MaDocGia.CompareTo(temp) == 0
                                       select tt).First();
            data.ThongTinMuonSaches.Remove(result);
            data.SaveChanges();
            return RedirectToAction("TKe");
        }

        // barcode
        public ActionResult GenerateBarcode(FormCollection f)
        {
            string madocgia = f["MaDocGia"];
            if (madocgia.CompareTo("")==0)
                return RedirectToAction("PhatSinhBarCodeThatBai");
            Linear barcode = new Linear();
            barcode.Type = BarcodeType.CODE39;
            barcode.ShowText = true;
            barcode.TextFont = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular);
            // set barcode bar with (X module) and bar height (Y module)
            barcode.X = 2; // width of black/white line
            barcode.BarcodeHeight = 5;
            //barcode.BarcodeWidth = 100;

            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            //SqlCommand cmd = new SqlCommand("select b.MSSV from Barcode_Of_Reader_Card b where b.MSSV ='"+mssv+"'");

            Barcode_Of_Reader_Card objbar = new Barcode_Of_Reader_Card();
            objbar.MaDocGia = madocgia;
            barcode.Data = madocgia;
            objbar.BarcodeName = barcode.Data.ToString();

            // save the image of barcode in 'images' folder inside project with filename is barcode
            string ImageBarcodeName = System.IO.Path.GetFileName(objbar.BarcodeName);
            string physicalPath = Server.MapPath("~/images/" + ImageBarcodeName + ".jpg");
            barcode.drawBarcode(physicalPath);// save image of barcode in folder

            // save new record in database
            objbar.BarcodePath = physicalPath;

            try
            {
                data.Barcode_Of_Reader_Card.Add(objbar);
                data.Barcode_Of_Reader_Card.Attach(objbar);
                data.SaveChanges();
                return RedirectToAction("PhatSinhBarCodeThanhCong");
            }
            catch (Exception e)
            {
                return RedirectToAction("PhatSinhBarCodeThatBai");
            }
            
        }

        public ActionResult PhatSinhBarCode()
        {
            return View();
        }

        public ActionResult PhatSinhBarCodeThanhCong()
        {
            return View();
        }

        public ActionResult PhatSinhBarCodeThatBai()
        {
            return View();
        }
    }
}
