//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tb_KhenThuong_KyLuat
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public string SOKTKL { get; set; }
        public Nullable<int> Ngay { get; set; }
        public Nullable<int> Thang { get; set; }
        public string Loai { get; set; }
        public Nullable<double> SoTien { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Deleteby { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
