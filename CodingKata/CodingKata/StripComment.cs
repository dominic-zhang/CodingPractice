using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata
{
    public class StripComment
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            return string.Join(
                "\n", 
                text.Split("\n")
                .Select(x => (x.Any(c => commentSymbols.Contains(c.ToString())) ? x.Substring(0, x.IndexOf(x.First(x => commentSymbols.Contains(x.ToString())))) : x).TrimEnd())
            );
        }
    }
}
