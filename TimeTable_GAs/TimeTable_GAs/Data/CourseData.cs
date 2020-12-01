using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_GAs.Data
{
    public class CourseData
    {
        TimeTableEntities1 db = new TimeTableEntities1();
        public List<MonHoc> Index()
        {
            //DataGridView dgv = new DataGridView();
            var course = db.MonHocs;
            //dgv.DataSource = ct;
            return course.ToList();
        }

        public bool Add(string id, string name, ref string err)
        {
            MonHoc course = new MonHoc();
            course.MaMon = id;
            course.TenMon = name;
            db.MonHocs.Add(course);
            db.SaveChanges();
            return true;

        }
        public bool Detele(ref string err, string id)
        {
            var course = db.MonHocs.Find(id);
            db.MonHocs.Remove(course);
            db.SaveChanges();
            return true;
        }
        public bool Update(string id, string name, ref string err)
        {
            var course = db.MonHocs.Find(id);
            //course.MaMon = id;
            course.TenMon = name;
            db.SaveChanges();

            return true;
        }
        public MonHoc Find(string id)
        {
            var course=db.MonHocs.Find(id);
            return course;
        }
    }
}
