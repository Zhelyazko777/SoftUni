using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            int counter = 0;
            int calories = 0;

            while (num > counter)
            {
                string products = Console.ReadLine();
                products = products.ToLower();
                if (products == "cheese")
                {
                    calories += 500;

                }
                else if (products == "tomato sauce")
                {
                    calories += 150;

                }
                else if (products == "salami")
                {
                    calories += 600;

                }
                else if (products == "pepper")
                {
                    calories += 50;

                }
                counter++;

            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
