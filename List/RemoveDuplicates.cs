using System;
using System.Collections;
namespace Collections_Generics.List
{
    class RemoveDuplicates
    {
        /*
        4. Remove Duplicates While Preserving Order
Remove duplicate elements from a list while maintaining the original order.
Example:
Input: [3, 1, 2, 2, 3, 4]
Output: [3, 1, 2, 4]
        */
        public ArrayList Remove(ArrayList ll)
        {
            ArrayList ans = new ArrayList();
            foreach(var i in ll)
            {
                if (!ans.Contains(i))
                {
                    ans.Add(i);
                }
            }
            return ans;
        }
    }
}