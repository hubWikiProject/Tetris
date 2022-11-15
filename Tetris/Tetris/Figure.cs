using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Figure
    {
        protected Point[] points = new Point[4];
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

        public void Move(Direction direction)
        {
            if(IsScreenBorder(direction))
                return;

            Hide();
            foreach (Point point in points)
            {
                point.Move(direction);
            }
            Draw();
        }

        private bool IsScreenBorder(Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    if (points[0].x - 1 == 0
                        || points[1].x - 1 == 0
                        || points[2].x - 1 == 0
                        || points[3].x - 1 == 0)
                        return true;
                    break;
                case Direction.RIGHT:
                    if (points[0].x + 1 == 40
                        || points[1].x + 1 == 40
                        || points[2].x + 1 == 40
                        || points[3].x + 1 == 40)
                        return true;
                    break;
                case Direction.DOWN:
                    if (points[0].y + 1 == 30
                        || points[1].y + 1 == 30
                        || points[2].y + 1 == 30
                        || points[3].y + 1 == 30)
                        return true;
                    break;
                default:
                    break;
            }
            
            foreach(Point point in points)
            {
                
            }
            return false;
        }

        public abstract void Rotate();
    }
}
