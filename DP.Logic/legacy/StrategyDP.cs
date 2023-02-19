namespace DP.Logic.legacy
{
 

    public  interface ISortStrategy
    {
        public void Sort(List<string> list);
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort();  // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class ShellSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.ShellSort();  not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class MergeSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class SortedList
    {
        private List<string> list = new List<string>();
        private ISortStrategy _sortstrategy;
        public void SetSortStrategy(ISortStrategy sortstrategy)
        {
            _sortstrategy = sortstrategy;
        }
        public void Add(string name)
        {
            list.Add(name);
        }
        public void Sort()
        {
            _sortstrategy.Sort(list);
            // Iterate over list and display results
            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }

}
