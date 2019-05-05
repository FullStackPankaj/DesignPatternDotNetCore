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
        // The Singleton's instance is stored in a static field. There there are
        // multiple ways to initialize this field, all of them have various pros
        // and cons. In this example we'll show the simplest of these ways,
        // which, however, doesn't work really well in multithreaded program.
        private static SingletonNonThreadSafeClass _instance;

        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private SingletonNonThreadSafeClass()
        {

        }

        // This is the static method that controls the access to the singleton
        // instance. On the first run, it creates a singleton object and places
        // it into the static field. On subsequent runs, it returns the client
        // existing object stored in the static field.
        public static SingletonNonThreadSafeClass GetInstance()
        {
            if(_instance == null)
            {
                _instance = new SingletonNonThreadSafeClass();
            }

            return _instance;
        }

        public static void SomeBusinessLogic()
        {
            Console.WriteLine("some business logic after single instance created");
        }
    }
}
