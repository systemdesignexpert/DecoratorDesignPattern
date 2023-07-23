// IProductService.cs

public interface IProductService
{
    double GetProductPrice(string product);
    int GetShippingTime(string product);
    int GetPremiumAnnualFee();
}
