using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class JewelsInStones
    {
        public static int numJewelsInStones(string J, string S)
        {
            int results = 0;
            if ((J.Length <= 50 && S.Length <= 50) && J.Distinct().Count() == J.Count())
            {
                for (int x = 0; x < J.Length; x++)
                {
                    for (int y = 0; y < S.Length; y++)
                    {
                        if (J[x] == S[y])
                        {
                            results++;
                        }
                    }
                }
                return results;
            }
            else
            {
                Console.WriteLine("J and S must have less than 50 letters and letters in J must be distinct"); 
            }
            return 0;
            
        }
    }
}
