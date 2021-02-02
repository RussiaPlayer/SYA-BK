using System;
using System.Windows.Forms;

namespace Zeitdifferenz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int hours1 = Convert.ToInt32(h1.Text);
                int hours2 = Convert.ToInt32(h2.Text);

                int m1 = Convert.ToInt32(min1.Text);
                int m2 = Convert.ToInt32(min2.Text);

                double second1 = Convert.ToDouble(s1.Text);
                double second2 = Convert.ToDouble(s2.Text);


                double allSeconds1 = TimeToSec(hours1, m1, second1);
                double allSeconds2 = TimeToSec(hours2, m2, second2);

                double dif = allSeconds1 - allSeconds2;

                SecToTime(dif, out hours2, out m2, out second2);
                h3.Text = hours2.ToString();
                min3.Text = m2.ToString();
                s3.Text = Math.Round(second2, 3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private double TimeToSec(int h, int m, double s)
        {
            if(h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59)
            {
                throw new Exception("Ungültige Eingabe");
            }
            else
            {
                return s + (m + h * 60) * 60;
            }
        }

        private void SecToTime(double sec, out int h, out int m, out double s)
        {
            int sInt = (int)sec;
            h = sInt / 3600;
            m = (sInt - h * 3600) / 60;
            s = sec % 60;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control tb in this.Controls)
            {
                if(tb is TextBox)
                {
                    (tb as TextBox).Text = "0";
                }
            }
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnlyNumberWithDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}