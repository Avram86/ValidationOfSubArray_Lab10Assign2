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
                int[] largerArray = CreateArray(lengthLargerArray);

                Console.WriteLine("Please enter the length of the smaller array= ");
                string input2 = Console.ReadLine();

                if(int.TryParse(input2, out int lengthShorterArray))
                {
                    int[] shorterArray=CreateArray(lengthShorterArray);

                    bool isSubArray = CheckIfSubSequenceOfLargerArray(largerArray, shorterArray);

                    Console.WriteLine($"The sorter array represents a sub-sequence of the larger array: {isSubArray}");
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
         static int[] CreateArray(int length)
        {
            int[] array = new int[length];
            
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine("Please add a number to the array");
                string input = Console.ReadLine();

                if(int.TryParse(input, out int element))
                {
                    array[i] = element;
                }
                
            }

            foreach(var elem in array)
            {
                Console.Write($"{elem}, ");
            }

            Console.WriteLine();
            return array;
        }

        static bool CheckIfSubSequenceOfLargerArray(int[] largerArray, int[] shortArray)
        {
            bool isSubArray = false;

            for(int i = 0; i < largerArray.Length; i++)
            {
                    for(int j = 0; j < shortArray.Length; j++)
                    {
                        if (largerArray[i] == shortArray[j])
                        {
                        isSubArray = true;
                        i++;
                        }
                        else if(j==shortArray.Length-1 || i==largerArray.Length-1)
                        {
                        break;
                        }
                        else
                        {
                        isSubArray = false;
                        break;
                        }
                    }
            }
            return isSubArray;
        }
    }
}
