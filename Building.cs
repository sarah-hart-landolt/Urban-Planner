using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building
    {

        private string _designer = "Sarah Hart Landolt";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;




        // Public Properties
        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

    public Building(string Address) {
        _address = Address;
    }

     public void Construct() 
     {
        _dateConstructed  = DateTime.Now;
    }

     public void Purchase(string Name) 
     {
        _owner  = Name;
    }
    }
}