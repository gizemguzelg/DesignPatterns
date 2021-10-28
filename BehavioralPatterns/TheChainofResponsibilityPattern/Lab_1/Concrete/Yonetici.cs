
using System;
using System.Collections.Generic;
using System.Text;
using TheChainofResponsibilityPattern.Lab_1.Abstract;
using TheChainofResponsibilityPattern.Lab_1.Model;

namespace TheChainofResponsibilityPattern.Lab_1.Concrete
{
   public class Yonetici:Employee
    {
        public override void ProcessRequest(Expense req)
        {
            if (req.Amount <= 50000)
            {
                Console.WriteLine($"{req.Amount} tutarında para çekme onaylandı.");
            }
            else
            {

                if (NextSubscriber != null)
                {
                    Console.Write("Maksimum limit aşıldığı için müdüre yönlendiriliyor.");
                   NextSubscriber.ProcessRequest(req);
                }

            }
        }
    }
}
