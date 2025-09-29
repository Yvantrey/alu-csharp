using System;
using System.Collections.Generic;

class LList
{
    // Method that returns the number of elements in a LinkedList without using .Count
    public static int Length(LinkedList<int> myLList)
    {
        int length = 0;
        LinkedListNode<int>? current = myLList.First;

        // Traverse the linked list manually
        while (current != null)
        {
            length++;
            current = current.Next;
        }

        return length;
    }
}
