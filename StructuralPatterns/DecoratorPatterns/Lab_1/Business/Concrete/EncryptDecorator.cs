using DecoratorPatterns.Lab_1.Business.Abstract;
using DecoratorPatterns.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatterns.Lab_1.Business.Concrete
{
   public class EncryptDecorator:Decorator
    {
        public EncryptDecorator(IMail mail):base(mail)
        {

        }
        public override void Send()
        {
            base.Send();
            Console.WriteLine("Şifrelendi!");
        }
    }
}
