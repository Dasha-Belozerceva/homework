using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var cursorMove = new CursorMove();

            eventLoop.LeftHandler += cursorMove.OnLeft;
            eventLoop.RightHandler += cursorMove.OnRight;
            eventLoop.UpHandler += cursorMove.OnUp;
            eventLoop.DownHandler += cursorMove.OnDown;

            eventLoop.Run();
        }
    }
}
