using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicles
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }
        public void Drive() 
        {
            Console.WriteLine("The Motorcycle is revving up!");
        }

    }
}
