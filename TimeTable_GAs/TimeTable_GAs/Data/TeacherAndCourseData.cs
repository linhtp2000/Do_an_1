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
    public class TeacherAndCourseData
    {
        public ThoiKhoaBieuEntities db = new ThoiKhoaBieuEntities();
        public List<Model.GiaoVien_Mon> Index()//(string id)
        {
            //DataGridView dgv = new DataGridView();
            var gv = db.GiaoVien_Mon;
            //dgv.DataSource = tkb;
            return gv.ToList();

        }

        public bool Add(string id,string name,string email, ref string err)
        {
            Model.GiaoVien_Mon gv = new Model.GiaoVien_Mon();
            gv.MaGV = id;
            gv.HoTen = name;
            gv.Email = email;
            db.GiaoVien_Mon.Add(gv);
            db.SaveChanges();
            return true;

        }
        public bool Detele(ref string err, string id)
        {
            var gv = db.GiaoVien_Mon.Find(id);
            db.GiaoVien_Mon.Remove(gv);
            db.SaveChanges();
            return true;
        }
        public bool Update(string id, string name, string email, ref string err)
        { 
            var gv = db.GiaoVien_Mon.Find(id);
            gv.HoTen = name;
            gv.Email = email;
            db.SaveChanges();

            return true;
        }
        public Model.GiaoVien_Mon Find(string id)
        {
            var gv = db.GiaoVien_Mon.Find(id);
            return gv;
        }

    }
}
