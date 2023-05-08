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
    }
}
