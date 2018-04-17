using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._11_12
{
   public class BinarySearch
    {
        /// <summary>
        /// Finds element in array using binary algorithm
        /// </summary>
        /// <typeparam name="T"> Any Type </typeparam>
        /// <param name="array"> Array to search in </param>
        /// <param name="key">Sought item</param>
        /// <param name="comparer">An instance of type that implements <see cref="IComparer{T}"./></param>
        /// <returns> Sought item </returns>
        public static T Search<T>(T[] array, T key, IComparer<T> comparer)
        {
            if (ReferenceEquals(array, null))
                throw new ArgumentNullException(nameof(array));
            
            if (ReferenceEquals(key, null))
                throw new ArgumentNullException(nameof(key));

            if (comparer == null)
                throw new ArgumentNullException(nameof(comparer));

            return InnerSearch<T>(array, key, comparer.Compare);
        }
        /// <summary>
        /// Finds element in array using binary algorithm
        /// </summary>
        /// <typeparam name="T"> Any Type </typeparam>
        /// <param name="array"> Array to search in </param>
        /// <param name="key">Sought item</param>
        /// <returns> Sought item </returns>
        public static T Search<T>(T[] array, T key)
        {
            if (ReferenceEquals(array, null))
                throw new ArgumentNullException(nameof(array));

            if (ReferenceEquals(key, null))
                throw new ArgumentNullException(nameof(key));
            if (Comparer<T>.Default == null)
                throw new ArgumentNullException($"{nameof(key)} must implements IComparer" );

            return InnerSearch<T>(array, key, Comparer<T>.Default.Compare);
        }
        private static T InnerSearch<T>(T[] array, T key, Comparison<T> comparison)
        {
            if (array.Length == 0)
                throw new ArgumentException($"{nameof(array)} must have more then zero elements");
            if (comparison(key, array[0]) == -1)
                throw new ArgumentException($"{nameof(key)} must be greater than first element of array");
            if (comparison(key, array[array.Length - 1]) == 1)
                throw new ArgumentException($"{nameof(key)} must be less than last element of array");

            int first = 0;

            int last = array.Length;

            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (comparison(key, array[mid]) == -1 || comparison(key, array[mid]) == 0) 
                    last = mid;
                else
                    first = mid + 1;
            }

            if (comparison(array[last], key) == 0)
                return array[last];
            else
                throw new Exception("The object haven't found");
        }
    }
}
