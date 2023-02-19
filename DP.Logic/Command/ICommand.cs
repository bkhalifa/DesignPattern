namespace DP.Logic.Command
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
    }
}
