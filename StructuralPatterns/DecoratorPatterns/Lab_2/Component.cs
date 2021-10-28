using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatterns.Lab_2
{
    public class Component : IComponent
    {
        public double OgrenimUcreti = 30000;
        public double KayitUcreti = 2000;

        public double Operation()
        {
            double ToplamUcret = OgrenimUcreti + KayitUcreti;
            return ToplamUcret;

        }
    }
}
