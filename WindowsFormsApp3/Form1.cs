using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp3.Data;
using Microsoft.Office.Interop.Excel;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        TimeTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new TimeTable();
            table.FillDummyData();
            DisplayTimetable(table.MasterSchedule);
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


        public void DisplayTimetable(Slot[,] arr)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("8:30");
            dt.Columns.Add("10:00");
            dt.Columns.Add("11:30");
            dt.Columns.Add("1:30");
            dt.Columns.Add("3:00");
            dt.Columns.Add("4:30");

            for (int day = 0; day < 5; day++)
            {
                DataRow row = dt.NewRow();

                for (int col = 1; col < dt.Columns.Count; col++)
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


        public void ReadExcelFile()
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"Time Table Fall 2018 V2.4.xlsx");
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            
            int rowCount = xlWorksheet.UsedRange.Rows.Count;
            int colCount = xlWorksheet.UsedRange.Columns.Count;

            ///Column 1 - day
            ///column 2 - Batch
            ///column 3 - room 
            ///column 4-9  slots 

            ///row 1  - column headings
           
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (xlWorksheet.UsedRange.Cells[i, j] != null && xlWorksheet.UsedRange.Cells[i, j].Value2 != null)
                    {
                        //SE101, OOP, Mr. Adeel <--Sample data
                        //excel cell contents are in --> xlWorksheet.UsedRange.Cells[i, j].Value2.ToString()
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
    }
}
