﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            byte a;
            a = Convert.ToByte(textBox1.Text);
            

            if (a /2==0)
            {
                label3.Text = "tek";
            }
            else if (a/2==1)
            {
                label3.Text = "çift";
            }
            */
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int a;
            a= Convert.ToInt16(textBox1.Text);
            
            
            if (a>=50)
            {
                label4.Text = Convert.ToString("Belge alamadı");

                if (a>=70&&a<85)
                {
                    label4.Text = Convert.ToString("Teşekkür Aldınız");
                }
                else if (a>=85&&a<=100)
                {
                    label4.Text = Convert.ToString("Taktir Aldınız");
                }
                
            }
            
                

            else
            {   
                label4.Text = Convert.ToString("Kaldı");
            }
            
            
                
        }
    }
}
