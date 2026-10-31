namespace Exercise_7;

public class Exercise
{
    public static decimal CalculateShippingCost(decimal orderTotal, bool isPremiumCustomer)
    {
        //your code goes here
        return orderTotal switch
        {
            < 50 => !isPremiumCustomer ? 10m : 5m,
            >= 50 => !isPremiumCustomer ? 5m : 0m
        };
    }

    //public static decimal CalculateShippingCost(decimal orderTotal, bool isPremiumCustomer)
    //{
    //    //your code goes here
    //    return orderTotal switch
    //    {
    //        < 50 when !isPremiumCustomer => 10m,
    //        < 50 when isPremiumCustomer => 5m,
    //        >= 50 when !isPremiumCustomer => 5m,
    //        >= 50 when isPremiumCustomer => 0m,
    //    };
    //}
}

/*
Calculate shipping cost based on order total and customer status (⭐)
Implement the CalculateShippingCost method that calculates the shipping cost 
based on the total value of an order and whether the customer is a premium member.

The method takes two parameters:
orderTotal – the total amount of the order (decimal)
isPremiumCustomer – a boolean flag indicating if the customer is a premium member

The method should return the shipping cost according to these rules:
If the order total is less than 50 and the customer is not a premium member, return 10
If the order total is less than 50 and the customer is a premium member, return 5
If the order total is 50 or more and the customer is not a premium member, return 5
If the order total is 50 or more and the customer is a premium member, return 0

You can use plain old if-else statements, but consider using a switch expression with 
when clauses to make the code shorter and cleaner.

What you'll practice:
Using switch expressions with when clauses
Combining value ranges with boolean flags
Using pattern matching

Example usage:

var result = CalculateShippingCost(30, false); // => 10
var result = CalculateShippingCost(30, true);  // => 5
var result = CalculateShippingCost(60, false); // => 5
var result = CalculateShippingCost(60, true);  // => 0
*/
