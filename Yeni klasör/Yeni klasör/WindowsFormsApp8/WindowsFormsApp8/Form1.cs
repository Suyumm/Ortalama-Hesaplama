﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 255;


            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 255;


            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 255;

            numericUpDown1.Increment = 10;
            numericUpDown2.Increment = 10;
            numericUpDown3.Increment = 10;

            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;

            textBox1.Enabled=false;
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
        }
    }
}
