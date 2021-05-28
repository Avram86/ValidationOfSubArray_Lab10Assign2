using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelper
{
    public static class ArrayUtilities
    {
        public static int[] CreateArray(int length)
        {
            int[] array = new int[length];

            if(length<1)
            {
                return new int[0];
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Please add a number to the array");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int element))
                {
                    array[i] = element;
                }

            }

            ConsoleUtilities.PrintArray(array);

            return array;
        }

        public static bool CheckIfSubSequenceOfLargerArray(int[] largerArray, int[] shortArray)
        {
            bool isSubArray = false;

            for (int i = 0; i < largerArray.Length; i++)
            {
                for (int j = 0; j < shortArray.Length; j++)
                {
                    if (largerArray[i] == shortArray[j])
                    {
                        isSubArray = true;

                        if (j == shortArray.Length - 1 || i == largerArray.Length - 1)
                        {
                            break;
                        }
                        i++;
                    }
                    else
                    {
                        isSubArray = false;
                    }
                  
                }
            }
            return isSubArray;
        }
    }
}
