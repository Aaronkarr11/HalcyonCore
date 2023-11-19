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

        public static Microsoft.Maui.Graphics.Color SetStateColor(string state)
        {
            return state switch
            {
                "New" => Microsoft.Maui.Graphics.Color.FromRgb(255, 204, 0),
                "In Progress" => Microsoft.Maui.Graphics.Color.FromRgb(0, 72, 255),
                "Done" => Microsoft.Maui.Graphics.Color.FromRgb(0, 102, 0),
                _ => Microsoft.Maui.Graphics.Color.FromRgb(0, 72, 255),
            };
        }
    }
}
