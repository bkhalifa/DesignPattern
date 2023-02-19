// See https://aka.ms/new-console-template for more information
using DP.Logic.Strategy;

Console.WriteLine("Hello, World!");

var order= new Order(1, "test", 10.2d);

var context = new ExportContext(new JsonExportService());
context.Export(order);

var context2 = new ExportContext(new XmlExportService());
context2.Export(order);

var context3 = new ExportContext(new CsvExportService());
context3.Export(order);

