using System.Linq;
using RealWorldDesignPatterns.RulesEngine.Common;
using RealWorldDesignPatterns.RulesEngine.Contract;

namespace RealWorldDesignPatterns.RulesEngine.Rules
{
    public class TransactionMustNotBeDuplicatedRule: ITransactionRule
    {
        public void Evaluate(
            BankAccount account,
            TransactionOperation transaction,
            OperationResult result
        )
        {
            var duplicated = account.Transactions.Any(e =>
                e.Merchant == transaction.Merchant &&
                e.Value == transaction.Value &&
                e.CompletedAt.IsInRangeOfMinutes(transaction.RequestedAt, 5)
            );
            
            if(duplicated)
                result.AddError("Duplicated Transaction!");
        }
    }
}