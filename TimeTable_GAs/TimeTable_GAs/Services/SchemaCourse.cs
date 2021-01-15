using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable_GAs.Model;

namespace TimeTable_GAs.Models
{
    //list thời gian 1 môn nào đó được dạy ở một phòng
    public class SchemaCourse
    {
        // public KhoaHoc KhoaHoc { get; set; }
        //public MonHoc MonHoc { get; set; }
        //public GiaoVien GiaoVien { get; set; }
        public Phong Phong { get; set; }
        public Khoa Khoa { get; set; }
        //public List<Lop> Lops { get; set; }
        public List<ThoiGian> LThoiGian { get; set; }
    }
    public class Khoa
    {
        // public KhoaHoc KhoaHoc { get; set; }
      
        public GiaoVien GiaoVien { get; set; }
        public MonHoc MonHoc { get; set; }
        public Lop Lop { get; set; }
      //  public List<Lop> Lops { get; set; }
      //  public List<ThoiGian> LThoiGian { get; set; }
    }
}
