﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_GAs.Data
{
    public class TeacherData
    {
        TimeTableEntities1 db = new TimeTableEntities1();
        public List<GiaoVien> Index()//(string id)
        {
           //DataGridView dgv = new DataGridView();
            var gv = db.GiaoViens;
           //dgv.DataSource = tkb;
            return gv.ToList();

        }

        public bool Add(string id,string name,string email, ref string err)
        {
            GiaoVien gv = new GiaoVien();
            gv.MaGV = id;
            gv.HoTen = name;
            gv.Email = email;
            db.GiaoViens.Add(gv);
            db.SaveChanges();
            return true;

        }
        public bool Detele(ref string err, string id)
        {
            var gv = db.GiaoViens.Find(id);
            db.GiaoViens.Remove(gv);
            db.SaveChanges();
            return true;
        }
        public bool Update(string id, string name, string email, ref string err)
        { 
            var gv = db.GiaoViens.Find(id);
            gv.HoTen = name;
            gv.Email = email;
            db.SaveChanges();

            return true;
        }
        public GiaoVien Find(string id)
        {
            var gv = db.GiaoViens.Find(id);
            return gv;
        }

    }
}
