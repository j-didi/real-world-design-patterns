using System;

namespace RealWorldDesignPatterns.RulesEngine.Common
{
    public static class DateTimeExtension
    {
        public static bool IsOvernight(this DateTime context) =>
            context.TimeOfDay >= new TimeSpan(20, 0, 0) && 
            context.TimeOfDay <= new TimeSpan(5, 0, 0);

        public static bool IsInRangeOfMinutes(
            this DateTime context,
            DateTime comparer,
            int minutes
        ) => context >= comparer.AddMinutes(-minutes) &&
             context <= comparer.AddMinutes(minutes);
    }
}