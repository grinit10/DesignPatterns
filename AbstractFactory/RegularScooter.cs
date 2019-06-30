using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }
}
