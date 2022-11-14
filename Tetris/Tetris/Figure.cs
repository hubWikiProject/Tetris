using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Figure
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
            foreach (Point point in points)
            {
                point.Move(direction);
            }
        }
    }
}
