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
public  Slot[,] timetable = new Slot[5, 8];
        public void FillDummyData()
        {
            Slot s = new Slot("Moiz", "OOP", "F17");
            timetable[1, 4] = s;

            s = new Slot("Shahid", "PF", "F17");
            timetable[2, 6] = s;

            s = new Slot("Jazib", "ISE", "F17");
            timetable[3, 1] = s;

            s = new Slot("Moiz", "OOP", "F17");
            timetable[1, 3] = s;

            s = new Slot("Jazib", "ISE", "F17");
            timetable[4, 1] = s;

            s = new Slot("Shahid", "PF", "F17");
            timetable[0, 0] = s;
        }
        public Slot[,] get_teacher(string steacher)
        {
            Slot[,] teachertimetable = new Slot[5, 8];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (timetable[i, j] != null)
                    {
                        if (steacher == timetable[i, j].Teacher)
                        {
                            teachertimetable[i, j] = timetable[i, j];
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
                    if (timetable[i, j] != null)
                    {
                        if (scourse == timetable[i, j].Course)
                        {
                            coursetimetable[i, j] = timetable[i, j];
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
                    if (timetable[i, j] != null)
                    {
                        if (sbatch == timetable[i, j].Batch)
                        {
                            batchtimetable[i, j] = timetable[i, j];
                        }
                    }
                }
            }
            return batchtimetable;
        }


       
    }
}
