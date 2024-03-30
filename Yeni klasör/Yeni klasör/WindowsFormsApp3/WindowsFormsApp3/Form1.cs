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

        int sayi = 0, tahminsay = 0, puan=100;

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Başla Butonu
            button2.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = true;
            
            Random r = new Random();
            sayi = r.Next(1, 10);
            label5.Text = "";     //Durum
            label6.Text = "";     //Tahmin sayısı
            label7.Text = "100";  //Puan
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kontrol Et
            int tahmin ;
            tahmin = Convert.ToInt32(textBox1.Text);
            tahminsay++;
            if(tahminsay<=10)
            {
                tahmin = Convert.ToInt32(textBox1.Text);
                label6.Text = tahminsay.ToString();
                if (sayi<tahmin)
                {
                    label5.Text = "Tahmini azalt";
                    puan -= 10;
                    label7.Text = puan.ToString();
                }
                else if(tahmin<sayi)
                {
                    label5.Text = "Tahmini arttır";
                    puan -= 10;
                    label7.Text = puan.ToString();
                }
                else
                {
                    label5.Text = "Tebrikler..";
                    label6.Text = tahminsay.ToString();
                    label7.Text = puan.ToString();
                    button2.Enabled = true;
                    button1.Enabled = false;
                }
            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("Tahmin hakkınız bitti");
                this.Close();
            }
        }
    }
}
