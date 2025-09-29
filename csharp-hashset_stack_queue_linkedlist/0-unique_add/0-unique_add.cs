using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        // HashSet removes duplicates automatically
        HashSet<int> unique = new HashSet<int>(myList);

        int sum = 0;
        foreach (int num in unique)
            sum += num;

        return sum;
    }
}
