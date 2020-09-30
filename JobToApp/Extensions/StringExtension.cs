namespace JobToApp.Extensions
{
    public static class StringExtension
    {
        public static bool IsPresent(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
