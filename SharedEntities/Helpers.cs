using System;
using System.Drawing;
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

        public static Color SetStateColor(string state)
        {
            return state switch
            {
                "New" => Color.FromArgb(255, 204, 0),
                "In Progress" => Color.FromArgb(0, 72, 255),
                "Done" => Color.FromArgb(0, 102, 0),
                _ => Color.FromArgb(0, 72, 255),
            };
        }
    }
}
