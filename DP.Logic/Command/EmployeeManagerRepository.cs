namespace DP.Logic.Command
{
    public class EmployeeManagerRepository : IEmployeeManagerRepository
    {
        private List<Manager> _managers = new List<Manager>
        {
            new Manager(1, "Katie"), new Manager(2,"Geof")
        };

        public void AddEmployee(int managerId, Employee employee)
        {
            _managers.First(m => m.Id == managerId).Employees.Add(employee);
        }

        public bool HasEmployee(int managerId, int employeeId)
        {
          return _managers.First(m=>m.Id == managerId).Employees.Any(i => i.Id == employeeId);
        }

        public void RemoveEmployee(int managerId, Employee employee)
        {
            _managers.First(m =>m.Id == managerId).Employees.Remove(employee);  
        }

        public void WriteDataStore()
        {
            foreach (var manager in _managers)
            {
                Console.WriteLine($"Manager {manager.Id}, {manager.Name}");
                if (manager.Employees.Any())
                {
                    foreach (var employee in manager.Employees)
                    {
                        Console.WriteLine($"\t Employee {employee.Id}, {employee.Name}");
                    }
                }
                else
                {
                    Console.WriteLine($"\t No Employee");
                }

            }
        }
    }
}
