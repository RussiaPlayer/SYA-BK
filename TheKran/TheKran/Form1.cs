using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheKran
{
    public partial class Form1 : Form
    {
        private bool m_bSteinAmHaken = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnde_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Willst Du wirklich schon beenden?", "Schon Ende?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Dispose();
            }
        }

        private void MoveTheKran(int x, int y)
        {
            pnlFuss.SetBounds(pnlFuss.Bounds.X + x, pnlFuss.Bounds.Y + y, pnlFuss.Bounds.Width, pnlFuss.Bounds.Height);
            pnlArm.SetBounds(pnlArm.Bounds.X + x, pnlArm.Bounds.Y + y, pnlArm.Bounds.Width, pnlArm.Bounds.Height);
            pnlMast.SetBounds(pnlMast.Bounds.X + x, pnlMast.Bounds.Y + y, pnlMast.Bounds.Width, pnlMast.Bounds.Height);
            pnlSeil.SetBounds(pnlSeil.Bounds.X + x, pnlSeil.Bounds.Y + y, pnlSeil.Bounds.Width, pnlSeil.Bounds.Height);
            if (m_bSteinAmHaken)
            {
                pnlStein.SetBounds(pnlStein.Bounds.X + x, pnlStein.Bounds.Y + y, pnlStein.Bounds.Width, pnlStein.Bounds.Height);
            }
        }

        private void MoveSeil(int h)
        {
            if (pnlSeil.Bounds.Height + h <= 0)
            {
                MessageBox.Show("Nicht so hoch!\nMein Seil möchte ich gerne behalten!","Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pnlSeil.Bounds.Height + h > pnlMast.Bounds.Height)
            {
                MessageBox.Show("Zu tief!\nIch bin doch kein Bohrer!", "Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (m_bSteinAmHaken)
            {
                pnlStein.SetBounds(pnlStein.Bounds.X, pnlStein.Bounds.Y + h, pnlStein.Bounds.Width, pnlStein.Bounds.Height);
                pnlSeil.SetBounds(pnlSeil.Bounds.X, pnlSeil.Bounds.Y, pnlSeil.Bounds.Width, pnlSeil.Bounds.Height + h);
            }
            else
            {
                pnlSeil.SetBounds(pnlSeil.Bounds.X, pnlSeil.Bounds.Y, pnlSeil.Bounds.Width, pnlSeil.Bounds.Height + h);
            }
        }

        private void BtnRechts_Click(object sender, EventArgs e)
        {
            MoveTheKran(trbSchritte.Value, 0);

            if (pnlArm.Bounds.X >= 844 && m_bSteinAmHaken == false)
            {
                MoveTheKran(-1 * (pnlArm.Bounds.X - 844), 0);
                MessageBox.Show("Ich kann nicht weiter nach Rechts", "Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(pnlStein.Bounds.X >= 914 && m_bSteinAmHaken == true)
            {
                MoveTheKran(-1 * (pnlStein.Bounds.X - 914), 0);
                MessageBox.Show("Ich kann nicht weiter nach Rechts", "Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLinks_Click(object sender, EventArgs e)
        {
            MoveTheKran(-1 * trbSchritte.Value, 0);

            if (pnlFuss.Bounds.X <= 12)
            {
                MoveTheKran(12 - pnlFuss.Bounds.X, 0);
                MessageBox.Show("Ich kann nicht weiter nach Links", "Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKranRauf_Click(object sender, EventArgs e)
        {
            MoveTheKran(0, -1 * trbSchritte.Value);

            if (pnlArm.Bounds.Y <= 12)
            {
                MoveTheKran(0, 12 - pnlArm.Bounds.Y);
                MessageBox.Show("Ich kann nicht weiter nach Rauf", "Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKranRunter_Click(object sender, EventArgs e)
        {
            MoveTheKran(0, trbSchritte.Value);

            if (pnlFuss.Bounds.Y >= 671)
            {
                MoveTheKran(0, -1 * (pnlFuss.Bounds.Y - 671));
                MessageBox.Show("Ich kann nicht weiter nach Rauf", "Uuuuups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHakenAuf_Click(object sender, EventArgs e)
        {
            MoveSeil(-1 * trbSchritte.Value);
        }

        private void BtnHakenAb_Click(object sender, EventArgs e)
        {
            MoveSeil(trbSchritte.Value);
        }

        private void BtnGreifen_Click(object sender, EventArgs e)
        {
            if (!m_bSteinAmHaken)
            {
                if (0 == Math.Abs(pnlSeil.Bounds.Y + pnlSeil.Bounds.Height) - pnlStein.Bounds.Y)
                {
                    m_bSteinAmHaken = true;
                    pnlStein.SetBounds(pnlSeil.Bounds.X-pnlStein.Bounds.Width/2+pnlSeil.Bounds.Width/2, pnlStein.Bounds.Y, pnlStein.Bounds.Width, pnlStein.Bounds.Height);
                    MessageBox.Show("Ok. Stein ist am Haken!", "Alles klar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Oh, je. Das schaffe ich nicht.\nDerStein ist noch zu weit weg!", "Klappt noch nicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLoslassen_Click(object sender, EventArgs e)
        {
            if (m_bSteinAmHaken)
            {
                m_bSteinAmHaken = false;
                MessageBox.Show("Stein losgelassen!", "Alles klar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
