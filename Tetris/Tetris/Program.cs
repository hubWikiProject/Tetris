using Tetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

        Stick stick = new Stick(4, 4, '*');
        stick.Draw();

        Square square = new Square(7, 1, '*');
        square.Draw();
        

        Console.ReadLine();
    }
}
