using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton
{
    public sealed class Singleton
    {
        public int RandomNum { get; set; }
        public static Singleton instance;
        static readonly object _object = new object();
        private Singleton()
        {
            RandomNum = new Random().Next(999999999);
        }

        //public Singleton()
        //{
        //    RandomNum = new Random().Next(999999999);
        //}

        public static Singleton GetInstance()
        {
            Monitor.Enter(_object);
            try
            {
                if (instance == null)
                {
                    instance = new Singleton();
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
