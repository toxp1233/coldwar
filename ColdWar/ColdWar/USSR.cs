using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdWar
{
    public class USSR : Country
    {
        public string Leader { get; set; }

        public USSR(int population, List<string> cities, int warHeads, string leader)
            : base("USSR", population, cities, warHeads)
        {
            Leader = leader;
        }

        // Override the CalculateIncome method
        public override decimal CalculateIncome()
        {
            // USSR could have a different income calculation
            return base.CalculateIncome() * 0.8m; // Example: 20% less income
        }

        public void DisplayUSSRInfo()
        {
            Console.WriteLine($"Leader: {Leader}");
        }
    }
}
