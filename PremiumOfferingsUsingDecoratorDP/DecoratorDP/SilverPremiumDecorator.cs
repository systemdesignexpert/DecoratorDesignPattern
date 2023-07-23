// SilverPremiumDecorator.cs

public class SilverPremiumDecorator : PremiumDecorator
{
    public SilverPremiumDecorator(IProductService service) : base(service)
    {
    }

    public override int GetPremiumAnnualFee()
    {
        return 150;
    }

    public override double GetProductPrice(string product)
    {
        // Silver premium price (20% discount)
        double basePrice = WrappedService.GetProductPrice(product);
        return basePrice * 0.8;
    }

    public override int GetShippingTime(string product)
    {
        // Silver premium shipping time (2 days faster)
        int baseShippingTime = WrappedService.GetShippingTime(product);
        return baseShippingTime - 3;
    }
}
