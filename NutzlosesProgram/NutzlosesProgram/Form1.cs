using System;
using System.Windows.Forms;

namespace NutzlosesProgram
{
    public partial class Form1 : Form
    {
        
        int counter = 0;
        
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            counter++;
            UpdateLabel();
        }

        private void keypressed(Object o, KeyPressEventArgs e)
        {
            counter++;
            UpdateLabel();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetCounter();
        }

        private void ResetCounter()
        {
            counter = 0;
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            Counter.Text = Convert.ToString(counter);
        }
    }
}
