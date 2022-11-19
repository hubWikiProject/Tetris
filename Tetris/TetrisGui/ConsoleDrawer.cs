using System;

namespace TetrisGui
{
    internal class ConsoleDrawer : IDrawer
    {
        public void DrawPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('#');
            Console.SetCursorPosition(0, 0);
        }

        public void HidePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            Console.SetCursorPosition(0, 0);
        }

        public void InitField()
        {
            Console.SetWindowSize(Fields.Width, Fields.Height);
            Console.SetBufferSize(Fields.Width, Fields.Height);
        }

        public void WriteGameOver()
        {
            Console.SetCursorPosition(Fields.Width / 2 - 5, Fields.Height / 2);
            Console.Write("GAME OVER!");
        }
    }
}
