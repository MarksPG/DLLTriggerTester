﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ElseTriggerHandler;

namespace TriggerTesterClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TriggerSender has started");
            Console.WriteLine("Press a key to ping the listener!");
            Console.ReadKey();

            for (int i = 0; i < 30; i++)
            {
                var client = TriggerSenderFactory.CreateTransportType(TransportType.WcfBasic);
                string name = client.GetName("TransportManager", 2);

                Thread.Sleep(1000);
                client.Send(name);

                Console.WriteLine();
                Console.WriteLine("Pinged {0}", i);
            }

        }
    }
}
