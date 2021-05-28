using System;

namespace ValidationOfSubArray_Lab10Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of the larger array= ");
            string input1 = Console.ReadLine();

            if(int.TryParse(input1, out int lengthLargerArray))
            {
                int[] largerArray = ArrayHelper.ArrayUtilities.CreateArray(lengthLargerArray);

                Console.WriteLine("Please enter the length of the smaller array= ");
                string input2 = Console.ReadLine();

                if(int.TryParse(input2, out int lengthShorterArray))
                {
                    int[] shorterArray=ArrayHelper.ArrayUtilities.CreateArray(lengthShorterArray);

                    bool isSubArray = ArrayHelper.ArrayUtilities.CheckIfSubSequenceOfLargerArray(largerArray, shorterArray);

                    Console.WriteLine($"The shorter array represents a sub-sequence of the larger array: {isSubArray}");
                }
                else
                {
                    Console.WriteLine("Please write a number!");
                }
            }
            else
            {
                Console.WriteLine("Please write a number!");
            }
        }
         

        
    }
}
