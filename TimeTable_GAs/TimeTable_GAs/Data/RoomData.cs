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
    public class RoomData
    {
        public ThoiKhoaBieuEntities db = new ThoiKhoaBieuEntities();
        public List<Model.Phong> Index()
        {
            // DataGridView dgv = new DataGridView();
            var room = db.Phongs;
            // dgv.DataSource = room;
            return room.ToList();
        }

        public bool Add(string id, string name, int capacity, ref string err)
        {
            Model.Phong room = new Model.Phong();
            room.MaPhong = id;
            room.TenPhong = name;
            room.SoLuong = capacity;
            db.Phongs.Add(room);
            db.SaveChanges();
            return true;

        }
        public bool Detele(ref string err, string id)
        {
            var room = db.Phongs.Find(id);
            db.Phongs.Remove(room);
            db.SaveChanges();
            return true;
        }
        public bool Update(string id, string name, int capacity, ref string err)
        {
            var room = db.Phongs.Find(id);
            room.TenPhong = name;
            room.SoLuong = capacity;
            db.SaveChanges();

            return true;
        }
        public Model.Phong Find(string id)
        {
            return db.Phongs.FirstOrDefault(r => r.MaPhong == id);
            // return room;
        }
    }
}
