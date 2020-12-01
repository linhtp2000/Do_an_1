using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable_GAs.Data;

namespace TimeTable_GAs
{
    public class Planner
    {
        TimeTableEntities db = new TimeTableEntities();
             
        public List<ThoiKhoaBieu> Generate(IDataModel model)
        {
            List<ThoiKhoaBieu> schedule = new List<ThoiKhoaBieu>();
            List<Phong> allRooms = model.Phongs;

            //Set all the possible timeslots in all the rooms as free 
            Dictionary<Phong, List<ThoiGian>> freeRoomTimes = new Dictionary<Phong, List<ThoiGian>>();
            foreach (Phong r in allRooms )
            {
               
                freeRoomTimes.Add(r, model.ThoiGians);
            }

            // make each course into a SchemaCourse, and remove the used lectureTimes from the room
            foreach (ChuongTrinh ct in model.ChuongTrinhs)
            {
                // Get all the rooms with sufficient capacity, based on the total number of students taking the course
                List<Phong> possibleRooms = FindPossibleRooms(ct, allRooms);

                //A possible lecture time must have no teacher clash or hold clash. 
                //We already know there is no room clash because we remove the used times from the room.
                Dictionary<Phong, List<ThoiGian>> possibleRoomTimes = FindPossibleRoomTimes(schedule, ct, freeRoomTimes, possibleRooms);

                //Filter the lecturetimes in the room to select only the preferred day(s)/time
                Dictionary<Phong, List<ThoiGian>> possibleRoomTimesFiltered = filterPossibleRoomTimes(possibleRoomTimes, ct);

                //Select those rooms where the number of possible lecturetimes is enough for the total number of modules in the course
                List<Phong> possibleRoomsWithEnoughLectureTimes = FindPossibleRoomsWithEnoughLectureTimes(possibleRoomTimesFiltered, ct);

                Phong selectedRoom;
                try
                {
                    // the selected room is the first room on the list
                    selectedRoom = possibleRoomsWithEnoughLectureTimes.First();
                }

                catch
                {
                    throw new ExceptionPlanning(ct);
                }

                //Select a list of lecturetimes to be used in the selected room
                List<ThoiGian> selectedLectureTimes = SelectLectureTimes(ct, possibleRoomTimesFiltered[selectedRoom]);

                // create a new SchemaCourse and add it to the list of already planned schemacourses.
                schedule.Add(new ThoiKhoaBieu() { Course = course, Place = selectedRoom, LectureTimes = selectedLectureTimes });

                // remove the used lecturetimes from the selected room.
                foreach (LectureTime lt in selectedLectureTimes)
                {
                    freeRoomTimes[selectedRoom].Remove(lt);
                }
            }
            return new MasterSchema() { SchemaCourse = schemaCourses };
        }


        /// <summary>
        ///method for choosing the rooms where the lecturetimes >= number of modules in the course   
        /// </summary>
        /// <param name="possibleRoomTimesFiltered">a list of the preferred lecturetimes</param>
        /// <param name="course">the current course to be scheduled</param>
        /// <returns>a list of Rooms</returns>
        public List<Lokale> FindPossibleRoomsWithEnoughLectureTimes(Dictionary<Lokale, List<LectureTime>> possibleRoomTimesFiltered, Kursus course)
        {
            List<Lokale> possibleRoomWithEnoughLectureTimes = new List<Lokale>();
            int numberOfModules = course.ModuleCount;

            foreach (var r in possibleRoomTimesFiltered)
            {
                if (r.Value.Count >= numberOfModules)
                {
                    possibleRoomWithEnoughLectureTimes.Add(r.Key);
                }
            }
            return possibleRoomWithEnoughLectureTimes;
        }


        /// <summary>
        /// Select a list of lecturetimes to be used
        /// </summary>
        /// <param name="course">the current course to be scheduled</param>
        /// <param name="possibleLectureTimes">a list of lecturetimes</param>
        /// <returns>a list of lecturetimes</returns>
        public List<LectureTime> SelectLectureTimes(Kursus course, List<LectureTime> possibleLectureTimes)
        {
            int lectureCount = course.ModuleCount;
            List<LectureTime> listToReturn = new List<LectureTime>();
            listToReturn = possibleLectureTimes.Take(lectureCount).ToList();
            return listToReturn;
        }

        /// <summary>
        /// method to get all the rooms with sufficient capacity, based on the 
        /// total number of students registered for the course
        /// </summary>
        /// <param name="kursus">the current course to be scheduled</param>
        /// <param name="lokalelist">a list of rooms</param>
        /// <returns></returns>
        List<Lokale> FindPossibleRooms(Kursus kursus, List<Lokale> lokalelist)
        {
            List<Lokale> possibleRooms = new List<Lokale>();

            foreach (Lokale lokale in lokalelist)
            {
                if (RoomHasCapacity(lokale, kursus))
                {
                    possibleRooms.Add(lokale);
                }
            }

            return possibleRooms;
        }






        /// <summary>
        /// method to check if the total number of students is >= the capacity of the lokale 
        /// </summary>
        /// <param name="room">a room</param>
        /// <param name="course">the current course to be scheduled</param>
        /// <returns>true if the room has enough space for the course and false otherwise</returns>
        public bool RoomHasCapacity(Lokale room, Kursus course)
        {
            List<int> holdCountList = HoldCount(course);
            int totalSumOfHold = holdCountList.Sum();
            return room.LokaleCapacity >= totalSumOfHold;

            //return room.LokaleCapacity >= course.HoldObjs.Select(h => h.HoldAntal).Sum();
        }


        /// <summary>
        /// returns the total number of students from each Hold that is participating in a given course
        /// </summary>
        /// <param name="kursus">the current course to be scheduled</param>
        /// <returns>a list of integers representing a count of the number of students in each hold</returns>
        private List<int> HoldCount(Kursus kursus)
        {
            IEnumerable<int> numberOfStudents = kursus.HoldObjs.Select(h => h.HoldAntal);
            return numberOfStudents.ToList();
        }

        /// <summary>
        /// method used for checking that neither the teacher nor any of the hold have been booked
        /// elsewhere at the same time
        /// </summary>
        /// <param name="planned">a list of planned schemacourses</param>
        /// <param name="course">the current course to be scheduled</param>
        /// <param name="time">the lecturetime we are checking</param>
        /// <returns>returns true if no time clash and false otherwise</returns>
        public bool IsPossibleTimeForCourse(List<SchemaCourse> planned, Kursus course, LectureTime time)
        {
            return !TeacherClash(planned, course.LaererObj, time) &&
                   !HoldClash(planned, course.HoldObjs, time);
        }

        //// there is a teacher clash if the teacher for the lecture has already been assigned to the same timeslot
        //public bool TeacherClash2(List<SchemaCourse> planned, Laerer teacher, LectureTime time)
        //{
        //    // All the already planned schemacourses, where a teacher has been booked to teach a course
        //    IEnumerable<SchemaCourse> coursesForThisTeacher = planned.Where(sc => sc.Course.LaererObj == teacher);
        //    //a call to the method 'Any' returns true or false
        //    return coursesForThisTeacher.Any(sc => sc.LectureTimes.Contains(time));

        //    //return planned.Where(sc => sc.Course.LaererObj == teacher).Any(sc => sc.LectureTimes.Contains(time));
        //}


        /// <summary>
        /// checks if the teacher for the lecture has already been assigned to the same timeslot somewhere else
        /// </summary>
        /// <param name="planned">a list containing all the already scheduled courses</param>
        /// <param name="teacher">the teacher we are making a check for</param>
        /// <param name="time">the lecturetime we are checking</param>
        /// <returns>true if either a teacher or a hold has been scheduled at the same time and false otherwise</returns>
        public bool TeacherClash(List<SchemaCourse> planned, Laerer teacher, LectureTime time)
        {
            bool result = false;
            foreach (SchemaCourse sc in planned)
            {
                if (sc.Course.LaererObj == teacher)
                {
                    foreach (LectureTime lt in sc.LectureTimes)
                    {
                        if (lt == time)
                            result = true;
                    }
                }
            }
            return result;
        }

        // 
        /// <summary>
        /// method to check if any of the hold in the course has already been scheduled
        /// at the same time somewhere else
        /// </summary>
        /// <param name="planned">a list of courses that have already been scheduled</param>
        /// <param name="hold">the list of hold participating in the course</param>
        /// <param name="time">the time we are checking</param>
        /// <returns></returns>
        private bool HoldClash(List<SchemaCourse> planned, List<Hold> hold, LectureTime time)
        {
            return hold.Any(h => planned.Where(sc => sc.Course.HoldObjs.Contains(h)).Any(sc => sc.LectureTimes.Contains(time)));
        }



        /// <summary>
        /// method to select the lecturetimes that can be used in the rooms
        /// </summary>
        /// <param name="planned">a list of courses that have already been scheduled</param>
        /// <param name="course">the current course to be scheduled</param>
        /// <param name="freeRoomTimes">all the lecturetimes in all the rooms</param>
        /// <param name="possibleRooms">the rooms with enough capacity for the students registered for the course</param>
        /// <returns>a dictionary containing a list of rooms and the corresponding lecturetimes that can be used in the room</returns>
        Dictionary<Lokale, List<LectureTime>> FindPossibleRoomTimes(List<SchemaCourse> planned, Kursus course,
                 Dictionary<Lokale, List<LectureTime>> freeRoomTimes, List<Lokale> possibleRooms)
        {
            Dictionary<Lokale, List<LectureTime>> possibleRoomTimes = new Dictionary<Lokale, List<LectureTime>>();
            foreach (var r in possibleRooms)
            {
                possibleRoomTimes[r] = new List<LectureTime>();

                foreach (var lt in freeRoomTimes[r])
                {
                    if (IsPossibleTimeForCourse(planned, course, lt))
                    {
                        possibleRoomTimes[r].Add(lt);
                    }
                }
            }
            return possibleRoomTimes;
        }


        /// <summary>
        /// method to filter and select only some particular day(s) of the week and timeofday from the list of lecturetimes
        /// </summary>
        /// <param name="PossibleRoomTimes">a list of lecturetimes</param>
        /// <param name="course">the current course to be scheduled</param>
        /// <returns>a dictionary containing a filtered list of rooms and 
        /// lecturetimes of the preferred day/time</returns>
        Dictionary<Lokale, List<LectureTime>> filterPossibleRoomTimes(Dictionary<Lokale, List<LectureTime>> PossibleRoomTimes, Kursus course)
        {
            Dictionary<Lokale, List<LectureTime>> resultFilteredPossibleRoomTimes = new Dictionary<Lokale, List<LectureTime>>();
            foreach (var r in PossibleRoomTimes)
            {
                TimeOfDay todObj = course.PreferredTimeOfday;
                resultFilteredPossibleRoomTimes[r.Key] = new List<LectureTime>();
                foreach (var lt in r.Value)
                {
                    foreach (DayOfWeek prefd in course.PreferredDays)
                    {
                        if (prefd.Equals(lt.WeekDay) && lt.TimeOfDay.Equals(todObj))
                        {
                            resultFilteredPossibleRoomTimes[r.Key].Add(lt);
                        }
                    }
                }

            }
            return resultFilteredPossibleRoomTimes;
        }
    }
}
}
}
