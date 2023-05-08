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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("壞手手!!");
            Form btnnewform = new Form_button();
            btnnewform.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form hwnewform = new Form2();
            hwnewform.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form form_TextBox = new Form_TextBox();
            form_TextBox.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form_Mid = new Form_MidTerm();
            form_Mid.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form_Ex = new Form_Exception();
            form_Ex.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form_timer = new Form_timer();
            form_timer.Show();
        }
    }
}
