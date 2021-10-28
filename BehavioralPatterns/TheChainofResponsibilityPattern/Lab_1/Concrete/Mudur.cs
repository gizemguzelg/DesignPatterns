using System;
using System.Collections.Generic;
using System.Text;
using TheChainofResponsibilityPattern.Lab_1.Abstract;
using TheChainofResponsibilityPattern.Lab_1.Model;

namespace TheChainofResponsibilityPattern.Lab_1.Concrete
{
   public class Mudur:Employee
    {
        public override void ProcessRequest(Expense req)
        {
            if (req.Amount <= 100000)
            {
                Console.WriteLine($"{req.Amount} tutarında para çekme onaylandı.");
            }
            else
            {

                if (NextSubscriber != null)
                {
                    Console.Write("Maksimum limit aşıldığı için para çekme işlemi onaylanmadı.");
                    NextSubscriber.ProcessRequest(req);
                }

            }
        }
    }
}
