using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bestNums = 0;
            var currentNums = 0;
            var currentIndex = 0;
            var bestIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        currentNums++;
                        
                    }

                }
                if (currentNums > bestNums)
                {
                    bestNums = currentNums;
                    bestIndex = currentIndex;
                    currentNums = 0;
                }
                else
                {
                    currentNums = 0;
                    currentIndex = i;
                }
            }
            if (bestIndex == 0 )
            {
                Console.WriteLine(nums[bestIndex]);
            }
            else
            {
                Console.WriteLine(nums[bestIndex + 1]);
            }
        }
    }
}
