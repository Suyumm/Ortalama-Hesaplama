using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 11;
            textBox1.MaxLength = 11;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = textBox1.Text.Length;
        }
    }
}
