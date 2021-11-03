
using Adapter.Concrete;
using Adapter.Interface;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Correlator correlator = new Correlator();
            ITarget target = new ConcreteAdapter(correlator);

            Console.WriteLine(target.Request());

        }
    }
}
