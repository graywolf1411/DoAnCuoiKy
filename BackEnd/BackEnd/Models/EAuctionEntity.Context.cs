﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EAuctionEntities : DbContext
    {
        public EAuctionEntities()
            : base("name=EAuctionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BaoCaoViPham> BaoCaoViPhams { get; set; }
        public DbSet<ChiTietPhienDauGia> ChiTietPhienDauGias { get; set; }
        public DbSet<ConNguoi> ConNguois { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<DanhMucAdmin> DanhMucAdmins { get; set; }
        public DbSet<DanhSachQuanTam> DanhSachQuanTams { get; set; }
        public DbSet<DanhSachYeuThich> DanhSachYeuThiches { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<HinhAnhSanPham> HinhAnhSanPhams { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<MoTaSanPham> MoTaSanPhams { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhanLoaiCuaSanPham> PhanLoaiCuaSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ServerDB> ServerDBs { get; set; }
    }
}
