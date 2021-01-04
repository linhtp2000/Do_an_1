using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable_GAs.Data
{
    public interface IDataModel
    {
        List<Phong> Phongs { get; set; }
        List<GiaoVien> GiaoViens { get; set; }
       // List<KhoaHoc> KhoaHocs { get; set; }
        //List<MonHoc> MonHocs { get; set; }
       // List<ThoiGian> ThoiGians { get; set; }
        GiaoVien FindTeacher { get; set; }
        //MonHoc FindSubject { get; set; }

    }
}
