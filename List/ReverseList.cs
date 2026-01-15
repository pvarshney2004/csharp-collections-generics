using System;
using System.Collections;
namespace Collections_Generics.List
{
    class ReverseList
    {
        /*
1. Reverse a List
Write a program to reverse the elements of a given list without using built-in
reverse methods. Implement it for both ArrayList and LinkedList.
        */
        // method to reverse ArrayList
        public void ReverseArrayList(ArrayList list)
        {
            int i = 0;
            int j = list.Count-1 ;
            while (i < j)
            {
                var temp = list[i];
                list[i] = list[j];
                list[j] = temp;
                i++;
                j--;
            }
        }

        // method to reverse LinkedList
        public LinkedList<int> ReverseLinkedList(LinkedList<int> ll)
        {
            LinkedList<int> ans = new LinkedList<int>();
            LinkedListNode<int> curr = ll.Last;
            while(curr != null)
            {
                ans.AddLast(curr.Value);
                curr = curr.Previous;
            }
            return ans;
        }
    }
}