using RealWorldDesignPatterns.RulesEngine.Common;
using RealWorldDesignPatterns.RulesEngine.Contract;

namespace RealWorldDesignPatterns.RulesEngine.Rules
{
    public class MustRespectOvernightTransactionLimitRule: ITransactionRule
    {
        public void Evaluate(
            BankAccount account,
            TransactionOperation transaction,
            OperationResult result
        )
        {
            if(transaction.RequestedAt.IsOvernight() && transaction.Value > 500)
                result.AddError("Transactions overnight must respect 500 limit!");
        }
    }
}