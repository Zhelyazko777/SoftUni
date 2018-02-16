using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double kilomiters = miles * 1.60934;
            Console.WriteLine($"{kilomiters:F2}");
        }
    }
}
