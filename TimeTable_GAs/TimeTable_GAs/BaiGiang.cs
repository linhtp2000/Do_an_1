//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeTable_GAs
{
    using System;
    using System.Collections.Generic;
    
    public partial class BaiGiang
    {
        public string MaBG { get; set; }
        public string MaSV { get; set; }
        public string MaMon { get; set; }
        public string MaGV { get; set; }
        public string MaPhong { get; set; }
        public Nullable<int> Tuan { get; set; }
        public DayOfWeek Thu { get; set; }
        public Nullable<int> TietBatDau { get; set; }
        public Nullable<int> TietKetThuc { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        public virtual Phong Phong { get; set; }
        public virtual HocSinh HocSinh { get; set; }
    }
}