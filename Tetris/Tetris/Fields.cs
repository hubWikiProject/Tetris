using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    static class Fields
    {
        private static int _width = 30;
        private static int _height = 40;
        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.SetWindowSize(Fields.Width, Fields.Height);
                Console.SetBufferSize(Fields.Width, Fields.Height);
            }
        }

        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.SetWindowSize(Fields.Width, Fields.Height);
                Console.SetBufferSize(Fields.Width, Fields.Height);
            }
        }

        private static bool[][] _heap;

        static Fields()
        {
            _heap = new bool[Height][];
            for (int i = 0; i < Height; i++)
            {
                _heap[i] = new bool[Width];
            }
        }

        public static bool CheckStrike(Point p)
        {
            return _heap[p.Y][p.X];
        }
        public static void AddFigure(Figure figure)
        {
            foreach (var p in figure.Points)
            {
                _heap[p.Y][p.X] = true;
            }
        }
    }
}
