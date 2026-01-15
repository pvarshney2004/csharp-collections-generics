using System;
namespace Collections_Generics.Set
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            HashSet<int> set1 = new HashSet<int>{1,2,3};
            HashSet<int> set2 = new HashSet<int>{3,1,2};
            CheckSetsEqual obj1 = new CheckSetsEqual();
            bool ans = obj1.IsEqual(set1, set2);
            if(ans) System.Console.WriteLine("Both the sets are equals.");
            else System.Console.WriteLine("Sets are not equal.");
            */

            /*
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 5 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
            UnionIntersection obj2 = new UnionIntersection();
            obj2.Union(set1,set2);
            System.Console.WriteLine("After union of both sets: ");
            foreach (int item in set1)
            {
                System.Console.Write(item+" ");
            }
            obj2.Intersection(set1,set2);
            System.Console.WriteLine("After intersection of both sets: ");
            foreach (int item in set1)
            {
                System.Console.Write(item+" ");
            }
            */

            /*
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
            SymmetricDiff obj3 = new SymmetricDiff();
            obj3.Diffrence(set1,set2);
            System.Console.WriteLine("Symmetric diffrence: ");
            foreach (var item in set1)
            {
                System.Console.Write(item+" ");
            }
            */

            /*
            HashSet<int> set1 = new HashSet<int> { 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };
            CheckSubset obj4 = new CheckSubset();
            bool ans = obj4.IsSubset(set1, set2);
            System.Console.WriteLine(ans);
            */

            HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };
            ConvertSet obj5 = new ConvertSet();
            obj5.Convert(set);

        }
    }
}