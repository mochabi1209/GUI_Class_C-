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
    public partial class Form_timer : Form

    {
        int second = 0;

        public Form_timer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = this.second + "秒";//test
            this.second++;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
