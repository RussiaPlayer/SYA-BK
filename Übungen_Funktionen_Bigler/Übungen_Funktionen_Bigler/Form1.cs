//Made by Maxim Bigler
using System;
using System.Windows.Forms;

namespace Übungen_Funktionen_Bigler
{
    public partial class Form1 : Form
    {
        byte aufgabe = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(numericUpDown1.Value);
            string b = Convert.ToString(numericUpDown2.Value);
            switch (aufgabe)
            {
                case 0:
                    MessageBox.Show("Bitte eine Aufgabe auswählen");
                    break;
                case 1:
                    textBox1.Text = Aufgabe1L();
                    break;
                case 2:
                    textBox1.Text = "Widerstand = " + Convert.ToString(Aufgabe2L(Convert.ToDecimal(a), Convert.ToDecimal(b))) + " Ohm";
                    break;
                case 3:
                    textBox1.Text = Aufgabe3L(Convert.ToDecimal(a), Convert.ToDecimal(b));
                    break;
            }
        }

        private void dropDownList_TextChanged(object sender, EventArgs e)
        {
            switch(dropDownList.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Bitte eine Aufgabe auswählen");
                    aufgabe = 0;
                    break;
                case 0:
                    aufgabe = 1;
                    numericUpDown2.Visible = false;
                    labelN1.Visible = false;
                    labelN2.Visible = false;
                    break;
                case 1:
                    aufgabe = 2;
                    numericUpDown2.Visible = true;
                    labelN1.Visible = true;
                    labelN2.Visible = true;
                    labelN1.Text = "Spannung (V)";
                    labelN2.Text = "Stromstärke (A)";
                    break;
                case 2:
                    aufgabe = 3;
                    numericUpDown2.Visible = true;
                    labelN1.Visible = true;
                    labelN2.Visible = true;
                    labelN1.Text = "Zahl 1";
                    labelN2.Text = "Zahl 2";
                    break;
            }
        }

        string Aufgabe1L()
        {
            return Convert.ToString(numericUpDown1.Value * numericUpDown1.Value);
        }

        decimal Aufgabe2L(decimal volt, decimal amper)
        {
            return volt / amper;
        }

        string Aufgabe3L(decimal zahl1, decimal zahl2)
        {
            string a = Convert.ToString(zahl1);
            string b = Convert.ToString(zahl2);

            return a + " + " + b + " = " + Convert.ToString(zahl1 + zahl2) + Environment.NewLine +
                   a + " - " + b + " = " + Convert.ToString(zahl1 - zahl2) + Environment.NewLine +
                   a + " * " + b + " = " + Convert.ToString(zahl1 * zahl2) + Environment.NewLine +
                   a + " / " + b + " = " + Convert.ToString(zahl1 / zahl2);
        }
    }
}
