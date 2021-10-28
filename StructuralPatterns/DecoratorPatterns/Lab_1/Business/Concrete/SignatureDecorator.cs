using DecoratorPatterns.Lab_1.Business.Abstract;
using DecoratorPatterns.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatterns.Lab_1.Business.Concrete
{
    public class SignatureDecorator:Decorator
    {
        public string Signature;
        public SignatureDecorator(IMail mail,string signature):base(mail)
        {
            this.Signature = signature;
        }

        public override void Send()
        {
            base.Send();
            Console.WriteLine(Signature+" tarafından imzalandı.");
        }

    }
}
