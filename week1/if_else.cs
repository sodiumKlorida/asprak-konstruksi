using System;
using System.Collections.Generic;
using System.Text;

namespace week1
{
    internal class if_else
    {
        // FUNGSI IF ELSE
        public static void IfElse()
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
        }
    }
}
