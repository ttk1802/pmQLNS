﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL_NSEntities : DbContext
    {
        public QL_NSEntities()
            : base("name=QL_NSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BANGCONG_NHANVIEN_CHITIET> BANGCONG_NHANVIEN_CHITIET { get; set; }
        public virtual DbSet<KYCONG> KYCONG { get; set; }
        public virtual DbSet<KYCONGCHITIET> KYCONGCHITIET { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<tb_BaoHiem> tb_BaoHiem { get; set; }
        public virtual DbSet<tb_ChucVu> tb_ChucVu { get; set; }
        public virtual DbSet<tb_HopDong> tb_HopDong { get; set; }
        public virtual DbSet<tb_KhenThuong_KyLuat> tb_KhenThuong_KyLuat { get; set; }
        public virtual DbSet<tb_LoaiCa> tb_LoaiCa { get; set; }
        public virtual DbSet<tb_Luong_NV> tb_Luong_NV { get; set; }
        public virtual DbSet<tb_PhanCong> tb_PhanCong { get; set; }
        public virtual DbSet<tb_PhongBan> tb_PhongBan { get; set; }
        public virtual DbSet<tb_PhuCap> tb_PhuCap { get; set; }
        public virtual DbSet<tb_PhuCap_NhanVien> tb_PhuCap_NhanVien { get; set; }
        public virtual DbSet<tb_TaiKhoan> tb_TaiKhoan { get; set; }
        public virtual DbSet<tb_TangCa> tb_TangCa { get; set; }
        public virtual DbSet<tb_TinhTrangNV> tb_TinhTrangNV { get; set; }
        public virtual DbSet<tb_TrinhDo> tb_TrinhDo { get; set; }
        public virtual DbSet<tb_UngLuong> tb_UngLuong { get; set; }
        public virtual DbSet<tb_BangLuong> tb_BangLuong { get; set; }
    }
}
