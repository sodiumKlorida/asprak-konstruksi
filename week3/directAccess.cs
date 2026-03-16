using System;
using System.Collections.Generic;
using System.Text;

namespace week3
{
    internal class directAccess
    {
        public static int GetDaysPerMonth(int month)
        {
            int[] daysPerMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return daysPerMonth[month - 1];
        }
    }
}
