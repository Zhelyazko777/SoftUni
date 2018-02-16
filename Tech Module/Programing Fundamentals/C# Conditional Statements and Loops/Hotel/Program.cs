using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            double numOfNights = double.Parse(Console.ReadLine());
            double priceStudio = 0.00;
            double priceDoubleRoom = 0.00;
            double priceSuit = 0.00;
            if (mounth == "May" || mounth == "October")
            {
                priceStudio = 50;
                priceDoubleRoom = 65;
                priceSuit = 75;
            }
            else if (mounth == "June" || mounth == "September")
            {
                priceStudio = 60;
                priceDoubleRoom = 72;
                priceSuit = 82;
            }
            else
            {
                priceStudio = 68;
                priceDoubleRoom = 77;
                priceSuit = 89;
            }

            // Discounts
            if ((mounth == "May" || mounth == "October") && numOfNights > 7)
            {
                priceStudio *= 0.95;
            }
            if ((mounth == "June" || mounth == "September") && numOfNights > 14)
            {
                priceDoubleRoom *= 0.90;
            }
            if ((mounth == "July" || mounth == "August" || mounth == "December") && numOfNights > 14)
            {
                priceSuit *= 0.85;
            }
            var totalStudio = priceStudio * numOfNights;
            var totalDouble = priceDoubleRoom * numOfNights;
            var totalSuit = priceSuit * numOfNights;
            if ((mounth == "September" || mounth == "October") && numOfNights > 7)
            {

                totalStudio -= priceStudio;

            }
            Console.WriteLine($"Studio: {totalStudio:F2} lv.");
            Console.WriteLine($"Double: {totalDouble:F2} lv.");
            Console.WriteLine($"Suite: {totalSuit:F2} lv.");
        }
    }
}


