using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Messaging.Nms.Core;
using Apache.NMS;

namespace ActiveMqTest
{
    class ListenerTest : IMessageListener
    {
        public ListenerTest()
        {
            Console.WriteLine("Listener Ver 0.1.0 Activated");            
        }

        public void OnMessage(Apache.NMS.IMessage message)
        {
            Console.WriteLine("OnMessage");
            //ITextMessage textMessage = message as ITextMessage;

            //if (textMessage == null) Console.WriteLine("Message is NULL or EMPTY");
            //else
            //Console.WriteLine("You have got the Message : " + textMessage.Text);
        }
    }
}
