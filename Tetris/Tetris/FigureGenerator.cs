using Tetris;

class FigureGenerator
{
    private int _x, _y;
    private char _symbol;

    public FigureGenerator(int x, int y, char symbol)
    {
        _x = x;
        _y = y;
        _symbol = symbol;
    }

    public Figure GetNewFigure()
    {
        Random random = new Random();
        if (random.Next(0, 2) == 0)
        {
            return new Square(_x, _y, _symbol);
        }
        else
        {
            return new Stick(_x, _y, _symbol);
        }
    }
}