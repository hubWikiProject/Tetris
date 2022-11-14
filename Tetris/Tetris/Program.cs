using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        /*Figure[] figures = new Figure[2];
        figures[0] = new Square(7, 1, '*');
        figures[1] = new Stick(4, 4, '*');

        foreach (Figure figure in figures)
        {
            figure.Draw();
            figure.Move(Direction.LEFT);
        }*/

        Figure square = new Stick(25, 4, '*');
        square.Draw();

        Thread.Sleep(500);
        square.Hide();
        square.Rotate();
        square.Draw();

        Thread.Sleep(500);
        square.Hide();
        square.Move(Direction.LEFT);
        square.Draw();

        Thread.Sleep(500);
        square.Hide();
        square.Move(Direction.DOWN);
        square.Draw();

        Thread.Sleep(500);
        square.Hide();
        square.Move(Direction.RIGHT);
        square.Draw();

        Thread.Sleep(500);
        square.Hide();
        square.Move(Direction.DOWN);
        square.Draw();

        Thread.Sleep(500);
        square.Hide();
        square.Rotate();
        square.Draw();

        Console.ReadLine();
    }
}
