using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable_GAs.Model;
namespace TimeTable_GAs.Data
{
    public class CourseData
    {
        public ThoiKhoaBieuEntities db = new ThoiKhoaBieuEntities();
        //public CourseData(ThoiKhoaBieuEntities db)
        //{
        //    this.db = db;
        // }
        public List<MonHoc> Index()
        {
            return (List<MonHoc>)(from gv in db.GiaoViens
                   orderby gv.HoTen
                   select gv);
            ////DataGridView dgv = new DataGridView();
            //var course = db.MonHocs;
            ////dgv.DataSource = ct;
            //return course.ToList();
        }

        public bool Add(string id, string name, ref string err)
        {
            Model.MonHoc course = new Model.MonHoc();
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
        public Model.MonHoc Find(string id)
        {
            var course = db.MonHocs.Find(id);
            return course;
        }
    }
}
