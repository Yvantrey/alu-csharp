using System;
using System.Collections.Generic;

class LList
{
    // Method that returns the sum of all data in a LinkedList
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        LinkedListNode<int>? current = myLList.First;

        // Traverse the linked list and accumulate values
        while (current != null)
        {
            sum += current.Value;
            current = current.Next;
        }

        return sum;
    }
}
