namespace Tetris
{
    internal class Stick : Figure
    {
        public Stick(int x, int y, char symbol)
        {
            Points[0] = new Point(x, y, symbol);
            Points[1] = new Point(x, y + 1, symbol);
            Points[2] = new Point(x, y + 2, symbol);
            Points[3] = new Point(x, y + 3, symbol);

            Draw();
        }

        public override void Rotate()
        {
            if (Points[0].X == Points[1].X)
            {
                RotateHorisontal();
            }
            else
            {
                RotateVertical();
            }
        }

        public override Result TryRotate()
        {
            Hide();
            Rotate();

            var result = VerifyPosition();
            if (result != Result.SUCCESS)
                Rotate();

            Draw();
            return result;
        }

        private void RotateVertical()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].X = Points[0].X;
                Points[i].Y = Points[0].Y + i;
            }
        }

        private void RotateHorisontal()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].Y = Points[0].Y;
                Points[i].X = Points[0].X + i;
            }
        }
    }
}
