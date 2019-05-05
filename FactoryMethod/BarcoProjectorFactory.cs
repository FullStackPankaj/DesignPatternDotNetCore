using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
  
    public abstract class BarcoProjectorFactory
    {
        public abstract IProjector CreateProjector();

        public string RenderProjector()
        {
            IProjector button = CreateProjector();
            var result = button.getCCData();
            return result;

        }
    }
}
