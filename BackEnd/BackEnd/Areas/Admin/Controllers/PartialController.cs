using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Areas.Admin.Models;
using BackEnd.Models;

namespace BackEnd.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PartialController : Controller
    {
        //
        // GET: /Admin/Partial/

        [ChildActionOnly]
        public PartialViewResult GetMenu(string id,string id2)
        {
            QuanLyThuVienEntities db = new QuanLyThuVienEntities();
            ViewBag.data = db.DanhMucAdmins.Where(x => x.parent == null).OrderBy(x=>x.oder).ToList();
            ViewBag.id = id;
            ViewBag.id2 = id2;
            return PartialView();
        }

        [ChildActionOnly]
        public PartialViewResult GetMenu2(string id, string parent)
        {
            QuanLyThuVienEntities db = new QuanLyThuVienEntities();
            ViewBag.data = db.DanhMucAdmins.Where(x => x.parent.Equals(parent)).OrderBy(x => x.oder).ToList();
            ViewBag.id = id;
            return PartialView();
        }

        [ChildActionOnly]
        public PartialViewResult GetMenu22(string id, string parent)
        {
            QuanLyThuVienEntities db = new QuanLyThuVienEntities();
            ViewBag.data = db.DanhMucAdmins.Where(x => x.parent.Equals(parent)).OrderBy(x => x.oder).ToList();
            ViewBag.id = id;
            return PartialView();
        }

        //[ChildActionOnly]
        //public PartialViewResult GetDanhMucDrop(string value,int type,string danhmuccon)
        //{
        //    EAuctionEntities db = new EAuctionEntities();
        //    var data = db.DanhMucs.Where(x=>x.parent == null && x.type == type).ToList();
        //    ListItemlModel model = new ListItemlModel();
        //    model.value = value;
        //    model.listitem = new SelectList(data, "id", "name");
        //    ViewBag.type = type;
        //    ViewBag.id = value;
        //    ViewBag.danhmuccon = danhmuccon;
        //    return PartialView(model);
        //}

        //[ChildActionOnly]
        //public PartialViewResult GetDanhMucDropdf(string id, int type, string danhmuccon)
        //{
        //    ThietBiYTeEntities db = new ThietBiYTeEntities();
        //    var data = db.DanhMucs.Where(x => x.parent.Equals(id) && x.type == 1).ToList();
        //    ListItemlModel model = new ListItemlModel();
        //    model.listitem = new SelectList(data, "id", "name");
        //    model.danhmuccon = danhmuccon;
        //    return PartialView("GetDanhMucDrop2", model);
        //}

        //[HttpPost]
        //public PartialViewResult GetDanhMucDrop2(string id,int type,string danhmuccon)
        //{
        //    ThietBiYTeEntities db = new ThietBiYTeEntities();
        //    var data = db.DanhMucs.Where(x => x.parent.Equals(id) && x.type == 1).ToList();
        //    ListItemlModel model = new ListItemlModel();
        //    model.listitem = new SelectList(data, "id", "name");
        //    model.danhmuccon = danhmuccon;
        //    return PartialView(model);
        //}
    }
}
