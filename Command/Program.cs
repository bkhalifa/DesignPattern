using DP.Logic.Command;

Console.Title = "Command design pattern";

CommandManager commandManager = new();

IEmployeeManagerRepository repository = new EmployeeManagerRepository();

commandManager.Invoke(new AddEmployeeToManagerList(repository, 1 , new Employee(111, "Kevin")));
