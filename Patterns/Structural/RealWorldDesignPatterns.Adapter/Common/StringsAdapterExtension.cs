namespace RealWorldDesignPatterns.Adapter.Common
{
    public static class StringsAdapterExtension
    {
        public static char AdaptGender(this string context) =>
            context.ToLower() switch
            {
                "female" => 'F',
                "male" => 'M',
                _ => 'O'
            };

        public static string AdaptHomeWorld(this string context) =>
            $"{context[0].ToString().ToUpper()}{context[1..]}";
    }
}