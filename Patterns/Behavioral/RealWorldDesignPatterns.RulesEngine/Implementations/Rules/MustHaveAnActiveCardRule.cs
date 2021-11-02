using RealWorldDesignPatterns.RulesEngine.Common;
using RealWorldDesignPatterns.RulesEngine.Contract;

namespace RealWorldDesignPatterns.RulesEngine.Implementations.Rules
{
    public class MustHaveAnActiveCardRule: ITransactionRule
    {
        public void Evaluate(
            BankAccount account,
            TransactionOperation transaction,
            OperationResult result
        )
        {
            if(!account.ActiveCard)
                result.AddError("Account must have an active card!");
        }
    }
}