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
    
    public partial class tb_BaoHiem
    {
        public int IDBH { get; set; }
        public string MaNV { get; set; }
        public string SoBH { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string NoiKhamBenh { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}