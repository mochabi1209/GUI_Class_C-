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
    public partial class MidTermMath : Form
    {
        public MidTermMath()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            double input = Int32.Parse(str1)* 9.0 / 5.0 + (32.0);
            label3.Text = (+ input + "F").ToString();
        }
    }
}
