namespace DP.Logic.Factory.Business
{
    public abstract class ProductFactory
    {
        public abstract Product GetProduct(string productType);

        public static ProductFactory CreateProductFactory(string productType)
        {
            if (productType.Equals("drink"))
            {
                return new DrinkFactory();
            }
            if (productType.Equals("drink"))
            {
                return new FruitFactory();
            }

            throw new ArgumentException("");
        }
    }
}
