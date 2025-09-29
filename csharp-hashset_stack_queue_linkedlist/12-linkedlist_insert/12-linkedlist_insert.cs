using System;
using System.Collections.Generic;

class LList
{
    // Method that inserts a new node in the correct position in an ordered LinkedList
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        // If the list is empty or n should be first
        if (myLList.First == null || n <= myLList.First.Value)
        {
            return myLList.AddFirst(n);
        }

        LinkedListNode<int> current = myLList.First;

        // Traverse the list to find the correct position
        while (current.Next != null && current.Next.Value < n)
        {
            current = current.Next;
        }

        // Insert after the current node
        return myLList.AddAfter(current, n);
    }
}
