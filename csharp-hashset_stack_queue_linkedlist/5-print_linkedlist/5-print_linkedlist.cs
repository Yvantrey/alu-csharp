using System;
using System.Collections.Generic;

class LList
{
    // Method that creates and prints a LinkedList of integers
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> llist = new LinkedList<int>();

        // Return empty list if size is negative
        if (size < 0)
            return llist;

        // Add integers from 0 to size - 1
        for (int i = 0; i < size; i++)
        {
            llist.AddLast(i);
            Console.WriteLine(i);
        }

        return llist;
    }
}