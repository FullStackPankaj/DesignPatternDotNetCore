using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class SignalCommand : ICommand
    {
        private Receiver _receiver;

        // Context data, required for launching the receiver's methods.
        private string _icmpsignal;

        private string _ccSignal;

        // Complex commands can accept one or several receiver objects along
        // with any context data via the constructor.
        public SignalCommand(Receiver receiver, string icmpSignal, string ccSignal)
        {
            this._receiver = receiver;
            this._ccSignal = ccSignal;
            this._ccSignal = ccSignal;
        }
        public void Execute()
        {
            Console.WriteLine("Signal: Signal stuff should be done by a receiver object.");
            this._receiver.processCCSignal(this._ccSignal);
            this._receiver.processIcmpSignal(this._icmpsignal);
        }
    }
}
