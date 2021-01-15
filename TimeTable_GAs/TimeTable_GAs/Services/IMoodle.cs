using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable_GAs.Model;

namespace TimeTable_GAs.Services
{
    public interface IMoodle
    {
        List<Phong> lPhong { get; }
        List<GiaoVien> lTeachers { get; }
        List<MonHoc>lMonHoc { get; }
        List<Lop> lLop { get; }
        GiaoVien LookupTeacher(string teacherCode);
        MonHoc LookupHold(string holdCode);
        List<ThoiGian> AllTimes();
    }
}
