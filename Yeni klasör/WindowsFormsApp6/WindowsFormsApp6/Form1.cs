using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double s1, snc;
            s1 = Convert.ToDouble(textBox1.Text);

            snc = s1 - (s1 * 10 / 100);

            textBox2.Text = snc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double s1, snc;
            s1 = Convert.ToDouble(textBox1.Text);

            snc = s1 - (s1 * 25 / 100);

            textBox2.Text = snc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double s1, snc;
            s1 = Convert.ToDouble(textBox1.Text);

            snc = s1 - (s1 * 50 / 100);

            textBox2.Text = snc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double s1, snc;
            s1 = Convert.ToDouble(textBox1.Text);

            snc = s1 - (s1 * 70 / 100);

            textBox2.Text = snc.ToString();
        }
      }
    }
    
    

