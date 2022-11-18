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

        public Point[] Points = new Point[LENGHT];
        public void Draw()
        {
            foreach (Point point in Points)
            {
                point.Draw();
            }
        }
        public void Hide()
        {
            foreach (Point point in Points)
            {
                point.Hide();
            }
        }
        public Result TryMove(Direction direction)
        {
            Hide();
            var clone = Clone();
            Move(clone, direction);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;

            Draw();
            return result;
        }
        public Result TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;

            Draw();
            return result;
        }

        protected Result VerifyPosition(Point[] pList)
        {
            foreach (var p in pList)
            {
                //нижняя граница
                if (p.Y >= Fields.Height)
                {
                    return Result.DOWN_BORDER_STRIKE;
                }

                if (p.X < 0 || p.Y < 0 || p.X >= Fields.Width)
                {
                    return Result.BORDER_STRIKE;
                }

                if (Fields.CheckStrike(p))
                {
                    return Result.HEAP_STRIKE;
                }
            }
            return Result.SUCCESS; ;
        }

        protected Point[] Clone()
        {
            Point[] newPoints = new Point[LENGHT];
            for (int i = 0; i < LENGHT; i++)
            {
                newPoints[i] = new Point(Points[i]);
            }

            return newPoints;
        }

        private void Move(Point[] pList, Direction direction)
        {
            foreach (var p in pList)
            {
                p.Move(direction);
            }
        }
        public abstract void Rotate(Point[] pList);

        internal bool IsOnTop()
        {
            return Points[0].Y == 0;
        }
    }
}
