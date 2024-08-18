using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int saniye = 0; int dakika = 0; int saat = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value == 0)
            {
                timer1.Stop();
                label1.Text = "00";
                label2.Text = "00";
                label3.Text = "00";
                MessageBox.Show("Zaman Doldu");
            }
            saniye++;
            label3.Text = saniye.ToString();
            if(saniye == 5)
            {
                dakika++;
                label2.Text = dakika.ToString();
                progressBar1.Value -= 10;
                saniye = 0;
            }
            if(dakika == 3)
            {
                saat++;
                label1.Text = dakika.ToString();
                dakika = 0;
            }
            
        }
    }
}
