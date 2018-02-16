using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < nums.Length; i++)
            {
                var leftSum = 0;
                var rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += nums[j];
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    rightSum += nums[j];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
                Console.WriteLine("no");
        }
    }
}
