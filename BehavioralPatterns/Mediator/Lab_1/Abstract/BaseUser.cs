using Mediator.Lab_1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Lab_1.Abstract
{
    public abstract class BaseUser
    {
        public string Name { get; set; }
        public ConcreteMediator concreteMediator { get; set; }
        public BaseUser(string name)
        {
            this.Name = name;
        }
        public void SendMessage(string receiver, string message)
        {
            concreteMediator.SendMessage(Name, receiver, message);
        }

        public virtual void MessageSink(string sender, string message)
        {
            Console.WriteLine("{0} to {1}:'{2}'", sender, Name, message);
        }

    }
}
