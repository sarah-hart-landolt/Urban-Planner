using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
Building FiveOneTwoEigth = new Building ("512 8th Avenue")
            {
                Width = 3000,
                Depth = 10000,
                Stories = 10,

            };   
            
                FiveOneTwoEigth.Construct ();
            FiveOneTwoEigth.Purchase ("Jordan Hampton");     }
    }
}
