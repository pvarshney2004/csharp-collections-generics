using System;
using System.Collections;
namespace Collections_Generics.Queue
{
    class GenerateBinary
    {
        /*
        2. Generate Binary Numbers Using a Queue
Generate the first N binary numbers using a queue.
Example:
Input: N=5
Output: {"1", "10", "11", "100", "101"}
        */

        public void Generate(int n)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("1");
            for(int i=0; i<n; i++)
            {
                string curr = q.Dequeue();
                System.Console.WriteLine(curr);
                q.Enqueue(curr+"0");
                q.Enqueue(curr+"1");
            }
        }


    }
}