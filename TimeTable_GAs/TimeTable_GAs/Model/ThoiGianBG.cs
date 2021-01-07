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
        public int Tuan { get; set; }
        public DayOfWeek NgayTrongTuan { get; set; }
        public Buoi Buoi { get; set; }
    }
}
