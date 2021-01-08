using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable_GAs.Model
{
    public class MonHoc
    {
        [Key]
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoTC { get; set; }
        public SinhVien SinhVien { get; set; }
        public ICollection<GiaoVien> GiaoViens { get; set; }
        public ICollection<BaiGiang> BaiGiangs { get; set; }

        // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        // public virtual ICollection<KhoaHoc> Lectures { get; set; }
    }
}
