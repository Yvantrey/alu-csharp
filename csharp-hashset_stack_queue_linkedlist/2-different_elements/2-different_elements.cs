using System;
using System.Collections.Generic;

class List
{
    // Method that returns a sorted list of elements present in one or the other list but not both
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> different = new List<int>();

        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);

        // Add elements from list1 not in list2
        foreach (int item in set1)
        {
            if (!set2.Contains(item))
            {
                different.Add(item);
            }
        }

        // Add elements from list2 not in list1
        foreach (int item in set2)
        {
            if (!set1.Contains(item))
            {
                different.Add(item);
            }
        }

        // Sort the result
        different.Sort();

        return different;
    }
}
