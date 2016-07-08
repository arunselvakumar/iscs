namespace Core
{
    using System;

    public static class Numbers
    {
        #region Public Methods

        public static bool IsNumber(object value)
        {
            decimal number;
            var stringToValidate = value.ToString();
            if (string.IsNullOrEmpty(stringToValidate) || string.IsNullOrWhiteSpace(stringToValidate))
            {
                return false;
            }

            var isNumber = decimal.TryParse(value.ToString(), out number);
            return isNumber;
        }

        public static bool IsFloatOrDouble(object value)
        {
            return Convert.ToDouble(value) != null;
        }
        #endregion
    }
}