using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> newList = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                // Check if either list is too short before dividing
                if (i >= list1.Count || i >= list2.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (list2[i] == 0)
                {
                    throw new DivideByZeroException();
                }

                newList.Add(list1[i] / list2[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                newList.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                newList.Add(0);
            }
        }

        return newList;
    }
}
