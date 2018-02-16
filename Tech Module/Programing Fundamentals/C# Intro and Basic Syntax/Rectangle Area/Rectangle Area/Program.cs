using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double hA = double.Parse(Console.ReadLine());
            double area = (A * hA);
            Console.WriteLine($"{area:F2}");
        }
    }
}
