using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // If key already exists, its value will be replaced automatically
        myDict[key] = value;
        return myDict;
    }
}
