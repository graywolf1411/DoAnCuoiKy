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
    
    public partial class BaoCaoViPham
    {
        public int IDBaoCaoViPham { get; set; }
        public Nullable<int> MaNguoiBaoCao { get; set; }
        public Nullable<int> MaNguoiBiBaoCao { get; set; }
        public Nullable<int> MaSanPhamBiBaoCao { get; set; }
        public string NoiDungViPham { get; set; }
        public Nullable<int> MaNhanVienDuyet { get; set; }
        public Nullable<int> KetQuaDuyet { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> NguonDB { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual KhachHang KhachHang1 { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual ServerDB ServerDB { get; set; }
    }
}