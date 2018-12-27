using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton
{
    public sealed class LazySingleton
    {
        public int RandomNum { get; set; }
        private static LazySingleton instance;
        static readonly object _object = new object();
        private LazySingleton()
        {
            RandomNum = new Random().Next(999999999);
        }

        //public Singleton()
        //{
        //    RandomNum = new Random().Next(999999999);
        //}

        public static LazySingleton GetInstance()
        {
            Monitor.Enter(_object);
            try
            {
                if (instance == null)
                {
                    instance = new LazySingleton();
                }
            }
            finally
            {
                Monitor.Exit(_object);
            }

            //lock(_object)
            //{
            //    if (instance == null)
            //    {
            //        instance = new Singleton();
            //    }
            //}

            return instance;
        }
    }
}
