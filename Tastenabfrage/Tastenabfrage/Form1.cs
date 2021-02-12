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
using System.Timers;

namespace Tastenabfrage
{
    public partial class Form1 : Form
    {
        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitOpenDevice();

        [DllImport("iowkit", SetLastError = true)]
        public static extern void IowKitCloseDevice(int iowHandle);

        [DllImport("iowkit", SetLastError = true)]
        public static extern void IowKitWrite(int iowHandle, int numPipe, ref byte buffer, int length);

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitGetDeviceHandle(int numDevice);
                
        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitReadNonBlocking(int iowHandle, int numPipe, ref byte buffer, int length);


        public int handle;
        public System.Timers.Timer aTimer = new System.Timers.Timer();
        public byte[] data = new byte[5];

        //Buttons
        private const byte pin1 = 1 << 5;
        private const byte pin2 = 1 << 6;
        private const byte pin3 = 1 << 7;

        //grüne LED
        private const byte pin17 = 1 << 0;
        //gelbe LED
        private const byte pin18 = 1 << 1;
        //rote LED
        private const byte pin19 = 1 << 2;

        public Form1()
        {
            InitializeComponent();
            aTimer.Interval = 50;
            aTimer.Elapsed += OnTimerElapsed;
            handle = IowKitOpenDevice();
            aTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data[0] = 0x00;
            data[1] = pin1 | pin2 | pin3;
            data[2] = pin17 | pin18 | pin19;
            data[3] = 0x00;
            data[4] = 0x00;
            IowKitWrite(handle, 0, ref data[0], 5);
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {

            IowKitReadNonBlocking(handle, 0, ref data[0], 5);
            Console.WriteLine("data = " + string.Join(" ", data));
            Invoke(new Action(() => { 
                label2.Text = "Data[1] = " + String.Format(" {0:X2} ", data[1]) + " ( " + data[1].ToString() + " ) ";
            }));

            ChangePanalColor(p3, (data[1] & pin1) == 0);
            ChangePanalColor(p2, (data[1] & pin2) == 0);
            ChangePanalColor(p1, (data[1] & pin3) == 0);
        }

        void ChangePanalColor(Panel p, bool active)
        {
            if (active)
            {
                p.BackColor = Color.Red;
            }
            else
            {
                p.BackColor = Color.Black;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            aTimer.Stop();
            IowKitCloseDevice(handle);
        }
    }
}
