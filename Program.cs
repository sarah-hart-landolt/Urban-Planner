using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Stories = 10,
                Width = 3000,
                Depth = 1000,

            };

            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Jordan Hampton");

            Building MySecondBuilding = new Building("111 1st Street")
            {
                Stories = 20,
                Width = 4000,
                Depth = 2000,

            };
            MySecondBuilding.Construct();
            MySecondBuilding.Purchase("Julie Whitford");

            Building MyThirdBuilding = new Building("222 2nd Street")
            {
                Stories = 30,
                Width = 5000,
                Depth = 2000,

            };
            MyThirdBuilding.Construct();
            MyThirdBuilding.Purchase("Whitney Kelly");

            City Megalopolis = new City("Megalopolis", "Sarah Landolt", "1985");

            Megalopolis.addBuilding(FiveOneTwoEigth);
            Megalopolis.addBuilding(MySecondBuilding);
            Megalopolis.addBuilding(MyThirdBuilding);

            foreach (Building building in Megalopolis.CityBuildingsCollection)
            {
                Console.WriteLine(building.BuildingReport);
            }
        }
    }

}