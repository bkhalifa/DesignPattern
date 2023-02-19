namespace DP.Logic.Facade
{
    public class PizzaProvider : IPizza
    {
        public void GetNonVegPizz()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting non veg pizza");
        }

        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting non Veg Pizza toppings");
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza");
        }
    }
}
