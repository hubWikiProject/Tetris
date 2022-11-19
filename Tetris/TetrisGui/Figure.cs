namespace TetrisGui
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
            Move(direction);

            var result = VerifyPosition();
            if (result != Result.SUCCESS)
                Move(Reverce(direction));

            Draw();

            return result;
        }

        public abstract Result TryRotate();

        private static Direction Reverce(Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    direction = Direction.RIGHT;
                    break;
                case Direction.RIGHT:
                    direction = Direction.LEFT;
                    break;
                case Direction.UP:
                    direction = Direction.DOWN;
                    break;
                case Direction.DOWN:
                    direction = Direction.UP;
                    break;
            }

            return direction;
        }

        protected Result VerifyPosition()
        {
            foreach (var p in Points)
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

        private void Move(Direction direction)
        {
            foreach (var p in Points)
            {
                p.Move(direction);
            }
        }
        public abstract void Rotate();

        internal bool IsOnTop()
        {
            return Points[0].Y == 0;
        }
    }
}
