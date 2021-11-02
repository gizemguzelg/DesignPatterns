using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Lab_1.Abstract
{
   public abstract class BaseMediator
    {
            public abstract void Login(BaseUser user);
            public abstract void SendMessage(string sender, string receiver, string message);
       
    }
}
