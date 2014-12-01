using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Areas.Admin.Models;
using System.Web.Security;
using BackEnd.Models;

namespace BackEnd.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Admin/Account/

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountModel model)
        {
            if (ModelState.IsValid)
            {
                var db = new QuanLyThuVienEntities();
                var accounts = db.Accounts.FirstOrDefault(x => x.acc.Equals(model.acc));
                ////----------------------------------------------------------------------------------------
                if (accounts != null)
                {
                    accounts =
                        db.Accounts.FirstOrDefault(
                            x => x.pass.Equals(model.pass) && x.acc.Equals(model.acc));
                    if (accounts != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.acc, model.luu);
                        if (Url.IsLocalUrl(model.returnUrl))
                        {
                            return Redirect(model.returnUrl);
                        }
                        return Redirect("/Admin");
                    }
                    ModelState.AddModelError("", "Sai Mật Khẩu");
                }
                else
                {
                    ModelState.AddModelError("", "Sai Tài Khoản");
                }
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Account");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult ChangePass()
        {
            QuanLyThuVienEntities db = new QuanLyThuVienEntities();
            string acc = User.Identity.Name;
            var data = db.Accounts.FirstOrDefault(x => x.acc == acc);
            ChangePassAccountModel model = new ChangePassAccountModel();
            if (data != null)
            {
                model.acc = data.acc;
                model.email = data.email;
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult ChangePass(ChangePassAccountModel model)
        {
            if (ModelState.IsValid)
            {
                QuanLyThuVienEntities db = new QuanLyThuVienEntities();
                var data = db.Accounts.FirstOrDefault(x => x.acc == model.acc && x.pass == model.pass);
                if (data != null)
                {
                    data.pass = model.pass;
                    data.email = model.email;
                    db.SaveChanges();
                    ModelState.AddModelError("", "Thay đổi thành công");
                }
                else
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng");
                }
            }
            return View(model);
        }
    }
}
