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
            var test = TriggerListenerFactory.CreateTransportType(TransportType.WcfBasic);
            test.SetUp("TransportManager", 2);

            Console.WriteLine("TriggerListener has been initiated!");
                        
            //Console.ReadKey();


            while (true)
            {
                if (!test.Wait(interval))
                {
                    Console.WriteLine("No ping for 3 seconds");
                }
               
            }
        }
    }
}
