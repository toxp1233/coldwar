using ColdWar;
using System;




class Program
{
    static void Main()
    {
        List<string> usaCities = new List<string> { "New York", "Los Angeles", "Chicago" };
        USA usa = new USA(300000000, usaCities, 5000, "Joe Biden");
        usa.DisplayInfo();
        usa.DisplayUSAInfo();

        Console.WriteLine("---------------------------------------------");
        List<string> ussrCities = new List<string> { "Moscow", "Saint Petersburg", "Kyiv" };
        USSR ussr = new USSR(250000000, ussrCities, 4000, "Mikhail Gorbachev");
        ussr.DisplayInfo();
        ussr.DisplayUSSRInfo();

        // Keep the program running to allow the timer to update income
        Console.WriteLine("Press [Enter] to stop the program.");
        Console.ReadLine();

    }
}





