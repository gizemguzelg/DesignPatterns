using FactoryMethod.Lab_1.Concrete;
using FactoryMethod.Lab_1.Enum;
using FactoryMethod.Lab_1.Interface;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var phoneFactory =new PhoneFactory();
            IPhone phoneSamsung = phoneFactory.ProducePhone(PhoneType.Samsung);
            phoneSamsung.DisplayInfo();

            IPhone phoneNokia = phoneFactory.ProducePhone(PhoneType.Nokia);
            phoneNokia.DisplayInfo();

            IPhone phoneIphone = phoneFactory.ProducePhone(PhoneType.Iphone);
            phoneIphone.DisplayInfo();
            Console.ReadKey();
        }
    }
}
