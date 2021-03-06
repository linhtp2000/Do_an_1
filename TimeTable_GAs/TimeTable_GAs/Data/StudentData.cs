﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using TimeTable_GAs.Model;
using TimeTable_GAs.Services;

namespace TimeTable_GAs.Data
{
    public class StudentData
    {
        public ThoiKhoaBieuEntities db = new ThoiKhoaBieuEntities();
        public List<SinhVien> Index()
        {
            //  DataGridView dgv = new DataGridView();
            var sv = from sinhvien in db.SinhViens
                     select sinhvien;
            // dgv.DataSource = teacher;
            return sv.ToList();

        }
        //public System.Data.Linq.Table<SinhVien> GetAll()
        //{
        //    DataSet ds = new DataSet();
        //    //SuperMarketDataContext qlHDB = new SuperMarketDataContext();
        //    return db.SinhViens;
        //}

        public bool Add(string id, string name, ref string err)
        {
            Model.SinhVien sv = new Model.SinhVien();
            sv.MaNhomSV = id;
            sv.TenNhomSV = name;
            db.SaveChanges();
            return true;

        }
        public bool Detele(ref string err, string id)
        {
            var sv = db.SinhViens.Find(id);
            db.SinhViens.Remove(sv);
            db.SaveChanges();
            return true;
        }
        public bool Update(string id, string name, ref string err)
        {
            var sv = db.SinhViens.Find(id);
            sv.TenNhomSV = name;
            db.SaveChanges();

            return true;
        }
        public Model.SinhVien Find(string id)
        {
            var tg = (from sv in db.SinhViens
                      where sv.MaNhomSV == id
                      select sv).FirstOrDefault();
            return tg;
        }
    }
}
