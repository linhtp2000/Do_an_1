using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable_GAs.Model;
using TimeTable_GAs.Services;

namespace TimeTable_GAs.Data
{
    public class Class
    {

        public ThoiKhoaBieuEntities db = new ThoiKhoaBieuEntities();
        public List<BaiGiang> Index()
        {
            // DataGridView dgv = new DataGridView();
            var baigiang = db.BaiGiangs;
            // dgv.DataSource = ct;
            return baigiang.ToList();
        }

        public bool Add(int id, string teacherid, string courseid, string roomid, string studentid, int thu, int start, int end, ref string err)
        {
            BaiGiang bg = new Model.BaiGiang();
            bg.MaBG = id;
            bg.GiaoVien = teacherid;
            bg.MonHoc = courseid;
            bg.Phong = roomid;
            bg.Lop = studentid;
            bg.ThoiGian = thu;

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
        public bool Update(string id, string teacherid, string courseid, string roomid, string studentid, int thu, int start, int end, ref string err)
        {
            var bg = db.BaiGiangs.Find(id);
            bg.GiaoVien = teacherid;
            bg.MonHoc = courseid;
            bg.Phong = roomid;
            bg.Lop = studentid;
            bg.ThoiGian = thu;

            db.SaveChanges();

            return true;
        }
        public BaiGiang Find(string id)
        {
            var bg = db.BaiGiangs.Find(id);
            return bg;
        }
    }
}


