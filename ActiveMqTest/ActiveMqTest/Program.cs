using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Apache.NMS.ActiveMQ;
using Spring.Messaging.Nms.Listener;

namespace ActiveMqTest
{
    class Program
    {
        private const string URI = "tcp://localhost:61616";
        private const string queueName = "activemqtest.queue";

        static void Main(string[] args)
        {
            try
            {
                ConnectionFactory connectionFactoryTest = new ConnectionFactory(URI);
               
                using (SimpleMessageListenerContainer listenerTest = new SimpleMessageListenerContainer())
                {
                    listenerTest.ConnectionFactory = connectionFactoryTest;
                    listenerTest.DestinationName = queueName;
                    listenerTest.MessageListener = new ListenerTest();
                    listenerTest.AfterPropertiesSet();
                    listenerTest.Start();

                    Console.WriteLine("Listening to Queue.");
                    Console.WriteLine("[Main]: Press <ENTER> to exit.");
                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);                
                Console.WriteLine("[Exception]: Press <ENTER> to exit.");
                Console.Read();
            }
        }
    }
}
