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

            int[] nums = { 1, 1, 2, 2 };
            int n = 2;
            Shuffle.shuffle(nums, n);
            foreach (var item in nums)
            {
                Console.Write("{0},", item);
            }

            Console.WriteLine("\nPress any key to continue..."); 
            Console.ReadKey();
        }
    }
}
