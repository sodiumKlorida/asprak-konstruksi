using System;
using System.Collections.Generic;
using System.Text;

namespace week1
{
    internal class input_output
    {
        // FUNGSI INPUT
        public static void InputOutput()
        {
            Console.WriteLine("input your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }

        // FUNGSI OUTPUT
        public void Output() {
            Console.WriteLine("Hello World!");
        }
    }
}
