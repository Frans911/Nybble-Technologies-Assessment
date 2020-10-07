using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Substrings
    {
        public static int numberOfSubstrings(string s)
        {
            int answer = 0;
            int[] digits = new int[3];
            if ((s.Length >= 3 && s.Length <= 5 * Math.Pow(10, 4)) && (s.Contains('a') || s.Contains('b') || s.Contains('c')))
            {
                for (int i = 0, j = 0; i < s.Length; i++)
                {
                    digits[s[i] - 'a']++;
                    while (digits[0] > 0 && digits[1] > 0 && digits[2] > 0)
                    {
                        answer += s.Length - i;
                        digits[s[j] - 'a']--;
                        j++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Your s must have more than 3 letters and less than 5000 letters and s consist of only a, b and c");
            }
            return answer;
        }
    }
}
