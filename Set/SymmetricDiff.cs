using System;
namespace Collections_Generics.Set
{
    class SymmetricDiff
    {
        /*
        3. Symmetric Difference
Find the symmetric difference (elements present in either set but not both).
Example:
Input: {1, 2, 3}, {3, 4, 5}
Output: {1, 2, 4, 5}
        */

        public void Diffrence(HashSet<int> set1, HashSet<int> set2)
        {
            set1.SymmetricExceptWith(set2);
        }
    }
}