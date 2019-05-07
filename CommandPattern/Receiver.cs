using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Receiver
    {
        public void processIcmpSignal(string icmpSignal)
        {
            Console.WriteLine($"Receiver: Working on ({icmpSignal}.)");
        }

        public void processCCSignal(string ccSignal)
        {
            Console.WriteLine($"Receiver: Also working on ({ccSignal}.)");
        }
    }
}
