using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUpGame.levelup
{
    public class Position
    {
        public Point Coordinates { get; set; }

        public Position(int x, int y)
        {
            Coordinates = new Point(x, y);
        }
    }
}
