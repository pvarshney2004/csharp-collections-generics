using System;
using System.Collections;
namespace Collections_Generics.List
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            ReverseList obj1 = new ReverseList();
            ArrayList ll1 = new ArrayList() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original ArrayList: ");
            foreach (var i in ll1) Console.Write(i + " ");
            System.Console.WriteLine();
            obj1.ReverseArrayList(ll1);
            Console.WriteLine("Reversed ArrayList: ");
            foreach (var i in ll1) Console.Write(i + " ");
            System.Console.WriteLine();
            LinkedList<int> ll2 = new LinkedList<int>();
            ll2.AddLast(10);
            ll2.AddLast(20);
            ll2.AddLast(30);
            ll2.AddLast(40);
            ll2.AddLast(50);
            Console.WriteLine("Original LinkedList: ");
            foreach (var i in ll2) Console.Write(i + " ");
            System.Console.WriteLine();
            LinkedList<int> ans = obj1.ReverseLinkedList(ll2);
            Console.WriteLine("Reversed LinkedList: ");
            foreach (var i in ans) Console.Write(i + " ");
            */

            /*
            ArrayList ll = new ArrayList() { 10, 20, 30, 40, 50 };
            int k = 2;
            RotateList obj2 = new RotateList();
            Console.WriteLine("Original ArrayList: ");
            foreach (var i in ll) Console.Write(i + " ");
            System.Console.WriteLine();
            obj2.Rotate(ll,k);
            Console.WriteLine("Rotated ArrayList: ");
            foreach (var i in ll) Console.Write(i + " ");
            */

            /*
            ArrayList ll = new ArrayList() { 3, 1, 2, 2, 3, 4 };
            RemoveDuplicates obj3 = new RemoveDuplicates();
            ArrayList ans = obj3.Remove(ll);
            Console.WriteLine("Original ArrayList: ");
            foreach (var i in ll) Console.Write(i + " ");
            System.Console.WriteLine();
            Console.WriteLine("After removing duplicates from ArrayList: ");
            foreach (var i in ans) Console.Write(i + " ");
            System.Console.WriteLine();
            */

            /*
            FindElement obj4 = new FindElement();
            LinkedList<char> ll = new LinkedList<char>();
            ll.AddLast('A');
            ll.AddLast('B');
            ll.AddLast('C');
            ll.AddLast('D');
            ll.AddLast('E');
            int idx = 2;
            obj4.FindFromEnd(ll,idx);
            */

            FindFrequency obj5 = new FindFrequency();
            ArrayList ll = new ArrayList(){"apple", "banana", "apple", "orange"};
            obj5.Find(ll);
        }
    }
}