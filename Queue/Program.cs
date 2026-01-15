using System;
namespace Collections_Generics.Queue
{
    class Program
    {
        public static void Main(string[] args)
        {
            // /*/
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            ReverseQueue obj1 = new ReverseQueue();
            obj1.Reverse(q);
            // */

            /*
            PriorityQueue<string,int> ll = new PriorityQueue<string, int>((Comparer<int>.Create((a, b) => b.CompareTo(a))));
            ll.Enqueue("John",3);
            ll.Enqueue("Alice",5);
            ll.Enqueue("Bob",2);
            HospitalTriage obj2 = new HospitalTriage();
            obj2.SeverityCheck(ll);
            */

            // int n = 5; // number of binary numbers in list
            // GenerateBinary obj3 = new GenerateBinary();
            // obj3.Generate(n);

            
            

        }
    }
}