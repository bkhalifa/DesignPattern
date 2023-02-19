// See https://aka.ms/new-console-template for more information
using ChainOfResponsability.Business.Payments;
using ChainOfResponsability.Models;

using DP.Logic.ChainOfResponsability;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

Console.Title = "Chain of responsability";


// payment process //

var order = new Order();
order.LineItems.Add(new Item(1, "Atomos ninja v", 499), 2);
order.LineItems.Add(new Item(2,"Canon",1799),2);

order.SelectedPayments.Add(
    new Payment
    {
        PaymentProvider = PaymentProvider.Paypal,
        Amount = 1000
    }
    );
order.SelectedPayments.Add(new Payment
{
    PaymentProvider = PaymentProvider.Invoice,
    Amount = 1799
});

Console.WriteLine(order.AmountDue);
Console.WriteLine(order.ShippingStatus);

///Handle payment...

var handler = new PayPalHandler();
handler.SetNext(new CreditCardHandler())
       .SetNext(new InvoiceHandler());

handler.Handle(order);

Console.WriteLine(order.AmountDue);
Console.WriteLine(order.ShippingStatus);



// validation process ///
var user = new User("Filip Ekberg",
               "870101XXXX",
               new RegionInfo("SE"),
               new DateTimeOffset(1987, 01, 29, 00, 00, 00, TimeSpan.FromHours(2)));


Console.WriteLine(user.Age);
var processor = new UserProcessor();

var ressult = processor.Register(user);

Console.WriteLine(ressult);






//var validDocument = new Document("how to avoid Java Development", DateTimeOffset.UtcNow, true, true);
//var invalidDodiment = new Document("How to avoid java develeopement", DateTimeOffset.UtcNow, false, true);

//var documentHandlerChain = new DocumentTitleHandler();
//documentHandlerChain
//    .SetSuccessor(new DocumentLastModifiedHandler())
//    .SetSuccessor(new DocumentApprovedByManagmentHandler())
//    .SetSuccessor(new DocumentApprovedByLitigationHandler());

//try
//{
//    documentHandlerChain.Handle(validDocument);
//    Console.WriteLine("Valid document is valid");
//    documentHandlerChain.Handle(invalidDodiment);
//    Console.WriteLine("Invalid document is valid");
//}
//catch (ValidationException validationExcpetion)
//{
//    Console.WriteLine(validationExcpetion.Message);
//}

Console.ReadKey();