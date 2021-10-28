using DecoratorPatterns.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatterns.Lab_1.Business.Abstract
{
    public abstract class Decorator : IMail
    {
        public IMail mail;
        public Decorator (IMail mail)
        {
            this.mail = mail;
        }
        public virtual void Send()
        {
            mail.Send();
        }
    }
}
