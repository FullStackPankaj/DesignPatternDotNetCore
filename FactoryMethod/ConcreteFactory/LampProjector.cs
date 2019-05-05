using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class LampProjector : BarcoProjectorFactory
    {
        public override IProjector CreateProjector()
        {
            return new Platinum();
        }
    }
}
