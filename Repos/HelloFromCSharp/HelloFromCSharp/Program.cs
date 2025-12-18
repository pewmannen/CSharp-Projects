using System;
using System.Collections.Generic;

//Problem Summary
//You are given a list of order lines. Each line represents a purchased item.
//You must calculate the total revenue for a given product category.

//Ignore null order lines
//Ignore order lines where:
//Category is null or empty
//Price is less than or equal to 0
//Quantity is less than or equal to 0
//Category matching must be case-insensitive
//Revenue for a line = Price * Quantity
//If no valid order lines match the category, return 0
//Do not throw exceptions

public class OrderLine
{
    public string Category { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public static class RevenueCalculator
{
    public static decimal CalculateCategoryRevenue(
        List<OrderLine> orderLines,
        string category)
    {
        // TODO: implement
        throw new NotImplementedException();
    }
}

public class Program
{
    public static void Main()
    {
        var orderLines = new List<OrderLine>
        {
            new OrderLine { Category = "Books", Quantity = 2, Price = 15m },   // 30
            new OrderLine { Category = "books", Quantity = 1, Price = 20m },   // 20
            new OrderLine { Category = "Games", Quantity = 1, Price = 60m },   // ignore
            new OrderLine { Category = "", Quantity = 5, Price = 10m },        // ignore
            null,
            new OrderLine { Category = "Books", Quantity = -1, Price = 15m },  // ignore
        };

        Console.WriteLine(
            RevenueCalculator.CalculateCategoryRevenue(orderLines, "BOOKS")
        );

        // Expected output: 50
    }
}