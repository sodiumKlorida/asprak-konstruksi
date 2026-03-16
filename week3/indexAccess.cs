using System;
using System.Collections.Generic;
using System.Text;

namespace week3
{
    internal class indexAccess
    {
        public static string indexAccessRun()
        {
            string[] categoryInfo = { "Electronics", "Clothing", "Food" };   // Main table
            int[] productCategory = { 0, 0, 1, 2, 1, 0 };  // Index table

            // Lookup product ID 4:
            return categoryInfo[productCategory[4]];   // → "Clothing"
        }
    }
}
