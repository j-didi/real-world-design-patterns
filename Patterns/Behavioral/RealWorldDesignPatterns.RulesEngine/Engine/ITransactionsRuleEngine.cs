using RealWorldDesignPatterns.RulesEngine.Common;
using RealWorldDesignPatterns.RulesEngine.Contract;

namespace RealWorldDesignPatterns.RulesEngine.Engine
{
    public interface ITransactionsRuleEngine
    {
        OperationResult Evaluate(
            BankAccount account,
            TransactionOperation transaction
        );
    }
}