using System;
using System.Collections.Generic;
using System.Text;

namespace TheChainofResponsibilityPattern.Lab_1.Model
{
    public class Expense
    {
        public string CustomerId { get; set; }
        public decimal Amount { get; set; }
        public Expense(string customerId,decimal amount)
        {
            CustomerId = customerId;
            Amount = amount;
        }
    }
}
