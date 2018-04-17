using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._11_12
{
   class BinarySearch
    {
      public static T InnerSearch<T>(T[] array, T key, Comparison<T> comparison)
        {
            if ((array.Length == 0) || (comparison(key, array[0]) == -1) || ((comparison(key, array[array.Length - 1]) == 1)))
                throw new ArgumentException("arguments is wrong");


            int first = 0;

            int last = array.Length;

            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (comparison(key, array[mid]) == -1 || comparison(key, array[mid]) == 0) //key <= array[mid]
                    last = mid;
                else
                    first = mid + 1;
            }

            if (comparison(array[last], key) == 0) //array[last] == key
                return array[last];
            else
                throw new Exception("Wholy shit");
        }
    }
}
