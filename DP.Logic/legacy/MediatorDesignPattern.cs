//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DP.Logic.Legacy
//{
//    /// <summary>
//    /// The 'Mediator' abstract class
//    /// </summary>
//    public abstract class Mediator
//    {
//        public abstract void Send(string message,
//            Colleague colleague);
//    }
//    /// <summary>
//    /// The 'ConcreteMediator' class
//    /// </summary>
//    public class ConcreteMediator : Mediator
//    {
//        ConcreteColleague1 colleague1;
//        ConcreteColleague2 colleague2;
//        public ConcreteColleague1 Colleague1
//        {
//            set { colleague1 = value; }
//        }
//        public ConcreteColleague2 Colleague2
//        {
//            set { colleague2 = value; }
//        }
//        public override void Send(string message, Colleague colleague)
//        {
//            if (colleague == colleague1)
//            {
//                colleague2.Notify(message);
//            }
//            else
//            {
//                colleague1.Notify(message);
//            }
//        }
//    }
//    /// <summary>
//    /// The 'Colleague' abstract class
//    /// </summary>
//    public abstract class Colleague
//    {
//        protected Mediator mediator;
//        // Constructor
//        public Colleague(Mediator mediator)
//        {
//            this.mediator = mediator;
//        }
//    }
//    /// <summary>
//    /// A 'ConcreteColleague' class
//    /// </summary>
//    public class ConcreteColleague1 : Colleague
//    {
//        // Constructor
//        public ConcreteColleague1(Mediator mediator)
//            : base(mediator)
//        {
//        }
//        public void Send(string message)
//        {
//            mediator.Send(message, this);
//        }
//        public void Notify(string message)
//        {
//            Console.WriteLine("Colleague1 gets message: "
//                + message);
//        }
//    }
//    /// <summary>
//    /// A 'ConcreteColleague' class
//    /// </summary>
//    public class ConcreteColleague2 : Colleague
//    {
//        // Constructor
//        public ConcreteColleague2(Mediator mediator)
//            : base(mediator)
//        {
//        }
//        public void Send(string message)
//        {
//            mediator.Send(message, this);
//        }
//        public void Notify(string message)
//        {
//            Console.WriteLine("Colleague2 gets message: "
//                + message);
//        }
//    }


//    //*************************************************************************************


//    /// <summary>
//    /// The 'Mediator' abstract class
//    /// </summary>
//    public abstract class AbstractChatroom
//    {
//        public abstract void Register(Participant participant);
//        public abstract void Send(string from, string to, string message);
//    }
//    /// <summary>
//    /// The 'ConcreteMediator' class
//    /// </summary>
//    public class Chatroom : AbstractChatroom
//    {
//        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();
//        public override void Register(Participant participant)
//        {
//            if (!participants.ContainsValue(participant))
//            {
//                participants[participant.Name] = participant;
//            }
//            participant.Chatroom = this;
//        }
//        public override void Send(string from, string to, string message)
//        {
//            Participant participant = participants[to];
//            if (participant != null)
//            {
//                participant.Receive(from, message);
//            }
//        }
//    }
//    /// <summary>
//    /// The 'AbstractColleague' class
//    /// </summary>
//    public class Participant
//    {
//        Chatroom chatroom;
//        string name;
//        // Constructor
//        public Participant(string name)
//        {
//            this.name = name;
//        }
//        // Gets participant name
//        public string Name
//        {
//            get { return name; }
//        }
//        // Gets chatroom
//        public Chatroom Chatroom
//        {
//            set { chatroom = value; }
//            get { return chatroom; }
//        }
//        // Sends message to given participant
//        public void Send(string to, string message)
//        {
//            chatroom.Send(name, to, message);
//        }
//        // Receives message from given participant
//        public virtual void Receive(
//            string from, string message)
//        {
//            Console.WriteLine("{0} to {1}: '{2}'",
//                from, Name, message);
//        }
//    }
//    /// <summary>
//    /// A 'ConcreteColleague' class
//    /// </summary>
//    public class Beatle : Participant
//    {
//        // Constructor
//        public Beatle(string name)
//            : base(name)
//        {
//        }
//        public override void Receive(string from, string message)
//        {
//            Console.Write("To a Beatle: ");
//            base.Receive(from, message);
//        }
//    }
//    /// <summary>
//    /// A 'ConcreteColleague' class
//    /// </summary>
//    public class NonBeatle : Participant
//    {
//        // Constructor
//        public NonBeatle(string name)
//            : base(name)
//        {
//        }
//        public override void Receive(string from, string message)
//        {
//            Console.Write("To a non-Beatle: ");
//            base.Receive(from, message);
//        }
//    }
//}
