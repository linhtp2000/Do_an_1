using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable_GAs.Model
{
    public enum Buoi { Morning, Afternoon }
    public class ThoiGian
    {
        public int MaTG { get; set; }
        public int Tuan { get; set; }
        public DayOfWeek Thu { get; set; }
        public Buoi Buoi { get; set; }
        public ICollection<BaiGiang> BaiGiangs { get; set; }
    }
}
