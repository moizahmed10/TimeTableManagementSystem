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
        private Slot[,] mTimetable = new Slot[5, 8];

        public Slot[,] MasterTimeTable
        {
            get { return mTimetable; }
        }

        public void FillDummyData()
        {
            Slot s = new Slot("Moiz", "OOP", "F17", "R1");
            mTimetable[1, 4] = s;

            s = new Slot("Shahid", "PF", "F17", "R2");
            mTimetable[2, 6] = s;

            s = new Slot("Jazib", "ISE", "F17", "R5");
            mTimetable[3, 1] = s;

            s = new Slot("Moiz", "OOP", "F17", "R3");
            mTimetable[1, 3] = s;

            s = new Slot("Jazib", "ISE", "F16", "R2");
            mTimetable[4, 1] = s;

            s = new Slot("Shahid", "PF", "F16", "R1");
            mTimetable[0, 0] = s;
        }

        public Slot[,] get_teacher(string steacher)
        {
            Slot[,] teachertimetable = new Slot[5, 8];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (mTimetable[i, j] != null)
                    {
                        if (steacher == mTimetable[i, j].Teacher)
                        {
                            teachertimetable[i, j] = mTimetable[i, j];
                        }
                    }
                }
            }
            return teachertimetable;
        }

        public Slot[,] get_course(string scourse)
        {
            Slot[,] coursetimetable = new Slot[5, 8];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (mTimetable[i, j] != null)
                    {
                        if (scourse == mTimetable[i, j].Course)
                        {
                            coursetimetable[i, j] = mTimetable[i, j];
                        }
                    }
                }
            }
            return coursetimetable;
        }
        public Slot[,] get_batch(string sbatch)
        {
            Slot[,] batchtimetable = new Slot[5, 8];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (mTimetable[i, j] != null)
                    {
                        if (sbatch == mTimetable[i, j].Batch)
                        {
                            batchtimetable[i, j] = mTimetable[i, j];
                        }
                    }
                }
            }
            return batchtimetable;
        }

        public Slot[,] GetTimetableByRoom(string pRoom)
        {
            Slot[,] table = new Slot[5, 8];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (mTimetable[i, j] != null)
                    {
                        if (pRoom == mTimetable[i, j].Room)
                        {
                            table[i, j] = mTimetable[i, j];
                        }
                    }
                }
            }
            return table;
        }



    }
}
