using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzasiparisi
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
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.White;

            }
            else
            {
                label1.BackColor = Color.Yellow;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                label1.BackColor = Color.Red;
                timer2.Start();
            }
        }




            private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if (progressBar2.Value % 20 == 0)
            {
                label2.BackColor = Color.White;

            }
            else
            {
                label2.BackColor = Color.Yellow;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                label2.BackColor = Color.Red;
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.White;

            }
            else
            {
                label3.BackColor = Color.Yellow;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                label3.BackColor = Color.Red;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10;
            if (progressBar4.Value % 20 == 0)
            {
                label4.BackColor = Color.White;

            }
            else
            {
                label4.BackColor = Color.Yellow;
            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                label4.BackColor = Color.Red;
                MessageBox.Show ("Siparişiniz yola çıkmak üzere hazırdır");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
