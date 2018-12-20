using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Data
{
    public class Slot
    {
        private string mTeacher;
        private string mCourse;
        private string mBatch;
        private string mRoom;
        
        public string Teacher
        {
            get { return mTeacher; }
        }

        public string Course
        {
            get { return mCourse; }
        }

        public string Batch
        {
            get { return mBatch; }
        }
        
        public string Room 
        {
            get { return mRoom;}
        }
        
        public Slot(string pteacher, string pcourse, string pbatch, string pRoom)
        {
            mTeacher = pteacher;
            mBatch = pbatch;
            mCourse = pcourse;
            mRoom = pRoom;
        }

    }
}
