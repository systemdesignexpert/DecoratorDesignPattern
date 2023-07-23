using System;
using System.Reflection.Emit;

	public class ProductService
	{
		double price;
		int shipping_time;
		public ProductService(int _price, int _shipping_time)
		{
			this.price = _price;
			this.shipping_time = _shipping_time;
		}
        public double GetProductPrice(PremiumLayers layer)
		{
            if(layer == PremiumLayers.ZENITH)
            {
            return price * 0.5;
            }
			else if(layer == PremiumLayers.GOLD)
			{
				return price * 0.7;
			} else if (layer == PremiumLayers.SILVER)
			{
                return price * 0.8;
            } else if(layer == PremiumLayers.PLATINUM)
			{
                return price * 0.6;
            } else if(layer == PremiumLayers.BRONZE)
			{
                return price * 0.9;
            } else
			{
				return price * 1.0;
			}

		}
        public int GetShippingTime(PremiumLayers layer)
		{
            if (layer == PremiumLayers.PLATINUM)
            {
                return Math.Max(0, shipping_time - 9);
            }
            else if (layer == PremiumLayers.GOLD)
            {
                return Math.Max(0, shipping_time - 5);
            }
            else if (layer == PremiumLayers.SILVER)
            {
                return Math.Max(0, shipping_time - 3);
            }
            else if (layer == PremiumLayers.PLATINUM)
            {
                return Math.Max(0, shipping_time - 7);
            }
            else if (layer == PremiumLayers.BRONZE)
            {
                return Math.Max(0, shipping_time - 1);
            }
            else
            {
                return Math.Max(0, shipping_time - 0);
            }

        }

        public int GetPremiumAnnualFee(PremiumLayers layer)
		{
            if (layer == PremiumLayers.GOLD)
            {
                return 300;
            }
            else if (layer == PremiumLayers.SILVER)
            {
                return 150;
            }
            else if (layer == PremiumLayers.PLATINUM)
            {
                return 350;
            }
            else if (layer == PremiumLayers.BRONZE)
            {
                return 80;
            }
            else
            {
                return 0;
            }
        }

    }

