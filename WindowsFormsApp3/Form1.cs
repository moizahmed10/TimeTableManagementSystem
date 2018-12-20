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
                        row[col] = s.Course + " , " + s.Teacher + " , " + s.Batch;
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
//            DisplayTimetable(table.timetable);

            Slot[,] ttable = table.get_course("PF");

            DisplayTimetable(ttable);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}