using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        if (aQueue == null)
            aQueue = new Queue<string>();

        // Number of items
        Console.WriteLine($"Number of items: {aQueue.Count}");

        // First item
        string? firstItem = aQueue.Count > 0 ? aQueue.Peek() : null;
        Console.WriteLine(firstItem != null ? $"First item: {firstItem}" : "Queue is empty");

        // Add new item
        aQueue.Enqueue(newItem);

        // Check if contains search item
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        // Remove items up to and including search
        if (containsSearch)
        {
            Queue<string> tempQueue = new Queue<string>();
            bool found = false;

            while (aQueue.Count > 0)
            {
                string item = aQueue.Dequeue();
                if (item == search)
                {
                    found = true;
                    break;
                }
                else
                {
                    tempQueue.Enqueue(item);
                }
            }

            while (tempQueue.Count > 0)
            {
                aQueue.Enqueue(tempQueue.Dequeue());
            }
        }

        return aQueue;
    }
}

