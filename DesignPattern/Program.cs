using System;
using System.Threading;
using SingletonNonThreadSafe;
using SingletonThreadSafe;
using EagerSingleton;
using FullLazyInstantion;
using LazyUsingTSingleton;
using GenericSingletonT;
using FactoryMethod;
using CommandPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            //prog.CallNonThreadSafeClass();
            //prog.CallthreadSafeClass();
            //prog.CallEagerSingleton();
            //prog.CallLazySingleton();
            // prog.CallLazyTSingleton();
            //prog.CallSingletonWithGeneric();
            // prog.CallFactory();
            prog.CallCommandPattern();
            Console.ReadKey();
        }

        private void CallNonThreadSafeClass()
        {
            SingletonNonThreadSafeClass s1 = SingletonNonThreadSafeClass.GetInstance();
            SingletonNonThreadSafeClass s2 = SingletonNonThreadSafeClass.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }

        private void CallthreadSafeClass()
        {
            Console.WriteLine(
              "{0}\n{1}\n\n{2}\n",
              "If you see the same value, then singleton was reused (yay!)",
              "If you see different values, then 2 singletons were created (booo!!)",
              "RESULT:"
          );
            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

        }

        public void TestSingleton(string value)
        {
            Singletonthreadsafeclass singleton = Singletonthreadsafeclass.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }

        private void CallEagerSingleton()
        {
            EagerSingletonClass s1 = EagerSingletonClass.GetInstance();
            EagerSingletonClass s2 = EagerSingletonClass.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

        }

        private void CallLazySingleton()
        {
            LazySingleton s1 = LazySingleton.Instance;
            LazySingleton s2 = LazySingleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }

        private void CallLazyTSingleton()
        {
            LazyTSingleton s1 = LazyTSingleton.GetInstance;
            LazyTSingleton s2 = LazyTSingleton.GetInstance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

        }


        private void CallSingletonWithGeneric()
        {
            GenericSingleton<SimpleType> instance = new GenericSingleton<SimpleType>();
            SimpleType simple = instance.GetInstance();

            GenericSingleton<SimpleType> instance2 = new GenericSingleton<SimpleType>();
            SimpleType simple2 = instance2.GetInstance();

            if (simple == simple2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }

        public class SimpleType
        {

        }


        public void CallFactory()
        {
            ClientCode(new LaserProjector());
            ClientCode(new LampProjector());
        }

        public void ClientCode(BarcoProjectorFactory factory)
        {
            // ...
            Console.WriteLine(factory.RenderProjector());
            // ...
        }


        public void CallCommandPattern()
        {
            CommandInvoker invoker = new CommandInvoker();
            invoker.handleNotificationCommand(new NotificationCommand("notification "));
            Receiver receiver = new Receiver();
            invoker.handleSignalCommand(new SignalCommand(receiver, "Send email", "Save report"));

            invoker.ProcessCommand();
        }
    }
}
