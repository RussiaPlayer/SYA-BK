using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fragebogen
{
    public partial class FragebogenFenster : Form
    {
        public FragebogenFenster()
        {
            InitializeComponent();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Absenden_Click(object sender, EventArgs e)
        {
            string ausgabeText;

            if (this.rbMännlich.Checked)
                ausgabeText = "Männlich";
            else
                ausgabeText = "Weiblich";

            if (this.cbCsharp.Checked == true)
                ausgabeText += ", Kenntnisse in C#";
            if (this.cbCplus.Checked == true)
                ausgabeText += ", Kenntnisse in C++";
            if (this.cbJava.Checked == true)
                ausgabeText += ", Kenntnisse in Java";

            MessageBox.Show(ausgabeText);
        }
    }
}
