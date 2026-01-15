using System;
namespace Collections_Generics.Map
{
    class Program
    {
        public static void Main(string[] args)
        {
            // WordFrequency obj1 = new WordFrequency();
            // string filepath = "sample.txt";
            // obj1.Count(filepath);

            InvertMap obj2 = new InvertMap();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('A',1);
            dict.Add('B',2);
            dict.Add('C',1);
            System.Console.WriteLine("Original Dictionary: ");
            foreach(var pair in dict)
            {
                System.Console.WriteLine(pair.Key+"->"+pair.Value);
            }
            obj2.Invert(dict);
        }
    }
}