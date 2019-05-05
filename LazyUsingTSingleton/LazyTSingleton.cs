using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyUsingTSingleton
{
    public class LazyTSingleton
    {
        private static readonly Lazy<LazyTSingleton> lazy =
        new Lazy<LazyTSingleton>(() => new LazyTSingleton());

        public static LazyTSingleton GetInstance { get { return lazy.Value; } }

        private LazyTSingleton()
        {
        }
    }
}
