using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class SportsBike : IBike
    {
        public string Name()
        {
            return "Sports Bike- Name";
        }
    }
}
