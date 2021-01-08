using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable_GAs.Model
{
    public class GiaoVien
    {
        [Key]
        public string MaGV { get; set; }
        public string TenGV { get; set; }
        public string Email { get; set; }
        public MonHoc MonHoc { get; set; }
        public ICollection<BaiGiang> BaiGiangs { get; set; }

        // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        // public virtual ICollection<KhoaHoc> Lectures { get; set; }
    }
}
