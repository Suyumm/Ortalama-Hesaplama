using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Anadolu Lisesi");
            comboBox1.Items.Add("Meslek Lisesi");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Anadolu Lisesi")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Sayısal");
                comboBox2.Items.Add("Sözel");
                comboBox2.Items.Add("Eşit Ağırlık");

            }
            else if (comboBox1.Text == "Meslek Lisesi")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bilişim");
                comboBox2.Items.Add("Büro");
                comboBox2.Items.Add("Muhasebe");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Lise Türü: " + comboBox1.Text + "/" + "Bölüm: " + comboBox2.Text);
        }
    }
}
