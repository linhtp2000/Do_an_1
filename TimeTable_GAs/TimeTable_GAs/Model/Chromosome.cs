//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TimeTable_GAs.Model
//{
//    public class Chromosome
//    {
//        // Time-space slots, one entry represent specific duration in one classroom
//        public int chromosomeLength = Data.daysPerWeek * Data.periodsPerDay * Data.rooms.length;
//        private int[] slots = new int[chromosomeLength];
//        private HashMap<Integer, Integer> classesMap = new HashMap<>(); //classID -> assignedSlotIdx
//        public double fitnessScore = 0;

//        Chromosome(boolean atRandom)
//        {
//            Arrays.fill(slots, -1);
//            classesMap.clear();
//            fitnessScore = 0;
//            if (atRandom)
//            {
//                Random rand = new Random();
//                //int roomID = 0;
//                for (int i = 0; i < Data.classes.length; i++)
//                {
//                    int slotIdx = rand.nextInt(chromosomeLength);
//                    /*roomID = (((slotIdx*Data.rooms.length*Data.daysPerWeek)/chromosomeLength) % Data.rooms.length);
//                    while(!Data.classes[i].isAllowedRoom(roomID) || slots[slotIdx]!=-1){
//                        slotIdx = rand.nextInt(chromosomeLength);
//                        roomID = (((slotIdx*Data.rooms.length*Data.daysPerWeek)/chromosomeLength) % Data.rooms.length);
//                    }*/
//                    while (slots[slotIdx] != -1)
//                    {
//                        slotIdx = rand.nextInt(chromosomeLength);
//                    }
//                    int classID = Data.classes[i].getID();
//                    slots[slotIdx] = classID;
//                    classesMap.put(classID, slotIdx);
//                }
//            }
//        }

//        public void calcFitness()
//        {
//            int qualityScore = 0;
//            Iterator <?> it = classesMap.entrySet().iterator();
//            while (it.hasNext())
//            {
//                Map.Entry pair = (Map.Entry)it.next();
//                int classID = (int)pair.getKey();
//                int slotIdx = (int)pair.getValue();
//                qualityScore += calculateGeneScore(classID, slotIdx);
//            }
//            fitnessScore = qualityScore / (3.0 * classesMap.size());
//        }

//        public int calculateGeneScore(int classID, int slotIdx)
//        {
//            int geneScore = 0;
//            int roomID = Data.rooms[(slotIdx * Data.rooms.length * Data.daysPerWeek / slots.length) % Data.rooms.length].getID();
//            if (Data.getClassByID(classID).isAllowedRoom(roomID))
//            {
//                geneScore++;
//            }
//            if (instructorIsAvailable(slotIdx))
//            {
//                geneScore++;
//            }
//            if (groupStudentIsAvailable(slotIdx))
//            {
//                geneScore++;
//            }
//            return geneScore;
//        }

//        private boolean instructorIsAvailable(int slotIdx)
//        {
//            Instructor ins = Data.getClassByID(slots[slotIdx]).getInstructor();
//            int instructorClassesCount = 0;
//            int k = slotIdx % Data.periodsPerDay;
//            int dayID = (slotIdx * Data.daysPerWeek / chromosomeLength) % Data.daysPerWeek;
//            k += dayID * (chromosomeLength / Data.daysPerWeek);
//            int roomsCount = Data.rooms.length;
//            for (int i = 0; i < roomsCount; i++, k += Data.periodsPerDay)
//            {
//                if (slots[k] == -1)
//                {
//                    continue;
//                }
//                else if (Data.getClassByID(slots[k]).getInstructor() == ins)
//                {
//                    instructorClassesCount++;
//                }
//            }
//            if (instructorClassesCount == 1)
//            {
//                return true;
//            }
//            return false;
//        }
//}
