namespace Core
{
    using System;

    public static class Common
    {
        #region Pubic Methods

        public static bool IsDBNull(object value)
        {
            return Convert.IsDBNull(value);
        }
        #endregion
    }
}