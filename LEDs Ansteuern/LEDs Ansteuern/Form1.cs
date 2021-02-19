using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Timer = System.Timers.Timer;

namespace LEDs_Ansteuern
{
    public partial class Form1 : Form
    {
        //Dll-start
        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitOpenDevice();

        [DllImport("iowkit", SetLastError = true)]
        public static extern void IowKitCloseDevice(int iowHandle);

        [DllImport("iowkit", SetLastError = true)]
        public static extern void IowKitWrite(int iowHandle, int numPipe, ref byte buffer, int length);
        //Dll-stop

        private Timer aTimer = new Timer();

        private byte[] data = new byte[5];
        //LEDs
        private const byte pin17 = 1 << 0;  //grün
        private const byte pin18 = 1 << 1;  //gleb
        private const byte pin19 = 1 << 2;  //rot

        int handle;

        public Form1()
        {
            InitializeComponent();
            handle = IowKitOpenDevice();

            //Panels-color
            panel1.BackColor = Color.FromArgb(21, 66, 35);
            panel2.BackColor = Color.FromArgb(82, 78, 24);
            panel3.BackColor = Color.FromArgb(92, 28, 28);

            //Timer
            aTimer.Interval = 500;
            aTimer.Elapsed += OnTimerEvent;
            aTimer.AutoReset = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Write on Iow
            data[0] = 0;
            data[1] = 0;
            data[2] = pin17 | pin18 | pin19;
            data[3] = 0;
            data[4] = 0;
            IowKitWrite(handle, 0, ref data[0], 5);

            //Labels
            label1.Text = "Data[1] = " + String.Format(" {0:X2} ", data[1]) + " ( " + data[1].ToString() + " ) ";
            label2.Text = "Data[2] = " + String.Format(" {0:X2} ", data[2]) + " ( " + data[2].ToString() + " ) ";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            aTimer.Stop();
            IowKitCloseDevice(handle);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LEDs(checkBox1.Checked, 1, panel1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            LEDs(checkBox2.Checked, 2, panel2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            LEDs(checkBox3.Checked, 3, panel3);
        }

        private void LEDs(bool active, byte pin, Panel panel)
        {
            if (active)
            {
                data[2] = (byte)(data[2] & ~(1 << (pin - 1)));
            }
            else if (!active)
            {
                data[2] = (byte)(data[2] | 1 << (pin - 1));
            }
            IowKitWrite(handle, 0, ref data[0], 5);
            ChangePanal(panel, pin, active);
            ChangeLabels();
            Console.WriteLine("data = " + string.Join(" ", data));
        }

        private void ChangePanal(Panel panel, byte pin, bool active)
        {
            if (active)
            {
                switch (pin)
                {
                    case 1:
                        panel.BackColor = Color.FromArgb(25, 191, 77);
                        break;
                    case 2:
                        panel.BackColor = Color.FromArgb(222, 210, 55);
                        break;
                    case 3:
                        panel.BackColor = Color.FromArgb(214, 39, 39);
                        break;
                }
            }
            else
            {
                switch (pin)
                {
                    case 1:
                        panel.BackColor = Color.FromArgb(21, 66, 35);
                        break;
                    case 2:
                        panel.BackColor = Color.FromArgb(82, 78, 24);
                        break;
                    case 3:
                        panel.BackColor = Color.FromArgb(92, 28, 28);
                        break;
                }
            }
        }
         private void ChangeLabels()
        {
            label1.Text = "Data[1] = " + String.Format(" {0:X2} ", data[1]) + " ( " + data[1].ToString() + " ) ";
            label2.Text = "Data[2] = " + String.Format(" {0:X2} ", data[2]) + " ( " + data[2].ToString() + " ) ";
        }

        //Lauflicht
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                aTimer.Start();
            }
            else
            {
                aTimer.Stop();
                data[2] = pin17 | pin18 | pin19;
            }
        }

        private int counter = 0;

        private void OnTimerEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                CalculatePattern();
                IowKitWrite(handle, 0, ref data[0], 5);
                ChangeLabels();
                counter++;
                Console.WriteLine("data = " + string.Join(" ", data));
                Console.WriteLine("Counter = " + counter);
            }));
        }

        private void CalculatePattern()
        {
            int reseter = byte.MaxValue;

            if (counter >= 3)
            {
                counter = 0;
            }

            if (checkBox1.Checked && counter == 0)
            {
                reseter &= ~pin17;
            }
            if (checkBox2.Checked && counter == 1)
            {
                reseter &= ~pin18;
            }
            if (checkBox3.Checked && counter == 2)
            {
                reseter &= ~pin19;
            }

            data[2] = (byte)reseter;
        }
    }
}
