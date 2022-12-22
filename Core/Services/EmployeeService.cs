using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using AzureFuncApi.Core.Services;
using AzureFuncApi.Core.Models;

namespace AzureFuncApi.Core.Services
{
    public class EmployeeService: IEmployee
    {
        public static List<Employee> empList = null;

        public EmployeeService()
        {
            empList = new List<Employee>() {
                new Employee()
                {
                    empID = 1516,
                    empName = "Sricharan",
                    empAge = 22,
                    empLn = "Chennai",
                }
            };
        }

        public string getLogIn(string empName)
        {
            return $"{empName} logged in successfully";
        }

        public async Task <IEnumerable<Employee>> getAllEmployees()
        {
                return empList;     
        }

        public Employee getEmployeeByID(int eID)
        {
            Employee emp = empList.Find(x => x.empID == eID);
            if (emp == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return emp;
        }

        public string createEmployee(Employee emp)
        {
            if(emp != null)
            {
                empList.Add(emp);
                return "Employee created successfully";
            }
            else
                throw new HttpResponseException(HttpStatusCode.NotFound);

        }

        public string updateEmployee(Employee emp)
        {
            Employee empUpdate = empList.Find(x => x.empID == emp.empID);
            if (empUpdate != null)
            {
                empUpdate.empName = emp.empName;
                empUpdate.empAge = emp.empAge;
                empUpdate.empLn = emp.empLn;
                return "Employee updated successfully";
            }
            else
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        public string removeEmployee(int empID)
        {
            Employee empDelete = empList.Find(x => x.empID == empID);
            if (empDelete != null)
            {
                empList.Remove(empDelete);
                return "Employee removed successfully";
            }
            else
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
    }
}

