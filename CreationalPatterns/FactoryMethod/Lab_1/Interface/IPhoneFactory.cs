using FactoryMethod.Lab_1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Lab_1.Interface
{
    public interface IPhoneFactory
    {
        IPhone ProducePhone(PhoneType type);
    }
}
