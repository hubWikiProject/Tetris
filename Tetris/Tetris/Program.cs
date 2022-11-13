using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        Point p1 = new Point(3, 4, '#');
        p1.Draw();

        Point p2 = new Point(1, 3, '*');
        p2.Draw();

        Console.ReadLine();
    }
}
