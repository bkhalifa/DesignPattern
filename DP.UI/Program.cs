// See https://aka.ms/new-console-template for more information
using DP.Logic.legacy;

Console.WriteLine("Hello, World!");
double a = 1.0;
decimal b = 2.1m;
Console.WriteLine(a + (double)b);
Console.WriteLine((decimal)a + b);

//var context = new Context(new ConcreteStrategyA());
//context.ContextInterface();

//context = new Context(new ConcreteStrategyB());
//context.ContextInterface();
//context = new Context(new ConcreteStrategyC());
//context.ContextInterface();

// Two contexts following different strategies
SortedList studentRecords = new SortedList();
studentRecords.Add("Samual");
studentRecords.Add("Jimmy");
studentRecords.Add("Sandra");
studentRecords.Add("Vivek");
studentRecords.Add("Anna");

studentRecords.SetSortStrategy(new QuickSort());
studentRecords.Sort();
studentRecords.SetSortStrategy(new ShellSort());
studentRecords.Sort();
studentRecords.SetSortStrategy(new MergeSort());
studentRecords.Sort();
// Wait for user
Console.ReadKey();
// Wait for user
Console.ReadKey();