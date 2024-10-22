using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ColdWar
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public List<string> Cities { get; set; }
        public int WarHeads { get; set; }
        public decimal Income { get; set; }

        private System.Timers.Timer incomeTimer; 

        public Country(string name, int population, List<string> cities, int warHeads)
        {
            Name = name;
            Population = population;
            Cities = cities;
            WarHeads = warHeads;
            Income = CalculateIncome();

           
            incomeTimer = new System.Timers.Timer(600); 
            incomeTimer.Elapsed += OnIncomeUpdate;
            incomeTimer.AutoReset = true; 
            incomeTimer.Enabled = true;
        }

        private void OnIncomeUpdate(object sender, ElapsedEventArgs e)
        {
            decimal incomeIncrease = CalculateIncome();
            Income += incomeIncrease;
            Console.WriteLine($"{Name}'s income increased by {incomeIncrease}C. Total Income: {Income}C");
        }

        public virtual decimal CalculateIncome()
        {
            return (Population / 1000) * 10;
        }

        public void BuyWarheads(int numberOfWarheads)
        {
            decimal cost = numberOfWarheads * 10; // 10 coins per warhead

            if (Income >= cost)
            {
                Income -= cost;
                WarHeads += numberOfWarheads;
                Console.WriteLine($"{Name} bought {numberOfWarheads} warheads. Remaining Income: {Income:C}. Total Warheads: {WarHeads}");
            }
            else
            {
                Console.WriteLine($"{Name} does not have enough income to buy {numberOfWarheads} warheads. Required: {cost:C}, Available: {Income:C}");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Country: {Name}");
            Console.WriteLine($"Population: {Population}");
            Console.WriteLine("Cities: " + string.Join(", ", Cities));
            Console.WriteLine($"WarHeads: {WarHeads}");
            Console.WriteLine($"Income: {Income:C}");
        }
    }
}
