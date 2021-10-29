using System;

namespace RealWorldDesignPatterns.RulesEngine.Contract
{
    public class Transaction
    {
        public DateTime CompletedAt { get; set; }
        public decimal Value { get; set; }
        public string Merchant { get; set; }
    }
}