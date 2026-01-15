using System;
namespace Collections_Generics.Map
{
    class WordFrequency
    {
        /*
        1. Word Frequency Counter
Read a text file and count the frequency of each word using a
Dictionary<string, int>.
Example:
Input: "Hello world, hello Java!"
Output: { "hello": 2, "world": 1, "java": 1 }
        */

        public void Count(string filepath)
        {
            Dictionary<string,int> dict = new Dictionary<string, int>();
            using(StreamReader reader = new StreamReader(filepath))
            {
                string line;
                while((line  = reader.ReadLine()) != null)
                {
                    line = line.ToLower();
                    char[] separators = { ' ', ',', '.' }; //symbols in file for seperation
                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (dict.ContainsKey(word))
                        {
                            dict[word]++;
                        }
                        else
                        {
                            dict[word] = 1;
                        }
                    }
                }
            }
            Console.WriteLine("Word Frequencies in file:");
            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }
        }
    }
}