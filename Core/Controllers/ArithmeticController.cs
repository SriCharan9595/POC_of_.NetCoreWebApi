using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using AzureFuncApi.Core.Services;

namespace AzureFuncApi.Core.controllers

{
    public class ArithmeticController : ControllerBase
    {
        private IArithmetic _arithRepo;

        public ArithmeticController(IArithmetic arithRepo)
        {
            _arithRepo = arithRepo;
        }

        [FunctionName("getAdd")]
        public string getAdd(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string strNum1 = req.Query["num1"];
            string strNum2 = req.Query["num2"];

            int num1 = Int32.Parse(strNum1);
            int num2 = Int32.Parse(strNum2);

            return _arithRepo.getAdd(num1, num2);
        }

        [FunctionName("getSub")]
        public string getSub(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string strNum1 = req.Query["num1"];
            string strNum2 = req.Query["num2"];

            int num1 = Int32.Parse(strNum1);
            int num2 = Int32.Parse(strNum2);

            return _arithRepo.getSub(num1, num2);
        }

        [FunctionName("getProd")]
        public string getProd(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string strNum1 = req.Query["num1"];
            string strNum2 = req.Query["num2"];

            int num1 = Int32.Parse(strNum1);
            int num2 = Int32.Parse(strNum2);

            return _arithRepo.getProd(num1, num2);
        }

        [FunctionName("getDiv")]
        public string getDiv(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string strNum1 = req.Query["num1"];
            string strNum2 = req.Query["num2"];

            int num1 = Int32.Parse(strNum1);
            int num2 = Int32.Parse(strNum2);

            return _arithRepo.getDiv(num1, num2);
        }
    }
}
