using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        for (int i = 0; i <= 3; i++)
        {
            Square square = new Square(1, i, '*');
            square.Draw();
        }

        Console.ReadLine();
    }
}
