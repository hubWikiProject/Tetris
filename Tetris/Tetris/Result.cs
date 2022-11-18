using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public enum Result
    {
        BORDER_STRIKE,
        DOWN_BORDER_STRIKE,
        HEAP_STRIKE,
        SUCCESS,
        GAME_OVER,
    }
}
