using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bestLength = 0;
            var currentLength = 0;
            var bestStartindex = 0;
            var currentIndex = 0;
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 0;
                    currentIndex = i + 1;
                }
                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestStartindex = currentIndex;
                }
            }
            for (int i = bestStartindex; i <= bestLength + bestStartindex; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
