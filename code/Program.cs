// Program.cs
using System;

class Program
{
    static void Main()
    {
        string? name = null;
        Console.WriteLine("Hello " + name.ToUpper()); // จะเกิด NullReferenceException
    }
}
