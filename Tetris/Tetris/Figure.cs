using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Figure
    {
        private const int LENGHT = 4;

        protected Point[] points = new Point[LENGHT];
        public void Draw()
        {
            foreach (Point point in points)
            {
                point.Draw();
            }
        }
        public void Hide()
        {
            foreach (Point point in points)
            {
                point.Hide();
            }
        }
        public void TryMove(Direction direction)
        {
            Hide();
            var clone = Clone();
            Move(clone, direction);

            if (VerifyPosition(clone))
                points = clone;

            Draw();
        }

        protected bool VerifyPosition(Point[] pList)
        {
            foreach (var p in pList)
            {
                if (p.X < 0 || p.Y < 0 || p.X >= Fields.Height || p.Y >= Fields.Width)
                    return false;
            }

            return true;
        }

        protected Point[] Clone()
        {
            Point[] newPoints = new Point[LENGHT];
            for (int i = 0; i < LENGHT; i++)
            {
                newPoints[i] = new Point(points[i]);
            }

            return newPoints;
        }

        public void Move(Point[] pList, Direction direction)
        {
            foreach (var p in pList)
            {
                p.Move(direction);
            }
        }
        public abstract void Rotate(Point[] pList);
        public abstract void TryRotate();
    }
}
