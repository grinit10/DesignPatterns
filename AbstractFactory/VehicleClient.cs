using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class VehicleClient
    {
        Bike bike;
        Scooter scooter;

        public VehicleClient(VehicleFactory factory, string type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }
    }
}
