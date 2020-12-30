//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TimeTable_GAs.Model
//{
//    public class Class
//    {
//        private static int count = 0;
//        private MonHoc course;
//        private GiaoVien teacher;
//        private HocSinh student;
//        private Phong allowedRoom;
//        private string name;
//        private int id;
//        private DayOfWeek day;
//        private int classstart = 0;

//        public Class(int id)
//        {
//            ID = new SimpleIntegerProperty(id);
//        }

//        public Class(Course course, String type, Instructor instructor, StudentsGroup studentGroup, Room allowedRoom)
//        {
//            this.course = course;
//            this.type = new SimpleStringProperty(type);
//            this.instructor = instructor;
//            this.studentGroup = studentGroup;
//            this.allowedRoom = allowedRoom;
//            ID = new SimpleIntegerProperty(count++);
//        }


//        public void setDay(String day)
//        {
//            this.day.set(day);
//        }

//        public StringProperty classDay()
//        {
//            return day;
//        }

//        public void setPeriod(int period)
//        {
//            this.period.set(period);
//        }

//        public IntegerProperty classPeriod()
//        {
//            return period;
//        }

//        public void setAllowedRoom(Room room)
//        {
//            this.allowedRoom = room;
//        }

//        public StringProperty className()
//        {
//            return new SimpleStringProperty(this.toString());
//        }

//        @Override
//    public String toString()
//        {
//            String str = "";
//            try
//            {

//                str = getID() + "_" + studentGroup.toString() + "_" + course.getCode() + "_ " + course.getName();
//            }
//            catch (NullPointerException e)
//            {
//                str = "Empty";
//            }
//            return str;

//        }

//        public Course getCourse()
//        {
//            return course;
//        }

//        public boolean isAllowedRoom(int roomID)
//        {
//            return allowedRoom.getID() == roomID;
//        }

//        public Instructor getInstructor()
//        {
//            return instructor;
//        }

//        public StudentsGroup getStudentGroup()
//        {
//            return studentGroup;
//        }

//        public int getID()
//        {
//            return ID.get();
//        }

//        public IntegerProperty classID()
//        {
//            return ID;
//        }

//        public StringProperty classGroup()
//        {
//            return studentGroup.groupName();
//        }

//        public StringProperty classType()
//        {
//            return type;
//        }

//        public StringProperty classCourse()
//        {
//            return new SimpleStringProperty(course.getName() + " " + course.getCode());
//        }

//        public StringProperty classInstructor()
//        {
//            return instructor.instructorName();
//        }

//        public StringProperty classRoom()
//        {
//            return allowedRoom.roomName();
//        }
//    }
//}
