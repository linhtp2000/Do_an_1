using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable_GAs.Model
{
    public class BaiGiang
    {
        public int MaBG { get; set; }
        public ThoiGian ThoiGian { get; set; }
        public Phong Phong { get; set; }
        public MonHoc MonHoc { get; set; }
        public GiaoVien GiaoVien { get; set; }
        public Lop Lop { get; set; }
       // public ICollection<MonHoc> MonHocs { get; set; }
    }
}
