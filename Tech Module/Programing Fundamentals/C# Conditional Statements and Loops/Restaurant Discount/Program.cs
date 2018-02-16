using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfPeople = double.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double sum = 0;
            if (numOfPeople <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                if (package == "Normal")
                {
                    sum = ((2500 + 500) - ((2500 + 500) * 5 / 100)) / numOfPeople;

                }
                else if (package == "Gold")
                {
                    sum = ((2500 + 750) - ((2500 + 750) * 10 / 100)) / numOfPeople;
                }
                else
                {
                    sum = ((2500 + 1000) - (2500 + 1000) * 15 / 100) / numOfPeople;
                }
                Console.WriteLine($"The price per person is {(sum):F2}$");
            }
            else if (numOfPeople <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                if (package == "Normal")
                {
                    sum = ((5000 + 500) - (5000 + 500) * 5 / 100) / numOfPeople;
                }
                else if (package == "Gold")
                {
                    sum = ((5000 + 750) - (5000 + 750) * 10 / 100) / numOfPeople;
                }
                else
                {
                    sum = ((5000 + 1000) - (5000 + 1000) * 15 / 100) / numOfPeople;
                }
                Console.WriteLine($"The price per person is {(sum):F2}$");
            }
            else if (numOfPeople <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                if (package == "Normal")
                {
                    sum = ((7500 + 500) - (7500 + 500) * 5 / 100) / numOfPeople;
                }
                else if (package == "Gold")
                {
                    sum = ((7500 + 750) - (7500 + 750) * 10 / 100) / numOfPeople;
                }
                else
                {
                    sum = ((7500 + 1000) - (7500 + 1000) * 15 / 100) / numOfPeople;
                }
                Console.WriteLine($"The price per person is {(sum):F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
