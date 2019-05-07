using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CommandInvoker
    {
        private ICommand _notificationCommand;

        private ICommand _SignalCommand;

        // Initialize commands.
        public void handleNotificationCommand(ICommand command)
        {
            this._notificationCommand = command;
        }

        public void handleSignalCommand(ICommand command)
        {
            this._SignalCommand = command;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a
        // command.
        public void ProcessCommand()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (this._notificationCommand is ICommand)
            {
                this._notificationCommand.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if (this._SignalCommand is ICommand)
            {
                this._SignalCommand.Execute();
            }
        }
    }
}
