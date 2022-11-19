using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal interface IDrawer
    {
        internal void DrawPoint(int x, int y);

        internal void HidePoint(int x, int y);

        internal void WriteGameOver();

        internal void InitField();
    }
}
