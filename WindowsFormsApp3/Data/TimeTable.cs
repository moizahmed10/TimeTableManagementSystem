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
public  slot[,] timetable = new slot[5, 8];
        public void FillDummyData()
        {
            slot s = new slot("Moiz", "OOP", "F17");
            timetable[1, 4] = s;

            s = new slot("Shahid", "PF", "F17");
            timetable[2, 6] = s;

            s = new slot("Jazib", "ISE", "F17");
            timetable[3, 1] = s;

            s = new slot("Moiz", "OOP", "F17");
            timetable[1, 3] = s;

            s = new slot("Jazib", "ISE", "F17");
            timetable[4, 1] = s;

            s = new slot("Shahid", "PF", "F17");
            timetable[0, 0] = s;
        }
        public slot[,] get_teacher(string steacher)
        {
            slot[,] teachertimetable = new slot[5, 8];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (steacher == timetable[i, j].mTeacher)
                    {
                        teachertimetable[i, j] = timetable[i, j];
                    }
                }
            }
            return teachertimetable;
        }
        public slot[,] get_course(string scourse)
        {
            slot[,] coursetimetable = new slot[5, 8];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (scourse == timetable[i, j].mCourse)
                    {
                        coursetimetable[i, j] = timetable[i, j];
                    }
                }
            }
            return coursetimetable;
        }
        public slot[,] get_batch(string sbatch)
        {
            slot[,] batchtimetable = new slot[5, 8];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (sbatch == timetable[i, j].mBatch)
                    {
                        batchtimetable[i, j] = timetable[i, j];
                    }
                }
            }
            return batchtimetable;
        }


       
    }
}
