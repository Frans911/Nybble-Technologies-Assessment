using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Shuffle
    {
        public static int[] shuffle(int[] numbers, int n)
        {
            var value1 = new int[n];
            var value2 = new int[n];

            if ((n >= 1 && n <= 500) && numbers.Length == 2 * n)
            {
                for (var i = 0; i < n; i++)
                {
                    if (numbers[i] >= 1 && numbers[i] <= Math.Pow(10, 3))
                    {
                        value1[i] = numbers[i];
                        value2[i] = numbers[n + i];
                    }
                    else
                    {
                        Console.WriteLine("Your values must range from 1 to 1000...");
                        break;
                    }
                }
                var x = 0;
                var y = 0;
                for (var i = 0; i < 2 * n; i++)
                {
                    if (i % 2 == 0)
                    {
                        numbers[i] = value1[x];
                        x++;
                    }
                    else
                    {
                        numbers[i] = value2[y];
                        y++;
                    }
                }
            }
            return numbers;
        }
    }
}
