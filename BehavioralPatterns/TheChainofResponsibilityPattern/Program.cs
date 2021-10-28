using System;
using TheChainofResponsibilityPattern.Lab_1.Abstract;
using TheChainofResponsibilityPattern.Lab_1.Concrete;
using TheChainofResponsibilityPattern.Lab_1.Model;

namespace TheChainofResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Expense expense = new Expense ("1", 90000);

            #region Lab_1
            Employee veznedar = new Veznedar();
            Employee yonetici = new Yonetici();
            Employee mudur = new Mudur();

            veznedar.SetNextSubscriber(yonetici);
            yonetici.SetNextSubscriber(mudur);

            veznedar.ProcessRequest(expense);
            
            #endregion
            Console.ReadKey();
        }
    }
}
