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
            TimeSpan interval = new TimeSpan(0, 0, 3);
            ITriggerListener test = TriggerListenerFactory.CreateTransportType(TransportType.Msmq);
            test.SetUp("TruckLiftManager", 3);

            Console.WriteLine("TriggerListener has been initiated!");
                        
           


            while (true)
            {
                if (!test.Wait(interval))
                {
                    Console.WriteLine("No ping for 3 seconds");
                }

                else
                {
                    Console.WriteLine("Pinged!");
                }
               
            }
        }
    }
}
