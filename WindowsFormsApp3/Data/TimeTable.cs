using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace WindowsFormsApp3.Data
{
    /*     AL AL AL
     *     AL AL AL
     *     AL NU AL
     * 
     * 
     * */
    class TimeTable
    {
        public const int COL_COUNT = 6;
        public const int ROW_COUNT = 5;

        private ArrayList[,] mSchedule = new ArrayList[ROW_COUNT, COL_COUNT];

        public ArrayList[,] MasterSchedule
        {
            get { return mSchedule; }
        }

        public Slot[,] get_teacher(string steacher)
        {
            Slot[,] teachertimetable = new Slot[ROW_COUNT, COL_COUNT];
            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COL_COUNT; j++)
                {
                    ArrayList arr = mSchedule[i, j];
                    if (arr != null)
                    {
                        for (int z = 0; z < arr.Count; z++)
                        {
                            Slot s = (Slot)arr[z];
                            if (s != null)
                            {
                                if (steacher == s.Teacher)
                                {
                                    teachertimetable[i, j] = s;
                                }
                            }
                        }
                    }
                }
            }
            return teachertimetable;
        }

        public Slot[,] get_course(string scourse)
        {
            Slot[,] coursetimetable = new Slot[ROW_COUNT, COL_COUNT];
            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COL_COUNT; j++)
                {
                    if (mSchedule[i, j] != null)
                        foreach (Slot classes in mSchedule[i, j])
                        {
                            if (classes != null)
                            {
                                if (scourse == classes.Course)
                                {
                                    coursetimetable[i, j] = classes;
                                }
                            }

                        }
                }
            }
            return coursetimetable;
        }

        public Slot[,] get_batch(string sbatch)
        {
            Slot[,] batchtimetable = new Slot[ROW_COUNT, COL_COUNT];
            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COL_COUNT; j++)
                {
                    if (mSchedule[i, j] != null)
                        foreach (Slot classes in mSchedule[i, j])
                        {
                            if (classes != null)
                            {
                                if (sbatch == classes.Batch)
                                {
                                    batchtimetable[i, j] = classes;
                                }
                            }

                        }
                }
            }
            return batchtimetable;
        }

        public Slot[,] GetTimetableByRoom(string pRoom)
        {
            Slot[,] table = new Slot[ROW_COUNT, COL_COUNT];
            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COL_COUNT; j++)
                {
                    if (mSchedule[i, j] != null)
                        foreach (Slot classes in mSchedule[i, j])
                        {
                            if (classes != null)
                            {
                                if (pRoom == classes.Room)
                                {
                                    table[i, j] = classes;
                                }
                            }

                        }
                }
            }
            return table;
        }

        public Slot[,] GetTimetableByTeacherBatch(string steacher, string sbatch)
        {
            Slot[,] temptimetable = new Slot[ROW_COUNT, COL_COUNT];
            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COL_COUNT; j++)
                {
                    if (mSchedule[i, j] != null)
                        foreach (Slot classes in mSchedule[i, j])
                        {
                            if (classes != null)
                            {
                                if (steacher == classes.Teacher || sbatch == classes.Batch)
                                {
                                    temptimetable[i, j] = classes;
                                }
                            }

                        }
                }
            }
            return temptimetable;
        }


        internal void AddToSchedule(string pDay, int col, Slot s)
        {
            int row = 0;
            switch (pDay)
            {
                case "Monday":
                    row = 0;
                    break;
                case "Tuesday":
                    row = 1;
                    break;
                case "Wednesday":
                    row = 2;
                    break;
                case "Thursday":
                    row = 3;
                    break;
                case "Friday":
                    row = 4;
                    break;
                default:
                    break;
            }
            if (mSchedule[row, col] is null)
                mSchedule[row, col] = new ArrayList();
            mSchedule[row, col].Add(s);
        }
    }
}