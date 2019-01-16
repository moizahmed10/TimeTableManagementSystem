using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp3.Data;
using Microsoft.Office.Interop.Excel;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Collections;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        TimeTable table;

        public Form1()
        {
            InitializeComponent();
            table = new TimeTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSearcchTeacher_Click(object sender, EventArgs e)
        {
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
            f2.search_text("Enter the Course");
            f2.ShowDialog();
            Slot[,] arr = table.get_course(f2.searchtext);
            DisplayTimetable(arr);
        }

        private void byBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.search_text("Enter the Batch Number");
            f2.ShowDialog();
            Slot[,] arr = table.get_batch(f2.searchtext);
            DisplayTimetable(arr);
        }

        private void matchTeacherBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            Slot[,] arr = table.GetTimetableByTeacherBatch(f3.teacher, f3.batch);
            DisplayTimetable(arr);

        }


        public void DisplayMasterTimetable(ArrayList[,] arr)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Day");
            dt.Columns.Add("8:30");
            dt.Columns.Add("10:00");
            dt.Columns.Add("11:30");
            dt.Columns.Add("1:30");
            dt.Columns.Add("3:00");
            dt.Columns.Add("4:30");

            for (int day = 0; day < TimeTable.ROW_COUNT; day++)
            {
                DataRow row = dt.NewRow();
                
                if (day == 0)
                    row[0] = "Monday";
                else if(day == 1)
                    row[0] = "Tuesday";
                else if (day == 2)
                    row[0] = "Wednesday";
                else if(day == 3)
                    row[0] = "Thursday";
                else if (day == 4)
                    row[0] = "Friday";
                else
                    row[0] = "unknown";


                for (int col = 1; col < dt.Columns.Count; col++)
                {
                    if (arr[day, col - 1] != null)
                    {
                        if (arr[day, col - 1].Count > 0)
                        {
                            row[col] = "("+ arr[day, col - 1].Count + ") "; 
                            foreach (Slot s in arr[day, col - 1])
                            {
                                row[col] += s.Course + " , " + s.Teacher + " , " + s.Batch + " , " + s.Room + " | ";
                            }
                        }
                    }
                }
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
        }


        public void DisplayTimetable(Slot[,] arr)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("Day");
            dt.Columns.Add("8:30");
            dt.Columns.Add("10:00");
            dt.Columns.Add("11:30");
            dt.Columns.Add("1:30");
            dt.Columns.Add("3:00");
            dt.Columns.Add("4:30");

            for (int day = 0; day < 5; day++)
            {
                DataRow row = dt.NewRow();

                if (day == 0)
                    row[0] = "Monday";
                else if (day == 1)
                    row[0] = "Tuesday";
                else if (day == 2)
                    row[0] = "Wednesday";
                else if (day == 3)
                    row[0] = "Thursday";
                else if (day == 4)
                    row[0] = "Friday";


                for (int col = 1; col < dt.Columns.Count; col++)
                {
                    if (arr[day, col - 1] != null)
                    {
                        Slot s = (Slot)arr[day, col - 1];
                        row[col] = s.Course + " , " + s.Teacher + " , " + s.Batch + " , " + s.Room;
                    }
                }
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
        }

        public void ReadExcelFile(string filename)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filename);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            
            int rowCount = xlWorksheet.UsedRange.Rows.Count;
            int colCount = xlWorksheet.UsedRange.Columns.Count;
                string lDay = "Monday";

            for (int i = 2; i <= rowCount; i++)
            {
                if(xlWorksheet.UsedRange.Cells[i, 1].Value2 !=null)
                    lDay = xlWorksheet.UsedRange.Cells[i, 1].Value2.ToString();
                string lBatch = xlWorksheet.UsedRange.Cells[i, 2].Value2.ToString();
                string lRoom = xlWorksheet.UsedRange.Cells[i, 3].Value2.ToString();

                for (int j = 4; j <= colCount; j++)
                {
                    if (xlWorksheet.UsedRange.Cells[i, j] != null && xlWorksheet.UsedRange.Cells[i, j].Value2 != null)
                    {
                        string data = xlWorksheet.UsedRange.Cells[i, j].Value2.ToString();
                        string[] items = data.Split(new char[] { ',' });

                        if (items.Length == 3)
                        {
                            string course = items[1].Trim();
                            string teacher = items[2].Trim();

                            Slot s = new Slot(teacher, course, lBatch, lRoom);

                            table.AddToSchedule(lDay, j - 4, s);
                        }
                        else
                            MessageBox.Show("Invalid input: " + data);
                    }
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void openScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedfile = dialog.FileName;
                ReadExcelFile(selectedfile);
                DisplayMasterTimetable(table.MasterSchedule);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
