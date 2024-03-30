using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double s1,s2, snc,s3,s4;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);

            snc = s1 - ((s2 * 1) / 4);

            textBox5.Text = snc.ToString();




            s3 = Convert.ToDouble(textBox4.Text);
            s4 = Convert.ToDouble(textBox3.Text);

            snc = s3 - ((s4 * 1) / 4);

            textBox6.Text = snc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
