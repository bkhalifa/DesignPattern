namespace DP.Logic.Factory.Business
{
    public class DrinkFactory : ProductFactory
    {
        public override Product GetProduct(string productType)
        {
            switch (productType)
            {
                case "coca":
                    return new Drink(3, "coca-cola", 40m);

                case "water":
                    return new Drink(3, "evian", 20m);

                default:
                    return null!;

            }
        }
    }
}
