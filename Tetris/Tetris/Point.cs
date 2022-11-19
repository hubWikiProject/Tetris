namespace Tetris
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Symbol = p.Symbol;
        }
        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Symbol = sym;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGHT:
                    X += 1;
                    break;
                case Direction.DOWN:
                    Y += 1;
                    break;
                case Direction.UP:
                    Y -= 1;
                    break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
            Console.SetCursorPosition(0, 0);
        }

        public void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
    }
}
