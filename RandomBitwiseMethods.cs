using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class RandomBitwiseMethods
    {
        public static void CounterGame(int n)
        {
            var counter = 0;

            bool isNpowerOf2 = false;

            while (n > 1)
            {
                counter++;
                isNpowerOf2 = (n & (n - 1)) == 0;

                if (isNpowerOf2)
                {
                    n = n / 2;
                }
                else
                {
                    var mostSignificantBit = BitwiseOperations.GetMostSignificantBitPosition(n);
                    var reduce = 1 << (mostSignificantBit);
                    n = n - reduce;
                }
            }
            var whoWin = counter % 2 == 0 ? "Richard" : "Louise";
            Console.WriteLine(whoWin);
        }
    }
}
