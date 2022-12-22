using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AzureFuncApi.Core.Models;

namespace AzureFuncApi.Core.Services
{
    public interface IEmployee
    {
        public string getLogIn(string name);

        public Task <IEnumerable<Employee>> getAllEmployees();

        public Employee getEmployeeByID(int id);

        public string createEmployee(Employee emp);

        public string updateEmployee(Employee emp);

        public string removeEmployee(int id);
    }
}