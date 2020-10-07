using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class LongestOnes
    {
        public static int longestOnes(int[] A, int K)
        {
            
            int left = 0;
            int right = 0;
            int max = 0;
            int n = A.Length;

            if ((A.Length >= 1 && A.Length <= 20000) && (K >= 0 && K <= A.Length))
            {
                foreach (var element in A)
                {
                    if (element >= 0 && element <= 1)
                    {
                        while (right < n)
                        {
                            if (A[right] == 0)
                            {
                                if (K == 0)
                                {
                                    while (A[left] == 1)
                                    {
                                        left++;
                                    }
                                    left++;
                                    K++;
                                }
                                K--;
                            }
                            max = Math.Max(max, (right++) - left + 1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Digits in A can be 0 or 1");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Number of digits in A must be greater than 1 and less than 20000, K must be greater than 0 and less or equals to number of digits in A");
            }
            return max;
        }
    }
}
