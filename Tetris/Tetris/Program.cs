using Tetris;

public class Program
{
    static FigureGenerator generator;
    private static void Main(string[] args)
    {
        Console.SetWindowSize(Fields.Width, Fields.Height);
        Console.SetBufferSize(Fields.Width, Fields.Height);

        generator = new FigureGenerator(Fields.Width / 2, 0, Drawer.DEFAULT_SYMBOL);
        Figure figure = generator.GetNewFigure();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                var result = HandleKey(figure, key);
                ProcessResult(result, ref figure);
            }
        }

        Console.ReadLine();

        static Result HandleKey(Figure figure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    return figure.TryMove(Direction.RIGHT);
                case ConsoleKey.LeftArrow:
                    return figure.TryMove(Direction.LEFT);
                case ConsoleKey.DownArrow:
                    return figure.TryMove(Direction.DOWN);
                case ConsoleKey.Spacebar:
                    return figure.TryRotate();
            }
            return Result.SUCCESS;
        }
    }

    private static bool ProcessResult(Result result, ref Figure figure)
    {
        if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
        {
            Fields.AddFigure(figure);
            Fields.TryDeleteLines();
            figure = generator.GetNewFigure();
            return true;
        }
        else
        {
            return false;
        }
    }
}