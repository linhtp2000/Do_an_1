//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TimeTable_GAs.Model;
//using TimeTable_GAs.Models;

//namespace TimeTable_GAs.Services
//{
//    public class Planner
//    {
//        ThoiKhoaBieuEntities tkb = new ThoiKhoaBieuEntities();
//        public MasterSchema GenerateSchema(IMoodle moodle)
//        {
//            List<SchemaCourse> schemaCourses = new List<SchemaCourse>();
//            List<Phong> allRooms = moodle.lPhong;
//            List<MonHoc> allSubjects = tkb.MonHocs.ToList();
//            List<GiaoVien> allTeachers = tkb.GiaoViens.ToList();
//            List<Lop> allClass = tkb.Lops.ToList();
//            List<ThoiGian> allTimes = tkb.ThoiGians.ToList();

//            List<Khoa> allCourse = new List<Khoa>();

//            //Set all the possible timeslots in all the rooms as free 
//            Dictionary<Phong, List<ThoiGian>> freeRoomTimes = new Dictionary<Phong, List<ThoiGian>>();
//            foreach (Phong r in allRooms)
//            {
//                foreach(ThoiGian tg in allTimes)
//                freeRoomTimes.Add(r, moodle.AllTimes());
//            }

//            //Tim DS GiaoVien theo MonHoc
//            Dictionary<GiaoVien, List<MonHoc>> planSubjectsForTeacher = new Dictionary<GiaoVien, List<MonHoc>>();
//            foreach (GiaoVien t in allTeachers)
//            {
//                foreach (MonHoc m in allSubjects)
//                {
//                    List<MonHoc> listmh = new List<MonHoc>();
//                    if (m.GiaoVien == t.MaGV)
//                    {
//                        listmh.Add(m);
//                    }
//                    planSubjectsForTeacher.Add(t, listmh);
//                }
//            }
//            //Tim DS Monhoc mà các Lop phải học
//            //Dictionary<Lop, List<MonHoc>> planSubjectsForClass = new Dictionary<Lop, List<MonHoc>>();
//            //foreach (Lop c in allClass)
//            //{
//            //    foreach (MonHoc m in allSubjects)
//            //    {
//            //        List<MonHoc> listmh = new List<MonHoc>();
//            //        if (m.SinhVien == c.SinhVien)
//            //        {
//            //            listmh.Add(m);
//            //        }
//            //        planSubjectsForClass.Add(c, listmh);
//            //    }
//            //}

//            //Tim DS GiaoVien co the cua Lop
//            foreach (GiaoVien t in allTeachers)
//            {
//                var lstmon= (from mon in tkb.MonHocs
//                             join gv in tkb.GiaoViens
//                             on mon.GiaoVien equals gv.MaGV
//                             select mon);
//                foreach (var s in lstmon.ToList())
//                {
//                   Khoa course = new Khoa();
//                   course.GiaoVien = t as GiaoVien;
//                   var p = (from lop in tkb.Lops
//                            join mon in tkb.MonHocs
//                            on lop.SinhVien equals mon.SinhVien
//                            select lop.MaLop);
//                    course.MonHoc = s as MonHoc;
//                    //course.MonHoc.MaMon = s.MaMon;
//                    //course.MonHoc.TenMon = s.TenMon;
//                    //course.MonHoc.SoTC = s.SoTC;
//                    //course.MonHoc.SinhVien = s.SinhVien;
//                    //course.MonHoc.SinhVien1 = s.SinhVien1;
//                    if (p.ToList().Count != 0)
//                    {
//                         course.Lop = p as Lop;
//                    }
//                    else { course.Lop = null; }
//                    allCourse.Add(course);                    
//                }
//            }
         
//            //foreach (GiaoVien t in allTeachers)
//            //{
//            //    foreach (MonHoc s in allSubjects)
//            //    {
//            //        if (s.GiaoVien == t.MaGV)
//            //        {
//            //            Khoa course = new Khoa();
//            //            course.GiaoVien = t;
//            //            foreach (MonHoc m in planSubjectsForTeacher[t])
//            //            {
//            //                var p = (from lop in tkb.Lops
//            //                         join mon in tkb.MonHocs
//            //                         on lop.SinhVien equals mon.SinhVien
//            //                         select lop.MaLop);
//            //                course.MonHoc = m;
//            //                if (p.ToList().Count != 0)
//            //                {
//            //                    course.Lops = p as List<Lop>;
//            //                }
//            //            }
//            //            allCourse.Add(course);
//            //        }
//            //    }
//            //} 
//            // make each course into a SchemaCourse, and remove the used lectureTimes from the room
//            foreach (Khoa course in allCourse)
//            {
                
//                    //lay tat ca cac phong co soluong phu hop vs siso cua lop
//                    List<Phong> possibleRooms = FindPossibleRooms(course.Lop, allRooms);

//                    //A possible lecture time must have no teacher clash or hold clash. 
//                    //We already know there is no room clash because we remove the used times from the room.
//                    Dictionary<Phong, List<ThoiGian>> possibleRoomTimes = FindPossibleRoomTimes(schemaCourses, course, freeRoomTimes, possibleRooms);

//                    //Filter the lecturetimes in the room to select only the time
//                    Dictionary<Phong, List<ThoiGian>> possibleRoomTimesFiltered = filterPossibleRoomTimes(possibleRoomTimes, course);

//                    //Select those rooms where the number of possible lecturetimes is enough for the total number of modules in the course
//                    List<Lokale> possibleRoomsWithEnoughLectureTimes = FindPossibleRoomsWithEnoughLectureTimes(possibleRoomTimesFiltered, course);

//                    Lokale selectedRoom;
//                    try
//                    {
//                        // the selected room is the first room on the list
//                        selectedRoom = possibleRoomsWithEnoughLectureTimes.First();
//                    }
//                    catch
//                    {
//                        throw new ExceptionSchemaPlanning(course);
//                    }

//                    //Select a list of lecturetimes to be used in the selected room
//                    List<LectureTime> selectedLectureTimes = SelectLectureTimes(course, possibleRoomTimesFiltered[selectedRoom]);

//                    // create a new SchemaCourse and add it to the list of already planned schemacourses.
//                    schemaCourses.Add(new SchemaCourse() { Course = course, Place = selectedRoom, LectureTimes = selectedLectureTimes });

//                    // remove the used lecturetimes from the selected room.
//                    foreach (LectureTime lt in selectedLectureTimes)
//                    {
//                        freeRoomTimes[selectedRoom].Remove(lt);
//                    }
//                }            
//            return new MasterSchema() { SchemaCourse = schemaCourses };
//        }

//           public List<Phong> FindPossibleRooms(Lop lop , List<Phong> lstPhong)
//            {
//                List<Phong> possibleRooms = new List<Phong>();                
//                foreach (Phong p in lstPhong)
//                {
//                    if (lop.SiSo==p.SoLuong)
//                    {
//                        possibleRooms.Add(p);
//                    }                    
//                }
//                return possibleRooms;
//            }

//            public Dictionary<Phong, List<ThoiGian>> FindPossibleRoomTimes(List<SchemaCourse> planned, Khoa course, Dictionary<Phong,List<ThoiGian>> freeRoomTimes, List<Phong> possibleRooms)
//            {
//                Dictionary<Phong,List<ThoiGian>> possibleRoomTimes = new Dictionary<Phong,List<ThoiGian>>();
//                foreach (var r in possibleRooms)
//                {
//                    possibleRoomTimes[r] = new List<ThoiGian>();

//                    foreach (var lt in freeRoomTimes[r])
//                    {
//                        if (IsPossibleTimeForCourse(planned, course, lt))
//                        {
//                            possibleRoomTimes[r].Add(lt);
//                        }
//                    }
//                }
//                return possibleRoomTimes;
//            }

//            public bool IsPossibleTimeForCourse(List<SchemaCourse> planned, Khoa course, ThoiGian time)
//            {
//            return !TeacherClash(planned, course.GiaoVien, time) && ClassClash(planned, course.Lop, time);                     
//            }

//            public bool TeacherClash(List<SchemaCourse> planned, GiaoVien teacher, ThoiGian time)
//            {
//                bool result = false;
//                foreach (SchemaCourse sc in planned)
//                {
                  
//                    if (sc.Khoa.GiaoVien.MaGV == teacher.MaGV)
//                    {
//                        foreach (ThoiGian tg in sc.LThoiGian)
//                        {
//                            if (tg.MaTG == time.MaTG)
//                                result = true;
//                        }
//                    }
//                }
//                return result;
//            }
//        public bool ClassClash(List<SchemaCourse> planned, Lop clss, ThoiGian time)
//        {
//            bool result = false;
//            foreach (SchemaCourse sc in planned)
//            {

//                if (sc.Khoa.Lop.MaLop == clss.MaLop)
//                {
//                    foreach (ThoiGian tg in sc.LThoiGian)
//                    {
//                        if (tg.MaTG == time.MaTG)
//                            result = true;
//                    }
//                }
//            }
//            return result;
//        }

//        Dictionary<Phong, List<ThoiGian>> filterPossibleRoomTimes(Dictionary<Phong, List<ThoiGian>> PossibleRoomTimes, Khoa course)
//        {
//            Dictionary<Phong,List<ThoiGian>> resultFilteredPossibleRoomTimes = new Dictionary<Phong, List<ThoiGian>>();
//            foreach (var r in PossibleRoomTimes)
//            {
//                string todObj = course.PreferredTimeOfday;
//                resultFilteredPossibleRoomTimes[r.Key] = new List<ThoiGian>();
//                foreach (var lt in r.Value)
//                {
//                    foreach (DayOfWeek prefd in course.PreferredDays)
//                    {
//                        if (prefd.Equals(lt.WeekDay) && lt.TimeOfDay.Equals(todObj))
//                        {
//                            resultFilteredPossibleRoomTimes[r.Key].Add(lt);
//                        }
//                    }
//                }

//            }
//            return resultFilteredPossibleRoomTimes;
//        }

//    }

//}


//Phong phong = TimPhongPhuHop();
//if (phong != null)
//{
//    baigiang.Phong1 = phong;
//    baigiang.Phong = phong.MaPhong;
//    ThoiGian tg = TimThoiGianPhuHop();
//    if (tg != null)
//    {
//        baigiang.ThoiGian1 = tg;
//        baigiang.ThoiGian = tg.MaTG;
//    }    