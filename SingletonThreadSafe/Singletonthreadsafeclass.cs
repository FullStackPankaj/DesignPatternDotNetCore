using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonThreadSafe
{
    public class Singletonthreadsafeclass
    {
        private Singletonthreadsafeclass() { }

        private static Singletonthreadsafeclass _instance;

        public string Value { get; set; }

        private static readonly object _lock = new Object();

        public static Singletonthreadsafeclass GetInstance( string value)
        {
            if(_instance == null)
            {
                lock (_lock)
                    {
                        if(_instance == null)
                        {
                        _instance = new Singletonthreadsafeclass();
                        _instance.Value = value;
                        }
                    }
            }

            return _instance;
        }
    }
}
