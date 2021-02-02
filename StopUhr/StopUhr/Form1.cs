using System;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;

namespace StopUhr
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer aTimer = new System.Timers.Timer();
        private System.Timers.Timer RGtimer = new System.Timers.Timer();
        private int Red = 255, Green = 1, Blue = 0;
        long s, m, h;

        public Form1()
        {
            InitializeComponent();
            aTimer.Interval = 1000;
            aTimer.Elapsed += OnTimeEvent;

            RGtimer.Interval = 1;
            RGtimer.AutoReset = true;
            RGtimer.Elapsed += RGtimerEvent;
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            ResetTimer();
            aTimer.Start();
            RGtimer.Start();
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            aTimer.Stop();
            RGtimer.Stop();
            this.BackColor = Color.White;
        }

        private void RGtimerEvent(object sender, ElapsedEventArgs e)
        {
            if (Red == 255 && Green < 255 && Blue == 0)
            {
                ++Green;
            }
            else if (Red > 0 && Green == 255 && Blue == 0)
            {
                --Red;
            }
            else if (Red == 0 && Green == 255 && Blue < 255)
            {
                ++Blue;
            }
            else if (Red == 0 && Green > 0 && Blue == 255)
            {
                --Green;
            }
            else if (Red < 255 && Green == 0 && Blue == 255)
            {
                ++Red;
            }
            else if (Red == 255 && Green == 0 && Blue > 0)
            {
                --Blue;
            }

            this.BackColor = Color.FromArgb(Red, Green, Blue);
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(delegate()
            {
                ++s;
                if (s == 60)
                {
                    ++m;
                    s = 0;
                }
                if (m == 60)
                {
                    ++h;
                    m = 0;
                }

                label1.Text = (h < 10 ? "0" : "") + $"{h} Stunde" + (h != 1 ? "n, " : ", ") + (m < 10 ? "0" : "") + $"{m} Minute" + (m != 1 ? "n, " : ", ") + (s < 10 ? "0" : "") + $"{s} Sekunde" + (s != 1 ? "n" : "");
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            aTimer.Stop();
        }

        void ResetTimer()
        {
            label1.Text = "00 Stunden, 00 Minuten, 00 Sekunden";
            s = 0;
            m = 0;
            h = 0;
        }
    }
}
