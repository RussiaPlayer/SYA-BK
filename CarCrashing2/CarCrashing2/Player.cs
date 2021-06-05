using System.Drawing;
using System.Windows.Forms;

namespace CarCrashing2
{
    public class Player
    {
        public Row lastRow { get; set; }
        public int positon { get; private set; }

        public Player(Row lastRow)
        {
            this.lastRow = lastRow;
        }

        public void Spawn()
        {
            lastRow.Panels[this.lastRow.Panels.Count/2].BackColor = Color.Red;
            positon = this.lastRow.Panels.Count / 2;
        }

        public void Move(int move)
        {
            if(positon + move < 0 || positon + move >= lastRow.Panels.Count) 
                return;
            
            foreach (Panel lastRowPanel in lastRow.Panels)
            {
                lastRowPanel.BackColor = Color.Gray;
            }
            
            lastRow.Panels[positon + move].BackColor = Color.Red;
            positon += move;
        }
    }
}