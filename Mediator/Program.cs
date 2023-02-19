// See https://aka.ms/new-console-template for more information
using DP.Logic.Mediator;

using Mediator;

using System.Text;





var messageWriter = new MessageWriter();
var bilel = new ConcreteColleague(messageWriter, "Bilel");
var titi = new ConcreteColleague(messageWriter, "Titi");

var mediator = new Mediator.ConcreteMediator(bilel, titi);
var m1 = new Message(bilel, "hi there i am bilel");
var m2 = new Message(titi, "hi i'am titi");
mediator.send(m1);
mediator.send(m2);

bilel.ReceiveMessage(m2);
titi.ReceiveMessage(m1);

var output = messageWriter.OutPut.ToString();

Console.WriteLine(output);


 class MessageWriter: IMessageWriter<Message>
{
    public StringBuilder OutPut { get; } = new StringBuilder();

    public void Write(Message tmessage)
    {
        OutPut.AppendLine($"[{tmessage.Sender.Name}]: {tmessage.Content}");
    }
}

//var mediator = new ConcreteMediator();

//var c1 = new Colleague1(mediator);
//var c2 = new Colleague2(mediator);

//mediator.Colleague1 = c1;
//mediator.Colleague2 = c2;

//c1.Send("hello from c1");
//c2.Send("hello from c2");

//Derrive d = new Derrive(new Base());
//d.checkThisOut("message");