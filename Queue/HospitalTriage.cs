using System;
namespace Collections_Generics.Queue
{
    class HospitalTriage
    {
        /*
        3. Hospital Triage System
Simulate a hospital triage system using a PriorityQueue where patients with
higher severity are treated first.
Example:
Patients: [ ("John", 3), ("Alice", 5), ("Bob", 2) ]
Order: Alice, John, Bob
        */

        public void SeverityCheck(PriorityQueue<string, int> ll)
        {
            while (ll.Count > 0)
            {
                ll.TryDequeue(out string name, out int priority);
                Console.WriteLine($"{name} with severity level {priority}");
            }
        }



    }
}