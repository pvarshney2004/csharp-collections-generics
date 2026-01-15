using System;
using System.Collections;
namespace Collections_Generics.List
{
    class RotateList
    {
        /*
3. Rotate Elements in a List
Rotate the elements of a list by a given number of positions.
Example:
Input: [10, 20, 30, 40, 50], rotate by 2
Output: [30, 40, 50, 10, 20]
        */
        public void Rotate(ArrayList ll, int k)
        {
            int n = ll.Count;
            k = k % n;
            int idx = n - k;
            Reverse(ll, 0, n - 1);
            Reverse(ll, 0, idx-1);
            Reverse(ll, idx, n - 1);
        }
        private void Reverse(ArrayList ll, int i, int j)
        {
            while (i < j)
            {
                var temp = ll[i];
                ll[i] = ll[j];
                ll[j] = temp;
                i++;
                j--;
            }
        }
    }
}