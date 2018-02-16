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
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestStartIndex = 0;
            int bestLength = 0;
            int currentLenght = 0;
            int currentIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    currentLenght++;
                    if (currentLenght > bestLength)
                    {
                        bestLength = currentLenght;
                        bestStartIndex = currentIndex;
                    }
                }
                else
                {
                    currentLenght = 0;
                    currentIndex = i;
                }

            }
            for (int i = bestStartIndex; i <= bestLength + bestStartIndex; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
