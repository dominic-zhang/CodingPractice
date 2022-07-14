using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata
{
    public class SqureToSqares
    {
        public static string decompose(long n)
        {
            Stack<long> stack = new Stack<long>();
            stack.Push(n);
            long total = 0;

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                total += current * current;
                for (var i = current -1; i > 0; i--)
                {
                    if (total > i * i)
                    {
                        total -= i * i;
                        stack.Push(i);
                    }
                    else if (total == i * i)
                    {
                        stack.Push(i);
                        return String.Join(",", stack.Select(x => x.ToString()));
                    }
                }
            }

            var str = "";
            str.Reverse();

            return null;
        }
    }
}
