using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatterns.Lab_2
{
   public class Client
    {
        public static void Display(IComponent c)
        {
            Console.WriteLine(c.Operation());

        }
        static void Uygula()
        {
            IComponent component = new Component();
            Display(component);
            Display(new DecoratorA(component));
            Display(new DecoratorB(component));
            Display(new DecoratorC(component));

        }

    }
}
