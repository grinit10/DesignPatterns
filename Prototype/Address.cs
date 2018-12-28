using System;

namespace Prototype
{
    [Serializable]
    public class Address
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }
        public Address()
        {

        }
        public override string ToString() => $"{StreetName} {HouseNumber.ToString()}";
    }
}