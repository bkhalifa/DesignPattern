namespace DP.Logic.Command
{
    public class CommandManager 
    {
       public void Invoke(ICommand command)
        {
            if (command.CanExecute())
            {
                command.Execute();
            }
        }
    }
}
