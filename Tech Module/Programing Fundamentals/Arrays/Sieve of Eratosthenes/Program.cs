using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool[] primes = new bool[num + 1];
            primes[0] = primes[1] = false;
            for (int i = 2; i <= num; i++)
            {
                primes[i] = true;
            }
            for (int i = 0; i <= num; i++)
            {
                if (!primes[i])
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
                for (int j = 2 * i; j <= num; j += i)
                {
                    primes[j] = false;
                }
            }
        }
    }
}
