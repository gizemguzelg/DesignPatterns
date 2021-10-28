using DecoratorPatterns.Lab_1.Business.Concrete;
using DecoratorPatterns.Lab_1.Interface;
using DecoratorPatterns.Lab_2;
using System;
using System.ComponentModel;
using Component = DecoratorPatterns.Lab_2.Component;
using IComponent = DecoratorPatterns.Lab_2.IComponent;

namespace DecoratorPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            string Sender = "Gizem";
            string Receiver = "Ayşe";
            IMail standartMail = new GeneralMail(Sender, Receiver);
            IMail signatureMail = new SignatureDecorator(standartMail, "Gizem");
            IMail encryptMail = new EncryptDecorator(signatureMail);
            encryptMail.Send();
            #endregion
            Console.ReadLine();

        }
    }
}
