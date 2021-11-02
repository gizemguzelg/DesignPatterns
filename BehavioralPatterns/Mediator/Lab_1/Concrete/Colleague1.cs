
using Mediator.Lab_1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Lab_1.Concrete
{
    public class Colleague1:BaseUser
    {
        public Colleague1(string name) : base(name) { }
        public override void MessageSink(string sender, string message)
        {
            base.MessageSink(sender, message);
            Console.WriteLine("Sender:Colleague1:");
        }

    }
}
