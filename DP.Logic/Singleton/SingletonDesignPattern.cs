namespace DP.Logic.Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {

        private static readonly Lazy<Logger> _logger = new Lazy<Logger>(() => new Logger());
        public static Logger Instance
        {
            get
            {
                return _logger.Value;
                //if (_instance == null) { _instance = new Logger(); }
                //return _instance;
            }
        }

        protected Logger()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine($"log info from => {message} ");
        }
    }

    public class Singleton
    {
        private static Singleton instance;

        private static object locker = new object();

        public static Singleton Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }

                    return instance;
                }

            }
        }

        protected Singleton()
        {

        }
    }


    public class Singleton2
    {
        private static Lazy<Singleton2> instance = new Lazy<Singleton2>();

        public Singleton2 Instance
        { 
          get
            {
                return instance.Value;
            }
        }

        protected Singleton2()
        {

        }
    }


  }
