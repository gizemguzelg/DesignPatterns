using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatterns.Lab_2
{
    public class DecoratorC:IComponent
    {
        private IComponent _component;
        public DecoratorC(IComponent c)
        {
            _component = c;
        }
        public double Operation()
        {
            Component nesne1 = new Component();
            Console.Write("Gazi yakını olduğunuz için eğitiminiz ücretsizdir.");
            double GaziYakiniUcret = 0;
            return GaziYakiniUcret;
        }
        
    }
}
