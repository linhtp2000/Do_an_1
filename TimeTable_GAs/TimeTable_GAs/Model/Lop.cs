using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable_GAs.Model
{
    public class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public SinhVien SinhVien { get; set; }
        public ICollection<BaiGiang> BaiGiangs { get; set; }
    }
}
