using System;
	public class PlatinumPremiumDecorator: PremiumDecorator
	{
        public PlatinumPremiumDecorator(IProductService service) : base(service)
        {
        }

        public override int GetPremiumAnnualFee()
        {
            return 500;
        }

        public override double GetProductPrice(string product)
        {
        return base.GetProductPrice(product) * 0.7;
        }

        public override int GetShippingTime(string product)
        {
            return base.GetShippingTime(product) - 7;
        }
    }

