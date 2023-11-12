using System;
using System.Text.RegularExpressions;

namespace HalcyonCore.SharedEntities
{
    public static class Helpers
    {
        public static string RemoveSpecialCharacters(this string str)
        {
            try
            {
                var stripped = Regex.Replace(str, "[^a-zA-Z0-9% ._]", string.Empty);
                var strippedUnderscores = stripped.Replace("_", "");
                return strippedUnderscores;
            }
            catch (Exception)
            {
                return "Pog";
            }

        }
    }
}
