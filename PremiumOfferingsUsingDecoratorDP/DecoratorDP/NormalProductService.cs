// NormalProductService.cs

using System;

public class NormalProductService : IProductService
{
    public int GetPremiumAnnualFee()
    {
        return 0;
    }

    public double GetProductPrice(string product)
    {
        // Non-premium price (MRP)
        // In a real-world scenario, this method could fetch the price from a database or external service.
        // For simplicity, we use fixed prices here.
        return 100.0;
    }

    public int GetShippingTime(string product)
    {
        // Non-premium shipping time
        // In a real-world scenario, this method could fetch the shipping time from a database or external service.
        // For simplicity, we use a fixed shipping time here.
        return 10;
    }
}
