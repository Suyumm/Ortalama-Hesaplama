﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Step = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
