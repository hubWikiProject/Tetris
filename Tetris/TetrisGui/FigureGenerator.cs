using System;
using TetrisGui;

class FigureGenerator
{
    private int _x, _y;

    public FigureGenerator(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public Figure GetNewFigure()
    {
        Random random = new Random();
        if (random.Next(0, 2) == 0)
        {
            return new Square(_x, _y);
        }
        else
        {
            return new Stick(_x, _y);
        }
    }
}