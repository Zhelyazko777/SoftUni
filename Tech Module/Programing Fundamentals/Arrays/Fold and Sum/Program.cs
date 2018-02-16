using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstNums = ReturnFirstNums(arr);
            int[] lastNums = ReturnlastNums(arr);
            int[] midleNums = ReturnMidleNums(firstNums, arr, lastNums);
            SumNums(firstNums, midleNums, lastNums, arr);
        }

        static void SumNums(int[] firstNums, int[] midleNums, int[] lastNums, int[] arr)
        {
            int[] sum = new int[midleNums.Length];
            for (int i = 0; i < firstNums.Length; i++)
            {
                sum[i] = firstNums[i];
            }
            for (int i = firstNums.Length; i < lastNums.Length + firstNums.Length; i++)
            {
                sum[i] = lastNums[midleNums.Length - 1 - i];
            }
            for (int i = 0; i < midleNums.Length; i++)
            {
                sum[i] += midleNums[i];
            }
            Console.WriteLine(String.Join(" ", sum));
        }

        static int[] ReturnMidleNums(int[] firstNums, int[] arr, int[] lastNums)
        {
            int[] midleNums = new int[arr.Length * 1 / 2];
            for (int i = arr.Length * 1 / 4 + 1; i < arr.Length * 3 / 4 + 1; i++)
            {
                midleNums[i - arr.Length * 1 / 4 - 1] = arr[i - 1];
            }
            return midleNums;
        }

        static int[] ReturnlastNums(int[] arr)
        {
            int[] lastNums = new int[arr.Length * 1 / 4];
            for (int i = arr.Length * 3 / 4; i <= arr.Length - 1; i++)
            {
                lastNums[i - arr.Length * 3 / 4] = arr[i];
            }
            return lastNums;
        }

        static int[] ReturnFirstNums(int[] arr)
        {
            int[] firstNums = new int[arr.Length * 1 / 4];
            for (int i = 0; i < arr.Length * 1 / 4; i++)
            {
                firstNums[i] = arr[arr.Length * 1 / 4 - i - 1];
            }
            return firstNums;
        }
    

    }
}
