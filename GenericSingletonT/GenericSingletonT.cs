using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSingletonT
{
    public class GenericSingleton<T> where T : new()
    {
        private static T ms_StaticInstance = new T();

        public T GetInstance()
        {
            return ms_StaticInstance;
        }
    }


}
