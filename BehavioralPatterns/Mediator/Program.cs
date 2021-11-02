using Mediator.Lab_1.Abstract;
using Mediator.Lab_1.Concrete;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator conversation = new ConcreteMediator();

            BaseUser Gizem = new Colleague1("Gizem");
            BaseUser Ayse = new Colleague1("Ayşe");
            BaseUser Yavuz = new Colleague2("Yavuz");
            BaseUser Selim = new Colleague2("Selim");

            conversation.Login(Gizem);
            conversation.Login(Ayse);
            conversation.Login(Yavuz);
            conversation.Login(Selim);

            Gizem.SendMessage("Yavuz", "Merhaba Yavuz");
            Yavuz.SendMessage("Gizem", "Merhaba Gizem");

            Console.ReadLine();
        }
    }
}
