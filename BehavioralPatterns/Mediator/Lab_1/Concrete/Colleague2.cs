using Mediator.Lab_1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Lab_1.Concrete
{
    public class Colleague2:BaseUser
    {

        public Colleague2(string name) : base(name) { }
        public override void MessageSink(string sender, string message)
        {
            base.MessageSink(sender, message);
            Console.WriteLine("Sender:Colleague2:");
        }

    }
}
