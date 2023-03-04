// See https://aka.ms/new-console-template for more information
using DP.Logic.Singleton;

Console.WriteLine("Hello, World!");



Dictionary<Person, int> dict = new Dictionary<Person, int>
{
    { new Person {Name = "Bilel", LastName = "Khalifa"},78 },
    { new Person {Name = "Jacques", LastName = "Chirac"},102 },

};
var chric = new Person { Name = "Jacques", LastName = "Chirac" };

int age;
dict.TryGetValue(chric, out age);
Console.WriteLine(age);

class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
}


//var instance1 =  Logger.Instance;
//var instance2 = Logger.Instance;


//if (instance1 == instance2 && instance2 == Logger.Instance)
//{
//    Console.WriteLine("Instance are the same");
//}


//instance1.Log($"message from {nameof(instance1)}");
//instance1.Log($"message from {nameof(instance2)}");
//Logger.Instance.Log($"messsage from {nameof(Logger.Instance)}");

//var b1 = LoadBalancer.Instance;
//var b2 = LoadBalancer.Instance;
//var b3 = LoadBalancer.Instance;
//var b4=  LoadBalancer.Instance;

//if (b1 == b2 && b2 == b3 && b3 == b4)
//{
//    Console.WriteLine("Same instance\n");
//}
//LoadBalancer balancer = LoadBalancer.Instance;
//for (int i = 0; i < 15; i++)
//{
//    string server = balancer.Server;
//    Console.WriteLine("Dispatch Request to: " + server);
//}

