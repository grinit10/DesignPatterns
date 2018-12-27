using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(FirstInvoke, SecondInvoke);
            //Console.WriteLine(new Singleton().RandomNum);
            //Console.WriteLine(new Singleton().RandomNum);
            Console.ReadLine();
        }

        private static void SecondInvoke()
        {
            Console.WriteLine(Singleton.GetInstance().RandomNum);
        }

        private static void FirstInvoke()
        {
            Console.WriteLine(Singleton.GetInstance().RandomNum);
        }
    }
}
