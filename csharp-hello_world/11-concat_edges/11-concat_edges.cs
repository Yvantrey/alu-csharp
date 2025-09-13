using System;
class Program
{
    static void Main(string[] args)
    {
        string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
        str = str.Replace("C#", "CSharp").Replace(", and type-safe ", " ");
        Console.WriteLine(string.Join(" ", args));
            str.Substring(
                str.IndexOf("object-oriented"),
                str.IndexOf("programming") + "programming".Length - str.IndexOf("object-oriented")
            ) + " in C#"
        );
    }
}
