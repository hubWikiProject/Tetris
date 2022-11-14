using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        Figure[] figures = new Figure[2];
        figures[0] = new Square(7, 1, '*');
        figures[1] = new Stick(4, 4, '*');

        foreach (Figure figure in figures)
        {
            figure.Draw();
        }

        Console.ReadLine();
    }
}
