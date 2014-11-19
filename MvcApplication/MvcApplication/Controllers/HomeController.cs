using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnBarcode.Barcode;
using System.IO;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Trang chủ";
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(DocGia dg)
        {
            if (ModelState.IsValid)
            {               
                using (QuanLyThuVienEntities3 db = new QuanLyThuVienEntities3())
                {
                    var v = db.DocGias.Where(a => a.TenDangNhap.Equals(dg.TenDangNhap) && a.MatKhau.Equals(dg.MatKhau)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["LogedUserID"] = v.MaSoDocGia.ToString();
                        Session["Name"] = v.HoTen.ToString();
                        return RedirectToAction("Afterlogin");
                    }
                }
            }
            return View(dg);
        }

        public ActionResult Afterlogin()
        {
            if (Session["LogedUserID"] != null)
            {
                return View();
            }
            else
                return RedirectToAction("index");
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "Giới thiệu";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Liên hệ";

            return View();
        }

        public ActionResult ThemDocGia()
        {
            return View();
        }

        public ActionResult Save(FormCollection f)
        {
            QuanLyThuVienEntities3 data = new QuanLyThuVienEntities3();
           
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
            QuanLyThuVienEntities3 data = new QuanLyThuVienEntities3();
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
            QuanLyThuVienEntities3 data = new QuanLyThuVienEntities3();
            DocGia result = (from p in data.DocGias
                             where p.MaSoDocGia.CompareTo(temp) == 0
                           select p).First();

            return View(result);
        }

        public ActionResult Details(int id)
        {
            string temp = id.ToString();
            QuanLyThuVienEntities3 data = new QuanLyThuVienEntities3();
            DocGia result = (from p in data.DocGias
                             where p.MaSoDocGia.CompareTo(temp) == 0
                            select p).First();

            return View(result);
        }

        public ActionResult Update(FormCollection f)
        {
            string temp = f["SoMaVach"];
            QuanLyThuVienEntities3 data = new QuanLyThuVienEntities3();
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
            QuanLyThuVienEntities3 data = new QuanLyThuVienEntities3();
            var result = from y in data.YKienDocGias
                         select y;
            return View(result);
        }

        //Xóa 1 ý kiến trong CSDL
        public ActionResult remove(int id)
        {
            QuanLyThuVienEntities3 data = new QuanLyThuVienEntities3();
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
            QuanLyThuVienEntities3 data = new QuanLyThuVienEntities3();
            var result = from tt in data.ThongTinMuonSaches
                         where (tt.NgayTra.Value.Day - tt.NgayMuon.Value.Day) > 7
                         select tt;
            return View(result);
        }

        //removeDGMuonSachQuaHan
        public ActionResult removeDGMuonSachQuaHan(int id)
        {
            string temp = id.ToString();
            QuanLyThuVienEntities3 data = new QuanLyThuVienEntities3();
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

            QuanLyThuVienEntities3 data = new QuanLyThuVienEntities3();
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
