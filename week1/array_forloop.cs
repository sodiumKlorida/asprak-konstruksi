using System;
using System.Collections.Generic;
using System.Text;

namespace week1
{
    internal class array_forloop
    {
        // FUNGSI ARRAY DENGAN FOR LOOP
        public static void ArrayForLoop()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}
