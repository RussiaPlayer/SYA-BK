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

namespace IOW_Identifizieren_Bigler
{
    public partial class Form1 : Form
    {
        public List<int> handles = new List<int>();
        
        public string textPNB;

        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitOpenDevice();

        [DllImport("iowkit", SetLastError = true)]
        public static extern void IowKitCloseDevice(int iowHandle);

        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitGetNumDevs();

        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitGetDeviceHandle(int numDevice);

        [DllImport("iowkit", SetLastError = true)]
        public static extern short IowKitGetProductId(int iowHandle);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int lowHandle = IowKitOpenDevice();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int lowHandle = IowKitOpenDevice();
            handles.Clear();
            textPNB = "";
            text2.Text = "";
            text1.Text = "";

            int counter = IowKitGetNumDevs();
            text1.Text = "Anzahl der angeschlossenen Warriors " + counter;

            for (int i = 1; i <= counter; i++)
            {
                handles.Add(IowKitGetDeviceHandle(i));
            }

            foreach (int handle in handles)
            {
                textPNB += "\n";
                textPNB += "Warrior Handle: " + handle + ", " + "Product Nummer: " + Convert.ToString(IowKitGetProductId(handle)) + ", Warrior-Typ " + WarriorType(IowKitGetProductId(handle));
            }

            text2.Text = "Produckt Number aller Warriors: " + textPNB;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (int handle in handles)
            {
                IowKitCloseDevice(handle);
            }
        }

        public string WarriorType(int handle)
        {
            string a = "Kein Type gefunden";

            switch (handle)
            {
                case 5380:
                    a = "28";
                    break;
                case 5377:
                    a = "24";
                    break;
                case 5376:
                    a = "40";
                    break;
                case 5379:
                    a = "56";
                    break;
            }

            return a;
        }
    }
}
