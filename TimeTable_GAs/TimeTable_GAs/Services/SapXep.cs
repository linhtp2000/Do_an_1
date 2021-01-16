using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable_GAs.Model;

namespace TimeTable_GAs.Services
{

    public class SapXep
    {
        ThoiKhoaBieuEntities tkb = new ThoiKhoaBieuEntities();
        public static List<BaiGiang> dsBaiGiang = new List<BaiGiang>();
        public static Dictionary<GiaoVien, List<BaiGiang>> SoBuoidayCuaGV = new Dictionary<GiaoVien, List<BaiGiang>>();

        public static List<BaiGiang> test = new List<BaiGiang>();
        static int id = 0;
        public void SapXepTKB()
        {
            List<Phong> allRooms = tkb.Phongs.ToList();
            List<MonHoc> allSubjects = tkb.MonHocs.ToList();
            List<GiaoVien> allTeachers = tkb.GiaoViens.ToList();
            List<Lop> allClass = tkb.Lops.ToList();
            List<ThoiGian> allTimes = tkb.ThoiGians.ToList();

            List<BaiGiang> allCourse = new List<BaiGiang>();

            Dictionary<Lop, List<MonHoc>> dsMonCuaLop = new Dictionary<Lop, List<MonHoc>>();
            Dictionary<MonHoc, List<Phong>> dsPhongCuaMon = new Dictionary<MonHoc, List<Phong>>();
            Dictionary<MonHoc, List<GiaoVien>> dsGVCuaMon = new Dictionary<MonHoc, List<GiaoVien>>();
            Dictionary<Phong, List<ThoiGian>> dsTGCuaPhong = new Dictionary<Phong, List<ThoiGian>>();

            foreach (GiaoVien gv in allTeachers)
            {
                SoBuoidayCuaGV.Add(gv, new List<BaiGiang>());
            }



            //tạo danh sách lớp có môn học và gv phù hợp
            XetMon(allClass, allTeachers);

            //tìm các phòng phù hợp cho các môn của lớp
            XetPhong(allClass, allTeachers);

            //tìm thời gian phù hợp
            XetThoiGian(allClass, allTeachers);

            
            for (int i = 0; i < dsBaiGiang.Count-1; i++)
            {
                if (dsBaiGiang[i].Lop == null || dsBaiGiang[i].MonHoc == null || dsBaiGiang[i].Phong == null || dsBaiGiang[i].ThoiGian == null)
                {
                    test.Add(dsBaiGiang[i]);
                }
                for (int j = i + 1; j < dsBaiGiang.Count; j++)
                {
                    if (dsBaiGiang[i].ThoiGian == dsBaiGiang[j].ThoiGian && dsBaiGiang[i].Lop == dsBaiGiang[j].Lop)
                    {
                        test.Add(dsBaiGiang[i]);
                        test.Add(dsBaiGiang[j]);
                    }
                    if (dsBaiGiang[i].ThoiGian == dsBaiGiang[j].ThoiGian && dsBaiGiang[i].Phong == dsBaiGiang[j].Phong)
                    {
                        test.Add(dsBaiGiang[i]);
                        test.Add(dsBaiGiang[j]);
                    }
                    if (dsBaiGiang[i].ThoiGian == dsBaiGiang[j].ThoiGian && dsBaiGiang[i].GiaoVien == dsBaiGiang[j].GiaoVien)
                    {
                        test.Add(dsBaiGiang[i]);
                        test.Add(dsBaiGiang[j]);
                    }


                   // Kiểm tra trùng tiết học
                    if (dsBaiGiang[i].ThoiGian1.Thu == dsBaiGiang[j].ThoiGian1.Thu && dsBaiGiang[i].ThoiGian1.Buoi == dsBaiGiang[j].ThoiGian1.Buoi)
                    {
                        if (dsBaiGiang[i].Lop == dsBaiGiang[j].Lop || dsBaiGiang[i].GiaoVien == dsBaiGiang[j].GiaoVien || dsBaiGiang[i].Phong == dsBaiGiang[j].Phong)
                        {
                            int h = (int)dsBaiGiang[i].ThoiGian1.TietBD;
                            int k = (int)dsBaiGiang[i].ThoiGian1.TietKT;
                           
                            for (; h <= k; h++)
                            {
                                int m = (int)dsBaiGiang[j].ThoiGian1.TietBD;
                                int n = (int)dsBaiGiang[j].ThoiGian1.TietKT;

                                for (; m <= n; m++)
                                {
                                    if (h == m) test.Add(dsBaiGiang[i]);
                                }
                            }
                        }
                    }

                }
            }
            }


            //foreach (BaiGiang bg in SapXep.dsBaiGiang)
            //{

            //    BaiGiang b = new BaiGiang();
            //    b.MaBG = bg.MaBG;
            //    b.Lop = bg.Lop;
            //    //b.Lop1 = bg.Lop1;
            //    b.MonHoc = bg.MonHoc;
            //   // b.MonHoc1 = bg.MonHoc1;
            //    b.GiaoVien = bg.GiaoVien;
            //   // b.GiaoVien1 = bg.GiaoVien1;
            //    b.Phong = bg.Phong;
            //  //  b.Phong1 = bg.Phong1;
            //    b.ThoiGian = bg.ThoiGian;
            //   // b.ThoiGian1 = bg.ThoiGian1;
            //    tkb.BaiGiangs.Add(b);
            //    tkb.SaveChanges();
            //}

        



        //xét môn
        void XetMon(List<Lop> lstlop, List<GiaoVien> allTeachers)
        {
            //  List<BaiGiang> lstBaiGiang = new List<BaiGiang>();
            for (int i = 0; i < lstlop.Count; i++)
            {
                string s = lstlop[i].SinhVien;
                var lstmon = (from mon in tkb.MonHocs
                                  // join lop in tkb.Lops
                                  // on mon.SinhVien equals lop.SinhVien
                              where mon.SinhVien == s
                              select mon).ToList();
                //Dictionary<MonHoc, GiaoVien> dsgvcuamon = new Dictionary<MonHoc, GiaoVien>();
               // int temp = 0;
                for (int j = 0; j < lstmon.Count; j++)
                {
                    GiaoVien r = TimGVPhuHop(lstlop[i], lstmon[j]);
                    if (r != null)
                    {
                        BaiGiang baigiang = new BaiGiang();
                        baigiang.MaBG = id;
                        id++;
                        baigiang.Lop = lstlop[i].MaLop;
                        baigiang.Lop1 = lstlop[i];
                        baigiang.MonHoc1 = lstmon[j];
                        baigiang.MonHoc = lstmon[j].MaMon;
                        baigiang.GiaoVien1 = r;
                        baigiang.GiaoVien = r.MaGV;
                        dsBaiGiang.Add(baigiang);
                    }
                    //else
                    //{
                    //    //xét lại môn
                    //    temp++;
                    //    dsBaiGiang.RemoveAt(dsBaiGiang.Count - 1);
                    //    j--;
                    //}
                    //if (temp > 100)
                    else
                    {
                        ////xét lại lớp
                        //List<BaiGiang> t = dsBaiGiang.FindAll(b => b.Lop == lstlop[i].MaLop);
                        //foreach (BaiGiang item in t)
                        //{
                        //    dsBaiGiang.Remove(item);
                        //}
                        //i--;
                        //break;
                        //xét lại lớp
                        //List<BaiGiang> t = dsBaiGiang.FindAll(b => b.Lop == lstlop[i].MaLop);
                        dsBaiGiang.Clear();
                        XetMon(lstlop, allTeachers);
                        return;
                    }

                }
            }
            //ràng buộc mỗi giáo viên phải dạy ít nhất 1 buổi
            foreach (GiaoVien gv in allTeachers)
            {
                if (SoBuoidayCuaGV[gv].Count < 1)
                {
                    //bỏ tất cả các bài giảng đã xét
                    dsBaiGiang.Clear();
                    //xét lại các bài giảng
                    XetMon(lstlop, allTeachers);
                }
            }
            return;
        }

        //xét phòng
        void XetPhong(List<Lop> allClass, List<GiaoVien> allTeachers)
        {
            // List<BaiGiang> lstBaiGiang = new List<BaiGiang>();
            //int temp = 0;
            for (int i = 0; i < dsBaiGiang.Count; i++)
            {
                int sl = (int)dsBaiGiang[i].Lop1.SiSo;
                var lstp = (from p in tkb.Phongs
                            where p.SoLuong >= sl
                            select p).ToList();
                //Dictionary<MonHoc, GiaoVien> dsgvcuamon = new Dictionary<MonHoc, GiaoVien>();

                Phong r = TimPhongPhuHop(dsBaiGiang[i], lstp);
                if (r != null)
                {
                    dsBaiGiang[i].Phong1 = r;
                    dsBaiGiang[i].Phong = r.MaPhong;
                }
                else
                {
                    //xét lại phòng của bài giảng trước
                    // temp++;
                    for (int j = 0; j < dsBaiGiang.Count; j++)
                    {
                        dsBaiGiang[j].Phong1 = null;
                        dsBaiGiang[j].Phong = null;
                    }
                    XetPhong(allClass, allTeachers);
                    return; ;
                    //dsBaiGiang[i - 1].Phong1 = new Phong();
                    //dsBaiGiang[i - 1].Phong = null;
                    //i--;
                }
                //if (temp > 100)
                //{
                //    dsBaiGiang.Clear();
                //    XetMon(allClass, allTeachers);
                //    XetPhong(allClass, allTeachers);
                //}
            }

            return;
        }

        //xét thời gian
        void XetThoiGian(List<Lop> allClass, List<GiaoVien> allTeachers)
        {
            // List<BaiGiang> lstBaiGiang = new List<BaiGiang>();
           // int temp = 0;
            for (int i = 0; i < dsBaiGiang.Count; i++)
            {
                var lsttg = (from t in tkb.ThoiGians
                             select t).ToList();
                //Dictionary<MonHoc, GiaoVien> dsgvcuamon = new Dictionary<MonHoc, GiaoVien>();

                ThoiGian r = TimTGPhuHop(dsBaiGiang[i], lsttg);
                if (r != null)
                {
                    dsBaiGiang[i].ThoiGian1 = r;
                    dsBaiGiang[i].ThoiGian = r.MaTG;
                  //  temp++;
                }
                else
                {
                    //xét lại phòng của bài giảng trước
                   // temp++;
                    for(int j=0;j<dsBaiGiang.Count;j++) 
                    {
                        dsBaiGiang[j].ThoiGian1 = null;
                        dsBaiGiang[j].ThoiGian = null;
                    }
                       XetThoiGian(allClass, allTeachers);
                    return;
                }
                //if (temp > 200)
                //{
                //    foreach (BaiGiang g in dsBaiGiang)
                //    {
                //        g.Phong1 = new Phong();
                //        g.Phong = null;
                //        g.ThoiGian1 = new ThoiGian();
                //        g.ThoiGian = null;
                //    }
                //    XetPhong(allClass, allTeachers);
                //    XetThoiGian(allClass, allTeachers);
                //    return;
                //}
            }

            if (dsBaiGiang.Exists(b => b.ThoiGian == null))
            {
                foreach (BaiGiang g in dsBaiGiang)
                    {
                        g.Phong1 = new Phong();
                        g.Phong = null;
                        g.ThoiGian1 = new ThoiGian();
                        g.ThoiGian = null;
                    }
                    XetPhong(allClass, allTeachers);
                    XetThoiGian(allClass, allTeachers);
                    return;
         
            }
        }
      
        ThoiGian TimTGPhuHop(BaiGiang baigiang, List<ThoiGian> lstthoigian)
        {

            Random r = new Random();
            int index = r.Next(lstthoigian.Count);
            List<int> temp = new List<int>();
            temp.Add(index);
            while (!KTTGPhuHop(baigiang, lstthoigian[index]))
            {
                index = r.Next(lstthoigian.Count);
                if (!temp.Contains(index))
                {
                    temp.Add(index);
                }
                if (temp.Count == lstthoigian.Count)
                {
                    return null;
                }
            }

            return lstthoigian[index];
        }

        //kiểm tra xem buổi có phù hợp hay không
        bool KTTGPhuHop(BaiGiang bg, ThoiGian time)
        {
            //kiểm tra xem cùng khoảng thời gian, cùng phòng gv có dạy môn nào khác chưa
            //if (dsBaiGiang.Exists(b => (b.ThoiGian == time.MaTG && b.Lop == bg.Lop)|| 
            //                      (b.ThoiGian == time.MaTG && b.Phong == bg.Phong)||
            //                      (b.ThoiGian == time.MaTG && b.GiaoVien == bg.GiaoVien)))
            //{
            //    return false;
            //}
            if (dsBaiGiang.Find(b => (b.ThoiGian == time.MaTG && b.Lop == bg.Lop)) != null)
            {
                return false;
            }
            if (dsBaiGiang.Find((b => b.ThoiGian == time.MaTG && b.Phong == bg.Phong)) != null)
            {
                return false;
            }
            if (dsBaiGiang.Find(b => (b.ThoiGian == time.MaTG && b.GiaoVien == bg.GiaoVien)) != null)
            {
                return false;
            }

            int t = (int)(time.TietKT - time.TietBD + 1);

            //xét số tiets học của môn theo tín chỉ của môn
            if (t < bg.MonHoc1.SoTC)
            {
                return false;
            }

            //Kiểm tra trùng tiết học
           var lst = dsBaiGiang.FindAll(b => b.ThoiGian != null).ToList();
            if (lst.Count!=0)
            {
               // List<BaiGiang> ds = new List<BaiGiang>();
               var ds = lst.FindAll(b => (b.ThoiGian1.Thu == time.Thu && b.ThoiGian1.Buoi == time.Buoi)).ToList();
                foreach (BaiGiang i in ds)
                {
                    if (i.Lop == bg.Lop || i.GiaoVien == bg.GiaoVien || i.Phong == bg.Phong)
                    {
                        int j = (int)i.ThoiGian1.TietBD;
                        int k = (int)i.ThoiGian1.TietKT;
                       
                        for (; j <= k; j++)
                        {
                            int m = (int)time.TietBD;
                            int n = (int)time.TietKT;
                            for (; m <= n; m++)
                            {
                                if (j == m) return false;
                            }
                        }
                    }
                }
            }

            return true;
        }


        //tìm giáo viên dạy môn đang xét cho lớp hiện tại
        GiaoVien TimGVPhuHop(Lop lop, MonHoc mon)
        {
            GiaoVien gv = new GiaoVien();
            BaiGiang bg = new BaiGiang();
            bg.Lop = lop.MaLop;
            bg.MonHoc = mon.MaMon;
            var ds = (from m in tkb.MonHocs
                      where m.MaMon == mon.MaMon
                      select m.GiaoVien1).ToList();
            Random r = new Random();
            int index = r.Next(ds.Count);
            List<int> temp = new List<int>();
            temp.Add(index);
            while (!KTGVPhuHop(ds[index]))
            {
                index = r.Next(ds.Count);
                if (!temp.Contains(index))
                {
                    temp.Add(index);
                }
                if (temp.Count == ds.Count)
                {
                    return null;
                }
            }
            bg.GiaoVien = ds[index].MaGV;
            bg.GiaoVien1 = ds[index];
            SoBuoidayCuaGV[ds[index]].Add(bg);

            return ds[index];
        }
        //Một gv chỉ dạy tối đa 15 buổi/ tuần
        bool KTGVPhuHop(GiaoVien teacher)
        {
            //kiểm tra xem cùng khoảng thời gian, cùng phòng gv có dạy môn nào khác chưa
            int sl = SoBuoidayCuaGV[teacher].Count;
            if (sl < 15) return true;
            return false;
        }

        //tìm Phòng phù hợp
        Phong TimPhongPhuHop(BaiGiang baigiang, List<Phong> lstphong)
        {

            Random r = new Random();
            int index = r.Next(lstphong.Count);
            List<int> temp = new List<int>();
            temp.Add(index);
            while (!KTPhongPhuHop(baigiang, lstphong[index]))
            {
                index = r.Next(lstphong.Count);
                if (!temp.Contains(index))
                {
                    temp.Add(index);
                }
                if (temp.Count == lstphong.Count)
                {
                    return null;
                }
            }

            return lstphong[index];
            //List<Phong> lstPhongCoThe = new List<Phong>();
            //    foreach (Phong p in lstphong)
            //    {
            //        if (!ds.ToList().Contains(p)&&p.SoLuong==lop.SiSo)
            //        {                   
            //            lstPhongCoThe.Add(p);
            //        }
            //    }
            //    for(int i=0;i<lstPhongCoThe.Count;i++)
            //        if(KTPhongPhuHop(mon,lop,teacher,lstPhongCoThe[i]))
            //        {
            //            return lstPhongCoThe[i];
            //        }
            //    return null;
        }
        //kiểm tra xem phòng có phu hợp không
        bool KTPhongPhuHop(BaiGiang baigiang, Phong phong)
        {
            //kiểm tra xem cùng khoảng thời gian, cùng phòng gv có dạy môn nào khác chưa
            //var i = (from bg in tkb.BaiGiangs
            //         where (bg.Lop != lop.MaLop && bg.Phong == room.MaPhong) ||
            //               (bg.GiaoVien != teacher.MaGV && bg.Phong == room.MaPhong)                         
            //         select bg).FirstOrDefault();
            if (baigiang.Lop1.SiSo <= phong.SoLuong) return true;
            return false;
        }

    }
}
