using System;
namespace Collections_Generics.List
{
    class FindElement
    {
        /*
        5. Find the Nth Element from the End
Given a singly linked list (LinkedList), find the Nth element from the end
without calculating its size.
Example:
Input: [A, B, C, D, E], N=2
Output: D
        */
        // method for finding nth element from end
        public void FindFromEnd(LinkedList<char> ll, int idx)
        {
            ReverseLinkedList(ll);
            LinkedListNode<char> ans = ll.First;
            for(int i=1; i<idx; i++)
            {
                ans = ans.Next;
            }
            System.Console.WriteLine($"{idx} element from end: "+ ans.Value);
        }

        // method to reverse LinkedList
        public void ReverseLinkedList(LinkedList<char> ll)
        {
            LinkedListNode<char> current = ll.First;
            while (current.Next != null)
            {
                LinkedListNode<char> nextNode = current.Next;
                ll.Remove(nextNode);
                ll.AddFirst(nextNode);
            }
        }
    }
}