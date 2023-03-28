using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N10310019_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = label1.Text;
            int count;
            count = Int32.Parse(number) + 1;
            label1.Text = count + "";
            label1.Text = Convert.ToString(count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number = label1.Text;
            int count ;
            count = Int32.Parse(number) - 1;
            label1.Text = count + "";
            label1.Text = Convert.ToString(count);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
