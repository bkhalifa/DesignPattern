namespace DP.Logic.Singleton
{
    public class LoadBalancer
    {

        private static readonly Lazy<LoadBalancer> _instance =
            new Lazy<LoadBalancer>(() => new LoadBalancer());

        List<string> servers = new List<string>();
        Random random = new Random();

        public static LoadBalancer Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        protected LoadBalancer()
        {
            // List of available servers
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }

    }
}
