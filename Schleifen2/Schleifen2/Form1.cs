using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schleifen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            listBox1.Items.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Clear();
            for(int i = 0; i <=20; i += 2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clear();

            for(decimal i = numericUpDown1.Value; i >= 0; --i)
            {
                listBox1.Items.Add(i);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Clear();
            int ergebnis = 0;
            for(int i = 0; i <= numericUpDown2.Value; i++)
            {
                ergebnis += i;
            }
            listBox1.Items.Add(ergebnis);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Clear();
            int ergebnis = 1;
            for (int i = 1; i <= numericUpDown3.Value; i++)
            {
                ergebnis *= i;
            }
            listBox1.Items.Add(ergebnis);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();

            decimal k = numericUpDown4.Value;
            decimal p = numericUpDown5.Value / 100;
            int n = 0;

            while(k <= 1000000)
            {
                k += k * p;
                n++;
            }

            listBox1.Items.Add(n);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clear();
            int max = 0;
            int min = int.MaxValue;
            foreach (Control nR in this.Controls)
            {
                if(nR.Name.Substring(0, 2).Equals("nR"))
                {
                    NumericUpDown nUD = (NumericUpDown)nR;
                    max = Math.Max(max, (int)nUD.Value);
                    min = Math.Min(min, (int)nUD.Value);
                }
            }
            listBox1.Items.Add("Max: "+ max);
            listBox1.Items.Add("Min: " + min);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
            for(int i = 1; i <= (int)numericA7.Value; i++)
            {
                if(((int)numericA7.Value % i) == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clear();

            bool isPrime;

            for(int i = 1; i <= (int)numericA8.Value; i++)
            {
                isPrime = (i != 0 && i != 1 && i % 2 != 0) || i == 2;
                int boundary = (int)Math.Floor(Math.Sqrt(i));

                for (int a = 3; a <= boundary; a += 2)
                {
                    if(i % a == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            int sterne = 7;

            for (int v = 1; v <= 4; v++)
            {
                for(int i = 1; i <= sterne; i++)
                {
                    label3.Text += "*";
                }

                sterne -= 2;
                label3.Text += "\r";
            }


            /*String result = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < (7 - i); j++)
                {
                    result += j < i ? " " : "*";
                }
                result += "\n";
            }
            label3.Text = result;*/
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clear();

            //deciaml wegen kommastellen und weil da viel, viel rein passt
            decimal a = 2;
            decimal b = 1;
            decimal ergebniss = 1;

            for(long i = 1; i <= (long)numericA10.Value; i++)
            {
                //guckt ob der Zähler i eine gerade oder ungerade zahl ist.
                if (i != 1)
                {
                    if (i % 2 == 0)
                    {
                        b += 2;
                    }
                    else
                    {
                        a += 2;
                    }
                }
                //Man muss die Zahlen Runden weil sonst die Zahl zu groß ist
                ergebniss *= Math.Round((a / b), 10);
                ergebniss = Math.Round(ergebniss, 10);
            }

            //added unsere PI Zahl und die eigendliche PI Zahl
            //um sie zu vergleichen
            listBox1.Items.Add("Dein PI:\t\t " + ergebniss * 2);
            listBox1.Items.Add("Normales PI:\t " + Math.Round(Math.PI, 10));
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            label3.Text = "Pyramide";
        }
    }
}
