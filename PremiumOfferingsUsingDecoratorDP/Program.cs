// Program.cs

using System;

public static class Program
{
    public static void Main()
    {
        // Non-Premium Customer Experience:

        //ProductService ps = new ProductService(100, 10);

        //Console.WriteLine("Non-Premium Customer Experience:");
        //Console.WriteLine("Annual Premium Fee: $" + ps.GetPremiumAnnualFee(PremiumLayers.NONE));
        //Console.WriteLine("Product Price: $" + ps.GetProductPrice(PremiumLayers.NONE));
        //Console.WriteLine("Shipping Time: " + ps.GetShippingTime(PremiumLayers.NONE) + " days");

        //// Premium Customer Experience (Platinum Level):
        //Console.WriteLine("\nPremium Customer Experience (Platinum Level):");
        //Console.WriteLine("Annual Premium Fee: $" + ps.GetPremiumAnnualFee(PremiumLayers.PLATINUM));
        //Console.WriteLine("Product Price: $" + ps.GetProductPrice(PremiumLayers.PLATINUM));
        //Console.WriteLine("Shipping Time: " + ps.GetShippingTime(PremiumLayers.PLATINUM) + " days");

        //// Premium Customer Experience (Gold Level):
        //Console.WriteLine("\nPremium Customer Experience (Gold Level):");
        //Console.WriteLine("Annual Premium Fee: $" + ps.GetPremiumAnnualFee(PremiumLayers.GOLD));
        //Console.WriteLine("Product Price: $" + ps.GetProductPrice(PremiumLayers.GOLD));
        //Console.WriteLine("Shipping Time: " + ps.GetShippingTime(PremiumLayers.GOLD) + " days");

        //// Premium Customer Experience (Silver Level):
        //Console.WriteLine("\nPremium Customer Experience (Silver Level):");
        //Console.WriteLine("Annual Premium Fee: $" + ps.GetPremiumAnnualFee(PremiumLayers.SILVER));
        //Console.WriteLine("Product Price: $" + ps.GetProductPrice(PremiumLayers.SILVER));
        //Console.WriteLine("Shipping Time: " + ps.GetShippingTime(PremiumLayers.SILVER) + " days");

        //// Premium Customer Experience (Bronze Level):
        //Console.WriteLine("\nPremium Customer Experience (Bronze Level):");
        //Console.WriteLine("Annual Premium Fee: $" + ps.GetPremiumAnnualFee(PremiumLayers.BRONZE));
        //Console.WriteLine("Product Price: $" + ps.GetProductPrice(PremiumLayers.BRONZE));
        //Console.WriteLine("Shipping Time: " + ps.GetShippingTime(PremiumLayers.BRONZE) + " days");




        IProductService normalService = new NormalProductService();
        Console.WriteLine("Non-Premium Customer Experience:");
        Console.WriteLine("Annual Premium Fee: $" + normalService.GetPremiumAnnualFee());
        Console.WriteLine("Product Price: $" + normalService.GetProductPrice("ProductA"));
        Console.WriteLine("Shipping Time: " + normalService.GetShippingTime("ProductA") + " days");

        Console.WriteLine("\nPremium Customer Experience (Platinum Level):");
        IProductService platinumService = new PlatinumPremiumDecorator(normalService);
        Console.WriteLine("Annual Premium Fee: $" + platinumService.GetPremiumAnnualFee());
        Console.WriteLine("Product Price: $" + platinumService.GetProductPrice("ProductA"));
        Console.WriteLine("Shipping Time: " + platinumService.GetShippingTime("ProductA") + " days");


        Console.WriteLine("\nPremium Customer Experience (Gold Level):");
        IProductService goldService = new GoldPremiumDecorator(normalService);
        Console.WriteLine("Annual Premium Fee: $" + goldService.GetPremiumAnnualFee());
        Console.WriteLine("Product Price: $" + goldService.GetProductPrice("ProductA"));
        Console.WriteLine("Shipping Time: " + goldService.GetShippingTime("ProductA") + " days");

        Console.WriteLine("\nPremium Customer Experience (Silver Level):");
        IProductService silverService = new SilverPremiumDecorator(normalService);
        Console.WriteLine("Annual Premium Fee: $" + silverService.GetPremiumAnnualFee());
        Console.WriteLine("Product Price: $" + silverService.GetProductPrice("ProductA"));
        Console.WriteLine("Shipping Time: " + silverService.GetShippingTime("ProductA") + " days");

        Console.WriteLine("\nPremium Customer Experience (Bronze Level):");
        IProductService bronzeService = new BronzePremiumDecorator(normalService);
        Console.WriteLine("Annual Premium Fee: $" + bronzeService.GetPremiumAnnualFee());
        Console.WriteLine("Product Price: $" + bronzeService.GetProductPrice("ProductA"));
        Console.WriteLine("Shipping Time: " + bronzeService.GetShippingTime("ProductA") + " days");
    }
}
