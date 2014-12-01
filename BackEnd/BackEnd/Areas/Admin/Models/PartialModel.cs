using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd.Areas.Admin.Models
{
    public class ListItemlModel
    {
        public SelectList listitem { get; set; }

        public string value { get; set; }

        public string danhmuccon { get; set; }
    }
}