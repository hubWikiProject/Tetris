﻿namespace TetrisGui
{
    static class Fields
    {
        private static int _width = 20;
        private static int _height = 20;
        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
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

        public static Result AddFigure(Figure figure)
        {
            foreach (var p in figure.Points)
            {
                if (p.Y == 0)
                {
                    return Result.GAME_OVER;
                }
                _heap[p.Y][p.X] = true;
            }
            return Result.SUCCESS;
        }

        public static void TryDeleteLines()
        {
            for (int j = 0; j < Height; j++)
            {
                int counterLineFull = 0;
                foreach (var i in _heap[j])
                {
                    counterLineFull += i ? 1 : 0;
                }

                if (counterLineFull == Width)
                {
                    DeleteLine(j);
                    Redraw();
                }
            }
        }

        private static void Redraw()
        {
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    if (_heap[j][i])
                        DrawerProvider.Drawer.DrawPoint(i, j);
                    else
                        DrawerProvider.Drawer.HidePoint(i, j);
                }
            }
        }

        private static void DeleteLine(int line)
        {
            for (int j = line; j >= 0; j--)
            {
                for (int i = 0; i < Width; i++)
                {
                    if (j == 0)
                        _heap[j][i] = false;
                    else
                        _heap[j][i] = _heap[j - 1][i];
                }
            }
        }
    }
}
