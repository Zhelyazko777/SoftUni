using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinations = 0;
            int sum = 0;

            bool keepLooping = true;

            int currentI = 0;
            int currentJ = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combinations++;
                    sum = i + j;
                    if (sum == magicNum)
                    {
                        currentI = i;
                        currentJ = j;
                        keepLooping = false;
                        break;
                    }
                }
                if (keepLooping == false)
                {
                    break;
                }
            }

            if (keepLooping == false)
            {
                Console.WriteLine($"Number found! {currentJ} + {currentI} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
