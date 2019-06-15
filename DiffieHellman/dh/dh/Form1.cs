using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            int p = int.Parse(numericUpDown1.Value.ToString());
            int g = int.Parse(numericUpDown2.Value.ToString());
            int a = int.Parse(numericUpDown3.Value.ToString());
            int b = int.Parse(numericUpDown4.Value.ToString());

            if(!(Prime(p)))
                MessageBox.Show("Numarul introdus nu e prim!");
            else if(!Ineg(p,g))
                MessageBox.Show("Generatorul trebuie sa fie mai mic decat p!");
            else if(!generator(p,g))
                MessageBox.Show("Numarul selectat nu e generator!");
            else
            {
                int pka, pkb;
                pka = pow_mod(p, g, a);
                pkb = pow_mod(p, g, b);
                textBox1.AppendText(pka.ToString());
                textBox2.AppendText(pkb.ToString());
                textBox3.AppendText(pow_mod(p, pka, b).ToString());
                textBox4.AppendText(pow_mod(p, pkb, a).ToString());
            }
           
        }
        public bool Prime(int p)
        {
            if (p == 1)
                return false;
            if (p == 2)
                return true;
            for(int i = 2; i <= Math.Sqrt(p); i++)
            {
                if (p % i == 0)
                    return false;
            }
            return true;
        }
        public bool generator(int p,int g)
        {
            int val = g;
            for (int i = 1; i <= p - 2; i++)
            {
                if (val % p == 1)
                    return false;
                val = (val * g)%p;
            }

            return true;
        }
        public bool Ineg(int p,int g)
        {
            if (p <= g)
                return false;
            return true;
        }
        public int pow_mod(int p, int g, int a)
        {
            int val = g;
            for(int i = 1; i <= a - 1; i++)
            {
                val = (val * g)%p;
            }
            return val;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
