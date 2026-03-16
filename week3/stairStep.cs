using System;
using System.Collections.Generic;
using System.Text;

namespace week3
{
    internal class stairStep
    {
        public static string GetGrade(double score)
        {
            string[] grade = { "A", "AB", "B" };
            double[] limit = { 80.0, 70.0, 65.0 };

            string result = "E";
            int level = 0;

            while (result == "E" && level < limit.Length)
            {
                if (score > limit[level])
                {
                    result = grade[level];
                }

                level++;
            }

            return result;
        }
    }
}
