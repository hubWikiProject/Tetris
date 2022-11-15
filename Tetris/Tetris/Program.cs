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

        FigureGenerator generate = new FigureGenerator(10, 0, '*');
        Figure figure = generate.GetNewFigure();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key =  Console.ReadKey();
                HandleKey(figure, key);
            }
        }

        Console.ReadLine();
    }

    private static void HandleKey(Figure figure, ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.RightArrow:
                figure.Move(Direction.RIGHT);
                break;
            case ConsoleKey.LeftArrow:
                figure.Move(Direction.LEFT);
                break;
            case ConsoleKey.DownArrow:
                figure.Move(Direction.DOWN);
                break;
            default:
                break;
        }
    }
}
