namespace DP.Logic.State
{

    public abstract class BankAccountState
    {
        public BankAccount BankAccount { get; protected set; } = null!;
        public decimal Balance { get; protected internal set; }
        public abstract void Deposit(decimal amount);
        public abstract void WithDraw(decimal amount);
    }

    public class RegularState : BankAccountState
    {
        public RegularState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;
        }

        public override void WithDraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount} from {Balance}");
            Balance -= amount;

            if (Balance < 0)
            {
                BankAccount.BankAccountState = new OverDrawState(Balance, BankAccount);
            }
        }
    }

    public class OverDrawState : BankAccountState
    {
        public OverDrawState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;
            if (Balance >= 0)
            {
                BankAccount.BankAccountState = new RegularState(Balance, BankAccount);
            }
        }

        public override void WithDraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, cannot with draw , balance {Balance}");
        }
    }

    /// <summary>
    /// Context
    /// </summary>
    public class BankAccount
    {
        public BankAccountState BankAccountState { get; set; }
        public decimal BankAccountBalance { get { return BankAccountState.Balance; } }
        public BankAccount()
        {
            BankAccountState = new RegularState(200, this);
        }

        public void Deposit(decimal amount)
        {
            BankAccountState.Deposit(amount);
        }

        public void WithDraw(decimal amount)
        {
            BankAccountState.WithDraw(amount);
        }
    }
}
