using System.Collections.Generic;
using System.Linq;
using RealWorldDesignPatterns.RulesEngine.Common;
using RealWorldDesignPatterns.RulesEngine.Contract;
using RealWorldDesignPatterns.RulesEngine.Rules;

namespace RealWorldDesignPatterns.RulesEngine.Engine
{
    public class TransactionsRuleEngine : ITransactionsRuleEngine
    {
        private readonly List<ITransactionRule> _rules;

        public TransactionsRuleEngine(IEnumerable<ITransactionRule> rules)
        {
            _rules = rules.ToList();
        }

        public OperationResult Evaluate(
            BankAccount account,
            TransactionOperation transaction
        )
        {
            var operation = new OperationResult();
            _rules.ForEach(e => e.Evaluate(account, transaction, operation));
            return operation;
        }
    }
}