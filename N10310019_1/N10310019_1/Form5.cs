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
    public partial class Form_Exception : Form
    {
        public Form_Exception()
        {
            InitializeComponent();
        }

        private void Form_Exception_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int add1 = 0, add2 = 0;

            try
            {
                add1 = Int32.Parse(textBox_Add1.Text);
                add2 = Int32.Parse(textBox_Add2.Text);
            }
            catch(SystemException)
            {
                MessageBox.Show("請輸入數字");
                add1 = 0;
                add2 = 0;
            }
            finally
            {
                MessageBox.Show("Try-Catch結束");
            }
            label_result.Text = (add1 + add2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int minus1 = 0, minus2 = 0;

            try
            {
                minus1 = Int32.Parse(textBox1.Text);
                minus2 = Int32.Parse(textBox2.Text);
            }
            catch (SystemException)
            {
                MessageBox.Show("請輸入數字");
                minus1 = 0;
                minus2 = 0;
            }
            finally
            {
                MessageBox.Show("Try-Catch結束");
            }
            label9.Text = (minus1 - minus2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int multiply1 = 0, multiply2 = 0;

            try
            {
                multiply1 = Int32.Parse(textBox3.Text);
                multiply2 = Int32.Parse(textBox4.Text);
            }
            catch (SystemException)
            {
                MessageBox.Show("請輸入數字");
                multiply1 = 0;
                multiply2 = 0;
            }
            finally
            {
                MessageBox.Show("Try-Catch結束");
            }
            label10.Text = (multiply1 * multiply2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double over1 = 0, over2 = 0;

            try
            {
                over1 = Int32.Parse(textBox5.Text);
                over2 = Int32.Parse(textBox6.Text);
            }
            catch (SystemException)
            {
                MessageBox.Show("請輸入數字");
                over1 = 0;
                over2 = 0;
            }
            finally
            {
                MessageBox.Show("Try-Catch結束");
            }
            label11.Text = (over1 / over2).ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
