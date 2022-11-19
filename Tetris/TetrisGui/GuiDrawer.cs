using Microsoft.SmallBasic.Library;

namespace TetrisGui
{
    internal class GuiDrawer : IDrawer
    {
        private const int SIZE = 20;
        public void DrawPoint(int x, int y)
        {
            GraphicsWindow.PenColor = "DarkGreen";
            GraphicsWindow.PenWidth = 2;
            GraphicsWindow.DrawRectangle(x * SIZE, y * SIZE, SIZE, SIZE);
        }

        public void HidePoint(int x, int y)
        {
            GraphicsWindow.PenColor = "LightGreen";
            GraphicsWindow.PenWidth = 3;
            GraphicsWindow.DrawRectangle(x * SIZE, y * SIZE, SIZE, SIZE);
        }

        public void InitField()
        {
            GraphicsWindow.BackgroundColor = "LightGreen";
            GraphicsWindow.Width = Fields.Width * SIZE;
            GraphicsWindow.Height = Fields.Height * SIZE;
        }

        public void WriteGameOver()
        {
            GraphicsWindow.BrushColor = "Red";
            GraphicsWindow.FontSize = 20;
            GraphicsWindow.DrawText((Fields.Width / 2 - 5) * SIZE, (Fields.Height / 2) * SIZE, "Game Over");
        }
    }
}
