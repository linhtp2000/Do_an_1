using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_GAs.Data
{
    public class Class
    {

        TimeTableEntities1 db = new TimeTableEntities1();
        public List<BaiGiang> Index()
        {
           // DataGridView dgv = new DataGridView();
            var baigiang= db.BaiGiangs;
           // dgv.DataSource = ct;
            return baigiang.ToList();
       }    

        public bool Add(string id, string teacherid,string courseid,string roomid, string studentid,DayOfWeek thu,int start, int end,ref string err)
        {
            BaiGiang bg = new BaiGiang();
            bg.MaBG = id;
            bg.MaGV = teacherid;
            bg.MaMon = courseid;
            bg.MaPhong = roomid;
            bg.MaSV = studentid;
            bg.Thu = thu;
            bg.TietBatDau = start;
            bg.TietKetThuc = end;
            db.BaiGiangs.Add(bg);
            db.SaveChanges();
            return true;

        }
        public bool Detele(ref string err, string id)
        {
            var bg = db.BaiGiangs.Find(id);
            db.BaiGiangs.Remove(bg);
            db.SaveChanges();
            return true;
        }
        public bool Update(string id, string teacherid, string courseid, string roomid, string studentid, DayOfWeek thu, int start, int end, ref string err)
        {
            var bg = db.BaiGiangs.Find(id);
            bg.MaGV = teacherid;
            bg.MaMon = courseid;
            bg.MaPhong = roomid;
            bg.MaSV = studentid;
            bg.Thu = thu;
            bg.TietBatDau = start;
            bg.TietKetThuc = end;
            db.SaveChanges();

            return true;
        }
        public BaiGiang Find( string id)
        {
            var bg = db.BaiGiangs.Find(id);
            return bg;
        }
    }
}


