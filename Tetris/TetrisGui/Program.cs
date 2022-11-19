using System.Threading;
using System;
using System.Timers;
using TetrisGui;
using Microsoft.SmallBasic.Library;

public class Program
{
    const int TIMER_INTERVAL = 500;
    static System.Timers.Timer aTimer;

    static private Object _lockObject = new object();

    static Figure figure;
    static FigureGenerator factory = new FigureGenerator(Fields.Width / 2, 0);

    static private bool gameOver = false;

    static void Main(string[] args)
    {
        DrawerProvider.Drawer.InitField();

        SetTimer();
        figure = factory.GetNewFigure();
        figure.Draw();
        GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
    }

    private static void GraphicsWindow_KeyDown()
    {
        Monitor.Enter(_lockObject);

        var result = HandleKey(figure, GraphicsWindow.LastKey);

        if (GraphicsWindow.LastKey == "Down")
            gameOver = ProcessResult(result, ref figure);

        Monitor.Exit(_lockObject);
    }

    private static void SetTimer()
    {
        if (!gameOver)
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(TIMER_INTERVAL);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Monitor.Enter(_lockObject);
        var result = figure.TryMove(Direction.DOWN);
        gameOver = ProcessResult(result, ref figure);
        if (gameOver)
            aTimer.Stop();
        Monitor.Exit(_lockObject);
    }

    private static bool ProcessResult(Result result, ref Figure figure)
    {
        if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
        {
            Fields.AddFigure(figure);
            Fields.TryDeleteLines();

            if (figure.IsOnTop())
            {
                DrawerProvider.Drawer.WriteGameOver();
                return true;
            }
            else
            {
                figure = factory.GetNewFigure();
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    private static Result HandleKey(Figure figure, ConsoleKeyInfo key)
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

    private static Result HandleKey(Figure figure, Primitive key)
    {
        string lastKey = (string)key;
        switch (lastKey)
        {
            case "Right":
                return figure.TryMove(Direction.RIGHT);
            case "Left":
                return figure.TryMove(Direction.LEFT);
            case "Down":
                return figure.TryMove(Direction.DOWN);
            case "Space":
                return figure.TryRotate();
        }
        return Result.SUCCESS;
    }
}