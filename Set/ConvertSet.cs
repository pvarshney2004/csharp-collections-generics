using System;
namespace Collections_Generics.Set
{
    class ConvertSet
    {
        /*
        4. Convert a Set to a Sorted List
Convert a HashSet<int> into a sorted list in ascending order.
Example:
Input: {5, 3, 9, 1}
Output: [1, 3, 5, 9]
        */
        public void Convert(HashSet<int> set)
        {
            List<int> ll = new List<int>(set);
            ll.Sort();
            foreach (int item in ll)
            {
                System.Console.Write(item+" ");
            }
        }
    }
}