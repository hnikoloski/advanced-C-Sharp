namespace Exercise2
{
    public static class IsDigit
    {
        public static bool CheckDigit(this string userInput)
        {
            int test;
            return int.TryParse(userInput, out test);
        }
    }
}