using FactoryMethod.Lab_1.Enum;
using FactoryMethod.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Lab_1.Concrete
{
    public class PhoneFactory : IPhoneFactory
    {
        public IPhone ProducePhone(PhoneType type)
        {
            IPhone phone = null;
            switch (type)
            {
                case PhoneType.Samsung:
                    phone = new Samsung();
                    break;
                case PhoneType.Nokia:
                    phone = new Nokia();
                    break;
                case PhoneType.Iphone:
                    phone = new Iphone();
                    break;
            }
            return phone;
        }
    }
}
