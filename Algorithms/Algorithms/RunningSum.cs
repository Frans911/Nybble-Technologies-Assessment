using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class RunningSum
    {
        public static int[] runningSum(int[] numbers)
        { 
            for (int x = 1; x < numbers.Length; x++)
            { 
                numbers[x] += numbers[x - 1];
            }
            return numbers;
        }
    }
}
