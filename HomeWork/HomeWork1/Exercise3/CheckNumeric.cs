using System;

namespace Exercise3
{
    public static class CheckNumeric
    {
        public static bool IsNumericType(this object o)
        {
            switch (Type.GetTypeCode(o.GetType()))
            {
                case TypeCode.Byte:
                    Console.WriteLine("Byte");
                    return true;

                case TypeCode.SByte:
                    Console.WriteLine("SByte");
                    return true;
                case TypeCode.UInt16:
                    Console.WriteLine("UInt16");
                    return true;
                case TypeCode.UInt32:
                    Console.WriteLine("UInt32");
                    return true;
                case TypeCode.UInt64:
                    Console.WriteLine("UInt64");
                    return true;
                case TypeCode.Int16:
                    Console.WriteLine("Int16");
                    return true;
                case TypeCode.Int32:
                    Console.WriteLine("Int32");
                    return true;
                case TypeCode.Int64:
                    Console.WriteLine("Int64");
                    return true;
                case TypeCode.Single:
                    Console.WriteLine("Single");
                    return true;
                case TypeCode.Double:
                    Console.WriteLine("Double");
                    return true;
                case TypeCode.Decimal:
                    Console.WriteLine("Decimal");
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsNotNumericType(this object o)
        {
            return !IsNumericType(o);
        }
    }
}