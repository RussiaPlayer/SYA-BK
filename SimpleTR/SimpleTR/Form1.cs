using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTR
{
    public partial class Form1 : Form
    {
        private bool gerechnet = false;
        private byte m_byOperation = 0;
        private bool istAuf = false;
        private int Red = 255;
        private int Green = 0;
        private int Blue = 0;
        private bool RainbowAn = false;

        public Form1()
        {
            InitializeComponent();
            this.Width = 344;
        }

        private void Text2Eingabe(string ein)
        {
            if (gerechnet)
            {
                ClrDisplay();
                gerechnet = false;
                m_byOperation = 0;
            }
            TbEingabe.Text += ein;
        }

        private void ClrDisplay()
        {
            TbEingabe.Text = "";
            TbAusage.Text = "";
        }

        private void BtnOff_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnKomma_Click(object sender, EventArgs e)
        {
            Text2Eingabe(",");
        }

        private void BtnNull_Click(object sender, EventArgs e)
        {
            Text2Eingabe("0");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Text2Eingabe("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Text2Eingabe("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Text2Eingabe("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Text2Eingabe("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Text2Eingabe("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Text2Eingabe("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Text2Eingabe("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Text2Eingabe("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Text2Eingabe("9");
        }
        private void BtnCLR_Click(object sender, EventArgs e)
        {
            ClrDisplay();
        }

        private void BtnGleich_Click(object sender, EventArgs e)
        {
            char[] delimiter = {'+', '-', '*', '/', '^', '√', '(' };
            double[] dOperant = {0.0, 0.0};
            double dErgebnis = 0.0;

            try
            {
                string[] sOparant = TbEingabe.Text.Split(delimiter, 2);
                dOperant[0] = Convert.ToDouble(sOparant[0]);
                dOperant[1] = Convert.ToDouble(sOparant[1]);

                switch (m_byOperation)
                {
                    case 1:
                        dErgebnis = dOperant[0] + dOperant[1];
                        break;
                    case 2:
                        dErgebnis = dOperant[0] - dOperant[1];
                        break;
                    case 3:
                        dErgebnis = dOperant[0] * dOperant[1];
                        break;
                    case 4:
                        if (dOperant[1] == 0)
                        {
                            MessageBox.Show("Eine Division durch null ist 'noch' nicht möglich", "Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dErgebnis = dOperant[0] / dOperant[1];
                        }
                        break;
                    case 5:
                        dErgebnis = Math.Pow(dOperant[0], dOperant[1]);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                try
                {
                    if (m_byOperation == 6)
                    {
                        string[] sOparant = TbEingabe.Text.Split(delimiter, 2);
                        dOperant[1] = Convert.ToDouble(sOparant[1]);
                        dErgebnis = Math.Sqrt(dOperant[1]);
                    }
                    else if (m_byOperation == 7)
                    {
                        string[] sOparant = TbEingabe.Text.Split(delimiter, 2);
                        dOperant[1] = Convert.ToDouble(sOparant[1]);
                        dErgebnis = Math.Sin(dOperant[1]);
                        Text2Eingabe(")");
                    }
                    else if (m_byOperation == 8)
                    {
                        string[] sOparant = TbEingabe.Text.Split(delimiter, 2);
                        dOperant[1] = Convert.ToDouble(sOparant[1]);
                        dErgebnis = Math.Cos(dOperant[1]);
                        Text2Eingabe(")");
                    }
                    else if (m_byOperation == 9)
                    {
                        string[] sOparant = TbEingabe.Text.Split(delimiter, 2);
                        dOperant[1] = Convert.ToDouble(sOparant[1]);
                        dErgebnis = Math.Tan(dOperant[1]);
                        Text2Eingabe(")");
                    }
                    else
                    {
                        MessageBox.Show("Das kann ich nicht berechnen :( Jetzt bin ich traurig ", "Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Das kann ich nicht berechnen :( Jetzt bin ich traurig ", "Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            TbAusage.Text = "" + dErgebnis;
            Text2Eingabe(" = ");
            gerechnet = true;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Text2Eingabe(" + ");
            m_byOperation = 1;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Text2Eingabe(" - ");
            m_byOperation = 2;
        }

        private void BtnMal_Click(object sender, EventArgs e)
        {
            Text2Eingabe(" * ");
            m_byOperation = 3;
        }

        private void BtnGeteilt_Click(object sender, EventArgs e)
        {
            Text2Eingabe(" / ");
            m_byOperation = 4;
        }

        private void BtnHoch_Click(object sender, EventArgs e)
        {
            Text2Eingabe("^");
            m_byOperation = 5;
        }

        private void BtnWurzel_Click(object sender, EventArgs e)
        {
            Text2Eingabe("√");
            m_byOperation = 6;
        }

        private void BntPI_Click(object sender, EventArgs e)
        {
                Text2Eingabe(Convert.ToString(Math.PI));
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                TbEingabe.Text = TbEingabe.Text.Remove(TbEingabe.Text.Length - 1, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hey du kannst nicht nichts löschen", "Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            Text2Eingabe("sin(");
            m_byOperation = 7;
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            Text2Eingabe("cos(");
            m_byOperation = 8;
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            Text2Eingabe("tan(");
            m_byOperation = 9;
        }

        private void BtnHoch2_Click(object sender, EventArgs e)
        {
            Text2Eingabe("^2");
            m_byOperation = 5;
        }

        private void BtnHoch3_Click(object sender, EventArgs e)
        {
            Text2Eingabe("^3");
            m_byOperation = 5;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            if (istAuf == false)
            {
                this.Width = 560;
                istAuf = true;
            }
            else if (istAuf == true)
            {
                this.Width = 344;
                istAuf = false;
            }
        }

        private void BackgroundColor(Color RGB)
        {
            this.BackColor = RGB;
            TbAusage.BackColor = RGB;
            TbEingabe.BackColor = RGB;
        }

        private void FontColor(Color RGB)
        {
            BtnNull.ForeColor = RGB;
            Btn1.ForeColor = RGB;
            Btn2.ForeColor = RGB;
            Btn3.ForeColor = RGB;
            Btn4.ForeColor = RGB;
            Btn5.ForeColor = RGB;
            Btn6.ForeColor = RGB;
            Btn7.ForeColor = RGB;
            Btn8.ForeColor = RGB;
            Btn9.ForeColor = RGB;
            BtnKomma.ForeColor = RGB;
            BntPI.ForeColor = RGB;
            BtnHoch.ForeColor = RGB;
            BtnWurzel.ForeColor = RGB;
            BtnSin.ForeColor = RGB;
            BtnCos.ForeColor = RGB;
            BtnTan.ForeColor = RGB;
            BtnHoch2.ForeColor = RGB;
            BtnHoch3.ForeColor = RGB;
            BtnSettings.ForeColor = RGB;
            BtnCLR.ForeColor = RGB;
            BtnOff.ForeColor = RGB;
            BtnPlus.ForeColor = RGB;
            BtnMinus.ForeColor = RGB;
            BtnMal.ForeColor = RGB;
            BtnGeteilt.ForeColor = RGB;
            BtnDel.ForeColor = RGB;
            BtnGleich.ForeColor = RGB;
        }

        private void NumPadColor(Color RGB)
        {
            BtnNull.BackColor = RGB;
            Btn1.BackColor = RGB;
            Btn2.BackColor = RGB;
            Btn3.BackColor = RGB;
            Btn4.BackColor = RGB;
            Btn5.BackColor = RGB;
            Btn6.BackColor = RGB;
            Btn7.BackColor = RGB;
            Btn8.BackColor = RGB;
            Btn9.BackColor = RGB;
            BtnKomma.BackColor = RGB;
            BntPI.BackColor = RGB;
        }

        private void SpecialKeys(Color RGB)
        {
            BtnHoch.BackColor = RGB;
            BtnWurzel.BackColor = RGB;
            BtnSin.BackColor = RGB;
            BtnCos.BackColor = RGB;
            BtnTan.BackColor = RGB;
            BtnHoch2.BackColor = RGB;
            BtnHoch3.BackColor = RGB;
            BtnSettings.BackColor = RGB;
            BtnPlus.BackColor = RGB;
            BtnMinus.BackColor = RGB;
            BtnMal.BackColor = RGB;
            BtnGeteilt.BackColor = RGB;
            button3.BackColor = RGB;
            button4.BackColor = RGB;
        }

        private void FunktionsKeys(Color RGB)
        {
            BtnCLR.BackColor = RGB;
            BtnOff.BackColor = RGB;
            BtnDel.BackColor = RGB;
            BtnGleich.BackColor = RGB;
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            BackgroundColor(colorPicker.Color);
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            FontColor(colorPicker.Color);
        }

        private void btnNumPadColor_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            NumPadColor(colorPicker.Color);
        }

        private void btnSpecialKeys_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            SpecialKeys(colorPicker.Color);
        }

        private void btmFunktionsKeys_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            FunktionsKeys(colorPicker.Color);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RBspeed.Start();
            RBspeed.Interval = 1000;

            BgRainbow.Start();
            BgRainbow.Interval = 5;
        }

        private void RBspeed_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int R, G, B;
            R = r.Next(0, 255);
            G = r.Next(0, 255);
            B = r.Next(0, 255);

            label2.ForeColor = Color.FromArgb(0, R, G, B);
        }

        private void BgRainbow_Tick(object sender, EventArgs e)
        {
            if (RainbowAn == true)
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

                BackgroundColor(Color.FromArgb(Red, Green, Blue));
            }
        }

        private void BtnRainbow_Click(object sender, EventArgs e)
        {
            if(RainbowAn == false)
            {
                RainbowAn = true;
            }
            else if(RainbowAn == true)
            {
                RainbowAn = false;
            }
            
        }
    }
}
