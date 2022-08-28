using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata
{
    public class FibProduct
    {
        public static ulong[] ProductFib(ulong prod)
        {
            ulong[] ret = new ulong[3];

            ulong int1 = 0;
            ulong int2 = 1;

            while (int1 * int2 <= prod)
            {
                if (int1 * int2 == prod)
                {
                    return new ulong[3] { int1, int2, 1 };
                }

                var temp = int1;
                int1 = int2;
                int2 = int1 + temp;
            }

            return new ulong[3] { int1, int2, 0};
        }
    }
}
