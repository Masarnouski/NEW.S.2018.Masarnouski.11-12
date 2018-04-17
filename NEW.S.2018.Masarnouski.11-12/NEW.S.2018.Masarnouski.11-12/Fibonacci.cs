using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._11_12
{
    class Fibonacci
    {
        public static IEnumerable<int> GetFibonacci()
        {
            int first = 0;
            int second = 1;

            while (first <= int.MaxValue - second)
            {
                yield return first;

                var nextNumber = first + second;
                first = second;
                second = nextNumber;
            }
        }
    }
}
