using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Singleton Design Pattern
//
// Intent: Lets you ensure that a class has only one instance, while providing a
// Singleton Design Pattern
//
// Intent: Lets you ensure that a class has only one instance, while providing a
// global access point to this instance.
namespace SingletonNonThreadSafe
{
    // The Singleton class defines the `GetInstance` method that serves as an
    // alternative to constructor and lets clients access the same instance of
    // this class over and over.
    public class SingletonNonThreadSafeClass
    {
        private static SingletonNonThreadSafeClass _instance;

        private SingletonNonThreadSafeClass()
        {

        }

        public static SingletonNonThreadSafeClass GetInstance()
        {
            if(_instance == null)
            {
                _instance = new SingletonNonThreadSafeClass();
            }

            return _instance;
        }
    }
}
