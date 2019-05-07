using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class NotificationCommand : ICommand
    {
        private string _notification  = string.Empty;

        public NotificationCommand(string payload)
        {
            this._notification = payload;
        }
        public void Execute()
        {
            Console.WriteLine($"NotificationCommand: ({this._notification})");
        }
    }
}
