using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;


namespace StopUhr
{
    class RainbowBackground
    {
        private int Red, Green, Blue;
        public Color RainbowBG(long RGspeed, bool an)
        {
            System.Timers.Timer RGtimer = new System.Timers.Timer();
            RGtimer.Interval = RGspeed;
            RGtimer.AutoReset = true;
            RGtimer.Elapsed += RGtimerEvent;

            if (an)
            {
                RGtimer.Start();
            }
            else if (!an)
            {
                RGtimer.Stop();
            }

            return Color.FromArgb(Red, Green, Blue);
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
        }
    }
}
