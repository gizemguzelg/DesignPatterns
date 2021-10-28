using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatterns.Lab_2
{
    public class DecoratorB:IComponent
    {
        private IComponent _component;
        public DecoratorB(IComponent c)
        {
            _component = c;
        }
        public double Operation()
        {
            Component nesne1 = new Component();
            Console.Write("Toplam ücretiniz hesaplanıyor.");
            Console.Write("Kardeş indirimli ücret hesaplanıyor.");
            double KardesIndirimliUcret = (nesne1.Operation())-(nesne1.Operation()*0.3);
            return KardesIndirimliUcret;
        }
    }
}
