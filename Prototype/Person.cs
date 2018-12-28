using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    [Serializable]
    public class Person
    {
        public string[] Names { get; set; }
        public Address Address { get; set; }
        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }
        public Person()
        {

        }
        public override string ToString() => $"Name: {string.Join(" ", Names)}\nAddress: {Address.ToString()}";

    }
}
