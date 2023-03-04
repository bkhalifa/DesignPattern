namespace DP.Logic.Factory.Business
{
    public class FruitFactory : ProductFactory
    {
        public override Product GetProduct(string productType)
        {
            switch (productType)
            {
                case "banana":
                    return new Fruit(33, "Banana", 40m);

                case "apple":
                    return new Fruit(3, "apple", 20m);

                default:
                    return null!;

            }
        }
    }
}
