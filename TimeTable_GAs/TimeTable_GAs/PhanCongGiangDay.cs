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
    
    public partial class PhanCongGiangDay
    {
        public string MaGiaoVien { get; set; }
        public string MaLop { get; set; }
        public string MaMon { get; set; }
        public string MaThu { get; set; }
        public Nullable<int> ThoiLuong { get; set; }
        public Nullable<int> TietBatDau { get; set; }
        public Nullable<int> TietKetThuc { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
        public virtual Lop Lop { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        public virtual Thu Thu { get; set; }
    }
}