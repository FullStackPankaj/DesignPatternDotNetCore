using System;
using SingletonNonThreadSafe;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.CallNonThreadSafeClass();

            Console.ReadKey();
        }

        private void CallNonThreadSafeClass()
        {
            SingletonNonThreadSafeClass s1 = SingletonNonThreadSafeClass.GetInstance();
            SingletonNonThreadSafeClass s2 = SingletonNonThreadSafeClass.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
                SingletonNonThreadSafeClass.SomeBusinessLogic();
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

        }
    }
}
