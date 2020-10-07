using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class RunningSum
    {
        public static int[] runningSum(int[] numbers)
        {
            if ((numbers.Length >= 1 && numbers.Length <= 1000))
            {
                for (int x = 1; x < numbers.Length; x++)
                {
                    if (numbers[x] >= Math.Pow(-10,6) * -1 && numbers[x] <= Math.Pow(10,6))
                    {
                        numbers[x] += numbers[x - 1];
                    }
                    else
                    {
                        Console.WriteLine("Your values must range from -1000000 to 1000000");
                        break;
                    }
                }
            }
            else 
            {
                Console.WriteLine("Your list is too large");
            }

            return numbers;
        }
    }
}
