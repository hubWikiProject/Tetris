using Tetris;

Fields.Width = 30;
Fields.Height = 40;

FigureGenerator generate = new FigureGenerator(10, 0, '*');
Figure figure = generate.GetNewFigure();

while (true)
{
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        HandleKey(figure, key);
    }
}

Console.ReadLine();

static void HandleKey(Figure figure, ConsoleKeyInfo key)
{
    switch (key.Key)
    {
        case ConsoleKey.RightArrow:
            figure.TryMove(Direction.RIGHT);
            break;
        case ConsoleKey.LeftArrow:
            figure.TryMove(Direction.LEFT);
            break;
        case ConsoleKey.DownArrow:
            figure.TryMove(Direction.DOWN);
            break;
        case ConsoleKey.Spacebar:
            figure.TryRotate();
            break;
        default:
            break;
    }
}
