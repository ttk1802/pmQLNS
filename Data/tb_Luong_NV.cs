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
    
    public partial class tb_Luong_NV
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public Nullable<double> LCB { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public Nullable<int> Deleteby { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
