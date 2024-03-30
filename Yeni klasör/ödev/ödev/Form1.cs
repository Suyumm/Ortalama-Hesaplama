using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            for (int i = a; i <= b; i++)
            {
                
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    listBox2.Items.Add(i);
                }

                else if (i % 2 == 1)
                {
                    listBox3.Items.Add(i);
                }
            }
        }
    }
}
