using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int momentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new String('|', momentHealth)}{new String('.', maxHealth - momentHealth)}|");
            Console.WriteLine($"Energy: |{new String('|', currentEnergy)}{new String('.', maxEnergy - currentEnergy)}|");
        }
    }
}
