using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[arr.Length];
            for (int i = 0; i < rotations; i++)
            {
                MakesRotations(arr);
                for (int j = 0; j < arr.Length; j++)
                {
                    sum[j] += arr[j];
                }
            }
            Console.WriteLine(String.Join(" ", sum));
        }

        static void MakesRotations(int[] arr)
        {
            int lastNum = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastNum;
        }
    }
}
