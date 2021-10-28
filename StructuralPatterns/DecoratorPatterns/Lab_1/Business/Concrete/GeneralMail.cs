using DecoratorPatterns.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatterns.Lab_1.Business.Concrete
{
   public class GeneralMail : IMail
    {
        public string Sender { get; set; }
        public string Receiver{get; set;}
        public GeneralMail(string sender, string receiver)
        {
            this.Sender = sender;
            this.Receiver = receiver;
        }
        public void Send()
        {
            Console.WriteLine($"Mail {Sender} kişisinden {Receiver} kişisine gönderiliyor.");
        }
    }
}
