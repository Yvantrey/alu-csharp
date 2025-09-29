using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);

        if (aStack.Count > 0)
            Console.WriteLine("Top item: " + aStack.Peek());
        else
            Console.WriteLine("Stack is empty");

        bool contains = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {contains}");

        if (contains)
        {
            Stack<string> temp = new Stack<string>();

            string popped;
            do
            {
                popped = aStack.Pop();
            }
            while (popped != search);

        }

        aStack.Push(newItem);

        return aStack;
    }
}
