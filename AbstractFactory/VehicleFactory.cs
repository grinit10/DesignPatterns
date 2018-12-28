using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface VehicleFactory
    {
        Bike GetBike(string Bike);
        Scooter GetScooter(string Scooter);
    }
}
