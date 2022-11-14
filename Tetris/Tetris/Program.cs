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
        Figure fig;

        while (true)
        {
            FigureFall(out fig, generate);
            fig.Draw();
        }

        Console.ReadLine();
    }

    static void FigureFall(out Figure figure, FigureGenerator generator)
    {
        figure = generator.GetNewFigure();
        figure.Draw();

        for (int i = 0; i < 15; i++)
        {
            figure.Hide();
            figure.Move(Direction.DOWN);
            figure.Draw();
            Thread.Sleep(100);
        }
    }
}
