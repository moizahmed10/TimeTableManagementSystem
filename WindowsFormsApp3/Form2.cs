using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{

    public partial class Form2 : Form
    {
        public string searchtext;
        public Form2()
        {
            InitializeComponent();
        }
        public void search_text(string c)
        {
            label1.Text=c;    
        }
        public string text_copy()
        {
            string c;
            c = textBox1.Text;
            return c;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   searchtext=text_copy();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
