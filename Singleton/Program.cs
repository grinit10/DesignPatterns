using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(LazyFirstInvoke, LazySecondInvoke, EagerFirstInvoke, EagerSecondInvoke);
            Console.ReadLine();
        }

        private static void LazySecondInvoke()
        {
            Console.WriteLine(LazySingleton.GetInstance().RandomNum);
        }

        private static void LazyFirstInvoke()
        {
            Console.WriteLine(LazySingleton.GetInstance().RandomNum);
        }

        private static void EagerSecondInvoke()
        {
            Console.WriteLine(EagerSingleton.GetInstance().RandomNum);
        }

        private static void EagerFirstInvoke()
        {
            Console.WriteLine(EagerSingleton.GetInstance().RandomNum);
        }
    }
}
