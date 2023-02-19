// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// Part 1: initialize data.
Dictionary<string, int> data1 = new Dictionary<string, int>()
        {
            {"cat", 2},
            {"dog", 1},
            {"llama", 0},
            {"iguana", -1}
        };

// Part 2: loop over pairs with foreach.
foreach (KeyValuePair<string, int> pair in data1)
{
    Console.WriteLine("FOREACH KEYVALUEPAIR: {0}, {1}", pair.Key, pair.Value);
}

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

