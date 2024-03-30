using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "25";
            textBox5.Text = "2";
            textBox6.Text = textBox4.Text + textBox5.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad, soyad, topla;
            ad = "Zeynep";
            soyad = "Sare";
            topla = ad + " " + soyad;
            MessageBox.Show(topla);
        }
    }
}
