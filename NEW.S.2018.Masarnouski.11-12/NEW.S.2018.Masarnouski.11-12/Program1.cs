using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._11_12
{
    class Program1
    {
        static void Main()
        {
            int[] intArray = new int[]
            {2,3,4,5,6,7,8,9,10};

            Console.WriteLine(BinarySearch.InnerSearch<int>(intArray, 6, Comparer<int>.Default.Compare));
            Console.ReadLine();
        }
       
    }
}
