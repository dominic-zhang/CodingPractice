using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata
{
    /*
        Write a function that takes a positive integer and returns the next smaller positive integer containing the same digits.

        For example:

        nextSmaller(21) == 12
        nextSmaller(531) == 513
        nextSmaller(2071) == 2017
        Return -1 (for Haskell: return Nothing, for Rust: return None), when there is no smaller number that contains the same digits. Also return -1 when the next smaller number with the same digits would require the leading digit to be zero.

        nextSmaller(9) == -1
        nextSmaller(111) == -1
        nextSmaller(135) == -1
        nextSmaller(1027) == -1 // 0721 is out since we don't write numbers with leading zeros
        some tests will include very large numbers.
        test data only employs positive integers.

        1. find the first char from right side, which has smaller digit on the right
        2. swap the char with it's next smaller number
        3. sort the digits in descending after the char
     */
    public class NextSmallNumberSameDigits
    {
        public static long GetNumber(long n)
        {
            List<char> digitsChars = n.ToString().ToCharArray().ToList();
            var index = -1;
            var nextSmallerIndex = -1;
            var max = int.MinValue;

            for (var i = digitsChars.Count - 1; i >= 0; i--)
            {
                for (var j = i + 1; j < digitsChars.Count; j++)
                {
                    if (digitsChars[i] > digitsChars[j] && digitsChars[j] > max)
                    {
                        max = digitsChars[j];
                        nextSmallerIndex = j;
                    }
                }

                if (nextSmallerIndex >= 0)
                {
                    index = i;
                    break;
                }
            }

            bool cannotSwapZeroToFirst = index == 0 && max == '0' && digitsChars.Count(x => x == '0') == 1;
            if (index >= 0 && nextSmallerIndex >= 0 && !cannotSwapZeroToFirst)
            {
                var temp = digitsChars[index];
                digitsChars[index] = digitsChars[nextSmallerIndex];
                digitsChars[nextSmallerIndex] = temp;
                var charsToKeep = digitsChars.Take(index + 1).ToList();
                charsToKeep.AddRange(digitsChars.Skip(index + 1).OrderByDescending(x => x));
                digitsChars = charsToKeep;
            }

            var result = long.Parse(new string(digitsChars.ToArray()));
            return result == n ? -1 : result;
        }
    }
}
