using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Point
    {
        public int x, y;
        private char symbol;
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.symbol = sym;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    x -= 1;
                    break;
                case Direction.RIGHT:
                    x += 1;
                    break;
                case Direction.DOWN:
                    y += 1;
                    break;
                default:
                    break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}
