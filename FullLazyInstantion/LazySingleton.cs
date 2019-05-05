using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullLazyInstantion
{
    public sealed class LazySingleton
    {
        private LazySingleton()
        {
        }

        public static LazySingleton Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
