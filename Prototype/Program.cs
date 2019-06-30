using System;

namespace Prototype
{
    class Program
    {
        static void Main()
        {
            var firstPerson = new Person(new[] { "Arnab", "Jon", "Smith" }, new Address("Ayyappa Society Main Road", 256334));
            var secondPerson = Extensions.DeepCopyUsingXmlSerializer(firstPerson);
            secondPerson.Names = new[] { "Arpita", "Jon", "Smith" };
            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
            Console.ReadLine();
        }
    }
}
