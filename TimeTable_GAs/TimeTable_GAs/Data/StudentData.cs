using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_GAs.Data
{
    public class StudentData
    {
        TimeTableEntities1 db = new TimeTableEntities1();
        public List<HocSinh> Index()
        {
            //  DataGridView dgv = new DataGridView();
            var hs = db.HocSinhs;
            // dgv.DataSource = teacher;
            return hs.ToList();

        }

        public bool Add(string id,string name, ref string err)
        {
            HocSinh hs = new HocSinh();
            hs.MaSV = id;
            hs.TenSV = name;
            db.SaveChanges();
            return true;

        }
        public bool Detele(ref string err, string id)
        {
            var hs = db.HocSinhs.Find(id);
            db.HocSinhs.Remove(hs);
            db.SaveChanges();
            return true;
        }
        public bool Update(string id, string name, ref string err)
        {
            var hs = db.HocSinhs.Find(id);
            hs.TenSV = name;
            db.SaveChanges();

            return true;
        }
        public HocSinh Find(string id)
        {
            var tg = db.HocSinhs.Find(id);
            return tg;
        }
    }
}
