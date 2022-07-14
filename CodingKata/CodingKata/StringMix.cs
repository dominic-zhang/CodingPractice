using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata
{
    public class StringMix
    {
        public static string Mix(string s1, string s2)
        {
            Dictionary<char, string> charsCounted = new Dictionary<char, string>();
            List<char> distinctChars = (s1 + s2).Distinct().Where(x => char.IsLower(x)).
                Where(x => s1.Count(c => c == x) > 1 || s2.Count(c => c == x) > 1).ToList();
            foreach (char c in distinctChars)
            {
                var countS1 = s1.Count(x => x == c);
                var countS2 = s2.Count(x => x == c);

                if (countS1 > countS2)
                {
                    charsCounted[c] = $"1:{new string(c, countS1)}";
                }
                else if (countS1 == countS2)
                {
                    charsCounted[c] = $"=:{new string(c, countS1)}";
                }
                else if (countS1 < countS2)
                {
                    charsCounted[c] = $"2:{new string(c, countS2)}";
                }
            }
            var sortedStrings = charsCounted
                .OrderByDescending(x => x.Value.Length)
                .ThenBy(x => x.Value[0])
                .ThenBy(x => x.Key)
                .Select(x => x.Value);

            return String.Join("/", sortedStrings);
        }
    }
}
