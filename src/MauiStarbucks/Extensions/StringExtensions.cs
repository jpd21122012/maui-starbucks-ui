using System.Text.RegularExpressions;

namespace CassavaRoots.Extensions
{
    public static partial class StringExtensions
    {
        // Other methods and properties

        public static string NormalizeAzureConfigJson(this string str)
        {
            return TrimUnicodeRegex().Replace(str.TrimStart('"').TrimEnd('"'), "").Replace("\\\"", "\"").Replace("\\\\", "").
                Replace("\"[", "[").Replace("]\"", "]").Replace("[^0-9]", "\"[^0-9]\"").Replace("\n", "");
        }

        [GeneratedRegex("\\\\(r|n|t)")]
        private static partial Regex TrimUnicodeRegex();
    }

}
