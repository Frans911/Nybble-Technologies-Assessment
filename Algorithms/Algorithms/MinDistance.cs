using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MinDistance
    {
        public static int minDistance(string word1, string word2)
        {

            int m = word1.Length;
            int n = word2.Length;
            var dp = new int[m + 1, n + 1];

            if (n * m == 0) {
                return n + m;
            }
            for (int i = 0; i < m + 1; i++) {
                dp[i, 0] = i;
            }
            for (int j = 0; j < n + 1; j++) {
                dp[0, j] = j;
            } 
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (word1[i] == word2[j])
                    {
                        dp[i + 1, j + 1] = dp[i, j];
                    }
                    else 
                    {
                        dp[i + 1, j + 1] = Math.Min(Math.Min(dp[i, j + 1], dp[i + 1, j]), dp[i, j]) + 1;
                    }
                }
            }
            return dp[m, n];
        }
    }
}
