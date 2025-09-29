using System;
using System.Collections.Generic;

class List
{
    // Method that returns a sorted list of common elements between two lists
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> common = new List<int>();

        // Use HashSet for quick lookup
        HashSet<int> set1 = new HashSet<int>(list1);

        foreach (int item in list2)
        {
            if (set1.Contains(item) && !common.Contains(item))
            {
                common.Add(item);
            }
        }

        // Sort the result list
        common.Sort();

        return common;
    }
}
