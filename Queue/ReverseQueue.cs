using System;
namespace Collections_Generics.Queue
{
    class ReverseQueue
    {
        /*
        1. Reverse a Queue
Reverse the elements of a queue using only queue operations.
Example:
Input: [10, 20, 30]
Output: [30, 20, 10]
        */

        public void Reverse(Queue<int> q)
        {
            Queue<int> reversed = new Queue<int>(q.Reverse());
            System.Console.WriteLine("Original Queue: ");
            foreach (var item in q)
            {
                System.Console.Write(item+" ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Reversed Queue: ");
            foreach (var item in reversed)
            {
                System.Console.Write(item+" ");
            }
        }
    }
}