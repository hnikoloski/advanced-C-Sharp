using System;

namespace Converter
{
    public static class LitersToGallons
    {
        public static double LitersToGallonsConversion(string litersValue)
        {
            var liters = double.Parse(litersValue);
            var gallons = liters * 0.26;
            return gallons;
        }
    }
}