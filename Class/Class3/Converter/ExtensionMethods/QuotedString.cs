namespace ExtensionMethods
{
    public static class QuotedString
    {
        public static string GetQuotes(this string text)
        {
            return "\"" + text + "\"";
        }
    }
}