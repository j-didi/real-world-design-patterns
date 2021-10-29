using System.Collections.Generic;

namespace RealWorldDesignPatterns.RulesEngine.Contract
{
    public class BankAccount
    {
        public bool ActiveCard { get; set; }
        public decimal Balance { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}