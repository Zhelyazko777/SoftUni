using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            int counterL = 0;
            int counterR = 0;
            for (int i = 0; i < Math.Min(arr.Length, arr1.Length); i++)
            {
                if (arr[i] == arr1[i])
                {
                    counterL++;
                }
                if (arr[arr.Length - 1 - i] == arr1[arr1.Length - 1 - i])
                {
                    counterR++;
                }
            }
            if (counterL > counterR)
            {
                Console.WriteLine(counterL);
            }
            else
            {
                Console.WriteLine(counterR);
            }
        }
    }
}
