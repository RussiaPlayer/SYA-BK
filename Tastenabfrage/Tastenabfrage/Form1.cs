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
        public static extern void IowKitWrite(int iowHandle, int numPipe, ref byte[] buffer, int length);

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitGetDeviceHandle(int numDevice);

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitGetNumDevs();

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitReadNonBlocking(int iowHandle, int numPipe, ref byte[] buffer, int length);


        private int handle;
        private System.Timers.Timer aTimer = new System.Timers.Timer();

        public Form1()
        {
            IowKitOpenDevice();
            InitializeComponent();
            aTimer.Interval = 50;
            aTimer.Elapsed += OnTimerElapsed;
            aTimer.Start();
            handle = IowKitGetDeviceHandle(1);
        }

        byte[] data = new byte[5];

        private void Form1_Load(object sender, EventArgs e)
        {
            data[0] = 0x00;
            data[1] = 0xE0;
            data[2] = 0x00;
            data[3] = 0x00;
            data[4] = 0x00;
            IowKitWrite(handle, 0, ref data, 5);
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            var buffer = new byte[5];
            IowKitReadNonBlocking(handle, 0, ref buffer, 5);
            label2.Text = buffer.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            IowKitCloseDevice(handle);
            aTimer.Stop();
        }
    }
}
