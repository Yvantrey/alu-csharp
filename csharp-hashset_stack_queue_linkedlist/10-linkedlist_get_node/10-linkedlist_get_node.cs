using System;
using System.Collections.Generic;

class LList
{
    // Method that returns the value of the nth node in a LinkedList
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        // Check for invalid index
        if (n < 0)
            return 0;

        int index = 0;
        LinkedListNode<int>? current = myLList.First;

        // Traverse the linked list
        while (current != null)
        {
            if (index == n)
                return current.Value;

            current = current.Next;
            index++;
        }

        // Node at index n does not exist
        return 0;
    }
}
