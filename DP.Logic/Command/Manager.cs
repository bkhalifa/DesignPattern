﻿namespace DP.Logic.Command
{
    public class Manager : Employee
    {
        public List<Employee> Employees = new();
        public Manager(int id, string name) : base(id, name)
        {
        }
    }
}
