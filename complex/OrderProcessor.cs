using System;
using System.Collections.Generic;
using System.Linq;

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

        return total < 0 ? 0 : total;
    }
}

public class OrderItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
