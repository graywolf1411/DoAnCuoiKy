//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanhSachQuanTam
    {
        public int IDDSQuanTam { get; set; }
        public Nullable<int> MaKhachHang { get; set; }
        public Nullable<int> MaSanPham { get; set; }
        public Nullable<int> MaPhienDauGia { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> NguonDB { get; set; }
    
        public virtual ChiTietPhienDauGia ChiTietPhienDauGia { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual ServerDB ServerDB { get; set; }
    }
}
