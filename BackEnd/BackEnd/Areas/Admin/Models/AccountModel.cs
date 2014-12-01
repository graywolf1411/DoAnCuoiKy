using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BackEnd.Areas.Admin.Models
{
    public class AccountModel
    {
        public string acc { get; set; }

        public string pass { get; set; }

        public bool luu { get; set; }

        public string returnUrl { get; set; }
    }

    public class ChangePassAccountModel
    {
        public string acc { get; set; }

        [Required(ErrorMessage ="Mật khẩu hiện tại không được để trống")]
        public string passcuren { get; set; }

        [Required(ErrorMessage = "Mật khẩu mới không được để trống")]
        public string pass { get; set; }

       //[Compare("pass", ErrorMessage = "Nhập lại mật khẩu không  đúng")]
        public string pass2 { get; set; }

        //[RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email không đúng")]
        public string email { get; set; }

    }
}