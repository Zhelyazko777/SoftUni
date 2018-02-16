using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int minLength = Math.Min(array1.Length, array2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (array1[i] < array2[i])
                {
                    foreach (char item in array1)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();

                    foreach (char item in array2)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    return;
                }
                else if (array2[i] < array1[i])
                {
                    foreach (char item in array2)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();

                    foreach (char item in array1)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    return;
                }
            }

            if (array1.Length < array2.Length)
            {
                Console.WriteLine(new string(array1));
                Console.WriteLine(new string(array2));
            }
            else
            {
                Console.WriteLine(new string(array2));
                Console.WriteLine(new string(array1));
            }
        }
    }
}
