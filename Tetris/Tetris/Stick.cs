using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Stick : Figure
    {
        public Stick(int x, int y, char symbol)
        {
            points[0] = new Point(x, y, symbol);
            points[1] = new Point(x, y + 1, symbol);
            points[2] = new Point(x, y + 2, symbol);
            points[3] = new Point(x, y + 3, symbol);
        }

        public override void Rotate()
        {
            if (points[0].x == points[1].x)
            {
                RotateHorisontal();
            }
            else
            {
                RotateVertical();
            }
        }

        private void RotateVertical()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = points[0].x;
                points[i].y = points[0].y + i;
            }
        }

        private void RotateHorisontal()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].y = points[0].y;
                points[i].x = points[0].x + i;
            }
        }
    }
}
