using System;

public class UserProcessor
{
    public void PrintUser(string? name, int age)
    {
        Console.WriteLine("User: " + name.ToUpper()); // NullReferenceException
        var arr = new int[5];
        arr[age] = 100; // ArgumentOutOfRangeException
        int score = 100 / (age - 20); // DivideByZeroException
        Console.WriteLine("Score: " + score);
    }
}
