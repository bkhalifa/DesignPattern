namespace DP.Logic.Facade
{
    public class BreadProvider : IBread
    {
        public void GetCheesyGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting cheesy Garlic Bread");
        }

        private void GetCheese()
        {
            Console.WriteLine("Getting Cheese");
        }

        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }
    }
}
