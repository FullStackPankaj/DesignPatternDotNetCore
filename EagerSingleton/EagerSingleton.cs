using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagerSingleton
{
    //We can choose to create the instance of Singleton class when the class is loaded.
    //This is thread-safe without using locking.
    public class EagerSingletonClass
    {
        private static EagerSingletonClass instance = new EagerSingletonClass();

        private EagerSingletonClass() { }

        public static EagerSingletonClass GetInstance()
        {
            return instance;//just return the instance
        }
    }
}
