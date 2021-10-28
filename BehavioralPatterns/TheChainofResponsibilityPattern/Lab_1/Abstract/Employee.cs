using System;
using System.Collections.Generic;
using System.Text;
using TheChainofResponsibilityPattern.Lab_1.Model;

namespace TheChainofResponsibilityPattern.Lab_1.Abstract
{
  public abstract class Employee
    {
        protected Employee NextSubscriber;
        public void SetNextSubscriber (Employee supervisor)
        {
            this.NextSubscriber = supervisor;
        }
        public abstract void ProcessRequest(Expense req);

    }
}
