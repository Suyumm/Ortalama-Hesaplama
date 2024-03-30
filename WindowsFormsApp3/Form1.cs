using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       int not1=0, not2=0, not3=0, ort = 1;
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.label4.Text = textBox1.Text;
            int not1 = Convert.ToInt32(textBox2.Text);
            int not5 = Convert.ToInt32(textBox3.Text);
            int not3 = Convert.ToInt32(textBox4.Text);
            ort = (not1 + not2 + not3) / 3;

            f2.label5.Text = ort.ToString();

            if (ort < 50)
                f2.label6.Text = "Kaldı";
            else
                f2.label6.Text = "Geçti";

            f2.ShowDialog();

        }
    }
}
