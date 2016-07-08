namespace Core
{
    using System;

    public static class Number
    {
        #region Public Methods

        public static bool IsNumber(object value)
        {
            switch (Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsFloat(object value)
        {
            return Type.GetTypeCode(value.GetType()) == TypeCode.Single;
        }

        public static bool IsDouble(object value)
        {
            return Type.GetTypeCode(value.GetType()) == TypeCode.Double;
        }

        public static bool IsShortInt(object value)
        {
            return Type.GetTypeCode(value.GetType()) == TypeCode.Int16;
        }

        public static bool IsInt(object value)
        {
            return Type.GetTypeCode(value.GetType()) == TypeCode.Int32;
        }

        public static bool IsLongInt(object value)
        {
            return Type.GetTypeCode(value.GetType()) == TypeCode.Int64;
        }

        public static bool IsEven(object value)
        {
            if (!IsLongInt(value))
            {
                return false;
            }

            long number;
            long.TryParse(value.ToString(), out number);
            return number % 2 == 0;
        }

        public static bool IsOdd(object value)
        {
            if (!IsLongInt(value))
            {
                return false;
            }

            long number;
            long.TryParse(value.ToString(), out number);
            return number % 2 != 0;
        }

        #endregion
    }
}