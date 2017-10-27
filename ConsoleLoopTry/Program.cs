using System;
using System.Threading;

namespace ConsoleLoopTry
{
    class Program
    {
        static void Main(string[] args)
        {         

            int x = 1000000000;
            while (x > 3)
            {
                x--;
                Thread.Sleep(20);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(x + "Q"+ x + "V" + x + "D" + x + "H" + x + "K" + x + "M" + x + "N" + x + "C" + x + "A" + x + "Y" + x + "I" + x );
            }
        }
    }
}
