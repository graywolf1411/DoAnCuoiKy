//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Barcode_Of_Reader_Card
    {
        public string MaDocGia { get; set; }
        public string BarcodeName { get; set; }
        public string BarcodePath { get; set; }
    
        public virtual DocGia DocGia { get; set; }
    }
}
