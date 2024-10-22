using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdWar
{
    public class USA : Country
    {
        public string President { get; set; }

        public USA(int population, List<string> cities, int warHeads, string president)
            : base("USA", population, cities, warHeads)
        {
            President = president;
        }

        public override decimal CalculateIncome()
        {
            // USA could have a different income calculation
            return base.CalculateIncome() * 1.2m; // Example: 20% more income
        }

        public void DisplayUSAInfo()
        {
            Console.WriteLine($"President: {President}");
        }
    }
}
