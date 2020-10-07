using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4 };
            //RunningSum.runningSum(nums);
            //foreach (var item in nums)
            //{
            //    Console.Write("{0} ", item);
            //}

            //int[] nums = { 1, 1, 2, 2 };
            //int n = 7;
            //Shuffle.shuffle(nums, n);
            //foreach (var item in nums)
            //{
            //    Console.Write("{0},", item);
            //}

            //string J = "aA", S = "aAAbbbb";
            //var answer = JewelsInStones.numJewelsInStones(J, S);
            //Console.WriteLine(answer);

            //string s = "abcabc";
            //Console.WriteLine(Substrings.numberOfSubstrings(s));

            //int[] A = { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            //int K = 2; 
            //Console.WriteLine(LongestOnes.longestOnes(A, K));

            string s = "HOW ARE YOU";
            var list = PrintVertically.printVertically(s);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPress any key to continue..."); 
            Console.ReadKey();
        }
    }
}
