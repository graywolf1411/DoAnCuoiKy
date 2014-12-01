using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd.Areas.Admin.Models
{
    public class MuonSachModel
    {
        public string madocgia { get; set; }

        public string hoten { get; set; }

        public string gioitinh { get; set; }

        public string donvi { get; set; }

        public string nhande { get; set; }

        public string tacgia { get; set; }

        public DateTime? ngaymuon { get; set; }

        public DateTime? ngaytra { get; set; }

    }
}