using System;

namespace AbstractFactory
{
    internal static class Program
    {
        private static void Main()
        {
            IVehicleFactory honda = new HondaFactory();
            var hondaClient = new VehicleClient(honda, "Regular");

            Console.WriteLine("******* Honda **********");
            Console.WriteLine(hondaClient.GetBikeName());
            Console.WriteLine(hondaClient.GetScooterName());

            hondaClient = new VehicleClient(honda, "Sports");
            Console.WriteLine(hondaClient.GetBikeName());
            Console.WriteLine(hondaClient.GetScooterName());

            IVehicleFactory hero = new HeroFactory();
            var heroClientlient = new VehicleClient(hero, "Regular");

            Console.WriteLine("******* Hero **********");
            Console.WriteLine(heroClientlient.GetBikeName());
            Console.WriteLine(heroClientlient.GetScooterName());

            heroClientlient = new VehicleClient(hero, "Sports");
            Console.WriteLine(heroClientlient.GetBikeName());
            Console.WriteLine(heroClientlient.GetScooterName());

            Console.ReadKey();
        }
    }
}
