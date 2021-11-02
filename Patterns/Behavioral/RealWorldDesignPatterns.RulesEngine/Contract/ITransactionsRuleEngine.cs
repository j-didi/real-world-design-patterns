using RealWorldDesignPatterns.RulesEngine.Common;

namespace RealWorldDesignPatterns.RulesEngine.Contract
{
    public interface ITransactionsRuleEngine
    {
        OperationResult Evaluate(
            BankAccount account,
            TransactionOperation transaction
        );
    }
}