using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, snc;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            snc = s1 + s2;
            textBox3.Text = snc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2, snc;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            snc = s1 - s2;
            textBox3.Text = snc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1, s2, snc;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            snc = s1 * s2;
            textBox3.Text = snc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1, s2, snc;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            snc = s1 / s2;
            textBox3.Text = snc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int s1, snc;
            s1 = Convert.ToInt32(textBox1.Text);
            
            snc = s1 *s1;
            
            MessageBox.Show(snc.ToString());
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // iki sayının toplamının iki çarpımının 5 fazlası
            int s1,s2, snc;
            s1 = Convert.ToInt32(textBox1.Text);
            
            s2 = Convert.ToInt32(textBox2.Text);

            snc = ((s1 + s2)*2)+5;

            MessageBox.Show(snc.ToString());
        }
    }
}
