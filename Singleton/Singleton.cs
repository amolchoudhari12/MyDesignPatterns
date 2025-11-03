using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.Singleton
{

    //First way
    public class Singleton : IDisposable
    {
        private static Singleton _instance;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (_instance != null)
                _instance = new Singleton();

            return _instance;
        }

        public void Dispose()
        {
            if (_instance != null)
                _instance = null; ;
        }
    }


    //Second way
    public class Singleton1
    {
        private static Singleton1 _instance;
        public Singleton1 Singleton
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton1();
                return _instance;

            }
        }
    }
}
