using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApp3.Data
{
    class TimeTable
    {
        private const int COL_COUNT = 6; 
        private const int ROW_COUNT = 5;

        private Slot[,] mSchedule = new Slot[ROW_COUNT, COL_COUNT];

        public Slot[,] MasterSchedule
        {
            get { return mSchedule; }
        }

        public void FillDummyData()
        {
            Slot s = new Slot("Moiz", "OOP", "F17", "R1");
            mSchedule[1, 4] = s;

            s = new Slot("Shahid", "PF", "F17", "R2");
            mSchedule[2, 6] = s;

            s = new Slot("Jazib", "ISE", "F17", "RROW_COUNT");
            mSchedule[3, 1] = s;

            s = new Slot("Moiz", "OOP", "F17", "R3");
            mSchedule[1, 3] = s;

            s = new Slot("Jazib", "ISE", "F16", "R2");
            mSchedule[4, 1] = s;

            s = new Slot("Shahid", "PF", "F16", "R1");
            mSchedule[0, 0] = s;
        }

        public Slot[,] get_teacher(string steacher)
        {
            Slot[,] teachertimetable = new Slot[ROW_COUNT, COL_COUNT];
            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COL_COUNT; j++)
                {
                    if (mSchedule[i, j] != null)
                    {
                        if (steacher == mSchedule[i, j].Teacher)
                        {
                            teachertimetable[i, j] = mSchedule[i, j];
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
                    {
                        if (scourse == mSchedule[i, j].Course)
                        {
                            coursetimetable[i, j] = mSchedule[i, j];
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
                    {
                        if (sbatch == mSchedule[i, j].Batch)
                        {
                            batchtimetable[i, j] = mSchedule[i, j];
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
                    {
                        if (pRoom == mSchedule[i, j].Room)
                        {
                            table[i, j] = mSchedule[i, j];
                        }
                    }
                }
            }
            return table;
        }

        public Slot[,] GetTimetableByTeacherBatch(string steacher,string sbatch)
        {
            Slot[,] temptimetable = new Slot[ROW_COUNT, COL_COUNT];
            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COL_COUNT; j++)
                {
                    if (mSchedule[i, j] != null)
                    {
                        if (steacher == mSchedule[i, j].Teacher | sbatch == mSchedule[i,j].Batch)
                        {
                            temptimetable[i, j] = mSchedule[i, j];
                        }
                    }
                }
            }
            return temptimetable;
        }

        internal void AddToSchedule(int row, int col, Slot s)
        {
            mSchedule[row, col] = s;
        }
    }
}
