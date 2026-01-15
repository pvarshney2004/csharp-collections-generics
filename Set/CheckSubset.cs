using System;
namespace Collections_Generics.Set
{
    class CheckSubset
    {
        /*
        5. Find Subsets
Check if one set is a subset of another.
Example:
Input: {2, 3}, {1, 2, 3, 4}
Output: true
        */

        public bool IsSubset(HashSet<int> set1, HashSet<int> set2)
        {
            return set1.IsSubsetOf(set2);
        }
    }
}