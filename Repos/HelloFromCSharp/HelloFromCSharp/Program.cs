using System;
using System.Collections.Generic;
using System.Numerics;


/*
Problem Summary

You are given a list of payments. Each payment has a CustomerId and an Amount.
Return a dictionary that maps each customer to their total paid amount, but only include customers whose total exceeds a minimum threshold.

Requirements
If the list is null, return an empty dictionary
Ignore null payments
Ignore payments where:
CustomerId is null or empty
Amount is less than or equal to 0
CustomerId matching is case-insensitive
Output dictionary keys must be UPPERCASE
After aggregating totals, exclude customers whose total is less than or equal to minTotal
Do not throw exceptions

*/

public class Payment
{
    public string CustomerId { get; set; }
    public decimal Amount { get; set; }
}

public static class PaymentStats
{
    public static Dictionary<string, decimal> TotalByCustomerAboveMinimum(List<Payment> payments, decimal minTotal)
    {
        var totalPaidThresholdAmount = new Dictionary<string, decimal>();
        if (payments == null)
        {
            return totalPaidThresholdAmount;
        }

        foreach (var payment in payments)
        {
            if (payment == null)
            {
                continue;
            }

            if (string.IsNullOrWhiteSpace(payment.CustomerId))
            {
                continue;
            }

            if (payment.Amount <= 0)
            {
                continue;
            }

            var key = payment.CustomerId.ToUpperInvariant();

            //Needs to skip C2, by if or new else dictionary. Should only count C1 (refer to requirement section)
            if (totalPaidThresholdAmount.ContainsKey(key))
            {

                totalPaidThresholdAmount[key] += payment.Amount;
            }
            else
            {
                totalPaidThresholdAmount[key] = payment.Amount;
            }
        }

        return totalPaidThresholdAmount;
    }
}

public class Program
{
    public static void Main()
    {
        var payments = new List<Payment>
        {
            new Payment { CustomerId = "C1", Amount = 100m },
            new Payment { CustomerId = "c1", Amount = 50m },
            new Payment { CustomerId = "C2", Amount = 20m },
            new Payment { CustomerId = "C2", Amount = -10m },  // ignore
            null,
            new Payment { CustomerId = "", Amount = 200m }     // ignore
        };

        var result = PaymentStats.TotalByCustomerAboveMinimum(payments, minTotal: 100m);

        foreach (var kvp in result)
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");

        // Expected output:
        // C1 => 150
    }
}