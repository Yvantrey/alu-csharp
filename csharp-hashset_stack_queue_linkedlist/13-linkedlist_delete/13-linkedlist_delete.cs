using System;
using System.Collections.Generic;

class LList
{
    // Method that deletes the node at a given index in a LinkedList
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || myLList.First == null)
            return;

        LinkedListNode<int> current = myLList.First;
        int currentIndex = 0;

        // If deleting the first node
        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }

        // Traverse to the node just before the one to delete
        while (current != null && currentIndex < index)
        {
            current = current.Next;
            currentIndex++;
        }

        // If node exists at the given index, remove it
        if (current != null)
        {
            myLList.Remove(current);
        }
    }
}
