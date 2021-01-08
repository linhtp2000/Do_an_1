using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable_GAs.Model
{
    public class SinhVien
    {
        public string MaNhomSV { get; set; }
        public string TenNhomSV { get; set; }
        public ICollection<MonHoc> MonHocs { get; set; }
        public ICollection<Lop> Lops { get; set; }
    }
}
