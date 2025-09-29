using System;
using System.Collections.Generic;

class LList
{
    // Method that adds a node to the beginning of a LinkedList
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        // Add new node at the beginning
        LinkedListNode<int> newNode = myLList.AddFirst(n);
        return newNode;
    }
}
