using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class PrintVertically
    {
        public static IList<string> printVertically(string s)
        {
            var results = new List<string>();
            if ((s.Length >= 1 && s.Length <= 200))
            {
                var words = s.Split(' ');
                var max = words.Select(word => word.Length).Max();

                for (var i = 0; i < max; i++)
                {
                    var sb = new StringBuilder();
                    foreach (var word in words)
                    {
                        sb.Append(i < word.Length ? word[i] : ' ');
                    }
                    results.Add(sb.ToString().TrimEnd());
                }
            }
            else
            {
                Console.WriteLine("Letters in S must be greater than 1 and less than 200 and letters must be in capital");
            }
            return results;
        }
    }
}
