using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    static class Fields
    {
        private static int _width = 30;
        private static int _height = 40;
        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.SetWindowSize(Fields.Height, Fields.Width);
                Console.SetBufferSize(Fields.Height, Fields.Width);
            }
        }

        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.SetWindowSize(Fields.Height, Fields.Width);
                Console.SetBufferSize(Fields.Height, Fields.Width);
            }
        }
    }
}
