using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class LaserProjector : BarcoProjectorFactory
    {
        public override IProjector CreateProjector()
        {
            return new Brahama();
        }
    }
}
