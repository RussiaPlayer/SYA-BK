using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCrashing
{
    public partial class Form1 : Form
    {
        byte playerPosition;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MovePlayer);
            timer1.Start();

            SpawnPlayer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SpawnObstacle();
        }

        void SpawnPlayer()
        {
            playerPosition = 3;
            UpdatePlayerPanel();
        }

        private void MovePlayer(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                if(playerPosition < 4)
                {
                    playerPosition++;
                }
            }
            if (e.KeyCode == Keys.A)
            {
                if (playerPosition > 1)
                {
                    playerPosition--;
                }
            }

            UpdatePlayerPanel();
        }

        private void UpdatePlayerPanel()
        {
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel4.BackColor = Color.FromArgb(224, 224, 224);

            switch (playerPosition)
            {
                case 1:
                    panel1.BackColor = Color.Red;
                    break;
                case 2:
                    panel2.BackColor = Color.Red;
                    break;
                case 3:
                    panel3.BackColor = Color.Red;
                    break;
                case 4:
                    panel4.BackColor = Color.Red;
                    break;
            }
        }

        void SpawnObstacle()
        {
            panel13.BackColor = Color.Green;
            panel14.BackColor = Color.Green;
            panel15.BackColor = Color.Green;
            panel16.BackColor = Color.Green;

            switch (rnd.Next(1, 5))
            {
                case 1:
                    panel13.BackColor = Color.FromArgb(224, 224, 224);
                    break;
                case 2:
                    panel14.BackColor = Color.FromArgb(224, 224, 224);
                    break;
                case 3:
                    panel15.BackColor = Color.FromArgb(224, 224, 224);
                    break;
                case 4:
                    panel16.BackColor = Color.FromArgb(224, 224, 224);
                    break;
            }
        }
    }
}
