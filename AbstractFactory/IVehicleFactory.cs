namespace AbstractFactory
{
    internal interface IVehicleFactory
    {
        IBike GetBike(string bike);
        IScooter GetScooter(string scooter);
    }
}
