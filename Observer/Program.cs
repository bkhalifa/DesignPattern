// See https://aka.ms/new-console-template for more information
using DP.Logic.Observer;

Console.Title = "Observer";


TicketStoreService ticketStockService = new();
TicketResellerService ticketResellerService = new();
OrderService orderService = new();

// add tow observers

orderService.AddObserver(ticketStockService);
orderService.AddObserver(ticketResellerService);

// notify 
orderService.CompleteTicketSale(1, 2);