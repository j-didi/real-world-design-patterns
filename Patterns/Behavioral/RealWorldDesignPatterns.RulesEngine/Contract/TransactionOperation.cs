using System;

namespace RealWorldDesignPatterns.RulesEngine.Contract
{
    public class TransactionOperation
    {
        public decimal Value { get; set; }
        public string Merchant { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}