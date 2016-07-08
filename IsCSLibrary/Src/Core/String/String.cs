namespace Core
{
    public static class String
    {
        #region Public Methods

        public static bool IsNull(object value)
        {
            return value == null;
        }

        public static bool IsNullOrEmptyOrWhiteSpace(object value)
        {
            var valueToCheck = value?.ToString();
            if (valueToCheck == null)
            {
                return true;
            }

            return string.IsNullOrEmpty(valueToCheck) || string.IsNullOrWhiteSpace(valueToCheck);
        }

        #endregion
    }
}