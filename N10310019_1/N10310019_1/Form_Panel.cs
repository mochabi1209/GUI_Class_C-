using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace N10310019_1
{
    public partial class Form_Panel : Form
    {
        public Form_Panel()
        {
            InitializeComponent();
            /*InitializeComponent();
            File.WriteAllText("Temp.txt", "Hello there:)!\n");
            File.AppendAllText("Temp.txt", "I'm Min.");
            String input = File.ReadAllText("Temp.txt");
            MessageBox.Show(input);*/

            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,配餐\n", Encoding.UTF8);

        }

        private void Form_Panel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainFood = "";
            string sideFood = "";

            foreach(Control c in panel2.Controls)
            {
                if(c is CheckBox)
                {
                    if(((CheckBox)c).Checked ==true)
                    {
                        mainFood += c.Text + " ";
                    }

                }
            }
            foreach (Control c in panel1.Controls)
            {
                if(c is CheckBox)
                {
                    if (((CheckBox)c).Checked ==true)
                    {
                        sideFood += c.Text + " ";
                    }
                }

            }

            DateTime currentDateTime = DateTime.Now;
            string formateDateTime = currentDateTime.ToString("yyyy/MM/dd HH:mm:ss");

            File.AppendAllText("OrderData.csv", formateDateTime + "," + mainFood + ","+sideFood+"\n");

            MessageBox.Show("點餐成功!");
        }
    }
}
