﻿using System;
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
    public partial class Form_button : Form
    {
        public Form_button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "請按我一下!")
                button1.Text = "我已經被按過了";
            else if (button1.Text == "我已經被按過了")
                button1.Text = "請按我一下!";
            
        }
    }
}
