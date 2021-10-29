using Microsoft.Extensions.DependencyInjection;
using RealWorldDesignPatterns.RulesEngine.Contract;
using RealWorldDesignPatterns.RulesEngine.Engine;
using RealWorldDesignPatterns.RulesEngine.Rules;

namespace RealWorldDesignPatterns.RulesEngine.DI
{
    public static class Injector
    {
        public static IServiceCollection AddTransactionRules(this IServiceCollection services)
        {
            services.AddScoped<ITransactionRule, MustHaveAnActiveCardRule>();
            services.AddScoped<ITransactionRule, MustHaveSufficientBalanceRule>();
            services.AddScoped<ITransactionRule, MustRespectOvernightTransactionLimitRule>();
            services.AddScoped<ITransactionRule, TransactionMustNotBeDuplicatedRule>();
            
            services.AddScoped<ITransactionsRuleEngine, TransactionsRuleEngine>();

            return services;
        }
    }
}