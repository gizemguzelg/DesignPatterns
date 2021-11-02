using Mediator.Lab_1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Lab_1.Concrete
{
    public class ConcreteMediator : BaseMediator
    {
        private Dictionary<string, BaseUser> _user = new Dictionary<string, BaseUser>();
        public override void Login(BaseUser baseUser)
        {
            if(!_user.ContainsValue(baseUser))
            {
                _user[baseUser.Name] = baseUser;
            }
            baseUser.concreteMediator = this;
        }

        public override void SendMessage(string sender, string receiver, string message)
        {
            BaseUser baseUser = _user[receiver];
            if(baseUser!=null)
            {
                baseUser.MessageSink(sender, message);
            }
        }
    }
}
