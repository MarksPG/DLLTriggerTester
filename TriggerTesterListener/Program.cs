using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElseTriggerHandler;

namespace TriggerTesterListener
{
    class Program
    {
        static void Main(string[] args)
        {
            TriggerListenerFactory.CreateTransportType(TransportType.Ewh);

            Console.WriteLine("TriggerListener has been initiated!");
        }
    }
}
