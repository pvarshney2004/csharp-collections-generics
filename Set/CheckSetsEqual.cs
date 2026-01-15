using System;
namespace Collections_Generics.Set
{
    class CheckSetsEqual
    {
        /*
        1. Check if Two Sets Are Equal
Compare two sets and determine if they contain the same elements, regardless
of order.
Example:
Set1: {1, 2, 3}, Set2: {3, 2, 1}
Output: true
        */
        public bool IsEqual(HashSet<int> set1, HashSet<int> set2)
        {
            if (set1.Count != set2.Count)
            {
                return false;
            }
            foreach (int item in set1)
            {
                bool found = false;
                foreach (int i in set2)
                {
                    if (item == i)
                    {
                        found = true;
                        break;
                    }
                }
                if(!found) return false;
            }
            return true;
        }
    }
}