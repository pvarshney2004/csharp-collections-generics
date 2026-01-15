using System;
namespace Collections_Generics.Set
{
    class UnionIntersection
    {
        /*
        2. Union and Intersection of Two Sets
Compute the union and intersection of two sets.
Example:
Set1: {1, 2, 3}, Set2: {3, 4, 5}
Output:
Union: {1, 2, 3, 4, 5}
Intersection: {3}
        */
        public void Union(HashSet<int> set1, HashSet<int> set2)
        {
            set1.UnionWith(set2);
        }

        public void Intersection(HashSet<int> set1, HashSet<int> set2)
        {
            set1.IntersectWith(set2);
        }
    }
}