using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable_GAs.Models;

namespace TimeTable_GAs.Model
{
    public class KhoaHoc
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public MonHoc MaMon { get; set; }
        public GiaoVien MaGV { get; set; }
        public List<DayOfWeek> LNgayDay { get; set; }
        public TimeOfDay BuoiDay { get; set; }
    }
}
