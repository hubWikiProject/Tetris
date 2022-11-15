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

            Draw();
        }

        public override void Rotate(Point[] pList)
        {
            if (pList[0].X == pList[1].X)
            {
                RotateHorisontal(pList);
            }
            else
            {
                RotateVertical(pList);
            }
        }

        public override void TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            if (VerifyPosition(clone))
                points = clone;

            Draw();
        }

        private void RotateVertical(Point[] pList)
        {
            for (int i = 0; i < points.Length; i++)
            {
                pList[i].X = pList[0].X;
                pList[i].Y = pList[0].Y + i;
            }
        }

        private void RotateHorisontal(Point[] pList)
        {
            for (int i = 0; i < points.Length; i++)
            {
                pList[i].Y = pList[0].Y;
                pList[i].X = pList[0].X + i;
            }
        }
    }
}
