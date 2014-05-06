namespace SubstringExtensionMethod
{
    using System;
    using System.Text;
    public static class StringBuilderSubstring
    {
        public static string Substring(this StringBuilder text, int startingPosition, int lengthOfThePosition)
        {
            return text.ToString().Substring(startingPosition, lengthOfThePosition);
        }
    }
}
