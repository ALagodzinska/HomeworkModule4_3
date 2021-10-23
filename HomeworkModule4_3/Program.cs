using System;

namespace HomeworkModule4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_SUM();
            Task_FindEvenOdd();

            #region Task1_SUM

            static void Task_SUM() 
            {
                int[] intArray = { 2, 4, 5, 6, 7, 8, 9, 32, 21, 2 };
                int sum = 0;

                for (int i = 0; i < intArray.Length; i++)
                {
                    Console.WriteLine($"STEP BY STEP: {sum} + {intArray[i]} = {sum + intArray[i]}");
                    sum = sum + intArray[i];
                }
                Console.WriteLine($"SUM of all numbers in array = {sum}");
                Console.ReadLine();
            }
                      
            #endregion

            #region Task2_FindEvenOdd
            
            static void Task_FindEvenOdd()
            {
                int[] integerArray = { 22, 33, 42, 233, 53, 78, 45, 34 };

                Console.Write($"Even number:");
                foreach (int item in integerArray)
                {
                    if (item % 2 == 0)
                    {
                        Console.Write($"{item}; ");
                    }
                }
                Console.WriteLine();

                Console.Write($"Odd number:");
                foreach (int item in integerArray)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write($"{item}; ");
                    }
                }
                Console.WriteLine();

                Console.ReadLine();
            }            

            #endregion

        }
    }
}
