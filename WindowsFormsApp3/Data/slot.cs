using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Data
{
    class slot
    {
        public string mTeacher;
        public string mCourse;
        public string mBatch;

        public slot(string pteacher, string pcourse, string pbatch)
        {
            mTeacher = pteacher;
            mBatch = pbatch;
            mCourse = pcourse;
        }

    }
}
