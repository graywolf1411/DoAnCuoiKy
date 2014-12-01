using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BackEnd
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "lienhe",
                url: "lien-he/",
                defaults: new { controller = "LienHe", action = "Index" },
                namespaces: new[] { "BackEnd.Areas.Main.Controllers" }
            ).DataTokens.Add("Area", "Main");

            routes.MapRoute(
                name: "hoatdong",
                url: "hoat-dong/{danhmuc}",
                defaults: new { controller = "HoatDong", action = "Index", danhmuc = UrlParameter.Optional },
                namespaces: new[] { "BackEnd.Areas.Main.Controllers" }
            ).DataTokens.Add("Area", "Main");

            //routes.MapRoute(
            //    name: "detailhoatdong",
            //    url: "hoat-dong/{danhmuc}/{hoatdong}",
            //    defaults: new { controller = "SanPham", action = "Detail", danhmuc = UrlParameter.Optional, hoatdong = UrlParameter.Optional },
            //    namespaces: new[] { "ThietBiYTe.Areas.Main.Controllers" }
            //).DataTokens.Add("Area", "Main");

            routes.MapRoute(
                name: "sanpham",
                url: "san-pham/{danhmuc}",
                defaults: new { controller = "SanPham", action = "Index", danhmuc = UrlParameter.Optional, danhmuccon = UrlParameter.Optional },
                namespaces: new[] { "BackEnd.Areas.Main.Controllers" }
            ).DataTokens.Add("Area", "Main");

            routes.MapRoute(
                name: "detailsanpham",
                url: "san-pham/{danhmuc}/{sanpham}",
                defaults: new { controller = "SanPham", action = "Detail", danhmuc = UrlParameter.Optional, sanpham = UrlParameter.Optional },
                namespaces: new[] { "BackEnd.Areas.Main.Controllers" }
            ).DataTokens.Add("Area", "Main");

            routes.MapRoute(
                name: "tintuc",
                url: "tin-tuc/{danhmuc}",
                defaults: new { controller = "TinTuc", action = "Index", danhmuc = UrlParameter.Optional },
                namespaces: new[] { "BackEnd.Areas.Main.Controllers" }
            ).DataTokens.Add("Area", "Main");

            routes.MapRoute(
                name: "detailtintuc",
                url: "tin-tuc/{danhmuc}/{tintuc}",
                defaults: new { controller = "TinTuc", action = "Detail", danhmuc = UrlParameter.Optional, tintuc = UrlParameter.Optional },
                namespaces: new[] { "BackEnd.Areas.Main.Controllers" }
            ).DataTokens.Add("Area", "Main");

            routes.MapRoute(
                name: "gioithieu",
                url: "gioi-thieu",
                defaults: new { controller = "GioiThieu", action = "Index" },
                namespaces: new[] { "BackEnd.Areas.Main.Controllers" }
            ).DataTokens.Add("Area", "Main");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "BackEnd.Areas.Admin.Controllers" }
            ).DataTokens.Add("Area", "Admin");
        }
    }
}