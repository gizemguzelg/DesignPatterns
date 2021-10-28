using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatterns.Lab_2
{
    public class DecoratorA : IComponent
    {
        private IComponent _component;
        public DecoratorA(IComponent c)
        {
            _component = c;
        }
        public double Operation()
        {
            Component nesne1 = new Component();
            Console.Write("Toplam ücretiniz hesaplanıyor.");
            double TamUcret = (nesne1.Operation());
            return TamUcret;
        }
    }
}
