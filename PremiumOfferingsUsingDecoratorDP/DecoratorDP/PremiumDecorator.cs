// PremiumDecorator.cs

public abstract class PremiumDecorator : IProductService
{
    protected IProductService WrappedService;

    public PremiumDecorator(IProductService service)
    {
        WrappedService = service;
    }

    public virtual double GetProductPrice(string product)
    {
        return WrappedService.GetProductPrice(product);
    }
    public virtual int GetShippingTime(string product)
    {
        return WrappedService.GetShippingTime(product);
    }
    public virtual int GetPremiumAnnualFee()
    {
        return WrappedService.GetPremiumAnnualFee();
    }

}
