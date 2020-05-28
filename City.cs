using System;
using System.Collections.Generic;

namespace Planner
{

    public class City
    {
        // Public Properties
        public string CityName { get; set; }

        public string Mayor { get; set; }

        public string YearEstablished { get; set; }

        public City(string cityName, string mayor, string yearEstablished)
        {
            CityName = cityName;
            Mayor = mayor;
            YearEstablished=yearEstablished;

        }


        public List<Building> CityBuildingsCollection { get; set; } = new List<Building> ();
        
        public void addBuilding(Building Building) {

                CityBuildingsCollection.Add(Building);
        }


    }
}