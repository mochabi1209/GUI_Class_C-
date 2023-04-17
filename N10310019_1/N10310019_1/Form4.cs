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
    public partial class Form_MidTerm : Form
    {
        public Form_MidTerm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form_Midterm = new MidTermMath();
            form_Midterm.Show();
        }
    }
}
