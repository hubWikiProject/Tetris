using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        Point p1 = new Point();
        p1.x = 3;
        p1.y = 4;
        p1.c = '*';
        p1.Draw();
        Console.ReadLine();
    }
}
