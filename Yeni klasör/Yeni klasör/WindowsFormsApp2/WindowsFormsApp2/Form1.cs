﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color[] renkler = new Color[3];
            renkler[0] = Color.CadetBlue;
            renkler[1] = Color.SkyBlue;
            renkler[2] = Color.RoyalBlue;


            Random r = new Random();
            int sayi = r.Next(3);
            this.BackColor = renkler[sayi];
            label1.Text = sayi.ToString();

        }
    }
}
