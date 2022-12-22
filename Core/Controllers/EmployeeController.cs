using System;
using System.Net.Http;
using AzureFuncApi.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using AzureFuncApi.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Web.Http;

namespace AzureFuncApi.Core.Controllers
{

    public class EmployeeController : ControllerBase
    {

        private IEmployee _empRepo;

        public EmployeeController(IEmployee empRepo)
        {
            _empRepo = empRepo;
        }

        [FunctionName("getLogIn")]
        public string getLogIn(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string name = req.Query["empName"];

            return _empRepo.getLogIn(name);
        }

        [FunctionName("getAllEmployees")]
        public async Task<IActionResult> getAllEmployees(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            return Ok(_empRepo.getAllEmployees());
        }

        [FunctionName("getEmployeeByID")]
        public Employee getEmployeeByID(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            string eID = req.Query["empID"];
            int empID = Int32.Parse(eID);
            Employee emp = _empRepo.getEmployeeByID(empID);
            return emp;
        }

        [FunctionName("createEmployee")]
        public string createEmployee(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            Employee emp,
            ILogger log)
        {
            return _empRepo.createEmployee(emp);
        }


        [FunctionName("updateEmployee")]
        public string updateEmployee(
            [HttpTrigger(AuthorizationLevel.Function, "put", Route = null)] HttpRequest req,
            Employee emp,
            ILogger log)
        {
            return _empRepo.updateEmployee(emp);
        }

        [FunctionName("removeEmployee")]
        public string removeEmployee(
            [HttpTrigger(AuthorizationLevel.Function, "delete", Route = null)] HttpRequest req,
            ILogger log)
        {
            string eID = req.Query["empID"];
            int empID = Int32.Parse(eID);
            if (empID == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return _empRepo.removeEmployee(empID);
        }

    }



}


