using System;
using System.Collections;
namespace Collections_Generics.List
{
    class FindFrequency
    {
        /*
        2. Find Frequency of Elements
Given a list of strings, count the frequency of each element and return the
results in a Dictionary<string, int>.
Example:
Input: {"apple", "banana", "apple", "orange"}
Output: { "apple": 2, "banana": 1, "orange": 1 }
        */

        public void Find(ArrayList ll)
        {
            Dictionary<string,int> dict = new Dictionary<string, int>();
            foreach(string i in ll)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict[i] = 1;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " has " + item.Value + " occurences in list.");
            }
        }
    }
}