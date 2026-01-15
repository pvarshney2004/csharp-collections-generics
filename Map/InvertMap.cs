using System;
namespace Collections_Generics.Map
{
    class InvertMap
    {
        /*
        2. Invert a Map
Invert a Dictionary<K, V> to produce a Dictionary<V, List<K>>.
Example:
Input: { A=1, B=2, C=1 }
Output: { 1=[A, C], 2=[B] }
        */

        public void Invert(Dictionary<char, int> dict)
        {
            Dictionary<int, List<char>> ans = new Dictionary<int, List<char>>();
            foreach (var pair in dict)
            {
                char ch = pair.Key;
                int val = pair.Value;
                if (!ans.ContainsKey(val))
                {
                    ans[val] = new List<char>();
                }
                ans[val].Add(ch);
            }
            System.Console.WriteLine("Inverted dictionary: ");
            foreach (var pair in ans)
            {
                Console.Write(pair.Key + " -> ");
                foreach (char c in pair.Value)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
    }
}