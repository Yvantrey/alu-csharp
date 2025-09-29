using System;
using System.Collections.Generic;

class LList
{
    // Method that finds a value in a LinkedList and returns its index
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        LinkedListNode<int>? current = myLList.First;

        // Traverse the linked list
        while (current != null)
        {
            if (current.Value == value)
            {
                return index; // Found the value
            }
            current = current.Next;
            index++;
        }

        // Value not found
        return -1;
    }
}
