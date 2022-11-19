namespace TetrisGui
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
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
            DrawerProvider.Drawer.DrawPoint(X, Y);
        }

        public void Hide()
        {
            DrawerProvider.Drawer.HidePoint(X, Y);
        }
    }
}
