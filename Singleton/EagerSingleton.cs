using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class EagerSingleton : IDisposable
    {
        public int RandomNum { get; set; }
        private static readonly EagerSingleton instance = new EagerSingleton();
        private EagerSingleton()
        {
            RandomNum = new Random().Next(999999999);
        }

        public static EagerSingleton GetInstance()
        {
            return instance;
        }

        public void Dispose()
        {
        }
    }
}
