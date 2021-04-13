using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FürTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void undByte_CheckedChanged(object sender, EventArgs e)
        {
            if (undByte.Checked)
            {
                Rechner(1);
            }
        }

        private void orByte_CheckedChanged(object sender, EventArgs e)
        {
            if (orByte.Checked)
            {
                Rechner(2);
            }
        }

        void Rechner(byte a)
        {
            int b = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox2.Text);

            switch (a)
            {
                case 1:
                    exit.Text = Convert.ToString(b & c);
                    break;
                case 2:
                    exit.Text = Convert.ToString(b | c);
                    break;
            }
        }
    }
}
