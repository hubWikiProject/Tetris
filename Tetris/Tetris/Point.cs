using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Point
    {
        int x, y;
        char symbol;
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.symbol = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
