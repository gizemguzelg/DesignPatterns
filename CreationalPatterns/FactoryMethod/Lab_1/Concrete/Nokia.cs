using FactoryMethod.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Lab_1.Concrete
{
    public class Nokia : IPhone
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Nokia Produced");
        }
    }
}
