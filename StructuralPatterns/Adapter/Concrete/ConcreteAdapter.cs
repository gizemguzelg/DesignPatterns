using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Concrete
{
    public class ConcreteAdapter : ITarget
    {
        private Correlator _correlator;
        public ConcreteAdapter(Correlator correlator)
        {
            this._correlator = correlator;
        }
        public string Request()
        {
            return $"{_correlator.SpesificRequest()}";
        }
    }
}
