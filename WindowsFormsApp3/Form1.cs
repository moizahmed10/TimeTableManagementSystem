using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Data;
using WindowsFormsApp3;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        TimeTable table;
        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayTimetable(Slot[,] arr)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("8:30");
            dt.Columns.Add("10:00");
            dt.Columns.Add("11:30");
            dt.Columns.Add("1:30");
            dt.Columns.Add("3:00");
            dt.Columns.Add("4:30");
            dt.Columns.Add("6:00");
            dt.Columns.Add("7:30");

            for (int day = 0; day < 5; day++)
            {
                DataRow row = dt.NewRow();
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    if (arr[day, col] != null)
                    {
                        Slot s = (Slot)arr[day, col];
                        row[col] = s.Course + " , " + s.Teacher + " , " + s.Batch + " , " + s.Room;
                    }
                }
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            table = new TimeTable();
            table.FillDummyData();
            DisplayTimetable(table.MasterTimeTable);

            //Slot[,] ttable = table.GetTimetableByRoom("R1");
            //DisplayTimetable(ttable);
        }

        private void btnSearcchTeacher_Click(object sender, EventArgs e)
        {
            
            //TODO: Add search by teacher functionality
        }

        private void byTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.search_text("Enter the Name of The Teacher");
            f2.ShowDialog();
            Slot[,] arr = table.get_teacher(f2.searchtext);
            DisplayTimetable(arr);
        }

        private void byCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.search_text("Enter the Course Code");
            f2.ShowDialog();
            Slot[,] arr=table.get_teacher(f2.searchtext);
            DisplayTimetable(arr);
        }

        private void byBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.search_text("Enter the Batch NUmber");
            f2.ShowDialog();
            Slot[,] arr=table.get_teacher(f2.searchtext);
            DisplayTimetable(arr);
        }

        //TODO Add menu for search Done
        //TODO add dialogs for search string 
        //TODO implement all 4 types of searches Done
    }
}