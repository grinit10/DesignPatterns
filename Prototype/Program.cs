using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstperson = new Person(new[] { "Arnab", "Jon", "Smith" }, new Address("Ayyappa Society Main Road", 256334));
            Person secondperson = Extensions.DeepCopyUsingXmlSerializer(firstperson);
            secondperson.Names = new[] { "Arpita", "Jon", "Smith" };
            Console.WriteLine(firstperson);
            Console.WriteLine(secondperson);
            Console.ReadLine();
        }
    }
}
