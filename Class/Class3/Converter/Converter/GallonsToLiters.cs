namespace Converter
{
    public static class GallonsToLiters
    {
        public static double GallonsToLiterConversion(string gallonsValue)
        {
            var gallons = double.Parse(gallonsValue);
            var liters = gallons * 3.78;
            return liters;
        }
    }
}