using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Brahama : IProjector
    {
        public string getCCData()
        {
            return "brahma Laser projector gives cc data";
        }

        public string getIcmpData()
        {
            return "brahma Laser projector gives icmp data";
        }
    }
}
