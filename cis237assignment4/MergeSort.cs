// Westin Curtis - CIS 237 - 3/20/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {
        // Merge two "sub arrays" that aren't really arrays
        private static void Merge(IComparable[] a, IComparable[] aux, int low, int mid, int high)
        {
            for(int k = low; k <= high; k++) // Copy the contents of the original array to the aux array
            {
                aux[k] = a[k];
            }

            int i = low;
            int j = mid + 1;

            for(int k = low; k <= high; k++)
            {
                if (i > mid)
                    a[k] = aux[j++];
                else if (j > high)
                    a[k] = aux[i++];
                else if (Less(aux[j], aux[i]))
                    a[k] = aux[j++];
                else
                    a[k] = aux[i++];
            }
        }

        // Recursive method that sorts the given array in ascending order
        private static void Sort(IComparable[] a, IComparable[] aux, int low, int high)
        {
            if (high <= low) return;
            int mid = low + (high - low) / 2;
            Sort(a, aux, low, mid);
            Sort(a, aux, mid + 1, high);
            Merge(a, aux, low, mid, high);
        }

        // Setup aux array and start sorting
        public static void Sort(IComparable[] a, int length)
        {
            IComparable[] aux = new IComparable[length];
            Sort(a, aux, 0, length - 1);
        }

        // Helper method to check if one value is less than another
        private static bool Less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }
    }
}
