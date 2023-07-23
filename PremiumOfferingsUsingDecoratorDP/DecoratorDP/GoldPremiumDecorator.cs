// GoldPremiumDecorator.cs

public class GoldPremiumDecorator : PremiumDecorator
{
    public GoldPremiumDecorator(IProductService service) : base(service)
    {
    }

    public override int GetPremiumAnnualFee()
    {
        return 300;
    }

    public override double GetProductPrice(string product)
    {
        // Gold premium price (30% discount)
        double basePrice = WrappedService.GetProductPrice(product);
        return basePrice * 0.7;
    }

    public override int GetShippingTime(string product)
    {
        // Gold premium shipping time (1 day faster)
        int baseShippingTime = WrappedService.GetShippingTime(product);
        return baseShippingTime - 5;
    }
}
