namespace AbstractFactory
{
    internal class VehicleClient
    {
        private readonly IBike _bike;
        private readonly IScooter _scooter;

        public VehicleClient(IVehicleFactory factory, string type)
        {
            _bike = factory.GetBike(type);
            _scooter = factory.GetScooter(type);
        }

        public string GetBikeName()
        {
            return _bike.Name();
        }

        public string GetScooterName()
        {
            return _scooter.Name();
        }
    }
}
