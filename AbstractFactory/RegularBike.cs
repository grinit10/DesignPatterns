using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class RegularBike : IBike
    {
        public string Name()
        {
            return "Regular Bike- Name";
        }
    }
}
