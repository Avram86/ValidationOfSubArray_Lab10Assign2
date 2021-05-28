using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelper
{
    public static class ConsoleUtilities
    {

        public static void PrintArray(int[] array)
        {
            foreach (var elem in array)
            {
                Console.Write($"{elem}, ");
            }

            Console.WriteLine();
        }
    }
}
