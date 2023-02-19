namespace DP.Logic.Strategy
{
    public interface IExportService
    {
        void Export(Order order);
    }

    public class JsonExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($" export to json {order.Customer}");
        }
    }
    public class XmlExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($" export to xml {order.Customer}");
        }
    }

    public class CsvExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($" export to csv {order.Customer}");
        }
    }

    public class ExportContext
    {
        private IExportService _exportService;
        public ExportContext(IExportService exportService)
        {
            _exportService = exportService; 
        }

       public void Export(Order order)
        {
            _exportService.Export(order);
        }
    }
}
