

namespace DP.Logic.legacy
{
    public class StrategyDesignPattern
    {
    }

    public abstract class Strategy
    {
        public string Name { get; }
        public abstract void AlgorithmInterface();
    }
    public interface  IStrategy
    {
        void AlgorithmInterface();
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class ConcreteStrategyA : IStrategy
    {
        public  void AlgorithmInterface()
        {
            Console.WriteLine(
                "Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class ConcreteStrategyB : IStrategy
    {
        public  void AlgorithmInterface()
        {
            Console.WriteLine(
                "Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class ConcreteStrategyC : IStrategy
    {
        public  void AlgorithmInterface()
        {
            Console.WriteLine(
                "Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }

    public class Context
    {
        private IStrategy _strategy { get; }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }

    }

}
