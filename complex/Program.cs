using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var userProcessor = new UserProcessor();
        try
        {
            userProcessor.PrintUser(null, 2);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        var numbers = new List<int> { 12, 15, 21 };
        var factors = MathUtils.PrimeFactors(numbers);
        Console.WriteLine("Factors: " + string.Join(",", factors));

        var orderProcessor = new OrderProcessor();
        var items = new List<OrderItem>
        {
            new OrderItem { Name = "Book", Price = 100, Quantity = 2 },
            new OrderItem { Name = "Pen", Price = 10, Quantity = 5 }
        };
        var total = orderProcessor.CalculateTotal(items, 0.1m);
        Console.WriteLine("Total: " + total);
    }
}
