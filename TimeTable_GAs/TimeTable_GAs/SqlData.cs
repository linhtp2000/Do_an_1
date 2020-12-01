using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable_GAs.Data;

namespace TimeTable_GAs
{
    public class SqlData: IDataModel
    {
        public List<Phong> Rooms
        {
            get
            {
                RoomData r = new RoomData();
                return r.Index();         
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<GiaoVien> Teachers
        {
            get
            {
                TeacherData t = new TeacherData();
                return t.Index();
            }
        }


        ///
        ///
        public List<MonHoc> Subjects
        {
            get
            {
               SubjectData s = new SubjectData();
                return s.Index();
            }
        }

        public List<KhoaHoc> Courses
        {
            get
            {
               CourseData c = new CourseData();
                return c.Index();
            }
        }

        public GiaoVien LookupTeacher(string id)
        {
            TeacherData t = new TeacherData();
            return t.Find(id);
        }


        public MonHoc LookupSubject(string id)
        {
            SubjectData m = new SubjectData();
            return m.Find(id);
        }

        // generate all combinations of weeks from 1 to 20, days from Monday to Friday and daytimes from morning to afternoon
        public List<ThoiGian> AllTimes()
        {
            get
            {
                StudentData t = new StudentData();
                return t.Index();
            };
        }
    }
}
