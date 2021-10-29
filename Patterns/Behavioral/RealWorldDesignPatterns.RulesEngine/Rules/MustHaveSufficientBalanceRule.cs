using RealWorldDesignPatterns.RulesEngine.Common;
using RealWorldDesignPatterns.RulesEngine.Contract;

namespace RealWorldDesignPatterns.RulesEngine.Rules
{
    public class MustHaveSufficientBalanceRule: ITransactionRule
    {
        public void Evaluate(
            BankAccount account,
            TransactionOperation transaction,
            OperationResult result
        )
        {
            if(account.Balance < transaction.Value)
                result.AddError("Account must have sufficient balance!");
        }
    }
}