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

            textBox1.TextChanged += Text_Changed;
            textBox2.TextChanged += Text_Changed;

            textBox1.KeyPress += Only1and0;
            textBox2.KeyPress += Only1and0;
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            Rechner();
        }

        private void Only1and0(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '0') && (e.KeyChar != '1') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void undByte_CheckedChanged(object sender, EventArgs e)
        {
            Rechner();
        }

        private void orByte_CheckedChanged(object sender, EventArgs e)
        {
            Rechner();
        }

        void Rechner()
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text, 2);
                int b = Convert.ToInt32(textBox2.Text, 2);

                if (undByte.Checked)
                {
                    exit.Text = Convert.ToString(a & b, 2);
                }
                else
                {
                    exit.Text = Convert.ToString(a | b, 2);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler");
            }
        }
    }
}
