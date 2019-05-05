using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Platinum : IProjector
    {
        public string getCCData()
        {
            return "PLATINUM lamp projector gives cc data";
        }

        public string getIcmpData()
        {
            return "PLATINUM lamp projector gives icmp data";
        }
    }
}
