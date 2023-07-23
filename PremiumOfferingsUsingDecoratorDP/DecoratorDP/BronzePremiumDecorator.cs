// BronzePremiumDecorator.cs

public class BronzePremiumDecorator : PremiumDecorator
{
    public BronzePremiumDecorator(IProductService service) : base(service)
    {
    }

    public override int GetPremiumAnnualFee()
    {
        return 80;
    }

    public override double GetProductPrice(string product)
    {
        // Bronze premium price (10% discount)
        double basePrice = WrappedService.GetProductPrice(product);
        return basePrice * 0.9;
    }

    public override int GetShippingTime(string product)
    {
        // Bronze premium shipping time (1 day faster)
        int baseShippingTime = WrappedService.GetShippingTime(product);
        return baseShippingTime - 1;
    }


}
