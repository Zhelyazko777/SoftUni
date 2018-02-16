using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var currentLength = 0;
            var currentIndex = 0;
            var bestStartIndex = 0;
            var bestLength = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + 1 == nums[i + 1])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStartIndex = currentIndex;
                    }
                    
                }
                else
                {
                    currentIndex = i + 1;
                    currentLength = 0;
                }
            }
            for (int i = bestStartIndex; i <= bestLength + bestStartIndex; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
