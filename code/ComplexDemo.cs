using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexDemo
{
    public class Demo
    {
        // 🐞 Debugger Example: Multiple possible exceptions
        public void ProcessUser(string? name, int age)
        {
            // Potential NullReferenceException
            Console.WriteLine("User: " + name.ToUpper());

            // Potential ArgumentOutOfRangeException
            var arr = new int[5];
            arr[age] = 100;

            // Potential DivideByZeroException
            int score = 100 / (age - 20);
            Console.WriteLine("Score: " + score);
        }

        // ⚡ Profiler Example: Inefficient algorithm
        public List<int> PrimeFactors(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var n in numbers)
            {
                for (int i = 2; i <= n; i++)
                {
                    while (n % i == 0)
                    {
                        result.Add(i);
                        n /= i;
                    }
                }
            }
            return result;
        }

        // 🧪 Test Example: Complex business logic
        public class OrderProcessor
        {
            public decimal CalculateTotal(List<OrderItem> items, decimal discountRate)
            {
                if (items == null || items.Count == 0)
                    throw new ArgumentException("Items cannot be empty");

                decimal subtotal = items.Sum(i => i.Price * i.Quantity);

                if (discountRate < 0 || discountRate > 1)
                    throw new ArgumentOutOfRangeException(nameof(discountRate));

                decimal discount = subtotal * discountRate;
                decimal total = subtotal - discount;

                if (total < 0) total = 0;
                return total;
            }
        }

        public class OrderItem
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
    }
}
