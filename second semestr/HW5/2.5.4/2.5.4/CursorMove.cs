using System;

namespace _2._5._4
{
    class CursorMove
    {
        /// <summary>
        /// To the left
        /// </summary>
        public void OnLeft(object sender, EventArgs args)
        {
            if (Console.CursorLeft - 1 < Console.WindowLeft)
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            else
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        /// <summary>
        /// To the right
        /// </summary>
        public void OnRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft > Console.WindowWidth - 2)
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            else
                Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
        }

        /// <summary>
        /// To the up
        /// </summary>
        public void OnUp(object sender, EventArgs args)
        {
            if (Console.CursorTop - 1 < Console.WindowTop)
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            else
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
        }

        /// <summary>
        /// To the down
        /// </summary>
        public void OnDown(object sender, EventArgs args)
        {
            if (Console.CursorTop > Console.WindowHeight)
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            else
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
        }
    }
}