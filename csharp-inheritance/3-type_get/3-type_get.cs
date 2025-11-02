using System;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        if (myObj == null)
        {
            Console.WriteLine("Object is null");
            return;
        }

        Type type = myObj.GetType();

        // Print properties
        Console.WriteLine($"{type.Name} Properties:");
        PropertyInfo[] properties = type.GetProperties();
        foreach (var prop in properties)
        {
            Console.WriteLine(prop.Name);
        }

        // Print methods
        Console.WriteLine($"{type.Name} Methods:");
        MethodInfo[] methods = type.GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}

