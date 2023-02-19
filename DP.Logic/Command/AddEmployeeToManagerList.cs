namespace DP.Logic.Command
{
    public class AddEmployeeToManagerList : ICommand
    {
        private readonly IEmployeeManagerRepository _employeeManagerRepository;
        private readonly int _managerId;
        private readonly Employee? _employee;
        public AddEmployeeToManagerList(IEmployeeManagerRepository employeeManagerRepository, int managerId, Employee? employee)
        {
            _employeeManagerRepository = employeeManagerRepository;
            _managerId = managerId;
            _employee = employee;
        }
        public bool CanExecute()
        {
            if (_employee == null)
            {
                return false;
            }

            if (_employeeManagerRepository.HasEmployee(_managerId, _employee.Id))
            {
                return false;
            }


            return true;
        }
        public void Execute()
        {
            if (_employee == null)
            {
                return;
            }
            _employeeManagerRepository.AddEmployee(_managerId, _employee);
        }
    }
}
